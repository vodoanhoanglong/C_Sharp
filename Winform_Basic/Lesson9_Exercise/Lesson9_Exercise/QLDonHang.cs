using Lesson9_Exercise.Models;
using Lesson9_Exercise.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9_Exercise
{
    public partial class QLDonHang : Form
    {
        private ContextDB context = Program.context;
        private DataGridViewComboBoxColumn cmbdgv = new DataGridViewComboBoxColumn();
        private ComboBox cbm;
        private DataGridViewCell currentCell;
        private int sum = 0;
        public static QLDonHang instance;
        public DataGridView dgv;
        private string invoiceID;
        public QLDonHang()
        {
            InitializeComponent();
            instance = this;
            dgv = dgvOrderInfo;
        }

        private void loadData()
        {
            List<Product> product = context.Products.ToList();
            dgvOrderInfo.Columns.Add("ProductID", "Mã sản phẩm");
            cmbdgv.HeaderText = "Tên sản phẩm";
            cmbdgv.Width = 270;
            cmbdgv.DataSource = product;
            cmbdgv.ValueMember = "ProductID";
            cmbdgv.DisplayMember = "ProductName";
            dgvOrderInfo.Columns.Add(cmbdgv);
            dgvOrderInfo.Columns.Add("Unit", "ĐVT");
            dgvOrderInfo.Columns.Add("Quantity", "Số lượng");
            dgvOrderInfo.Columns.Add("Price", "Giá bán");
            dgvOrderInfo.Columns.Add("TotalPrice", "Thành tiền");
            dgvOrderInfo.Columns[0].ReadOnly = true;
            dgvOrderInfo.Columns[2].ReadOnly = true;
            dgvOrderInfo.Columns[4].ReadOnly = true;
            dgvOrderInfo.Columns[5].ReadOnly = true;
        }

        private void QLDonHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvOrderInfo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                cbm = (ComboBox)e.Control;

                if (cbm != null)
                    cbm.SelectedIndexChanged += new EventHandler(cbm_SelectedIndexChanged);
                currentCell = this.dgvOrderInfo.CurrentCell;
            }
        }

        private void cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(EndEdit));
        }

        private void EndEdit()
        {
              
            if (cbm != null)
            {
                /*string SelectedItem = cbm.SelectedItem.ToString();*/
                int index = dgvOrderInfo.CurrentRow.Index;
                var result = from p in context.Products where cbm.Text == p.ProductName select new { p.ProductID, p.Unit, p.SellPrice };
                dgvOrderInfo.Rows[index].Cells["ProductID"].Value = result.ToList()[0].ProductID;
                dgvOrderInfo.Rows[index].Cells["Unit"].Value = result.ToList()[0].Unit;
                dgvOrderInfo.Rows[index].Cells["Price"].Value = result.ToList()[0].SellPrice;
                if (dgvOrderInfo.Rows[index].Cells["Quantity"].Value != null)
                    dgvOrderInfo.Rows[index].Cells["TotalPrice"].Value = Convert.ToInt32(dgvOrderInfo.Rows[index].Cells["Quantity"].Value.ToString()) * Convert.ToInt32(dgvOrderInfo.Rows[index].Cells["Price"].Value.ToString());
            }
        }


        private void dgvOrderInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgvOrderInfo.Rows[index].Cells["Quantity"].Value != null && dgvOrderInfo.Rows[index].Cells["Price"].Value != null)
            {
                int quantityID = Convert.ToInt32(dgvOrderInfo.Rows[index].Cells["ProductID"].Value);
                int quantity = Convert.ToInt32(dgvOrderInfo.Rows[index].Cells["Quantity"].Value);

                for (int i = 0; i < dgvOrderInfo.Rows.Count - 2; i++)
                {
                    int count = 0;
                    if (quantityID == Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["ProductID"].Value))
                        count++;
                    if (count != 0)
                    {                          
                        quantity += Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["Quantity"].Value);
                        dgvOrderInfo.Rows.Remove(dgvOrderInfo.Rows[i]);                      
                    }               
                }
                int currIndex = dgvOrderInfo.Rows.Count - 2;
                dgvOrderInfo.Rows[currIndex].Cells["Quantity"].Value = quantity;
                dgvOrderInfo.Rows[currIndex].Cells["TotalPrice"].Value = quantity * Convert.ToInt32(dgvOrderInfo.Rows[currIndex].Cells["Price"].Value.ToString());

            }
                
        }

        private void resetInput()
        {
            txtNote.Text = "";
            txtTotalPrice.Text = "0";
        }

        private void saveData()
        {
            if (txtNote.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            else
            {
                invoiceID = DateTime.Now.ToString("yyyyMMddHHmmss");
                for (int i = 0; i < dgvOrderInfo.Rows.Count - 1; i++)
                    sum += Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["TotalPrice"].Value.ToString());
                txtTotalPrice.Text = sum.ToString();
                MessageBox.Show("Đặt hàng thành công \n Tổng tiền: " + sum);
                Invoice newIn = new Invoice();
                newIn.InvoiceID = invoiceID;
                newIn.OrderDate = orderDate.Value.Date;
                newIn.DeliveryDate = deliveryDate.Value.Date;
                newIn.Note = txtNote.Text;
                context.Invoices.Add(newIn);
                context.SaveChanges();

                
                for (int i = 0; i < dgvOrderInfo.Rows.Count - 1; i++)
                {
                    Order newOr = new Order();
                    newOr.InvoiceID = invoiceID;
                    newOr.ProductID = dgvOrderInfo.Rows[i].Cells["ProductID"].Value.ToString();
                    newOr.Price = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["Price"].Value.ToString());
                    newOr.Quantity = Convert.ToInt32(dgvOrderInfo.Rows[i].Cells["Quantity"].Value.ToString());
                    context.Orders.Add(newOr);
                    context.SaveChanges();
                }
                resetInput();
                dgvOrderInfo.Rows.Clear();
            }
        }

        private bool checkDgv()
        {
            for (int i = 0; i < dgvOrderInfo.Rows.Count - 1; i++)
            {
                if (dgvOrderInfo.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm");
                    return false;
                }
                if (dgvOrderInfo.Rows[i].Cells[3].Value == null)
                {
                    MessageBox.Show("Vui lòng nhập số lượng");
                    return false;
                }
            }
            return true;
        }
        private void order_Click(object sender, EventArgs e)
        {
            if (dgvOrderInfo.Rows.Count == 1 && (dgvOrderInfo.Rows[0].Cells[1].Value == null || dgvOrderInfo.Rows[0].Cells[3].Value == null))
            {
                MessageBox.Show("Vui lòng thêm sản phẩm");
                return;
            }
            if(checkDgv())
                saveData();
        }

        private void printOrder_Click(object sender, EventArgs e)
        {
            saveData();
            rpvQLDH rpv = new rpvQLDH(invoiceID);
            rpv.Show();
        }
    }
}

