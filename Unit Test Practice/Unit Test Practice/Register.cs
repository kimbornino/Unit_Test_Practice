using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegisterSystem
{
    public class Register
    {
        // member variables

        // constructor
        public Register()
        {
            
        }

        // member methods
        // If the number is even, it's taxable.  If the number is odd, it's not taxable
        public void CalculateSalesTax(Item item)
        {
            if (item.price % 2 == 0)
            {
                item.price = (item.price * .05);
            }
        }

        // Add up the cost of each item in a customer's list
        public double AddUpItems(List<Item> items)
        {
            double itemTotal = 0;

            foreach(Item item in items)
            {
                itemTotal += item.price;
            }

            return itemTotal;
        }

        // Deducts amount from customer based on their purchase total
        public void AcceptPayment(double itemTotal, Customer customer)
        {
            customer.money -= itemTotal; 
        }

    }
}
