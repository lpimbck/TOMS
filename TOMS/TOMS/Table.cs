using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMS
{
    
    class Table
    {
        public Table(int tableNo, string waiterName = "default")
        {
            this.tableNo = tableNo;
            order = new Order();
            occupied = false;
            numOfCustomers = 0;
            this.waiterName = waiterName;
            this.tableDetailsForm = new TableDetails();
        }

        String waiterName { get; set; }
        Order order { get; set; }
        int numOfCustomers { get; set; }
        bool occupied { get; set; }
        int tableNo { get; set; }
        TableDetails tableDetailsForm { get; set; }

        public bool getOccupiedStatus ()
        {
            return this.occupied;
        }

        public TableDetails TableDetailsForm
        {
            get
            {
                return this.tableDetailsForm;
            }

            set
            {

            }

        }

    public int getTableId ()
        {
            return this.tableNo;
        }


    }
}
