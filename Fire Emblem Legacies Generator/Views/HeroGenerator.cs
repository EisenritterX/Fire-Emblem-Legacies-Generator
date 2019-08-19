/*
 * STUDENT NAME: QIAN LONG (GEORGE) ZHOU
 * STUDENT ID: 300613283
 * DESCRIPTION: This is the Hero Generator Form
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace FELegaciesGeneratorTool.Views
{
    public partial class HeroGenerator : FELegaciesGeneratorTool.Views.MasterForm
    {
        List<string> FirstNameList;
        List<string> LastNameList;
        List<string> PowersList;
        public HeroGenerator()
        {
            InitializeComponent();
            LoadNames();
            GenerateNames();
            LoadPowers();
        }

        /// <summary>
        /// This is the event handler for the Next Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the event handler for the Back Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }

        }
        /// <summary>
        /// Open Character Sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            CharacterSheetOpenFileDialog.FileName = "CharacterSheet.txt";
            CharacterSheetOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSheetOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = CharacterSheetOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open the stream for reading
                    using (StreamReader inputStream = new StreamReader(File.Open(CharacterSheetOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read from file
                        Program.hero.FirstName = inputStream.ReadLine();
                        Program.hero.LastName = inputStream.ReadLine();
                        ////Physical Ability
                        //Program.hero.Fighting = inputStream.ReadLine();
                        //Program.hero.Agility = inputStream.ReadLine();
                        //Program.hero.Strength = inputStream.ReadLine();
                        //Program.hero.Endurance = inputStream.ReadLine();
                        ////Mental Abillity
                        //Program.hero.Reason = inputStream.ReadLine();
                        //Program.hero.Intuition = inputStream.ReadLine();
                        //Program.hero.Psyche = inputStream.ReadLine();
                        //Program.hero.Popularity = inputStream.ReadLine();

                        //Program.hero.Powers.Clear();
                        //Program.hero.Powers.Add(inputStream.ReadLine());
                        //Program.hero.Powers.Add(inputStream.ReadLine());
                        //Program.hero.Powers.Add(inputStream.ReadLine());
                        //Program.hero.Powers.Add(inputStream.ReadLine());
                        //Clean up
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("ERROR" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadHero();
            }
        }

        /// <summary>
        /// Saving Character Sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            //configure the file dialog
            CharacterSheetSaveFileDialog.FileName = "CharacterSheet.txt";
            CharacterSheetSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSheetSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files{*.*)|*.*";

            //open the file dialog
            var result = CharacterSheetSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(File.Open(CharacterSheetSaveFileDialog.FileName, FileMode.Create)))
                {

                    //Write to File
                    //outputStream.WriteLine(Program.hero.FirstName);
                    //outputStream.WriteLine(Program.hero.LastName);
                    ////Physical Ability
                    //outputStream.WriteLine(Program.hero.Fighting);
                    //outputStream.WriteLine(Program.hero.Agility);
                    //outputStream.WriteLine(Program.hero.Strength);
                    //outputStream.WriteLine(Program.hero.Endurance);
                    ////Mental Ability
                    //outputStream.WriteLine(Program.hero.Reason);
                    //outputStream.WriteLine(Program.hero.Intuition);
                    //outputStream.WriteLine(Program.hero.Psyche);
                    //outputStream.WriteLine(Program.hero.Popularity);
                    ////cleanup

                    //outputStream.WriteLine(Program.hero.Powers[0]);
                    //outputStream.WriteLine(Program.hero.Powers[1]);
                    //outputStream.WriteLine(Program.hero.Powers[2]);
                    //outputStream.WriteLine(Program.hero.Powers[3]);

                    outputStream.Close();
                    outputStream.Dispose();

                    //Give feedback to the user that the file has been saved
                    MessageBox.Show("File Saved...", "Saving File...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            GenerateRandomPowers();
            RNGenerator();
        }

        private void GenerateRandomPowers()
        {
            Random powerIndex = new Random();
            Power1DataLabel.Text =PowersList[powerIndex.Next(0, PowersList.Count - 1)];
            Power2DataLabel.Text = PowersList[powerIndex.Next(0, PowersList.Count - 1)];
            Power3DataLabel.Text = PowersList[powerIndex.Next(0, PowersList.Count - 1)];
            Power4DataLabel.Text = PowersList[powerIndex.Next(0, PowersList.Count - 1)];

            //Program.hero.Powers.Add(Power1DataLabel.Text);
            //Program.hero.Powers.Add(Power2DataLabel.Text);
            //Program.hero.Powers.Add(Power3DataLabel.Text);
            //Program.hero.Powers.Add(Power4DataLabel.Text);
        }

        private void LoadPowers()
        {
            PowersList = File.ReadAllLines(@"..\..\Data\powers.txt").ToList();
        }

        private void RNGenerator()
        {
            Random stats = new Random();
            FightingDataLabel.Text = stats.Next(10, 50).ToString();
            StrengthDataLabel.Text = stats.Next(10,50).ToString();
            AgilityDataLabel.Text = stats.Next(10, 50).ToString();
            EnduranceDataLabel.Text = stats.Next(10, 50).ToString();

            ReasonDataLabel.Text = stats.Next(10, 50).ToString();
            IntuitionDataLabel.Text = stats.Next(10, 50).ToString();
            PsycheDataLabel.Text = stats.Next(10, 50).ToString();
            PopularityDataLabel.Text = stats.Next(10, 50).ToString();

            ////Physical Ability
            //Program.hero.Fighting = FightingDataLabel.Text;
            //Program.hero.Agility = AgilityDataLabel.Text;
            //Program.hero.Strength = StrengthDataLabel.Text;
            //Program.hero.Endurance = EnduranceDataLabel.Text;
            ////Mental Abillity
            //Program.hero.Reason = ReasonDataLabel.Text;
            //Program.hero.Intuition =IntuitionDataLabel.Text;
            //Program.hero.Psyche = PsycheDataLabel.Text;
            //Program.hero.Popularity = PopularityDataLabel.Text;
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.hero.FirstName = FirstNameDataLabel.Text;
            Program.hero.LastName = LastNameDataLabel.Text;
        }

        private void LoadNames()
        {
            FirstNameList = File.ReadAllLines(@"..\..\Data\firstNames.txt").ToList();
            LastNameList = File.ReadAllLines(@"..\..\Data\lastNames.txt").ToList();
        }

        private void GenerateNames()
        {
            Random fnameRandomIndex = new Random();
            Random lnameRandomIndex = new Random();
            string Fname = FirstNameList[fnameRandomIndex.Next(0, FirstNameList.Count - 1)];
            string Lname = LastNameList[lnameRandomIndex.Next(0, LastNameList.Count - 1)];
            HeroNameTextBox.Text = Fname +" "+ Lname;
            FirstNameDataLabel.Text = Fname;
            LastNameDataLabel.Text = Lname;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex == 3)
            {
                LoadHero();
            }
        }

        private void LoadHero()
        {
            CSFname.Text = Program.hero.FirstName;
            CSLName.Text = Program.hero.LastName;
            ////Physical Ability
            //CSFighting.Text = Program.hero.Fighting;
            //CSStrength.Text = Program.hero.Agility;
            //CSAgility.Text = Program.hero.Strength;
            //CSEndurance.Text = Program.hero.Endurance;
            ////Mental Abillity
            //CSReason.Text = Program.hero.Reason;
            //CSIntuition.Text = Program.hero.Intuition;
            //CSPsyche.Text = Program.hero.Psyche;
            //CSPopularity.Text = Program.hero.Popularity;

            //CSPower1.Text = Program.hero.Powers[0];
            //CSPower2.Text = Program.hero.Powers[1];
            //CSPower3.Text = Program.hero.Powers[2];
            //CSPower4.Text = Program.hero.Powers[3];
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HeroGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
