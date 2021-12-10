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
    public partial class rpvQLDH : Form
    {
        private string invoiceID;
        private ContextDB context = Program.context;
        public rpvQLDH(string invoiceID)
        {
            this.invoiceID = invoiceID;
            InitializeComponent();
        }

        private void rpvQLDH_Load(object sender, EventArgs e)
        {
            var query = context.Orders.Where(x => x.InvoiceID == invoiceID)
                .AsEnumerable()
                .Select(x => new DataSetOrder
                (
                    x.InvoiceID,
                    x.Product.ProductName,
                    x.Product.Unit,
                    x.Quantity,
                    x.Price
                )).ToList();
            reportViewer1.LocalReport.ReportPath = @"D:\C#\Lesson9_Exercise\Lesson9_Exercise\Report\ReportQLDH.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetOrder", query);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
