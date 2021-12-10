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

namespace Lesson9
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }


        public List<Student> GetTempListStudent()
        {
            List<Student> listStudent = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student temp = new Student();
                temp.StudentID = "CNTTK60" + i;
                temp.FullName = "Vo " + i;
                temp.Birthday = new DateTime(2000, 1, 1);
                temp.Address = "Dia chi " + i;
                listStudent.Add(temp);
            }
            return listStudent;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            List<Student> listStudent = GetTempListStudent();
            
            ReportDataSource rds = new ReportDataSource("DataSetStudent", listStudent);
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
