using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;


namespace TOMS
{
    //System holds a list of Tables and other global information about the whole restaurant
    class System
    {
        private static System instance;
        int numberOfTables;
        List<Table> tableList;
        private System() {
            DataFacade df = new DataFacade();
            numberOfTables = df.getNoOfTables();
            tableList = new List<Table>();
            for (int i=0; i< numberOfTables; i++)
            {
                tableList.Add(new Table(i));
            }
        }

        public static System Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new System();
                }
                return instance;
            }
        }

        public void setNumberofTables(int numberOfTables)
        {
            this.numberOfTables= numberOfTables;
        }

        public Table getTable (int tableId)
        {
            return this.tableList.Find(x => x.getTableId() == tableId);
        }
        public int getNumberofTables()
        {
            return numberOfTables;
        }
    }
}
