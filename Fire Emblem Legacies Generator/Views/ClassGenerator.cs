using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using FELegaciesGeneratorTool.Objects;

namespace FELegaciesGeneratorTool.Views
{
    public partial class ClassGenerator : FELegaciesGeneratorTool.Views.MasterForm
    {
        public Class JobClass;
        public ClassGenerator()
        {
            InitializeComponent();
        }

        private void ClassGenerator_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.START_FORM].Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetDataFromForm();
            string classJsonData = JsonConvert.SerializeObject(JobClass);
            if (!Program.JobClasses.Contains(JobClass))
            {
                Program.JobClasses.Add(JobClass);
            }
        }

        private void GetDataFromForm()
        {
            //Class Info
            JobClass.Name = ClassNameTB.Text;
            JobClass.Desc = DescriptionRTF.Text;
            JobClass.Portrait = PortraitPictureBox.Image;

            //Base Stats
            JobClass.BaseStat.HP = (int)BSHPNum.Value;
            JobClass.BaseStat.STR = (int)BSSTRNum.Value;
            JobClass.BaseStat.MAG = (int)BSMAGNum.Value;
            JobClass.BaseStat.SKL = (int)BSSKLNum.Value;
            JobClass.BaseStat.SPD = (int)BSSPDNum.Value;
            JobClass.BaseStat.LUK = (int)BSLCKNum.Value;
            JobClass.BaseStat.DEF = (int)BSDEFNum.Value;
            JobClass.BaseStat.RES = (int)BSRESNum.Value;
            JobClass.BaseStat.MV = (int)BSMVNum.Value;
            JobClass.BaseStat.LVCap = (int)BSLVLCapNum.Value;

            //Base Mastery
            JobClass.BaseMastery.SwordMastery = (int)(SwordMasteryNumeric.Value);
            JobClass.BaseMastery.LanceMastery = (int)(LanceMasteryNumeric.Value);
            JobClass.BaseMastery.AxeMastery = (int)(AxeMasteryNumeric.Value);
            JobClass.BaseMastery.UnarmedMastery = (int)(UnarmedMasteryNumeric.Value);
            JobClass.BaseMastery.BowMastery = (int)(BowMasteryNumeric.Value);
            JobClass.BaseMastery.DaggerMastery = (int)(DaggerMasteryNumeric.Value);
            JobClass.BaseMastery.ShurikenMastery = (int)(ShurikenMasteryNumeric.Value);
            JobClass.BaseMastery.CrossbowMastery = (int)(CrossbowMasteryNumeric.Value);
            JobClass.BaseMastery.LightMastery = (int)(LightMasteryNumeric.Value);
            JobClass.BaseMastery.AnimaMastery = (int)(AnimaMasteryNumeric.Value);
            JobClass.BaseMastery.DarkMastery = (int)(DarkMasteryNumeric.Value);
            JobClass.BaseMastery.StaveMastery = (int)(StaveMasteryNumeric.Value);

            //Growth Rate
            JobClass.GrowthRate.HP = (int)HPGrowthNumeric.Value;
            JobClass.GrowthRate.STR = (int)STRGrowthNumeric.Value;
            JobClass.GrowthRate.MAG = (int)MAGGrowthNumeric.Value;
            JobClass.GrowthRate.SKL = (int)SKLGrowthNumeric.Value;
            JobClass.GrowthRate.SPD = (int)SPDGrowthNumeric.Value;
            JobClass.GrowthRate.LUK = (int)LCKGrowthNumeric.Value;
            JobClass.GrowthRate.DEF = (int)DEFGrowthNumeric.Value;
            JobClass.GrowthRate.RES = (int)RESGrowthNumeric.Value;
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            JobClass = new Class();
        }

        private void ClassGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.START_FORM].Show();
        }
    }
}
