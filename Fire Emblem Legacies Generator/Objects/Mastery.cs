using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELegaciesGeneratorTool.Objects
{
    public class Mastery
    {
        //Melee
        public int SwordMastery { get; set; }
        public int LanceMastery { get; set; }
        public int AxeMastery { get; set; }
        public int UnarmedMastery { get; set; }
        //Ranged
        public int BowMastery { get; set; }
        public int DaggerMastery { get; set; }
        public int ShurikenMastery { get; set; }
        public int CrossbowMastery { get; set; }
        //Magic
        public int AnimaMastery { get; set; }
        public int LightMastery { get; set; }
        public int DarkMastery { get; set; }
        public int StaveMastery { get; set; }
    }
}
