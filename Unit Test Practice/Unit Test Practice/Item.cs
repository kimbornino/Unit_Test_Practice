using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterSystem
{
    public class Item
    {
        public string name;
        public double price;

        //items need a price and name to be instatiated
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price; 
        }

 
    }
}
