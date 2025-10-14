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
    public partial class ChoiceCard : UserControl
    {

        public string Title;
        public string Description;
        public Image Image;
        public Data.UpgradeType UpgradeType;
        public ChoiceCard(string Title, string Description, Image Image, Data.UpgradeType UpgradeType)
        {
            InitializeComponent();
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.UpgradeType = UpgradeType;
        }

        private void ChoiceCard_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Title;
            descriptionLabel.Text = Description;
            pictureBox1.Image = Image;

            //HEY
            //HEYHEYHEY
            //REPLACE WITH IMAGES LATER
            switch (UpgradeType)
            {
                case Data.UpgradeType.Modifier:
                    this.BackColor = Color.LightGreen;
                    break;
                case Data.UpgradeType.Improvement:
                    this.BackColor = Color.LightBlue;
                    break;
                case Data.UpgradeType.Consumable:
                    this.BackColor = Color.LightCoral;
                    break;
                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
            //DO NOT LEAVE THIS UNMODIFIED
            //HEYHEYHEY
            //HEY
        }
    }
}
