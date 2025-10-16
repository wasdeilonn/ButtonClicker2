﻿using System;
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
            Koki, //high sell price, low produce
            Baliko, //low sell price, high produce
            AutoClicker, //medium sell price, medium produce. should scale with something
            Dice6, //1/6 chance to get 20% the goal
            Dice20, //1/20 chance to get 100% the goal
            MegaKnight, //doubles click value, including autoclicker. also makes a stupid smash sound
            Sandwich, //give 5% of the goal
            TimeMachine, //removes 5 s of time
            FileExplorer, //nonexistent sell price, high produce
            RecycleBin, //doubles file explorer produce
            Virus, //every click takes away 5% of the goal from your total, but it stores it in the sell value. every round end doubles the stored value
            Miner, //pools produce in sell price, doubles if you have virus, halves with file explorer
        }

        public struct UpgradeData()
        {
            public UpgradeBank upgrade;
            public UpgradeType type;
            public string name = "defaultName";
            public string description = "defaultDesctiption";
            public Image? image; //get a few images later
        }


        public Dictionary<UpgradeBank, UpgradeData> Upgrades = new Dictionary<UpgradeBank, UpgradeData>()
        {
            //fill out later
        };
    }
}