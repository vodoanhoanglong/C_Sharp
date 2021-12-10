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
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string result = "";
            if (textBoxName.Text == "") result += "Thieu ten!!! \n\n";
            else result += textBoxName.Text + "\n\n";
            if (textBoxAddress.Text == "") result += "Thieu dia chi!!! \n\n";
            else result += textBoxAddress.Text + "\n\n";
            if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false && radioButtonLGBT.Checked == false) result += "Thieu gioi tinh!!! \n\n";
            else if (radioButtonMale.Checked == true) result += radioButtonMale.Text + "\n\n";
            else if (radioButtonFemale.Checked == true) result += radioButtonFemale.Text + "\n\n";
            else result += radioButtonLGBT.Text + "\n\n";
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false) result += "Thieu ngon ngu!!! \n\n";
            if (checkBox1.Checked == true) result += checkBox1.Text + "\n\n";
            if (checkBox2.Checked == true) result += checkBox2.Text + "\n\n";
            if (checkBox3.Checked == true) result += checkBox3.Text + "\n\n";
            if (listBox.Text == "") result += "Thieu thanh pho!!! \n\n";
            else result += listBox.Text + "\n\n";
            MessageBox.Show(result);
        }
    }
}