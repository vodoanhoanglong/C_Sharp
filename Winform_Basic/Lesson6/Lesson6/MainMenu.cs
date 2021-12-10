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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void item1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da chon item1");
        }

        private void item2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban da chon item2");
        }

        private void form_Progress(object sender, EventArgs e)
        {
            ProgressBar progress_mdi_child = new ProgressBar();
            progress_mdi_child.Text = "Cua so con Progressbar";
            progress_mdi_child.MdiParent = this;
            progress_mdi_child.Show();
        }

        private void form_FontDiaLog(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void form_Picture(object sender, EventArgs e)
        {
            PictureBox mdi_child = new PictureBox();
            mdi_child.Text = "Cua so con PictureBox";
            mdi_child.MdiParent = this;
           mdi_child.Show();
        }

        private void form_DateTime(object sender, EventArgs e)
        {
            DateTime mdi_child = new DateTime();
            mdi_child.Text = "Cua so con DateTime";
            mdi_child.MdiParent = this;
            mdi_child.Show();
        }

        private void form_DataGrid(object sender, EventArgs e)
        {
            DataGrid mdi_child = new DataGrid();
            mdi_child.Text = "Cua so con DataGrid";
            mdi_child.MdiParent = this;
            mdi_child.Show();
        }

        private void form_ListView(object sender, EventArgs e)
        {
            ListView mdi_child = new ListView();
            mdi_child.Text = "Cua so con ListView";
            mdi_child.MdiParent = this;
            mdi_child.Show();
        }
    }
}
