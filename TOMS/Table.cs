using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TOMS
{
    
    public class Table
    {
        public Table(int tableNo, string waiterName = "default", Users userObj = null)
        {
            this.tableNo = tableNo;
            order = null;
            occupied = false;
            numOfCustomers = 0;
            this.waiterName = waiterName;
        }

        String waiterName { get; set; }
        OrderAbstract order { get; set; }
        int numOfCustomers { get; set; }
        bool occupied { get; set; }
        int tableNo { get; set; }
        TableDetails tableDetailsForm { get; set; }

        public OrderAbstract OrderObj 
        {
            get
            {
                return order;
            }
            set
            {
                order = value;
            }

        }

        public bool getOccupiedStatus ()
        {
            return this.occupied;
        }

        public void setOccupiedStatus()
        {
            this.occupied = true;
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
