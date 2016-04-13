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
        private List<Item> itemList;
        private Menu()
        {
            itemList = new List<Item>();
        }

        public static Menu Instance
        {
            get
            {
                if (menu == null)
                {
                    menu = new Menu();
                } else if (menu.itemList.Count ==0)
                {
                    DataFacade df = new DataFacade();
                    df.MenuReload(menu);
                }
                return menu;
            }
        }

        public void reloadMenu()
        {
            DataFacade df = new DataFacade();
            df.MenuReload(this);
        }

        public void addItem(Item newItem)
        {
            itemList.Add(newItem);
        }

        public Item getItem (int itemId)
        {
            return itemList.Find(x => x.getid() == itemId);
        }
    }
}
