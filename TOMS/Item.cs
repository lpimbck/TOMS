using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class represent an item with an order
namespace TOMS
{
    class Item
    {
        int id;
        string name;
        float price;
        public Item(int id)
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
        }

        public string getName(){
            return this.name;
        }
        public float getPrice()
        {
            return this.price;
        }

    }
}
