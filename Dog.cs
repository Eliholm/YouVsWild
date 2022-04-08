using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouVsWild
{
    static internal class Dog
    {
        static public string Name = "Dina";
        static int healthPoints = 3;

        static public int HealthPoints
        {
            get { return healthPoints; }
            set
            {
                healthPoints = value;
            }
        }
    }

}
