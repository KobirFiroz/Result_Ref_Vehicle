using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class VehicleClass
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public List <int> Speed { set; get; }

        public int GetMaximumSpeed()
        {
            return Speed.Max();
        }

        public int GetMinimumSpeed()
        {
            return Speed.Min();
        }

        public double GetAverageSpeed()
        {
            double averageSSpeed = Convert.ToDouble(Speed.Average());
            return averageSSpeed;
        }

    }
}
