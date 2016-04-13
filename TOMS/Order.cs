using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMS
{
    //Order keeps a list of items that the customer ordered
    class Order : OrderAbstract
    {
        public override void closeOrder() 
        {
            DataFacade df = new DataFacade();
            df.SaveOrder(this);
            ItemList = new List<ListLineItem>();
        }

        public Order()
        {
            ItemList = new List<ListLineItem>();
        }

        
    }
}
