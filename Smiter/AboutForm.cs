using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiter
{
    public partial class AboutForm : Form
    {
        #region Circumvent Form not being draggeable because of no borders
        //src https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AboutForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion


        ToolTip ToolTipExport = new ToolTip();
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            ToolTipExport.SetToolTip(ExportBtn, "Export to file");
            ToolTipExport.ShowAlways = true;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenGitPage(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/rt-zen");
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            //TODO: Export all Log Text to File
        }
    }
}
