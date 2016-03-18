using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class represent an item with an order
namespace TOMS
{
    public class Item
    {
        int id { get; set; }
        string name;
        float price;
        string description;

        public int getid()
        {
            return this.id;
        }
        public static string getDescription (Item item)
        {
            return item.description;
        }

        public static string getName(Item item)
        {
            return item.name;
        }
        public static int getItemId(Item item)
        {
            return item.id;
        }
        public static float getPrice(Item item)
        {
            return item.price;
        }
        public Item (int id, string name, string description, float price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
        }
        /*public Item(int id)
        {
            switch (id)
            {
                case 1:
                    this.name = "Cheese Burger";
                    this.price = 5.99f;
                    break;
                case 2:
                    this.name = "Fries";
                    this.price = 1.99f;
                    break;
                case 3:
                    this.name = "Cola";
                    this.price = 1.5f;
                    break;
                case 4:
                    this.name = "Pancake";
                    this.price = 2.5f;
                    break;
            }
           
        }*/

        public string getName(){
            return this.name;
        }

        /*public static Item getItem (int itemID)
        {
           // return new Item ()
        }*/
        public float getPrice()
        {
            return this.price;
        }

    }
}
