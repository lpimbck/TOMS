using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOMS
{
    class OrderFactory
    {
        public OrderFactory()
        {

        }

        public OrderAbstract getNewOrder(string ordertype = "Dinein")
        {
            if (ordertype.Equals("Dinein"))
            {
                OrderPool.getInstance().getNewOrder();
            }
            else if (ordertype.Equals("Takeout")) {
                //create a new take out object for now creating normal object
                return new Order();
            }
            return new Order();
        }
    }
}
