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
        public UpgradeForm ParentUpgradeForm;

        bool hovered = false;
        bool clicked = false;



        public ChoiceCard(string Title, string Description, Image Image, Data.UpgradeType UpgradeType, UpgradeForm parentForm)
        {
            InitializeComponent();
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
            this.UpgradeType = UpgradeType;
            ParentUpgradeForm = parentForm;
        }

        private void ChoiceCard_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Title;
            descriptionLabel.Text = Description;
            pictureBox1.Image = Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ChoiceCard_Click(object sender, EventArgs e)
        {
            clicked = true;
        }

        private void Hover_Begin(object sender, EventArgs e)
        {
            hovered = true;
            this.Size = new Size(this.Size.Width + 20, this.Size.Height + 20);
        }

        private void Hover_End(object sender, EventArgs e)
        {
            hovered = false;
            this.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
