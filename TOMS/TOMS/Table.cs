using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMS
{
    
    class Table
    {
        String waiterName { get; set; }
        Order order { get; set; }
        int numOfCustomers { get; set; }
        bool occupied { get; set; }

        Table()
        {
            //order = new Order();
            occupied = false;
            numOfCustomers = 0;
            waiterName = "default";
        }



    }
}
