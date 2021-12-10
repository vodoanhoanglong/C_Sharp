using Lesson9_Exercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9_Exercise
{
    public partial class QLSanPham : Form
    {
        ContextDB context = new ContextDB();
        public QLSanPham()
        {
            InitializeComponent();
        }

        private void reset()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtUnit.Text = "";
            txtBuyPrice.Text = "";
            txtSellPrice.Text = "";
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var result = context.Products;
            dgvProduct.DataSource = result.ToList();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvProduct.Rows[e.RowIndex];
                txtID.Text = dgvRow.Cells[0].Value.ToString();
                txtName.Text = dgvRow.Cells[1].Value.ToString();
                txtUnit.Text = dgvRow.Cells[2].Value.ToString();
                txtBuyPrice.Text = dgvRow.Cells[3].Value.ToString();
                txtSellPrice.Text = dgvRow.Cells[4].Value.ToString();
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = dgvProduct.SelectedCells[0].OwningRow.Cells["productID"].Value.ToString();
            Product updateStu = context.Products.Find(id);
            updateStu.ProductName = txtName.Text;
            updateStu.Unit = txtUnit.Text;
            updateStu.BuyPrice = Convert.ToInt32(txtBuyPrice.Text);
            updateStu.SellPrice = Convert.ToInt32(txtSellPrice.Text);
            context.SaveChanges();
            loadData();
            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvProduct.SelectedRows.Count==0)
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa");
            }    
            foreach (var r in dgvProduct.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
            {
                string id = r.Cells[0].Value.ToString();
                Product delStu = context.Products.Where(st => st.ProductID == id).SingleOrDefault();
                context.Products.Remove(delStu);
                context.SaveChanges();
            }
            reset();
            loadData();
        }
    }
}
