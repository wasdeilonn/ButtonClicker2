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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ClickEvent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.TickEvent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Program.GetMainForm((MainForm)sender);
        }

        public event System.Windows.Forms.FormClosingEventHandler? FormClosing;
    }
}
