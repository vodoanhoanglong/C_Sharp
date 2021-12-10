using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson5
{
    public partial class HelloWorld : Form
    {

     
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblText2.Text = "This is my first lable";
            lblText2.BorderStyle = BorderStyle.FixedSingle;
            lblText2.TextAlign = ContentAlignment.MiddleCenter;

            lblText.AutoSize = true;
            lblText.Text = "Do you want to submit this project?";
            lblText.Font = new Font("French Srcipt MT", 18);

            btnSubmit.Text = "Submit";
            btnSubmit.AutoSize = true;
            btnSubmit.BackColor = Color.LightBlue;
            btnSubmit.Padding = new Padding(6);
            btnSubmit.Font = new Font("French Srcipt MT", 18);

            btnCancel.Text = "Cancel";
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.LightPink;
            btnCancel.Padding = new Padding(6);
            btnCancel.Font = new Font("French Srcipt MT", 18);

            txtInput.Width = 250;
            txtInput.Height = 50;
            txtInput.Multiline = true;
            txtInput.BackColor = Color.Blue;
            txtInput.ForeColor = Color.White;
            txtInput.BorderStyle = BorderStyle.Fixed3D;

            radioButton1.Checked = true;

            comboBox.Items.Add("Monday");
            comboBox.Items.Add("Tuesday");
            comboBox.Items.Add("Wednesday");
            comboBox.Items.Add("Thursday");
            comboBox.Items.Add("Friday");
            comboBox.Items.Add("Saturday");
            comboBox.Items.Add("Sunday");
            comboBox.SelectedIndex = 0;

           

            listBox.Items.Add("Monday");
            listBox.Items.Add("Tuesday");
            listBox.Items.Add("Wednesday");
            listBox.Items.Add("Thursday");
            listBox.Items.Add("Friday");
            listBox.Items.Add("Saturday");
            listBox.Items.Add("Sunday");
            listBox.SelectionMode = SelectionMode.MultiSimple;


            numericUpDown.Value = 5;
            textBoxNUD.Text = "5";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            handleLBL.Text = "Ban da click vao nut submit";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            handleLBL.Text = "Ban da click vao nut cancel";
        }

        private void btnSubmitTextBox_Click(object sender, EventArgs e)
        {
            string var;
            var = txtInput.Text;
            MessageBox.Show(var);
        }

        private void btnSubmitCheckBox_Click(object sender, EventArgs e)
        {
            string result = "";

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
                result += "Khong mon nao duoc chon!!! \n\n";
            if (checkBox1.Checked == true)
                result +=" Nhap mon lap trinh \n\n";
            if (checkBox2.Checked == true)
                result +="Lap trinh huong doi tuong \n\n";
            if (checkBox3.Checked == true)
                result += "Lap trinh truc quan \n\n";
            MessageBox.Show(result);
            
            checkBox1.ThreeState = true;
        }

        private void btnSubmitRadio_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                MessageBox.Show("Mau do");
                return;
            }
            else if(radioButton2.Checked == true)
            {
                MessageBox.Show("Mau xanh duong");
                return;
            }
            else
            {
                MessageBox.Show("Mau xanh la");
                return;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show(comboBox.Text);
        }

        private void selectListBox_Click(object sender, EventArgs e)
        {
            string result = "";
            foreach (var item in listBox.SelectedItems)
                result += item.ToString() + "\n\n";

            MessageBox.Show(result);
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBoxNUD.Text = numericUpDown.Value.ToString();
        }
    }
}
