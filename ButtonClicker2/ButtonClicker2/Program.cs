using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ButtonClicker2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }

        public static MainForm mainForm;

        public static void GetMainForm(MainForm main)
        {
            mainForm = main;
            mainForm.mainButton.Text = "Start";
        }

        public static int ValueCount = 0;
        public static int ValueGoal = 100;
        public static int IncrementNum = 1;
        public static int TimeGoal = 2000;
        public static int Time = 0;
        public static int TimeIncrement = 1;
        public static int TimeIncrementMultiplier = 1; //can be used later for difficulty

        public static bool EndedRound = false;


        public static void SaveAndQuit()
        {
            Application.Exit();
        }

        public static void StartGameEvent()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        public static void ClickEvent()
        {
            ValueCount += IncrementNum;
        }

        public static void TickEvent()
        {
            if (!EndedRound) 
            {
                UpdateTimeLeft();
                UpdateVisuals();
                CheckForEndRound();
            }
        }



        public static void UpdateTimeLeft()
        {
            Time += TimeIncrement * TimeIncrementMultiplier;
        }

        public static void UpdateVisuals()
        {
            double timeValue = ((double)Time / (double)TimeGoal) * 100;
            double valueValue = ((double)ValueCount / (double)ValueGoal) * 100;

            mainForm.mainButton.Text = ValueCount.ToString();

            mainForm.timeLeftBar.Value = (timeValue > 100) ? 100 : (int)timeValue;
            mainForm.progressBar.Value = (valueValue > 100) ? 100 : (int)valueValue;
        }

        public static void CheckForEndRound()
        {
            if (ValueCount >= ValueGoal)
            {
                EndRound(true);
                return;
            }
            if (Time >= TimeGoal)
            {
                EndRound(false); 
                return;
            }
        }

        public static void EndRound(bool isWin)
        {
            EndedRound = true;
            if (isWin)
            {
                UpgradeForm upgradeForm = new UpgradeForm();
                upgradeForm.ShowDialog();
                return;
            }
            
            DefeatForm defeatForm = new DefeatForm();
            defeatForm.ShowDialog();
        }



        public static void StartNextRound()
        {
            EndedRound = false;
            ValueCount = 0;
            Time = 0;
            ValueGoal = (int)(ValueGoal * 1.5);

        }
    }
}
