using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * STUDENT NAME: QIAN LONG (GEORGE) ZHOU
 * STUDENT ID: 300613283
 * DESCRIPTION: This is the Hero Data Container Class
 */
namespace FELegaciesGeneratorTool.Objects
{
    public class Hero
    {
        //PRIVATE INSTANCE VARIABLE
        private int m_HP;
        private int m_STR;
        private int m_MAG;
        private int m_SKL;
        private int m_SPD;
        private int m_LUK;
        private int m_DEF;
        private int m_RES;

        //Identity
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Image Portrait { get; set; }
        

        //PRIMARY ABILITIES
        //Stats
        public int HP
        {
            get
            {
                return m_HP;
            }

            set
            {
                this.m_HP = value;
            }
        }
        public int STR
        {
            get
            {
                return m_STR;
            }

            set
            {
                this.m_STR = value;
            }
        }
        public int MAG
        {
            get
            {
                return m_MAG;
            }

            set
            {
                this.m_MAG = value;
            }
        }
        public int SKL
        {
            get
            {
                return m_SKL;
            }

            set
            {
                this.m_SKL = value;
            }
        }
        public int SPD
        {
            get
            {
                return m_SPD;
            }

            set
            {
                this.m_SPD = value;
            }
        }
        public int LUK
        {
            get
            {
                return m_LUK;
            }

            set
            {
                this.m_LUK = value;
            }
        }
        public int DEF
        {
            get
            {
                return m_DEF;
            }

            set
            {
                this.m_DEF = value;
            }
        }
        public int RES
        {
            get
            {
                return m_RES;
            }

            set
            {
                this.m_RES = value;
            }
        }

        //Unit Class
        public UnitClass Class { get; set; }
        //Power List
        public Power Powers;
        //Mastery
        public Mastery mastery;

        //Constructor
        public Hero()
        {
            //Instantiates an empty Power List
            //Powers = new List<string>();
        }
    }

}
