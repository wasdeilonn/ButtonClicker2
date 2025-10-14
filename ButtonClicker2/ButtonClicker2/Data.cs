using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonClicker2
{
    public class Data
    {
        public enum UpgradeType
        {
            Modifier,
            Improvement,
            Consumable
        }

        public enum UpgradeBank
        {
            //fill out later
        }

        public struct UpgradeData()
        {
            UpgradeBank upgrade;
            UpgradeType type;
            string name = "defaultName";
            string description = "defaultDesctiption";
            Image image; //get a few images later
        }


        public Dictionary<UpgradeBank, UpgradeData> Upgrades = new Dictionary<UpgradeBank, UpgradeData>()
        {
            //fill out later
        };
    }
}