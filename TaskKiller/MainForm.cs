using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskKiller
{
    public partial class MainForm : Form
    {
        private PerformanceCounter cpuMetric = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private Timer timer = new Timer();
        private bool TimerStatus = true;

        System.Diagnostics.Process CMDProcess = new System.Diagnostics.Process();
        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        private List<ProcessSum> ProcessNames
        {
            get
            {
                Process[] processCollection = Process.GetProcesses();
                List<ProcessSum> ProcessList = new List<ProcessSum>();
                foreach (Process process in processCollection)
                {
                    ProcessList.Add(new ProcessSum(process.Id, process.ProcessName, string.Empty));
                }
                return ProcessList;
            }
        }

        public MainForm()
        {
            InitializeComponent();


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CPU_Bar.Value = 50;
            float CPU_Value = cpuMetric.NextValue();
            timer.Interval = 500;
            RR.Value = 500;
            timer.Tick += new EventHandler(refreshMetrics);
            timer.Start();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            NotificationAreaIcon.Visible = false;
            System.Windows.Forms.Application.Exit();
        }

        private void refreshMetrics(object sender, EventArgs e)
        {
            ProcessList.DataSource = ProcessNames;
            float CPU_Value = cpuMetric.NextValue();

            if (CPU_Value < 50)
            {
                CPU_Bar.ForeColor = Color.Green;
            }
            else
            {
                if (CPU_Value >= 50 && CPU_Value < 75)
                {
                    CPU_Bar.ForeColor = Color.Yellow;
                }
                else
                {
                    if (CPU_Value >= 75)
                    {
                        CPU_Bar.ForeColor = Color.Red;
                    }
                }
            }
            CPU_Bar.Style = ProgressBarStyle.Continuous;
            CPU_Bar.Value = (int)CPU_Value;

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (TimerStatus)
            {
                timer.Stop();
                PauseBtn.Text = "4";
            }
            else
            {
                timer.Start();
                PauseBtn.Text = ";";
            }
            TimerStatus = !TimerStatus;
        }

        private void ChangeRefreshRate(object sender, EventArgs e)
        {
            timer.Interval = (int)RR.Value;
        }

        private void ChangeRefreshRate(object sender, ScrollEventArgs e)
        {
            timer.Interval = (int)RR.Value;
        }

        //Open About Form
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void KillTask(object sender, DataGridViewCellEventArgs e)
        {
            System.Windows.Forms.DataGridViewRow row = ProcessList.Rows[e.RowIndex];
            if (e.ColumnIndex == 0)
            {
                startInfo.Arguments = string.Format("/C taskkill.exe /PID {0} /F", row.Cells[0].Value);
                CMDProcess.StartInfo = startInfo;
                CMDProcess.Start();
            }
            if (e.ColumnIndex == 1)
            {
                startInfo.Arguments = string.Format("/C taskkill.exe /IM {0}.exe /F", row.Cells[1].Value);
                CMDProcess.StartInfo = startInfo;
                CMDProcess.Start();
            }
        }

    }
}
