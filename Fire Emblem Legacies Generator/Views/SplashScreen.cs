using FELegaciesGeneratorTool.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FELegaciesGeneratorTool.Views
{
    public partial class SplashScreen : FELegaciesGeneratorTool.Views.MasterForm
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enable Timers When Splash Screen is Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            ProgressTimer.Enabled = true;
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            SplashProgressBar.PerformStep();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            ProgressTimer.Enabled = false;
            this.Hide();
            Program.Forms[FormNames.HEROGEN_FORM].Show();
        }
    }
}
