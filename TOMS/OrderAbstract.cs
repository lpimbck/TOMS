using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOMS
{
    public abstract class OrderAbstract
    {
        String TimeStamp;
        int orderNumber;
        List<ListLineItem> itemList { get; set; }

        public List<ListLineItem> ItemList
        {
            get
            {
                return this.itemList;
            }
            set
            {
                this.itemList = ItemList;
            }
        }
        internal void updateTimeStamp()
        {
            TimeStamp = DateTime.Now.ToString();
        }

        public void addToOrder(Item item, int quantity)
        {
            this.itemList.Add(new ListLineItem(item, quantity));
        }

        public void addToOrder(int itemId, int quantity)
        {
            this.itemList.Add(new ListLineItem(itemId, quantity));
        }

        public abstract void closeOrder();
    }
}
