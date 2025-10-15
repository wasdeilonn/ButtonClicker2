using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonClicker2
{
    public partial class UpgradeForm : Form
    {
        public UpgradeForm()
        {
            InitializeComponent();
        }

        private bool ChoiceMade = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Program.StartNextRound();
            this.Close();
        }

        private void UpgradeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing || ChoiceMade) return;


            DialogResult result = MessageBox.Show(
                "Are you sure you wanna quit? Remember, 99% of players quit before the big win!",
                "Confirm Quit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Program.SaveAndQuit();
        }

        private void UpgradeForm_Load(object sender, EventArgs e)
        {
            centerFlowPanel1.AddCard("Double Clicks", "Your clicks are now twice as effective!", SystemIcons.Information.ToBitmap(), Data.UpgradeType.Modifier, this);
            centerFlowPanel1.AddCard("Auto Clicker", "You get an auto clicker that clicks once every second!", SystemIcons.Question.ToBitmap(), Data.UpgradeType.Improvement, this);
            centerFlowPanel1.AddCard("Mega Click", "Your next click counts as 10 clicks!", SystemIcons.Warning.ToBitmap(), Data.UpgradeType.Consumable, this);
            button1.Enabled = false;
        }

        public void MakeChoice(Data.UpgradeData upgradeData)
        {
            ChoiceMade = true;
            button1.Enabled = true;
        }
    }
}
