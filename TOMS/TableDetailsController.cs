using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper;

namespace TOMS
{
    class TableDetailsController : ITableDetails
    {
        private static TableDetailsController TableDetailsControllerInstance;

        private TableDetailsController()
        {
            Menu.Instance.reloadMenu();
            Mapper.CreateMap<Table, OrderAbstract>().ReverseMap();
        }

        public static TableDetailsController getInstance()
        {
            if (TableDetailsControllerInstance == null)
            {
                TableDetailsControllerInstance= new TableDetailsController();
            }
            return TableDetailsControllerInstance;
        }
        public string autoPopulate (string fieldText)
        {
            int j;
            if (Int32.TryParse(fieldText, out j))
            {

            }
            else {
                throw new InvalidOperationException ("field item id has to be an integer");
            }
            Item tmpItem = TOMS.Menu.Instance.getItem(j);
            return Item.getName(tmpItem);
        }

        public void addItem(Table tableObj, string ItemId, string Quantity)
        {
            int itemid, quantity;
            
            Int32.TryParse(ItemId, out itemid);
            Int32.TryParse(Quantity, out quantity);

            if (tableObj.getOccupiedStatus() == false)
            {
                OrderFactory factoryObj = new OrderFactory();
                OrderAbstract newOrderObj;
                newOrderObj = factoryObj.getNewOrder();
                tableObj.OrderObj = newOrderObj;
                tableObj.OrderObj.addToOrder(itemid, quantity);
                tableObj.setOccupiedStatus();
            } else
            {
                tableObj.OrderObj.addToOrder(itemid, quantity);
            }
        }

        public void checkOut(object sender)
        {

        }
    }
}
