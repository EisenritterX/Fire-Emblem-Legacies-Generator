using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FELegaciesGeneratorTool.Objects
{
    public class Class
    {
        public string Name { get; set; }
        public int LevelCap { get; set; }
        public bool isPromoted { get; set; }
        public bool isLegendary { get; set; }
        public bool isMounted { get; set; }
        public bool isFlying { get; set; }
        public bool isArmored { get; set; }
        public GrowthRate GrowthRate { get; set; }

        private const double XPMultiplier = 1;
    }
}
