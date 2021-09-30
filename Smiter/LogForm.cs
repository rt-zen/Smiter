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

namespace Smiter
{
    public partial class LogForm : Form
    {
        MainForm parent;
        List<LogEvent> LogList;
        public LogForm(MainForm parent, List<LogEvent> Log)
        {
            InitializeComponent();
            this.parent = parent;
            this.LogList = Log;
        }


        private void ListBoxGraphicsHandler(object sender, DrawItemEventArgs e)
        {
            //src: https://stackoverflow.com/questions/29173517/winforms-simplest-way-to-change-listbox-text-color-on-the-fly

            //bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            //Color foreColor;
            //if (!)
            //{

            //}

            
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
                LogListBox.Items.Add(@event.ToString());
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
