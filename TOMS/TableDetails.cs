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
    public partial class TableDetails : Form
    {
        int dataGridCurosrY = 0;
        List<Item> itemList = new List<Item>();
        public TableDetails()
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fieldId_Leave(object sender, EventArgs e)
        {
            int j;
            String input = fieldId.Text.ToString();
            if(Int32.TryParse(input, out j)){

            }else{
                return;
            }
            if (j==0||j>4) return;
            Item tmpItem = new Item(j);
            string name = tmpItem.getName();
            fieldName.Text = name;
           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int j;
            String input = fieldId.Text.ToString();
            if (Int32.TryParse(input, out j))
            {

            }
            else
            {
                return;
            }
            if (j == 0 || j > 4) return;
            int quan;
            if (!Int32.TryParse(fieldQuan.Text, out quan)) return;
            
            Item tmpItem = new Item(j);
            itemList.Add(tmpItem);
            Console.WriteLine(dataGridCurosrY);
            if (dataGridView1.Rows[0].Cells[0].Value==null)
            {
                dataGridView1.Rows[dataGridCurosrY].Cells[0].Value = tmpItem.getName();
                dataGridView1.Rows[dataGridCurosrY].Cells[1].Value = quan;
                dataGridView1.Rows[dataGridCurosrY].Cells[2].Value = tmpItem.getPrice();
                dataGridView1.Rows[dataGridCurosrY].Cells[3].Value = tmpItem.getPrice() * quan;
            }
            else
            {
                 dataGridCurosrY = dataGridView1.Rows.Add();
                //dataGridCurosrY++;
                dataGridView1.Rows[dataGridCurosrY].Cells[0].Value = tmpItem.getName();
                dataGridView1.Rows[dataGridCurosrY].Cells[1].Value = quan;
                dataGridView1.Rows[dataGridCurosrY].Cells[2].Value = tmpItem.getPrice();
                dataGridView1.Rows[dataGridCurosrY].Cells[3].Value = tmpItem.getPrice() * quan;
            }

            Console.WriteLine(dataGridCurosrY);


 


        }
    }
}
