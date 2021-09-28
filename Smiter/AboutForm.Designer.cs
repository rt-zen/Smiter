
namespace TaskKiller
{
    partial class AboutForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.topSeparator = new System.Windows.Forms.Label();
            this.BottomSeparator = new System.Windows.Forms.Label();
            this.gitLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(276, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CloseForm);
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(5, 5);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(96, 40);
            this.AboutLabel.TabIndex = 1;
            this.AboutLabel.Text = "About";
            // 
            // topSeparator
            // 
            this.topSeparator.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.topSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.topSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topSeparator.Location = new System.Drawing.Point(0, 50);
            this.topSeparator.Name = "topSeparator";
            this.topSeparator.Size = new System.Drawing.Size(602, 2);
            this.topSeparator.TabIndex = 2;
            // 
            // BottomSeparator
            // 
            this.BottomSeparator.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BottomSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BottomSeparator.Location = new System.Drawing.Point(1, 348);
            this.BottomSeparator.Name = "BottomSeparator";
            this.BottomSeparator.Size = new System.Drawing.Size(602, 2);
            this.BottomSeparator.TabIndex = 3;
            // 
            // gitLink
            // 
            this.gitLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gitLink.Image = global::TaskKiller.Properties.Resources.logo3256;
            this.gitLink.LinkColor = System.Drawing.Color.Transparent;
            this.gitLink.Location = new System.Drawing.Point(10, 71);
            this.gitLink.Name = "gitLink";
            this.gitLink.Size = new System.Drawing.Size(256, 256);
            this.gitLink.TabIndex = 4;
            this.gitLink.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.gitLink.Click += new System.EventHandler(this.OpenGitPage);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.gitLink);
            this.Controls.Add(this.BottomSeparator);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topSeparator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label topSeparator;
        private System.Windows.Forms.Label BottomSeparator;
        public System.Windows.Forms.LinkLabel gitLink;
    }
}