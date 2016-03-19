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
            
            public ListLineItem(Item item, int qty)
            {
                this.item = item;
                this.qty = qty;
            }
            public ListLineItem(int itemID, int qty)
            {
                this.item = Menu.Instance.getItem(itemID);
                this.qty = qty;
            }

        }
        List<ListLineItem> itemList { get; set; }

        public Order()
        {
            itemList = new List<ListLineItem>();
        }

        public void addToOrder (Item item, int quantity)
        {
            this.itemList.Add(new ListLineItem(item, quantity));
        }

        public void addToOrder(int itemId, int quantity)
        {
            this.itemList.Add(new ListLineItem(itemId, quantity));
        }

    }
}
