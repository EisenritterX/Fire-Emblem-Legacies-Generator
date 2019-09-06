using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FELegaciesGeneratorTool.Objects;
using FELegaciesGeneratorTool.Views;

namespace FELegaciesGeneratorTool
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        // This is temporary
        public static Hero hero;
        public static List<Class> JobClasses;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initiate a new dictionary of the forms being used
            Forms = new Dictionary<FormNames, Form>();

            //Add form used to the dictionary
            Forms.Add(FormNames.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.HEROGEN_FORM, new HeroGenerator());
            Forms.Add(FormNames.CLASSGEN_FORM, new ClassGenerator());
            

            //Creates a new Hero
            hero = new Hero();
            JobClasses = new List<Class>();

            Application.Run(Forms[FormNames.SPLASH_SCREEN]);
        }
    }
}
