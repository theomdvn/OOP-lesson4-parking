using OOP_parking.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_parking.test
{
    public class Driver
    {
        public Driver()
        {
            Console.Write("I am a driver");
        }

        public void CreateObjects()
        {
            carpark carpark = new carpark();

            carpark.listOfCustomers.Add(new customers(2, "a"));
            carpark.listOfCustomers.Add(new customers(3, "b"));
            carpark.listOfCustomers.Add(new customers(4, "c"));
            carpark.listOfCustomers.Add(new customers(5, "d"));
            carpark.listOfCustomers.Add(new customers(6, "e"));

            carpark.CalculateCharges();


            customers customers = new customers(7, "f");
            carparkcharges carparkcharges = new carparkcharges();
        }
    }
}
