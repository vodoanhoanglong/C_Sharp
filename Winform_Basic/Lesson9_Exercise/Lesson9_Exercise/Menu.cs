using Lesson9_Exercise.Report;
using Microsoft.Reporting.WinForms;
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

namespace Lesson9_Exercise
{
    public partial class ContainMenu : Form
    {
        public static ContainMenu instance;
        public Panel content;
        public ContainMenu()
        {
            InitializeComponent();
            instance = this;
            content = pnlMenu;
        }
        private XemDonHang xdh = new XemDonHang();
        private QLDonHang qldh = new QLDonHang();
        private QLSanPham qlsp = new QLSanPham();

       

        private void Menu_Load(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            xdh.FormBorderStyle = FormBorderStyle.None;
            xdh.TopLevel = false;
            pnlMenu.Controls.Add(xdh);
            xdh.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            xdh.FormBorderStyle = FormBorderStyle.None;
            xdh.TopLevel = false;
            pnlMenu.Controls.Add(xdh);
            xdh.Show();
        }

        public void nhậpĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            qldh.FormBorderStyle = FormBorderStyle.None;
            qldh.TopLevel = false;
            pnlMenu.Controls.Add(qldh);
            qldh.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void quảnLýSảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            qlsp.FormBorderStyle = FormBorderStyle.None;
            qlsp.TopLevel = false;
            pnlMenu.Controls.Add(qlsp);
            qlsp.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            xdh.FormBorderStyle = FormBorderStyle.None;
            xdh.TopLevel = false;
            pnlMenu.Controls.Add(xdh);
            xdh.Show();
            XemDonHang.instance.loadData();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            pnlMenu.Controls.Clear();
            qldh.FormBorderStyle = FormBorderStyle.None;
            qldh.TopLevel = false;
            pnlMenu.Controls.Add(qldh);
            qldh.Show();
        }

        private void xuấtBáoGiáSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpvQLSP rpv = new rpvQLSP();
            rpv.Show();
        }
    }
}
