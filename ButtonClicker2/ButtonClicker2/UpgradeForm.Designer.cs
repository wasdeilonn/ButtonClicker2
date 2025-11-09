namespace ButtonClicker2
{
    partial class UpgradeForm
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
            button1 = new Button();
            centerFlowPanel1 = new CenterFlowPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(376, 442);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(163, 69);
            button1.TabIndex = 0;
            button1.Text = "Next Round";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // centerFlowPanel1
            // 
            centerFlowPanel1.Anchor = AnchorStyles.None;
            centerFlowPanel1.BackColor = SystemColors.ControlDark;
            centerFlowPanel1.Location = new Point(54, 25);
            centerFlowPanel1.Name = "centerFlowPanel1";
            centerFlowPanel1.Size = new Size(807, 411);
            centerFlowPanel1.TabIndex = 1;
            // 
            // UpgradeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(915, 532);
            Controls.Add(centerFlowPanel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpgradeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Choose a Reward! If you do not choose a reward I will find you";
            FormClosing += UpgradeForm_FormClosing;
            Load += UpgradeForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CenterFlowPanel centerFlowPanel1;
    }
}