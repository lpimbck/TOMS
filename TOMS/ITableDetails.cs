using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOMS
{
    interface ITableDetails
    {
        string autoPopulate(string fieldText);
        void addItem(Table TableObj, string ItemId, string Quantity);
        void checkOut(object sender);
    }
}
