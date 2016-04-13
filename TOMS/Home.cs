using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOMS
{
    public partial class Home : Form
    {
        IHome homeController;
        public Home()
        {
            InitializeComponent();
            homeController = HomeController.getInstance();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableClick(object sender, EventArgs e)
        {
            homeController.ManageTable(sender);
        }

        private void manage1_click(object sender, EventArgs e)
        {
            homeController.ManageTable(sender);
        }

        private void menuReloadClick (object sender, EventArgs e)
        {
            homeController.MenuReload();
        }

        private void AddUsers(object sender, EventArgs e)
        {
            homeController.AddUsers();
        }
    }
}
