using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMS
{
    //Order keeps a list of items that the customer ordered
    class Order
    {
        private class ListLineItem
        {
            Item item;
            int qty;
            
            ListLineItem(Item item, int qty)
            {
                this.item = item;
                this.qty = qty;
            }
            ListLineItem(int itemID, int qty)
            {
                //this.item = Item.getItem(itemID);
                this.qty = qty;
            }

        }
        List<Item> itemList { get; set; }

        Order()
        {
            itemList = null;
        }

        public void addToOrder (Item itemId, int quantity)
        {
            //this.itemList.Add
        }

    }
}
