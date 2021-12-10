using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_Exercise
{
    public partial class NhanVien : Form
    {
        private DataTable tbStaff = new DataTable("Staff");
        private string oldPhoneNumber;
        public NhanVien()
        {
            InitializeComponent();
        }
        private void deleteItem()
        {
            for (int i = tbStaff.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = tbStaff.Rows[i];
                dr.Delete();
            }
        }

        private void loadData()
        {
            string connectionString, sql;
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            connectionString = @"Data Source=DESKTOP-0L66HQK\SQLEXPRESS;Initial Catalog=DemoC#;User ID=sa;Password=123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM NhanVien";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                DataRow newRow = tbStaff.NewRow();
                newRow[0] = dataReader.GetValue(0);
                newRow[1] = dataReader.GetValue(2);
                newRow[2] = dataReader.GetValue(1);
                newRow[3] = dataReader.GetValue(3);
                tbStaff.Rows.Add(newRow);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void insertData(string fullName, string phoneNumber, string birthDay, string address)
        {
            string connectionString, sql = "";
            SqlConnection cnn;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connectionString = @"Data Source=DESKTOP-0L66HQK\SQLEXPRESS;Initial Catalog=DemoC#;User ID=sa;Password=123";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "INSERT INTO NhanVien (FullName, PhoneNumber, BirthDay, Address) VALUES('" + fullName + "', '" + phoneNumber + "', '" + birthDay + "', '" + address + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            deleteItem();
        }

        private void updateData(string phoneNumber)
        {
            string connectionString = @"Data Source=DESKTOP-0L66HQK\SQLEXPRESS;Initial Catalog=DemoC#;User ID=sa;Password=123";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "UPDATE NhanVien SET FullName='"+txtFullName.Text+"', PhoneNumber='"+ txtPhoneNumber.Text + "', BirthDay='"+dptDate.Value.ToShortDateString()+"', Address='"+txtAddress.Text+"' WHERE PhoneNumber='" + phoneNumber + "'";
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
            deleteItem();
        }

        private void deleteData(string phoneNumber)
        {
            string connectionString = @"Data Source=DESKTOP-0L66HQK\SQLEXPRESS;Initial Catalog=DemoC#;User ID=sa;Password=123";
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "DELETE NhanVien WHERE PhoneNumber='" + phoneNumber + "'";
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DemoC_DataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this._DemoC_DataSet.NhanVien);
            tbStaff.Columns.Add("Họ tên", System.Type.GetType("System.String"));
            tbStaff.Columns.Add("Ngày sinh", System.Type.GetType("System.String"));
            tbStaff.Columns.Add("Điện thoại", System.Type.GetType("System.String"));
            tbStaff.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            dptDate.Format = DateTimePickerFormat.Custom;
            dptDate.CustomFormat = "dd/MM/yyyy";
            loadData();
            dataGV.DataSource = tbStaff;
            dataGV.Columns[0].Width = 250;
            dataGV.Columns[1].Width = 150;
            dataGV.Columns[2].Width = 150;
            dataGV.Columns[3].Width = 400;
            finishedEdit.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtFullName.Text.Equals("") || txtAddress.Text.Equals("") || txtPhoneNumber.Text.Equals(""))
            {
                MessageBox.Show("Vui long nhap day du thong tin!!!");
                return;
            }
            insertData(txtFullName.Text, txtPhoneNumber.Text, dptDate.Value.ToShortDateString(), txtAddress.Text);
            loadData();
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedRows.Count == 0)
                MessageBox.Show("Vui long chon nhan vien can xoa");
            else
            {
                foreach (var r in dataGV.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
                {
                    string phoneNumber = r.Cells[2].Value.ToString();
                    dataGV.Rows.Remove(r);
                    deleteData(phoneNumber);
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGV.SelectedRows.Count == 0)
                MessageBox.Show("Vui long chon nhan vien can chinh sua!!!");
            else if (dataGV.SelectedRows.Count > 1)
                MessageBox.Show("Vui long chi chon 1 nhan vien");
            else
            {
                DataGridViewRow r = dataGV.SelectedRows[0];
                txtFullName.Text = r.Cells[0].Value.ToString();
                dptDate.Text = r.Cells[1].Value.ToString();
                txtPhoneNumber.Text = r.Cells[2].Value.ToString();
                txtAddress.Text = r.Cells[3].Value.ToString();
                oldPhoneNumber = txtPhoneNumber.Text;
                finishedEdit.Visible = true;
                groupBoxBtn.Visible = false;
               
            }
        }
        private void btnFinsihEdit(object sender, EventArgs e)
        {
            finishedEdit.Visible = false;
            groupBoxBtn.Visible = true;
            updateData(oldPhoneNumber);
            loadData();
            txtFullName.Text = "";
            dptDate.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

      
    }
}
