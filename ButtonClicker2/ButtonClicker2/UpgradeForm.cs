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

        private void UpgradeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.StartNextRound();
            this.Close();
        }

        private void UpgradeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;
            

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
    }
}
