using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_parking.models
{
    public class carparkcharges
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public carparkcharges(int _minimumFee = 2, int _minimumHours = 3)
        {
            Console.WriteLine("I am the carparkcharges");
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public int CalculateCharges(int hoursParked)
        {
            int calculatedFee = hoursParked < minimumHours ? minimumFee : hoursParked * minimumFee;
            return calculatedFee;
        }
    }
}
