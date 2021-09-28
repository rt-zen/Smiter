
namespace TaskKiller
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProcessList = new System.Windows.Forms.DataGridView();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.CPU_Bar = new System.Windows.Forms.ToolStripProgressBar();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.RR = new System.Windows.Forms.NumericUpDown();
            this.RRLabel = new System.Windows.Forms.Label();
            this.NotificationAreaIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.AboutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RR)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessList
            // 
            this.ProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessList.Location = new System.Drawing.Point(0, 32);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(406, 375);
            this.ProcessList.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.CloseBtn.Location = new System.Drawing.Point(768, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(32, 32);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "r";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.RefreshBtn.Location = new System.Drawing.Point(738, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(32, 32);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "q";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.refreshMetrics);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip,
            this.CPU_Bar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // CPU_Bar
            // 
            this.CPU_Bar.Name = "CPU_Bar";
            this.CPU_Bar.Size = new System.Drawing.Size(100, 16);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(-5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(2);
            this.TitleLabel.Size = new System.Drawing.Size(111, 29);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "TaskKiller";
            // 
            // PauseBtn
            // 
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseBtn.Font = new System.Drawing.Font("Webdings", 12F);
            this.PauseBtn.Location = new System.Drawing.Point(707, 0);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(32, 32);
            this.PauseBtn.TabIndex = 5;
            this.PauseBtn.Text = ";";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // RR
            // 
            this.RR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RR.Cursor = System.Windows.Forms.Cursors.Default;
            this.RR.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RR.Location = new System.Drawing.Point(15, 429);
            this.RR.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RR.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(67, 16);
            this.RR.TabIndex = 6;
            this.RR.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RR.ValueChanged += new System.EventHandler(this.ChangeRefreshRate);
            this.RR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ChangeRefreshRate);
            // 
            // RRLabel
            // 
            this.RRLabel.AutoSize = true;
            this.RRLabel.Location = new System.Drawing.Point(12, 413);
            this.RRLabel.Name = "RRLabel";
            this.RRLabel.Size = new System.Drawing.Size(70, 13);
            this.RRLabel.TabIndex = 7;
            this.RRLabel.Text = "Refresh Rate";
            // 
            // NotificationAreaIcon
            // 
            this.NotificationAreaIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificationAreaIcon.Icon")));
            this.NotificationAreaIcon.Text = "TaskKiller Running";
            this.NotificationAreaIcon.Visible = true;
            // 
            // AboutBtn
            // 
            this.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutBtn.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.AboutBtn.Location = new System.Drawing.Point(676, 0);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(32, 32);
            this.AboutBtn.TabIndex = 8;
            this.AboutBtn.Text = "s";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.ControlBox = false;
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.RRLabel);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ProcessList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.8D;
            this.Text = "TaskKiller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.KillTask);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProcessList;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ToolStripProgressBar CPU_Bar;
        private System.Windows.Forms.Button PauseBtn;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.NumericUpDown RR;
        private System.Windows.Forms.Label RRLabel;
        private System.Windows.Forms.NotifyIcon NotificationAreaIcon;
        private System.Windows.Forms.Button AboutBtn;
    }
}

