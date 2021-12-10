using Lesson8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class StudentForm : Form
    {
        private StudentContextDB context = new StudentContextDB();
        public StudentForm()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            var result = from c in context.Students select new { StudentID = c.StudentID  ,FullName = c.FullName, AverageSorce = c.AverageScore, FacultyName = c.Faculty.FacultyName, FacultyID = c.FacultyID};
            dgvStudent.DataSource = result.ToList();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            loadData();
            List<Faculty> listFal = context.Faculties.ToList();
            cmbFal.DataSource = listFal;
            cmbFal.ValueMember = "FacultyID";
            cmbFal.DisplayMember = "FacultyName";
            btnUpdate.Visible = false;
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                btnUpdate.Visible = true;
                txtID.ReadOnly = true;
                DataGridViewRow dgvRow = dgvStudent.Rows[e.RowIndex];
                txtID.Text = dgvRow.Cells[0].Value.ToString();
                txtFullName.Text = dgvRow.Cells[1].Value.ToString();
                txtAverageScore.Text = dgvRow.Cells[2].Value.ToString();
                cmbFal.SelectedValue = dgvRow.Cells[4].Value;
            }
        }

        private void resetInput()
        {
            txtID.Text = "";
            txtFullName.Text = "";
            txtAverageScore.Text = "";
        }

        private Boolean checkID(string id)
        {

            foreach (DataGridViewRow row in dgvStudent.Rows)
                if (row.Cells[0].Value.ToString().Equals(id))
                    return true; 
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtFullName.Text == "" && txtAverageScore.Text == "")
                MessageBox.Show("Vui long nhap day du thong tin!!!");
            else if(checkID(txtID.Text)) MessageBox.Show("MSSV da trung");
            else
            {
                Student newStu = new Student();
                newStu.StudentID = Convert.ToInt32(txtID.Text);
                newStu.FullName = txtFullName.Text;
                newStu.AverageScore = Convert.ToDouble(txtAverageScore.Text);
                newStu.FacultyID = Convert.ToInt32(cmbFal.SelectedValue);
                context.Students.Add(newStu);
                context.SaveChanges();
                resetInput();
                loadData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(dgvStudent.SelectedCells[0].OwningRow.Cells["StudentID"].Value.ToString());
            Student updateStu = context.Students.Find(studentID);
            updateStu.FullName = txtFullName.Text;
            updateStu.AverageScore = Convert.ToDouble(txtAverageScore.Text);
            updateStu.FacultyID = Convert.ToInt32(cmbFal.SelectedValue);
            btnUpdate.Visible = false;
            txtID.ReadOnly = false;
            context.SaveChanges();
            resetInput();
            loadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (var r in dgvStudent.SelectedRows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow))
            {
                int studentID = Convert.ToInt32(r.Cells[0].Value.ToString());
                Student delStu = context.Students.Where(st => st.StudentID == studentID).SingleOrDefault();
                context.Students.Remove(delStu);
                context.SaveChanges();
            }
            resetInput();
            loadData();
        }
    }
}
