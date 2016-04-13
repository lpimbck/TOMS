using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOMS
{
    public partial class TableDetails : Form
    {
        int dataGridCurosrY = 0;
        List<Item> itemList = new List<Item>();
        ITableDetails ControllerObj;
        BindingSource bindingSource1 = new BindingSource();
        Table TableObj { get; }
        public TableDetails(Table showTable)
        {
            InitializeComponent();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            ControllerObj = TableDetailsController.getInstance();
            TableObj = showTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity,null);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        private DataTable getOrderData ()
        {
            if (TableObj.OrderObj == null)
            {
                return new DataTable();
            }
            return CreateDataTable<ListLineItem>(TableObj.OrderObj.ItemList);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind the DataGridView to the BindingSource
            // and load the data from the database.
            dataGridView1.DataSource = bindingSource1;
            getOrderData();
        }
        private void fieldId_Leave(object sender, EventArgs e)
        {
            fieldName.Text = ControllerObj.autoPopulate(fieldId.Text.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int j;
            ControllerObj.addItem(TableObj, fieldId.Text, fieldQuan.Text);
            String input = fieldId.Text.ToString();
            if (Int32.TryParse(input, out j))
            {

            }
            else
            {
                return;
            }
            int quan;
            if (!Int32.TryParse(fieldQuan.Text, out quan)) return;

            Item tmpItem = TOMS.Menu.Instance.getItem(j);
            itemList.Add(tmpItem);
            Console.WriteLine(dataGridCurosrY);
            if (dataGridView1.Rows[0].Cells[0].Value != null) {
                dataGridCurosrY = dataGridView1.Rows.Add();
            }
            dataGridView1.Rows[dataGridCurosrY].Cells[0].Value = tmpItem.getName();
            dataGridView1.Rows[dataGridCurosrY].Cells[1].Value = quan;
            dataGridView1.Rows[dataGridCurosrY].Cells[2].Value = tmpItem.getPrice();
            dataGridView1.Rows[dataGridCurosrY].Cells[3].Value = tmpItem.getPrice() * quan;
            Console.WriteLine(dataGridCurosrY);
        }

        private void checkOutClick(object sender, EventArgs e)
        {
            Double preTaxTotal = 0;
            Double Total = 0;
            Double Tax = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                preTaxTotal += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }

            Double taxRate = 1.4;// currently hardcoded

            Tax = (taxRate * preTaxTotal) / 100;
            Total = preTaxTotal + Tax;

            //write the calculated tax to console

            dataGridCurosrY = dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridCurosrY].Cells[0].Value = "Pre Tax Total";
            dataGridView1.Rows[dataGridCurosrY].Cells[1].Value = "-";
            dataGridView1.Rows[dataGridCurosrY].Cells[2].Value = "-";
            dataGridView1.Rows[dataGridCurosrY].Cells[3].Value = preTaxTotal;
            Console.WriteLine(dataGridCurosrY);

            dataGridCurosrY = dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridCurosrY].Cells[0].Value = "Tax Calculated";
            dataGridView1.Rows[dataGridCurosrY].Cells[1].Value = "-";
            dataGridView1.Rows[dataGridCurosrY].Cells[2].Value = "-";
            dataGridView1.Rows[dataGridCurosrY].Cells[3].Value = Tax;
            Console.WriteLine(dataGridCurosrY);

            dataGridCurosrY = dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridCurosrY].Cells[0].Value = "Total";
            dataGridView1.Rows[dataGridCurosrY].Cells[1].Value = "-";
            dataGridView1.Rows[dataGridCurosrY].Cells[2].Value = "-";
            dataGridView1.Rows[dataGridCurosrY].Cells[3].Value = Total;
            Console.WriteLine(dataGridCurosrY);
        }

        
    }


}
