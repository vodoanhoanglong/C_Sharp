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
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void btn_ListView(object sender, EventArgs e)
        {
            string productName = null;
            string price = null;
            string quantity = null;
            if (listView1.SelectedItems.Count > 0)
            {
                productName = listView1.SelectedItems[0].SubItems[0].Text;
                price = listView1.SelectedItems[0].SubItems[1].Text;
                quantity = listView1.SelectedItems[0].SubItems[2].Text;

                MessageBox.Show(productName + " ," + price + " ," + quantity);
            }
            else MessageBox.Show("Hay chon 1 san pham");
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Ten san pham", 100);
            listView1.Columns.Add("Gia", 70);
            listView1.Columns.Add("So luong", 70);

            string[] arr = new string[4];
            ListViewItem item;

            arr[0] = "Kem danh rang";
            arr[1] = "100";
            arr[2] = "10";
            item = new ListViewItem(arr);
            listView1.Items.Add(item);

            arr[0] = "Ban chai danh rang";
            arr[1] = "200";
            arr[2] = "20";
            item = new ListViewItem(arr);
            listView1.Items.Add(item);
        }
    }
}
