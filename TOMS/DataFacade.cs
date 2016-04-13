using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TOMS
{
    class DataFacade
    {
        //private TomsDatabase DatabaseConnector ; 
        private string configPath;
        private OrderSaver OrderSaverObj;
        private string menuFile;
        private string orderHistoryFile;
        private MenuReader MenuReaderObj;
        private int no_of_tables;

        public int getNoOfTables()
        {
            return no_of_tables;
        }

        public void setNoOfTables(int number)
        {
            no_of_tables = number;
        }

        public void MenuReload(Menu menuObj)
        {
            MenuReaderObj.MenuLoad(menuObj);
        }
        public string getOrderHistoryFile()
        {
            return orderHistoryFile;
        }
        public string getMenuFile()
        {
            return menuFile;
        }
        public void setOrderHistoryFile(String path = "C:/Users/Mahesh K S/Documents/Orders.json")
        {
            orderHistoryFile = path;
        }
        public void setMenuFile(String path)
        {
            menuFile = path;
        }
        public void SaveOrder(Order OrderObj)
        {
            OrderSaverObj.WriteToFile(OrderObj);
        }

        internal void LoadConfig(string configFile)
        {
            string line;
            StreamReader sr = new StreamReader(configFile);
            while ((line = sr.ReadLine()) != null)
            {
                string[] iter = line.Split(',');
                try
                {
                    string name = iter[0];
                    if (iter[0].Contains("tables"))
                    {
                        setNoOfTables(Int32.Parse(iter[1]));
                    }
                    else if (iter[0].Contains("menu"))
                    {
                        setMenuFile(iter[1]);
                    }
                    else if (iter[0].Contains("order"))
                    {
                        setOrderHistoryFile(iter[1]);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            if (this.getOrderHistoryFile()==null)
            {
                this.setOrderHistoryFile();
            }
        }
        public DataFacade (string configFile = "C:/Users/Mahesh K S/Documents/Config.csv")
        {
            configPath = configFile;
            LoadConfig(configFile);
            MenuReaderObj = new MenuReader(getMenuFile());
            OrderSaverObj = new OrderSaver(getOrderHistoryFile());
        }


    }
}
