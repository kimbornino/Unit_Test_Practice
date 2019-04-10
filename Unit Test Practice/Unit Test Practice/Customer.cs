using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSystem
{
    public class Customer
    {
        public double money;
        public List<Item> items;
        

        public Customer()
        {
            money = 20.00;
        }

        //Add items to a customer before checkout
        public void CreateItem(Item item)
        {
            items.Add(item);
        }
   

    }
   
}
