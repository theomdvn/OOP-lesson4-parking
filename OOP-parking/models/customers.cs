using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_parking.models
{
    public class customers
    {
        public int hoursParked { get; set; }
        public string registration { get; set; }
        public customers(int _hoursParked, string _registration)
        {
            Console.WriteLine("I am the customers");
            hoursParked = _hoursParked;
            registration = _registration;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
