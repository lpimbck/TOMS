using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOMS
{
    class OrderPool
    {
        private static OrderPool OPInstance;
        List<Order> OP;
        private OrderPool()
        {
            OP = new List<Order>();
            DataFacade df = new DataFacade();
            for(int i=0; i< df.getNoOfTables();i++)
            {
                OP.Add(new Order());
            }
        } 
        public static OrderPool getInstance()
        {
            if (OPInstance == null)
            {
                OPInstance = new OrderPool();
            }
            return OPInstance;
        }

        public Order getNewOrder()
        {
            return this.OP.Find(x => x.ItemList == null);
        }

    }
}
