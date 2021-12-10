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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }


        private void NhanVien_Load(object sender, EventArgs e)
        {
            lsvNhanVien.View = View.Details;
            lsvNhanVien.GridLines = true;
            lsvNhanVien.FullRowSelect = true;
            dptDate.Format = DateTimePickerFormat.Custom;
            dptDate.CustomFormat = "dd/MM/yyyy";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            if(txtFullName.Text.Equals("") || txtAddress.Text.Equals("") || txtPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap day du thong tin!!!");
                return;
            }
            ListViewItem lvi = lsvNhanVien.Items.Add(txtFullName.Text);
            lvi.SubItems.Add(dptDate.Value.ToShortDateString());
            lvi.SubItems.Add(txtPhoneNumber.Text);
            lvi.SubItems.Add(txtAddress.Text);
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
            else MessageBox.Show("Vui long chon nhan vien can xoa!!!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtFullName.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dptDate.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txtPhoneNumber.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
            }
            else MessageBox.Show("Vui long chon nhan vien can chinh sua!!!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lsvNhanVien_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txtFullName.Text = lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dptDate.Text =
                lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtPhoneNumber.Text =
                lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text =
                lsvNhanVien.SelectedItems[0].SubItems[3].Text;

            }
        }
    }
}
