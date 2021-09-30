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
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
           
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

        private void topSeparator_Click(object sender, EventArgs e)
        {

        }
    }
}
