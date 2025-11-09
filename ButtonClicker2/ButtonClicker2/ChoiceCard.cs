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

        public bool clicked = false;
        Size ogSize;
        Size targetsize;

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

            this.BackColor = Color.Aqua;
            ogSize = Size;
        }

        private void ChoiceCard_Click(object sender, EventArgs e)
        {
            foreach (Control c in Parent!.Controls)
            {
                ChoiceCard card = (ChoiceCard)c;
                card.clicked = false;
            }
            clicked = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clicked)
            {
                targetsize = new Size(ogSize.Width + 60, ogSize.Height + 60); 
            }
            else if (MouseInControl(this))
            {
                targetsize = new Size(ogSize.Width + 30, ogSize.Height + 30);
            }
            else
            {
                targetsize = ogSize;
            }

            if (Size.Width < targetsize.Width && Size.Height < targetsize.Height)
            {
                Size = new Size(Size.Width + 3, Size.Height + 3);
            }
            if (Size.Width > targetsize.Width && Size.Height > targetsize.Height)
            {
                Size = new Size(Size.Width - 3, Size.Height - 3);
            }
        }
        private bool MouseInControl(Control ctrl)
        {
            return ctrl.ClientRectangle.Contains(ctrl.PointToClient(MousePosition));
        }
    }
}
