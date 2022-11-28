using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace botjson
{
    public partial class Form1 : Form
    {

        string serverPath = Environment.CurrentDirectory + "\\..\\Aki_Data\\Server\\configs\\bot.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                string bot = File.ReadAllText(serverPath);
                dynamic botContent = JsonConvert.DeserializeObject(bot);

                useDifficultyOverride.Text = botContent["pmc"]["useDifficultyOverride"].ToString();
                difficultyLevel.Text = botContent["pmc"]["difficulty"].ToString();
                usecChance.Text = botContent["pmc"]["isUsec"].ToString() + " %";
                sameSideHostility.Text = botContent["pmc"]["chanceSameSideIsHostilePercent"].ToString() + " %";

                conversionAssault.Text = botContent["pmc"]["convertIntoPmcChance"]["assault"]["max"].ToString() + " %";
                conversionCursedAssault.Text = botContent["pmc"]["convertIntoPmcChance"]["cursedassault"]["max"].ToString() + " %";
                conversionPmcBot.Text = botContent["pmc"]["convertIntoPmcChance"]["pmcbot"]["max"].ToString() + " %";
                conversionExUsec.Text = botContent["pmc"]["convertIntoPmcChance"]["exusec"]["max"].ToString() + " %";

            } catch(Exception b)
            {
                Debug.WriteLine($"ERROR: {b.Message}");
            }
        }

        private void pSeparator1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hoverBotJson_MouseEnter(object sender, EventArgs e)
        {
            difficultyItem.ForeColor = Color.DodgerBlue;
            difficultyItem.Text += " →";
        }

        private void hoverBotJson_MouseLeave(object sender, EventArgs e)
        {
            difficultyItem.ForeColor = Color.Gainsboro;
            difficultyItem.Text = difficultyItem.Text.Substring(0, difficultyItem.Text.Length - 2);
        }

        private void difficultyLevel_Click(object sender, EventArgs e)
        {
            
        }

        private void difficultyLevel_MouseEnter(object sender, EventArgs e)
        {
            difficultyLevel.ForeColor = Color.DodgerBlue;
        }

        private void difficultyLevel_MouseLeave(object sender, EventArgs e)
        {
            difficultyLevel.ForeColor = Color.Gainsboro;
        }

        private void usecChance_MouseEnter(object sender, EventArgs e)
        {
            usecChance.ForeColor = Color.DodgerBlue;
        }

        private void usecChance_MouseLeave(object sender, EventArgs e)
        {
            usecChance.ForeColor = Color.Gainsboro;
        }

        private void difficultyLevel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (difficultyLevel.Text)
            {
                case "AsOnline":
                    difficultyLevel.Text = "Easy";
                    break;

                case "Easy":
                    difficultyLevel.Text = "Medium";
                    break;

                case "Medium":
                    difficultyLevel.Text = "Hard";
                    break;

                case "Hard":
                    difficultyLevel.Text = "Impossible";
                    break;

                case "Impossible":
                    difficultyLevel.Text = "Random";
                    break;

                case "Random":
                    difficultyLevel.Text = "AsOnline";
                    break;

                default: break;
            }
        }

        private void useDifficultyOverride_MouseEnter(object sender, EventArgs e)
        {
            useDifficultyOverride.ForeColor = Color.DodgerBlue;
        }

        private void useDifficultyOverride_MouseLeave(object sender, EventArgs e)
        {
            useDifficultyOverride.ForeColor = Color.Gainsboro;
        }

        private void useDifficultyOverride_MouseDown(object sender, MouseEventArgs e)
        {
            switch (useDifficultyOverride.Text)
            {
                case "True":
                    useDifficultyOverride.Text = "False";
                    break;
                case "False":
                    useDifficultyOverride.Text = "True";
                    break;
            }
        }

        private void usecChance_MouseDown(object sender, MouseEventArgs e)
        {
            int[] count = new int[] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            

        }

        private void usecChancePrevious_Click(object sender, EventArgs e)
        {

        }

        private void usecChancePrevious_MouseDown(object sender, MouseEventArgs e)
        {
            switch (usecChance.Text)
            {
                case "0 %":
                    break;
                case "10 %":
                    usecChance.Text = "0 %";
                    break;
                case "20 %":
                    usecChance.Text = "10 %";
                    break;
                case "30 %":
                    usecChance.Text = "20 %";
                    break;
                case "40 %":
                    usecChance.Text = "30 %";
                    break;
                case "50 %":
                    usecChance.Text = "40 %";
                    break;
                case "60 %":
                    usecChance.Text = "50 %";
                    break;
                case "70 %":
                    usecChance.Text = "60 %";
                    break;
                case "80 %":
                    usecChance.Text = "70 %";
                    break;
                case "90 %":
                    usecChance.Text = "80 %";
                    break;
                case "100 %":
                    usecChance.Text = "90 %";
                    break;
            }
        }

        private void usecChanceNext_MouseDown(object sender, MouseEventArgs e)
        {
            switch (usecChance.Text)
            {
                case "0 %":
                    usecChance.Text = "10 %";
                    break;
                case "10 %":
                    usecChance.Text = "20 %";
                    break;
                case "20 %":
                    usecChance.Text = "30 %";
                    break;
                case "30 %":
                    usecChance.Text = "40 %";
                    break;
                case "40 %":
                    usecChance.Text = "50 %";
                    break;
                case "50 %":
                    usecChance.Text = "60 %";
                    break;
                case "60 %":
                    usecChance.Text = "70 %";
                    break;
                case "70 %":
                    usecChance.Text = "80 %";
                    break;
                case "80 %":
                    usecChance.Text = "90 %";
                    break;
                case "90 %":
                    usecChance.Text = "100 %";
                    break;
                case "100 %":
                    break;
            }
        }

        private void usecChancePrevious_MouseEnter(object sender, EventArgs e)
        {
            usecChancePrevious.ForeColor = Color.DodgerBlue;
        }

        private void usecChancePrevious_MouseLeave(object sender, EventArgs e)
        {
            usecChancePrevious.ForeColor = Color.Gainsboro;
        }

        private void usecChanceNext_MouseEnter(object sender, EventArgs e)
        {
            usecChanceNext.ForeColor = Color.DodgerBlue;
        }

        private void usecChanceNext_MouseLeave(object sender, EventArgs e)
        {
            usecChanceNext.ForeColor = Color.Gainsboro;
        }

        private void sameSideHostility_MouseEnter(object sender, EventArgs e)
        {
            sameSideHostility.ForeColor = Color.DodgerBlue;
        }

        private void sameSideHostility_MouseLeave(object sender, EventArgs e)
        {
            sameSideHostility.ForeColor = Color.Gainsboro;
        }

        private void sameSideHostilityPrev_MouseEnter(object sender, EventArgs e)
        {
            sameSideHostilityPrev.ForeColor = Color.DodgerBlue;
        }

        private void sameSideHostilityPrev_MouseLeave(object sender, EventArgs e)
        {
            sameSideHostilityPrev.ForeColor = Color.Gainsboro;
        }

        private void sameSideHostilityNext_MouseEnter(object sender, EventArgs e)
        {
            sameSideHostilityNext.ForeColor = Color.DodgerBlue;
        }

        private void sameSideHostilityNext_MouseLeave(object sender, EventArgs e)
        {
            sameSideHostilityNext.ForeColor = Color.DodgerBlue;
        }

        private void sameSideHostilityPrev_MouseDown(object sender, MouseEventArgs e)
        {
            switch (sameSideHostility.Text)
            {
                case "0 %":
                    break;
                case "10 %":
                    sameSideHostility.Text = "0 %";
                    break;
                case "20 %":
                    sameSideHostility.Text = "10 %";
                    break;
                case "30 %":
                    sameSideHostility.Text = "20 %";
                    break;
                case "40 %":
                    sameSideHostility.Text = "30 %";
                    break;
                case "50 %":
                    sameSideHostility.Text = "40 %";
                    break;
                case "60 %":
                    sameSideHostility.Text = "50 %";
                    break;
                case "70 %":
                    sameSideHostility.Text = "60 %";
                    break;
                case "80 %":
                    sameSideHostility.Text = "70 %";
                    break;
                case "90 %":
                    sameSideHostility.Text = "80 %";
                    break;
                case "100 %":
                    sameSideHostility.Text = "90 %";
                    break;
            }
        }

        private void sameSideHostilityNext_MouseDown(object sender, MouseEventArgs e)
        {
            switch (sameSideHostility.Text)
            {
                case "0 %":
                    sameSideHostility.Text = "10 %";
                    break;
                case "10 %":
                    sameSideHostility.Text = "20 %";
                    break;
                case "20 %":
                    sameSideHostility.Text = "30 %";
                    break;
                case "30 %":
                    sameSideHostility.Text = "40 %";
                    break;
                case "40 %":
                    sameSideHostility.Text = "50 %";
                    break;
                case "50 %":
                    sameSideHostility.Text = "60 %";
                    break;
                case "60 %":
                    sameSideHostility.Text = "70 %";
                    break;
                case "70 %":
                    sameSideHostility.Text = "80 %";
                    break;
                case "80 %":
                    sameSideHostility.Text = "90 %";
                    break;
                case "90 %":
                    sameSideHostility.Text = "100 %";
                    break;
                case "100 %":
                    break;
            }
        }

        private void ConversionAssault_MouseEnter(object sender, EventArgs e)
        {
            conversionAssault.ForeColor = Color.DodgerBlue;
        }

        private void ConversionAssault_MouseLeave(object sender, EventArgs e)
        {
            conversionAssault.ForeColor = Color.Gainsboro;
        }

        private void conversionCursedAssault_MouseEnter(object sender, EventArgs e)
        {
            conversionCursedAssault.ForeColor = Color.DodgerBlue;
        }

        private void conversionCursedAssault_MouseLeave(object sender, EventArgs e)
        {
            conversionCursedAssault.ForeColor = Color.Gainsboro;
        }

        private void conversionPmcBot_MouseEnter(object sender, EventArgs e)
        {
            conversionPmcBot.ForeColor = Color.DodgerBlue;
        }

        private void conversionPmcBot_MouseLeave(object sender, EventArgs e)
        {
            conversionPmcBot.ForeColor = Color.Gainsboro;
        }

        private void conversionExUsec_MouseEnter(object sender, EventArgs e)
        {
            conversionExUsec.ForeColor = Color.DodgerBlue;
        }

        private void conversionExUsec_MouseLeave(object sender, EventArgs e)
        {
            conversionExUsec.ForeColor = Color.Gainsboro;
        }

        private void ConversionAssaultPrev_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionAssault.Text)
            {
                case "0 %":
                    break;
                case "10 %":
                    conversionAssault.Text = "0 %";
                    break;
                case "20 %":
                    conversionAssault.Text = "10 %";
                    break;
                case "30 %":
                    conversionAssault.Text = "20 %";
                    break;
                case "40 %":
                    conversionAssault.Text = "30 %";
                    break;
                case "50 %":
                    conversionAssault.Text = "40 %";
                    break;
                case "60 %":
                    conversionAssault.Text = "50 %";
                    break;
                case "70 %":
                    conversionAssault.Text = "60 %";
                    break;
                case "80 %":
                    conversionAssault.Text = "70 %";
                    break;
                case "90 %":
                    conversionAssault.Text = "80 %";
                    break;
                case "100 %":
                    conversionAssault.Text = "90 %";
                    break;
            }
        }

        private void ConversionAssaultNext_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionAssault.Text)
            {
                case "0 %":
                    conversionAssault.Text = "10 %";
                    break;
                case "10 %":
                    conversionAssault.Text = "20 %";
                    break;
                case "20 %":
                    conversionAssault.Text = "30 %";
                    break;
                case "30 %":
                    conversionAssault.Text = "40 %";
                    break;
                case "40 %":
                    conversionAssault.Text = "50 %";
                    break;
                case "50 %":
                    conversionAssault.Text = "60 %";
                    break;
                case "60 %":
                    conversionAssault.Text = "70 %";
                    break;
                case "70 %":
                    conversionAssault.Text = "80 %";
                    break;
                case "80 %":
                    conversionAssault.Text = "90 %";
                    break;
                case "90 %":
                    conversionAssault.Text = "100 %";
                    break;
                case "100 %":
                    break;
            }
        }

        private void conversionCursedAssaultPrev_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionCursedAssault.Text)
            {
                case "0 %":
                    break;
                case "10 %":
                    conversionCursedAssault.Text = "0 %";
                    break;
                case "20 %":
                    conversionCursedAssault.Text = "10 %";
                    break;
                case "30 %":
                    conversionCursedAssault.Text = "20 %";
                    break;
                case "40 %":
                    conversionCursedAssault.Text = "30 %";
                    break;
                case "50 %":
                    conversionCursedAssault.Text = "40 %";
                    break;
                case "60 %":
                    conversionCursedAssault.Text = "50 %";
                    break;
                case "70 %":
                    conversionCursedAssault.Text = "60 %";
                    break;
                case "80 %":
                    conversionCursedAssault.Text = "70 %";
                    break;
                case "90 %":
                    conversionCursedAssault.Text = "80 %";
                    break;
                case "100 %":
                    conversionCursedAssault.Text = "90 %";
                    break;
            }
        }

        private void conversionCursedAssaultNext_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionCursedAssault.Text)
            {
                case "0 %":
                    conversionCursedAssault.Text = "10 %";
                    break;
                case "10 %":
                    conversionCursedAssault.Text = "20 %";
                    break;
                case "20 %":
                    conversionCursedAssault.Text = "30 %";
                    break;
                case "30 %":
                    conversionCursedAssault.Text = "40 %";
                    break;
                case "40 %":
                    conversionCursedAssault.Text = "50 %";
                    break;
                case "50 %":
                    conversionCursedAssault.Text = "60 %";
                    break;
                case "60 %":
                    conversionCursedAssault.Text = "70 %";
                    break;
                case "70 %":
                    conversionCursedAssault.Text = "80 %";
                    break;
                case "80 %":
                    conversionCursedAssault.Text = "90 %";
                    break;
                case "90 %":
                    conversionCursedAssault.Text = "100 %";
                    break;
                case "100 %":
                    break;
            }
        }

        private void conversionPmcBotPrev_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionPmcBot.Text)
            {
                case "0 %":
                    break;
                case "10 %":
                    conversionPmcBot.Text = "0 %";
                    break;
                case "20 %":
                    conversionPmcBot.Text = "10 %";
                    break;
                case "30 %":
                    conversionPmcBot.Text = "20 %";
                    break;
                case "40 %":
                    conversionPmcBot.Text = "30 %";
                    break;
                case "50 %":
                    conversionPmcBot.Text = "40 %";
                    break;
                case "60 %":
                    conversionPmcBot.Text = "50 %";
                    break;
                case "70 %":
                    conversionPmcBot.Text = "60 %";
                    break;
                case "80 %":
                    conversionPmcBot.Text = "70 %";
                    break;
                case "90 %":
                    conversionPmcBot.Text = "80 %";
                    break;
                case "100 %":
                    conversionPmcBot.Text = "90 %";
                    break;
            }
        }

        private void conversionPmcBotNext_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionPmcBot.Text)
            {
                case "0 %":
                    conversionPmcBot.Text = "10 %";
                    break;
                case "10 %":
                    conversionPmcBot.Text = "20 %";
                    break;
                case "20 %":
                    conversionPmcBot.Text = "30 %";
                    break;
                case "30 %":
                    conversionPmcBot.Text = "40 %";
                    break;
                case "40 %":
                    conversionPmcBot.Text = "50 %";
                    break;
                case "50 %":
                    conversionPmcBot.Text = "60 %";
                    break;
                case "60 %":
                    conversionPmcBot.Text = "70 %";
                    break;
                case "70 %":
                    conversionPmcBot.Text = "80 %";
                    break;
                case "80 %":
                    conversionPmcBot.Text = "90 %";
                    break;
                case "90 %":
                    conversionPmcBot.Text = "100 %";
                    break;
                case "100 %":
                    break;
            }
        }

        private void conversionCursedAssaultPrev_MouseEnter(object sender, EventArgs e)
        {
            conversionCursedAssaultPrev.ForeColor = Color.DodgerBlue;
        }

        private void conversionCursedAssaultPrev_MouseLeave(object sender, EventArgs e)
        {
            conversionCursedAssaultPrev.ForeColor = Color.Gainsboro;
        }

        private void ConversionAssaultPrev_MouseEnter(object sender, EventArgs e)
        {
            ConversionAssaultPrev.ForeColor = Color.DodgerBlue;
        }

        private void ConversionAssaultPrev_MouseLeave(object sender, EventArgs e)
        {
            ConversionAssaultPrev.ForeColor = Color.Gainsboro;
        }

        private void ConversionAssaultNext_MouseEnter(object sender, EventArgs e)
        {
            ConversionAssaultNext.ForeColor = Color.DodgerBlue;
        }

        private void ConversionAssaultNext_MouseLeave(object sender, EventArgs e)
        {
            ConversionAssaultNext.ForeColor = Color.Gainsboro;
        }

        private void conversionPmcBotPrev_MouseEnter(object sender, EventArgs e)
        {
            conversionPmcBotPrev.ForeColor = Color.DodgerBlue;
        }

        private void conversionPmcBotPrev_MouseLeave(object sender, EventArgs e)
        {
            conversionPmcBotPrev.ForeColor = Color.Gainsboro;
        }

        private void conversionPmcBotNext_MouseEnter(object sender, EventArgs e)
        {
            conversionPmcBotNext.ForeColor = Color.DodgerBlue;
        }

        private void conversionPmcBotNext_MouseLeave(object sender, EventArgs e)
        {
            conversionPmcBotNext.ForeColor = Color.Gainsboro;
        }

        private void conversionExUsecPrev_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionExUsec.Text)
            {
                case "0 %":
                    break;
                case "10 %":
                    conversionExUsec.Text = "0 %";
                    break;
                case "20 %":
                    conversionExUsec.Text = "10 %";
                    break;
                case "30 %":
                    conversionExUsec.Text = "20 %";
                    break;
                case "40 %":
                    conversionExUsec.Text = "30 %";
                    break;
                case "50 %":
                    conversionExUsec.Text = "40 %";
                    break;
                case "60 %":
                    conversionExUsec.Text = "50 %";
                    break;
                case "70 %":
                    conversionExUsec.Text = "60 %";
                    break;
                case "80 %":
                    conversionExUsec.Text = "70 %";
                    break;
                case "90 %":
                    conversionExUsec.Text = "80 %";
                    break;
                case "100 %":
                    conversionExUsec.Text = "90 %";
                    break;
            }
        }

        private void conversionExUsecNext_MouseDown(object sender, MouseEventArgs e)
        {
            switch (conversionExUsec.Text)
            {
                case "0 %":
                    conversionExUsec.Text = "10 %";
                    break;
                case "10 %":
                    conversionExUsec.Text = "20 %";
                    break;
                case "20 %":
                    conversionExUsec.Text = "30 %";
                    break;
                case "30 %":
                    conversionExUsec.Text = "40 %";
                    break;
                case "40 %":
                    conversionExUsec.Text = "50 %";
                    break;
                case "50 %":
                    conversionExUsec.Text = "60 %";
                    break;
                case "60 %":
                    conversionExUsec.Text = "70 %";
                    break;
                case "70 %":
                    conversionExUsec.Text = "80 %";
                    break;
                case "80 %":
                    conversionExUsec.Text = "90 %";
                    break;
                case "90 %":
                    conversionExUsec.Text = "100 %";
                    break;
                case "100 %":
                    break;
            }
        }

        private void conversionExUsecPrev_MouseEnter(object sender, EventArgs e)
        {
            conversionExUsecPrev.ForeColor = Color.DodgerBlue;
        }

        private void conversionExUsecPrev_MouseLeave(object sender, EventArgs e)
        {
            conversionExUsecPrev.ForeColor = Color.Gainsboro;
        }

        private void conversionExUsecNext_MouseEnter(object sender, EventArgs e)
        {
            conversionExUsecNext.ForeColor = Color.DodgerBlue;
        }

        private void conversionExUsecNext_MouseLeave(object sender, EventArgs e)
        {
            conversionExUsecNext.ForeColor = Color.Gainsboro;
        }

        private void conversionCursedAssaultNext_MouseEnter(object sender, EventArgs e)
        {
            conversionCursedAssaultNext.ForeColor = Color.DodgerBlue;
        }

        private void conversionCursedAssaultNext_MouseLeave(object sender, EventArgs e)
        {
            conversionCursedAssaultNext.ForeColor = Color.Gainsboro;
        }

        private void difficultyItem_MouseDown(object sender, MouseEventArgs e)
        {
            panelDifficulty.BringToFront();
        }

        private void mapBotCapacitiesItem_MouseDown(object sender, MouseEventArgs e)
        {
            panelMaxBotCapacities.BringToFront();
        }

        private void lootValuesItem_MouseEnter(object sender, EventArgs e)
        {
            lootValuesItem.ForeColor = Color.DodgerBlue;
            lootValuesItem.Text += " →";
        }

        private void lootValuesItem_MouseLeave(object sender, EventArgs e)
        {
            lootValuesItem.ForeColor = Color.Gainsboro;
            lootValuesItem.Text = lootValuesItem.Text.Substring(0, lootValuesItem.Text.Length - 2);
        }

        private void mapBotCapacitiesItem_MouseEnter(object sender, EventArgs e)
        {
            mapBotCapacitiesItem.ForeColor = Color.DodgerBlue;
            mapBotCapacitiesItem.Text += " →";
        }

        private void mapBotCapacitiesItem_MouseLeave(object sender, EventArgs e)
        {
            mapBotCapacitiesItem.ForeColor = Color.Gainsboro;
            mapBotCapacitiesItem.Text = mapBotCapacitiesItem.Text.Substring(0, mapBotCapacitiesItem.Text.Length - 2);
        }
    }
}
