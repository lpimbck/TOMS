using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOMS
{
    public class ListLineItem
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
}
