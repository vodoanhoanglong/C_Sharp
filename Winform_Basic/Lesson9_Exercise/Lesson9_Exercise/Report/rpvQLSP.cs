using Lesson9_Exercise.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson9_Exercise.Report
{
    public partial class rpvQLSP : Form
    {
        private ContextDB context = Program.context;
        public rpvQLSP()
        {
            InitializeComponent();
        }

        private void rpvQLSP_Load(object sender, EventArgs e)
        {
            var query = context.Products.ToList();
            reportViewer1.LocalReport.ReportPath = @"D:\C#\Lesson9_Exercise\Lesson9_Exercise\Report\ReportQLSP.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetProduct", query);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
