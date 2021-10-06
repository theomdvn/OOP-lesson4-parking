using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_parking.models
{
    public class carpark
    {
        public List<customers> listOfCustomers = new List<customers>();

        public carparkcharges CarParkCharges = new carparkcharges();
        public carpark()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public void CalculateCharges()
        {
            foreach(customers Customer in listOfCustomers)
            {
                int calculatedCharge = CarParkCharges.CalculateCharges(Customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer, price for this customer is {calculatedCharge}euros");
            }
        }
    }

}
