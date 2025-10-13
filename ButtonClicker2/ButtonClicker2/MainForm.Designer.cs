namespace ButtonClicker2
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
            this.mainButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLeftBar = new System.Windows.Forms.ProgressBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.consumablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainButton.AutoSize = true;
            this.mainButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mainButton.FlatAppearance.BorderSize = 0;
            this.mainButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainButton.ForeColor = System.Drawing.Color.Black;
            this.mainButton.Location = new System.Drawing.Point(330, 195);
            this.mainButton.MinimumSize = new System.Drawing.Size(140, 60);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(140, 60);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "0";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLeftBar
            // 
            this.timeLeftBar.BackColor = System.Drawing.SystemColors.Control;
            this.timeLeftBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLeftBar.ForeColor = System.Drawing.Color.Red;
            this.timeLeftBar.Location = new System.Drawing.Point(0, 0);
            this.timeLeftBar.Name = "timeLeftBar";
            this.timeLeftBar.Size = new System.Drawing.Size(800, 26);
            this.timeLeftBar.Step = 5;
            this.timeLeftBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.timeLeftBar.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.ForeColor = System.Drawing.Color.Blue;
            this.progressBar.Location = new System.Drawing.Point(0, 26);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 26);
            this.progressBar.Step = 5;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // consumablePanel
            // 
            this.consumablePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.consumablePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.consumablePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.consumablePanel.Location = new System.Drawing.Point(587, 52);
            this.consumablePanel.Name = "consumablePanel";
            this.consumablePanel.Size = new System.Drawing.Size(213, 398);
            this.consumablePanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consumablePanel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.timeLeftBar);
            this.Controls.Add(this.mainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Button Clicker 2: Electric Boogaloo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button mainButton;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.ProgressBar timeLeftBar;
        public System.Windows.Forms.FlowLayoutPanel consumablePanel;
    }
}

