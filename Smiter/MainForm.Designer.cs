
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
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.radioBtnMilliseconds = new System.Windows.Forms.RadioButton();
            this.radioBtnSeconds = new System.Windows.Forms.RadioButton();
            this.HnRCheckBox = new System.Windows.Forms.CheckBox();
            this.topSeparator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RR)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessList
            // 
            this.ProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessList.Location = new System.Drawing.Point(0, 68);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(406, 356);
            this.ProcessList.TabIndex = 0;
            this.ProcessList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KillTask);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
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
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(5, 5);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(99, 40);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Smiter";
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
            this.RR.Location = new System.Drawing.Point(6, 42);
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
            this.RR.Size = new System.Drawing.Size(67, 18);
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
            this.RRLabel.Location = new System.Drawing.Point(79, 44);
            this.RRLabel.Name = "RRLabel";
            this.RRLabel.Size = new System.Drawing.Size(72, 13);
            this.RRLabel.TabIndex = 7;
            this.RRLabel.Text = "Refresh Rate";
            // 
            // NotificationAreaIcon
            // 
            this.NotificationAreaIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificationAreaIcon.Icon")));
            this.NotificationAreaIcon.Text = "Smiter Running";
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
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.radioBtnMilliseconds);
            this.SettingsGroupBox.Controls.Add(this.radioBtnSeconds);
            this.SettingsGroupBox.Controls.Add(this.HnRCheckBox);
            this.SettingsGroupBox.Controls.Add(this.RR);
            this.SettingsGroupBox.Controls.Add(this.RRLabel);
            this.SettingsGroupBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsGroupBox.Location = new System.Drawing.Point(412, 68);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(382, 127);
            this.SettingsGroupBox.TabIndex = 9;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // radioBtnMilliseconds
            // 
            this.radioBtnMilliseconds.AutoSize = true;
            this.radioBtnMilliseconds.Checked = true;
            this.radioBtnMilliseconds.Location = new System.Drawing.Point(232, 42);
            this.radioBtnMilliseconds.Name = "radioBtnMilliseconds";
            this.radioBtnMilliseconds.Size = new System.Drawing.Size(89, 17);
            this.radioBtnMilliseconds.TabIndex = 9;
            this.radioBtnMilliseconds.TabStop = true;
            this.radioBtnMilliseconds.Text = "Milliseconds";
            this.radioBtnMilliseconds.UseVisualStyleBackColor = true;
            this.radioBtnMilliseconds.Click += new System.EventHandler(this.ChangeRR_to_Milliseconds);
            // 
            // radioBtnSeconds
            // 
            this.radioBtnSeconds.AutoSize = true;
            this.radioBtnSeconds.Location = new System.Drawing.Point(157, 42);
            this.radioBtnSeconds.Name = "radioBtnSeconds";
            this.radioBtnSeconds.Size = new System.Drawing.Size(68, 17);
            this.radioBtnSeconds.TabIndex = 8;
            this.radioBtnSeconds.TabStop = true;
            this.radioBtnSeconds.Text = "Seconds";
            this.radioBtnSeconds.UseVisualStyleBackColor = true;
            this.radioBtnSeconds.Click += new System.EventHandler(this.ChangeRR_to_Seconds);
            // 
            // HnRCheckBox
            // 
            this.HnRCheckBox.AutoSize = true;
            this.HnRCheckBox.Location = new System.Drawing.Point(6, 19);
            this.HnRCheckBox.Name = "HnRCheckBox";
            this.HnRCheckBox.Size = new System.Drawing.Size(157, 17);
            this.HnRCheckBox.TabIndex = 0;
            this.HnRCheckBox.Text = "Hit and Run/Win9x Mode";
            this.HnRCheckBox.UseVisualStyleBackColor = true;
            this.HnRCheckBox.CheckedChanged += new System.EventHandler(this.HnRCheckBoxChanged);
            // 
            // topSeparator
            // 
            this.topSeparator.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.topSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topSeparator.Location = new System.Drawing.Point(0, 50);
            this.topSeparator.Name = "topSeparator";
            this.topSeparator.Size = new System.Drawing.Size(800, 2);
            this.topSeparator.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.ControlBox = false;
            this.Controls.Add(this.topSeparator);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.AboutBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.ProcessList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RR)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.CheckBox HnRCheckBox;
        private System.Windows.Forms.Label topSeparator;
        private System.Windows.Forms.RadioButton radioBtnMilliseconds;
        private System.Windows.Forms.RadioButton radioBtnSeconds;
    }
}

