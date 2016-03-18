using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TOMS
{
    public class Menu
    {
        private static Menu menu;
        List<Item> itemList =  new List<Item>();
        private Menu()
        {
            string line;
            FileStream aFile = new FileStream("C:/Users/Mahesh K S/Documents/Menu.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);

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
                    Item item = new Item(id, name, description, price);
                    itemList.Add(item); //add items to the list
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
        }

        public static Menu Instance
        {
            get
            {
                if (menu == null)
                {
                    menu = new Menu();
                }
                return menu;
            }
        }

        public void reloadMenu()
        {
            string line;
            FileStream aFile = new FileStream("C:/Users/Mahesh K S/Documents/Menu.csv", FileMode.Open);
            StreamReader sr = new StreamReader(aFile);

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
                    Item item = new Item(id, name, description, price);
                    itemList.Add(item); //add items to the list
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                line = sr.ReadLine();
            }
            sr.Close();
        }

        public Item getItem (int itemId)
        {
            return itemList.Find(x => x.getid() == itemId);
        }
    }
}
