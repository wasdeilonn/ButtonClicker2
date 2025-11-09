using System.Runtime.CompilerServices;

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
            components = new System.ComponentModel.Container();
            mainButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timeLeftBar = new ProgressBar();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // mainButton
            // 
            mainButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mainButton.FlatAppearance.BorderColor = Color.Black;
            mainButton.FlatAppearance.BorderSize = 0;
            mainButton.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mainButton.ForeColor = Color.Black;
            mainButton.Location = new Point(0, 69);
            mainButton.Margin = new Padding(4, 3, 4, 3);
            mainButton.MinimumSize = new Size(163, 69);
            mainButton.Name = "mainButton";
            mainButton.Size = new Size(384, 80);
            mainButton.TabIndex = 0;
            mainButton.Text = "0";
            mainButton.UseVisualStyleBackColor = true;
            mainButton.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timeLeftBar
            // 
            timeLeftBar.BackColor = SystemColors.Control;
            timeLeftBar.Dock = DockStyle.Top;
            timeLeftBar.ForeColor = Color.Red;
            timeLeftBar.Location = new Point(0, 0);
            timeLeftBar.Margin = new Padding(4, 3, 4, 3);
            timeLeftBar.Name = "timeLeftBar";
            timeLeftBar.Size = new Size(384, 30);
            timeLeftBar.Step = 5;
            timeLeftBar.Style = ProgressBarStyle.Continuous;
            timeLeftBar.TabIndex = 1;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.Control;
            progressBar.Dock = DockStyle.Top;
            progressBar.ForeColor = Color.Blue;
            progressBar.Location = new Point(0, 30);
            progressBar.Margin = new Padding(4, 3, 4, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(384, 30);
            progressBar.Step = 5;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(384, 161);
            Controls.Add(progressBar);
            Controls.Add(timeLeftBar);
            Controls.Add(mainButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Button Clicker 2: Electric Boogaloo";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button mainButton;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.ProgressBar timeLeftBar;
    }
}

