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

        public void AddCard(string title, string description, Image image, Data.UpgradeType upgradeType, UpgradeForm upgradeForm)
        {
            ChoiceCard card = new ChoiceCard(title, description, image, upgradeType, upgradeForm);
            Controls.Add(card);
        }



        private int controlSpacing = 10;

        private void CenterFlowPanel_Layout(object sender, LayoutEventArgs e)
        {
            if (sender == null) return;
            Panel? containerPanel = sender as Panel;
            if (containerPanel == null) return;

            int panelWidth = containerPanel.ClientSize.Width;
            int panelHeight = containerPanel.ClientSize.Height;

            List<Control> controlsToLayout = containerPanel.Controls.OfType<Control>().Where(c => c.Visible).ToList();

            if (!controlsToLayout.Any())
            {
                containerPanel.AutoScrollMinSize = new Size(0, 0);
                return;
            }

            int totalControlsWidth = controlsToLayout.Sum(c => c.Width) + (Math.Max(0, controlsToLayout.Count - 1) * controlSpacing);

            int startX = (panelWidth - totalControlsWidth) / 2;
            if (startX < 0) startX = controlSpacing;

            int currentX = startX;

            foreach (Control control in controlsToLayout)
            {
                int centerY = (panelHeight - control.Height) / 2;
                if (centerY < 0) centerY = controlSpacing;

                control.Location = new Point(currentX, centerY);
                currentX += control.Width + controlSpacing;
            }

            if (totalControlsWidth > panelWidth || startX == controlSpacing)
            {
                containerPanel.AutoScrollMinSize = new Size(totalControlsWidth + controlSpacing + startX, 0);
            }
            else
            {
                containerPanel.AutoScrollMinSize = new Size(0, 0);
            }

            containerPanel.Invalidate();
        }
    }
}
