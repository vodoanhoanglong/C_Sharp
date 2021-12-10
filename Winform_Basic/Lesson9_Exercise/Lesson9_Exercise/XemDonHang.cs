using Lesson9_Exercise.Models;
using Lesson9_Exercise.Report;
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
    public partial class XemDonHang : Form
    {
        ContextDB context = new ContextDB();
        public static XemDonHang instance;
        public DataGridView dgv;
        public XemDonHang()
        {
            InitializeComponent();
            instance = this;
            dgv = dgvOrderView;
        }

        public void loadData(int condition = 0)
        {
            
            int sum = 0;
            if(condition == 0)
            {
                var result = from o in context.Orders
                             select new { o.InvoiceID, o.Invoice.OrderDate, o.Invoice.DeliveryDate, totalPrice = o.Price * o.Quantity };
                dgvOrderView.DataSource = result.GroupBy(x => new
                {
                    x.InvoiceID,
                    x.OrderDate,
                    x.DeliveryDate
                })
                    .Select(x => new
                    {
                        x.Key.InvoiceID,
                        x.Key.OrderDate,
                        x.Key.DeliveryDate,
                        totalPrice = x.Sum(o => o.totalPrice)
                    } 
                    )
                    .ToList();
            }
            else if(condition==1)
            {
                string sMonth = DateTime.Now.ToString("MM");
                int month = Convert.ToInt32(sMonth);
                var result = from o in context.Orders
                             where o.Invoice.OrderDate.Month == month && o.Invoice.DeliveryDate.Month == month
                             select new {  o.InvoiceID, o.Invoice.OrderDate, o.Invoice.DeliveryDate, totalPrice = o.Price * o.Quantity };
                dgvOrderView.DataSource = result.GroupBy(x => new
                {
                    x.InvoiceID,
                    x.OrderDate,
                    x.DeliveryDate
                })
                    .Select(x => new
                    {
                        x.Key.InvoiceID,
                        x.Key.OrderDate,
                        x.Key.DeliveryDate,
                        totalPrice = x.Sum(o => o.totalPrice)
                    }
                    )
                    .ToList();
            }
            else
            {
                var result = from o in context.Orders
                             where o.Invoice.OrderDate == orderDate.Value.Date && o.Invoice.DeliveryDate == deliveryDate.Value.Date
                             select new {  o.InvoiceID, o.Invoice.OrderDate, o.Invoice.DeliveryDate, totalPrice = o.Price * o.Quantity };
                dgvOrderView.DataSource = result.GroupBy(x => new
                {
                    x.InvoiceID,
                    x.OrderDate,
                    x.DeliveryDate
                })
                    .Select(x => new
                    {
                        x.Key.InvoiceID,
                        x.Key.OrderDate,
                        x.Key.DeliveryDate,
                        totalPrice = x.Sum(o => o.totalPrice)
                    }
                    )
                    .ToList();
            }
            dgvOrderView.Columns[0].HeaderText = "Số Hóa Đơn";
            dgvOrderView.Columns[1].HeaderText = "Ngày Đặt Hàng";
            dgvOrderView.Columns[2].HeaderText = "Ngày Giao Hàng";
            dgvOrderView.Columns[3].HeaderText = "Thành Tiền";
            dgvOrderView.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrderView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            deliveryDate.Format = DateTimePickerFormat.Custom;
            orderDate.Format = DateTimePickerFormat.Custom;
            deliveryDate.CustomFormat = "dd/MM/yyyy";
            orderDate.CustomFormat = "dd/MM/yyyy";
            foreach (DataGridViewRow row in dgvOrderView.Rows)
                sum += Convert.ToInt32(row.Cells[3].Value.ToString());
            totalPrice.Text = sum.ToString();
        }

        private void XemDonHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDate.Checked)
                loadData(1);
            else loadData();
        }

        private void orderDate_ValueChanged(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void deliveryDate_ValueChanged(object sender, EventArgs e)
        {
            loadData(2);
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            Panel pnlMenu = ContainMenu.instance.content;
            QLDonHang qldh = new QLDonHang();
            pnlMenu.Controls.Clear();
            qldh.FormBorderStyle = FormBorderStyle.None;
            qldh.TopLevel = false;
            pnlMenu.Controls.Add(qldh);
            qldh.Show();
        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            int index = dgvOrderView.CurrentRow.Index;
            string invoiceID = dgvOrderView.Rows[index].Cells[0].Value.ToString();
            rpvQLDH rpv = new rpvQLDH(invoiceID);
            rpv.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbDate.Checked = false;
            loadData();
        }
    }
}
