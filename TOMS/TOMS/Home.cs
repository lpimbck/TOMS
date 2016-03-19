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
        public Home()
        {
            InitializeComponent();
            /*button1.Text = "Table 1" + Environment.NewLine + "Customers: 5/8";
            button2.Text = "Table 2" + Environment.NewLine + "Customers: 5/8";
            button3.Text = "Table 3" + Environment.NewLine + "Customers: 5/8";
            button4.Text = "Table 4" + Environment.NewLine + "Customers: 5/8";
            button5.Text = "Table 5" + Environment.NewLine + "Customers: 5/8";
            button6.Text = "Table 6" + Environment.NewLine + "Customers: 5/8";
            button7.Text = "Table 7" + Environment.NewLine + "Customers: 5/8";
            button8.Text = "Table 8" + Environment.NewLine + "Customers: 5/8";
            button9.Text = "Table 9" + Environment.NewLine + "Customers: 5/8";*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableClick(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            Table tempTable = (Table)tempButton.Tag;
            TableDetails m = new TableDetails();
            m.Show();

        }

        private void manage1_click(object sender, EventArgs e)
        {
            TableDetails m = new TableDetails();
            m.Show();
        }

        private void menuReloadClick (object sender, EventArgs e)
        {
            TOMS.Menu.Instance.reloadMenu();
        }
    }
}
