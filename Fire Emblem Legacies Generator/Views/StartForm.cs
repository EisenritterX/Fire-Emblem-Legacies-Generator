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
    public partial class StartForm : FELegaciesGeneratorTool.Views.MasterForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateUnitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms[FormNames.HEROGEN_FORM].Show();
        }
    }
}
