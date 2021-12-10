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
    public partial class BT2 : Form
    {
        public BT2()
        {
            InitializeComponent();
        }
        private int totalPrice = 0;
 
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control chair in panelContent.Controls)
            {
               
                if(chair.BackColor.Equals(Color.Blue))
                    chair.BackColor = Color.White;
            }
            totalPrice = 0;
            textBoxPrice.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           foreach(Control chair in panelContent.Controls)
                if (chair.BackColor.Equals(Color.Blue))
                    chair.BackColor = Color.Yellow;   
            totalPrice = 0;
            textBoxPrice.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void handleColor(Control chair)
        {
            int chairNumber;
            if (chair.BackColor.Equals(Color.White))
            {
                chairNumber = Convert.ToInt32(chair.Text);
                chair.BackColor = Color.Blue;
                if (chairNumber <= 5)
                {
                    totalPrice += 5000;
                    textBoxPrice.Text = totalPrice.ToString();
                }    
                else if (chairNumber <= 10)
                {
                    totalPrice += 8000;
                    textBoxPrice.Text = totalPrice.ToString();
                }
                else
                {
                    totalPrice += 6500;
                    textBoxPrice.Text = totalPrice.ToString();
                }
            }   
            else if (chair.BackColor.Equals(Color.Blue))
            
                {
                chair.BackColor = Color.White;
                chairNumber = Convert.ToInt32(chair.Text);
                if (chairNumber <= 5)
                {
                    totalPrice -= 5000;
                    textBoxPrice.Text = totalPrice.ToString();
                }
                else if (chairNumber <= 10)
                {
                    totalPrice -= 8000;
                    textBoxPrice.Text = totalPrice.ToString();
                }
                else
                {
                    totalPrice -= 6500;
                    textBoxPrice.Text = totalPrice.ToString();
                }
            }
            else MessageBox.Show("Chỗ ngồi đã bán!!!");
        }

        private void chair_Click(object sender, EventArgs e)
        {
            Control chair = (Control)sender; 
            handleColor(chair);
        }
    }
}
