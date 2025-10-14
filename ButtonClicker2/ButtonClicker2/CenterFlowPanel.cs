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
    public partial class CenterFlowPanel : Panel
    {
        public CenterFlowPanel()
        {
            InitializeComponent();
        }

        public void AddCard(string title, string description, Image image, Data.UpgradeType upgradeType)
        {
            ChoiceCard card = new ChoiceCard(title, description, image, upgradeType);
            this.Controls.Add(card);
        }

        private void CenterFlowPanel_Layout(object sender, LayoutEventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;

            foreach (Control control in this.Controls)
            {
                //get total width of all controls or idk
            }
        }
    }
}
