using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSystem
{
    public class Customer
    {

        // member variables
        public double money;
        public List<Item> items;

        // constructor
        public Customer()
        {
            money = 20.00;
        }

        // member methods
        // Add items to a customer before checkout
        public void CreateItem(Item item)
        {
            items.Add(item);
        }

    }   
}
