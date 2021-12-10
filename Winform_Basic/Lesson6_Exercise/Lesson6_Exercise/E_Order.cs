using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6_Exercise
{
    public partial class E_Order : Form
    {
       private DataTable tbOrder = new DataTable("Order");
        public E_Order()
        {
            InitializeComponent();
        }
        private void BT1_Load(object sender, EventArgs e)
        {
            tbOrder.Columns.Add("Food Name", System.Type.GetType("System.String"));
            tbOrder.Columns.Add("Quantity", System.Type.GetType("System.Int32"));
            tbOrder.PrimaryKey = new DataColumn[] { tbOrder.Columns["Food Name"] };
            dataGView.DataSource = tbOrder;
        }
        private void btn_food(object sender, EventArgs e)
        {
            Button btnFood = (Button)sender;
            DataRow foundRow = tbOrder.Rows.Find(btnFood.Text);
            if (foundRow != null)
            {
                int quantity = (int)foundRow[1];
                foundRow[1] = quantity + 1;
            }else
            {
                foundRow = tbOrder.NewRow();
                foundRow["Food Name"] = btnFood.Text;
                foundRow["Quantity"] = 1;
                tbOrder.Rows.Add(foundRow);
            }
        }
        private void deleteItems()
        {
            for (int i = tbOrder.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = tbOrder.Rows[i];
                dr.Delete();
            }
        }
        private void btn_Delete(object sender, EventArgs e)
        {
            if (dataGView.SelectedRows.Count == 0)
                MessageBox.Show("Vui long chon mon an can xoa");
            else{
                foreach (var r in dataGView.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
                    dataGView.Rows.Remove(r);
            }
        }
        private void btn_Order(object sender, EventArgs e)
        {
            if (cbTableName.Text == "" && tbOrder.Rows.Count == 0)
                MessageBox.Show("Vui long chon ban va mon an");
            else if (cbTableName.Text == "")
                MessageBox.Show("Vui Long chon Ban");
            else if (tbOrder.Rows.Count == 0)
                MessageBox.Show("Vui long chon mon an");
            else
            {
                MessageBox.Show("Dat mon thanh cong cho " + cbTableName.Text);
                cbTableName.Text = "";
                deleteItems();
            }
        }
    }
}
