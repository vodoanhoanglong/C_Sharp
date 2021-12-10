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

namespace Lesson7
{
    public partial class Form1 : Form
    {
        private string connect  = @"Data Source=DESKTOP-0L66HQK\SQLEXPRESS;Initial Catalog=DemoC#;User ID=sa;Password=123";
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        SqlDataAdapter adapter;
        String sql, output = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connect);
            cnn.Open();
            sql = "SELECT ID, Name FROM LearnC#";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
                output = output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            MessageBox.Show(output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();
            cnn.Close();

        }

        private void btnUpdate(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connect);
            cnn.Open();
            adapter = new SqlDataAdapter(); 
            sql = "UPDATE LearnC# SET Name='"+"VB.NET Udt"+"' WHERE ID=3";
            command = new SqlCommand(sql, cnn);
            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void btnDelete(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connect);
            cnn.Open();
            adapter = new SqlDataAdapter();
            sql = "DELETE LearnC# WHERE ID=3";
            command = new SqlCommand(sql, cnn);
            adapter.DeleteCommand = new SqlCommand(sql, cnn);
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DemoC_DataSet._LearnC_' table. You can move, or remove it, as needed.
            this.learnC_TableAdapter.Fill(this._DemoC_DataSet._LearnC_);

        }

        private void btnInsert(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connect);
            cnn.Open();
            adapter = new SqlDataAdapter();
            sql = "INSERT INTO LearnC# (ID, Name) VALUES(3, '" + "VB.NET" + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
          
        }
    }
}
