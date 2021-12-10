using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson6
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("People");

            dt.Columns.Add("First Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Last Name", System.Type.GetType("System.String"));
            dt.Columns.Add("Occupation", System.Type.GetType("System.String"));
            dt.Columns.Add("Salary", System.Type.GetType("System.Int32"));

            dt.Rows.Add(new Object[] { "Long", "Hoang", "Nerd", 1000 });
            dt.Rows.Add(new Object[] { "Hoang", "Long", "Cartoonist", 2000 });
            dt.Rows.Add(new Object[] { "Tieu", "Loi", "Author", 5000 });
            dt.Rows.Add(new Object[] { "Loi", "Tieu", "Author", 4000 });

            dataGridView1.DataSource = dt;
        }
    }
}
