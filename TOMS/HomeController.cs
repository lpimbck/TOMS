using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AutoMapper;

namespace TOMS
{
    class HomeController : IHome
    {
        private static HomeController HomeControllerObj;
        private HomeController()
        {

        }

        public static HomeController getInstance ()
        {
            if (HomeControllerObj == null)
            {
                HomeControllerObj = new HomeController();
            }
            return HomeControllerObj;
        }

        public void MenuReload()
        {
            Menu menuObj = Menu.Instance;
            menuObj.reloadMenu();
        }

        public void AddUsers()
        {

        }

        public void ManageTable (object sender)
        {
            Button tempButton = (Button)sender;
            Table tempTable = (Table)tempButton.Tag;
            TableDetails showTable = new TableDetails(tempTable);
            showTable.Show();
        }   
    }
}
