using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELegaciesGeneratorTool.Objects
{
    public class UnitClass
    {
        public string Name { get; set; }
        public int LevelCap { get; set; }
        public bool Promoted { get; set; }
        public bool Legendary { get; set; }
        public GrowthRate GrowthRate {get;set;}
    }
}
