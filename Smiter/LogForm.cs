using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smiter.Classes;
using System.IO;

namespace Smiter
{
    public partial class LogForm : Form
    {
        List<string> LogLines = new List<string>();
        ToolTip ToolTipExport = new ToolTip();

        #region Circumvent Form not being draggeable because of no borders
        //src https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void LogForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion



        List<LogEvent> LogList;
        public LogForm(List<LogEvent> Log)
        {
            InitializeComponent();
            this.LogList = Log;
        }

        
        private void ListBoxGraphicsHandler(object sender, DrawItemEventArgs e)
        {
            //src: https://stackoverflow.com/questions/29173517/winforms-simplest-way-to-change-listbox-text-color-on-the-fly
            


            
            Graphics g = e.Graphics;
            Dictionary<string, object> LogObj = LogList[e.Index].ToFormattedString();
            SolidBrush backgroundBrush = new SolidBrush(LogObj.ContainsKey("BackColor") ? (Color)LogObj["BackColor"] : SystemColors.Control);
            SolidBrush foregroundBrush = new SolidBrush(LogObj.ContainsKey("ForeColor") ? (Color)LogObj["ForeColor"] : Color.Purple);
            Font textFont = LogObj.ContainsKey("Font") ? (Font)LogObj["Font"] : e.Font;
            string text = LogObj.ContainsKey("Text") ? (string)LogObj["Text"] : string.Empty;
            RectangleF rectangle = new RectangleF(new PointF(e.Bounds.X, e.Bounds.Y), new SizeF(e.Bounds.Width, g.MeasureString(text, textFont).Height));

            g.FillRectangle(backgroundBrush, rectangle);
            g.DrawString(text, textFont, foregroundBrush, rectangle);

            backgroundBrush.Dispose();
            foregroundBrush.Dispose();
            g.Dispose();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            LogListBox.DrawMode = DrawMode.OwnerDrawVariable;
            LogListBox.DrawItem += new DrawItemEventHandler(ListBoxGraphicsHandler);
            foreach (LogEvent @event in LogList)
            {
                string eventString = @event.ToString();
                LogListBox.Items.Add(eventString);
                LogLines.Add(eventString);
            }
            ToolTipExport.SetToolTip(ExportBtn, "Export to file");
            ToolTipExport.ShowAlways = true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog ExportDialog = new SaveFileDialog();
            ExportDialog.Filter = "Simple Text file (*.txt)|*.txt|All Files (*.*)|*.*";
            ExportDialog.RestoreDirectory = true;
            ExportDialog.FileName = "Log.txt";
            ExportDialog.DefaultExt = "txt";
            ExportDialog.Title = "Save Log file As";
            ExportDialog.InitialDirectory = @"%HOMEPATH%\Documents";

            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(ExportDialog.FileName, LogLines);
            }
        }
    }
}
