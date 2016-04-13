using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TOMS
{
    class MenuReader
    {
        private string MenuFilePath ;

        public MenuReader(String MenuFilePath) 
        {
            this.MenuFilePath = MenuFilePath;
        }

        public void MenuLoad(Menu MenuObj)
        {
            string line;
            FileStream MFile = new FileStream(this.MenuFilePath, FileMode.Open);
            StreamReader sr = new StreamReader(MFile);

            // read data in line by line
            while ((line = sr.ReadLine()) != null)
            {
                string[] iter = line.Split(',');
                try
                {
                    string name = iter[1];
                    string description = iter[2];
                    float price = float.Parse(iter[3]);
                    int id = Int32.Parse(iter[0]);
                    Item newItem = new Item(id, name, description, price);
                    MenuObj.addItem(newItem); //add items to the list
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
