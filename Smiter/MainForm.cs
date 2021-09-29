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
        #region Global Variables
        //Object to get CPU Usage
        private PerformanceCounter cpuMetric = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        //Timer object to constantly refresh the process list and CPU Usage
        private Timer timer = new Timer();
        //Boolean used to pause or resume the timer
        private bool TimerStatus = true;
        //Boolean to enable or disable Hit and Run/Win9x mode
        private bool HnR_Enabled = false;
        //Multiplier for selecting between seconds or milliseconds for the timer
        private int multiplier = 1;

        //Objects for calling taskkill
        private System.Diagnostics.Process CMDProcess = new System.Diagnostics.Process();
        private System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
        #endregion
        public MainForm()
        {
            InitializeComponent();


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Placeholder for the CPU Usage Bar
            CPU_Bar.Value = 50;
            //Get current CPU Usage
            float CPU_Value = cpuMetric.NextValue();
            //Setting default timer Interval and putting number updown on the default position
            timer.Interval = 500;
            RR.Value = 500;
            //Assigning a method for each timer tick
            timer.Tick += new EventHandler(refreshMetrics);
            //Starting the timer
            timer.Start();
            //Hiding the command prompt execution and setting the executable for the command prompt
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
        }


        //Method to get the Process List. Using a custom class so that it's easier to set-up the datagridview (MainForm.ProcessList)
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

        //The method that closes the program. It first disables the notification icon, so that it doesn't remain zombified and then exits.
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            NotificationAreaIcon.Visible = false;
            System.Windows.Forms.Application.Exit();
        }

        private void refreshMetrics(object sender, EventArgs e)
        {
            ProcessList.DataSource = ProcessNames;
            float CPU_Value = cpuMetric.NextValue();

            //From 0% to 50% the bar will be yellow, from 50% to 75% will be yellow, from 75% to 100% will be red 
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
            
            //Assigning the Bar Style and percentage filled
            CPU_Bar.Style = ProgressBarStyle.Continuous;
            CPU_Bar.Value = (int)CPU_Value;

        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            //Changes the timer status and the button text to match the button action
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

        #region Functions to change the Refresh Rate of the program, matching what's on the updown object
        private void ChangeRefreshRate(object sender, EventArgs e)
        {
            timer.Interval = (int)RR.Value * multiplier;
        }

        private void ChangeRefreshRate(object sender, ScrollEventArgs e)
        {
            timer.Interval = (int)RR.Value * multiplier;
        }
        #endregion

        //Create a About Form instance and open it
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }


        private void KillTask(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: Add message on bottom saying what process was killed, and maybe a log??
            System.Windows.Forms.DataGridViewRow row = ProcessList.Rows[e.RowIndex];
            //if user double clicked a PID
            if (e.ColumnIndex == 0)
            {
                startInfo.Arguments = string.Format("/C taskkill.exe /PID {0} /F", row.Cells[0].Value);
                CMDProcess.StartInfo = startInfo;
                CMDProcess.Start();
            }
            //if user double clicked a Process Name
            if (e.ColumnIndex == 1)
            {
                //TODO: Add confirmation message
                startInfo.Arguments = string.Format("/C taskkill.exe /IM {0}.exe /F", row.Cells[1].Value);
                CMDProcess.StartInfo = startInfo;
                CMDProcess.Start();
            }
            //If enabled, will exit the program after killing whatever process was selected
            if (HnR_Enabled)
            {
                NotificationAreaIcon.Visible = false;
                System.Windows.Forms.Application.Exit();
            }
        }

        //Method is called when Hit and Run/Win9x Mode checkbox is changed
        private void HnRCheckBoxChanged(object sender, EventArgs e)
        {
            HnR_Enabled = HnRCheckBox.Checked;
        }

        #region RRType Radio Buttons
        //Method is called when user clicks the Milliseconds radio button
        private void ChangeRR_to_Milliseconds(object sender, EventArgs e)
        {
            multiplier = 1;
            RR.Minimum = 100;
            RR.Increment = 100;
            timer.Interval = (int)RR.Value * multiplier;
        }

        //Method is called when user clicks the Seconds radio button
        private void ChangeRR_to_Seconds(object sender, EventArgs e)
        {
            multiplier = 1000;
            RR.Minimum = 1;
            RR.Increment = 1;
            timer.Interval = (int)RR.Value * multiplier;
        }
        #endregion
    }
}
