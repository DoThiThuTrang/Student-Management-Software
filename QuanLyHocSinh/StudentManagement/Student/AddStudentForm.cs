using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentManagement.Student;

namespace StudentManagement.Student
{
    public partial class AddStudentForm : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Retangle;
        public AddStudentForm()
        {
            InitializeComponent();
            AddMultiRow.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd-MM-yyyy";
            dtp.TextChanged += new EventHandler(dtp_TextChange);
        }
        private void dtp_TextChange(Object sender, EventArgs e)
        {
            AddMultiRow.CurrentCell.Value = dtp.Text.ToString();
        }
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            AddMultiRow.AllowUserToAddRows = false;
            AddMultiRow.Rows.Add();
        }

        private void AddMultiRow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddMultiRow.Rows.Add();
                AddMultiRow.CurrentCell = AddMultiRow.Rows[AddMultiRow.Rows.Count - 1].Cells[0];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentDetail detailModel = new StudentDetail();
            DateTime timenow = DateTime.Now;
            Boolean ValidAge = false;
            Boolean ValidName = false;
            List<StudentDetail> objectDetailList = new List<StudentDetail>();
            foreach (DataGridViewRow dgvRow in AddMultiRow.Rows)
            {
                var detail = new StudentDetail()
                {
                    HO = Convert.ToString(dgvRow.Cells[0].Value),
                    TEN = Convert.ToString(dgvRow.Cells[1].Value),
                    NGSINH = Convert.ToDateTime(dgvRow.Cells[2].Value),
                    GIOITINH = Convert.ToString(dgvRow.Cells[3].Value),
                    DIACHI = Convert.ToString(dgvRow.Cells[4].Value),
                    EMAIL = Convert.ToString(dgvRow.Cells[5].Value),
                };
                if (detail.HO == "" || detail.TEN == "")
                {
                    ValidName = true;
                }
                else if (((timenow.Year - detail.NGSINH.Year) < detailModel.MinAge()) || (timenow.Year - detail.NGSINH.Year) > detailModel.MaxAge())
                {
                    ValidAge = true;
                }
                else
                {
                    objectDetailList.Add(detail);
                }
            }
            if (ValidName == true)
            {
                MessageBox.Show("Vui lòng nhập vào trường họ tên");
            }
            else if (ValidAge == false)
            {
                detailModel = new StudentDetail();
                detailModel.add_MultipleStatementsSingleInsert(objectDetailList);
                MessageBox.Show("Thêm học sinh thành công");
            }
            else
            {
                MessageBox.Show("Độ tuổi không hợp lệ");
            }

        }

        private void AddMultiRow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddMultiRow_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void AddMultiRow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (AddMultiRow.Columns[e.ColumnIndex].Name)
            {
                case "NGSINH":
                    _Retangle = AddMultiRow.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Retangle.Width, _Retangle.Height);
                    dtp.Location = new Point(_Retangle.X, _Retangle.Y);
                    dtp.Visible = true;
                    break;
                
            }
        }

        private void AddMultiRow_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            switch (AddMultiRow.Columns[e.ColumnIndex].Name)
            {
                case "NGSINH":
                    dtp.Visible = false;
                    break;
            }
        }

        protected void AddMultiRow_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            StudentDetail detailModel = new StudentDetail();
            String x;
            DateTime timenow = DateTime.Now;
            switch (AddMultiRow.Columns[e.ColumnIndex].Name)
            {
                case "NGSINH":
                    x = "a";
                    if (AddMultiRow.CurrentCell.Value != null)
                    {
                        x = AddMultiRow.CurrentCell.Value.ToString();
                    }
                    if ((DateTime.TryParse(x, out DateTime res)) == false)
                    {
                        MessageBox.Show("Vui lòng nhập ngày tháng hợp lệ");
                    }
                    else
                    {
                        DateTime xx = Convert.ToDateTime(x);
                        if (((timenow.Year - xx.Year) < detailModel.MinAge()) || (timenow.Year - xx.Year) > detailModel.MaxAge())
                        {
                            MessageBox.Show("Độ tuổi không hợp lệ");
                        }
                    }
                    break;
            }
        }
    }
}
