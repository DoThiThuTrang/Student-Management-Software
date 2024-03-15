using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Class1;
using StudentManagement.Student;

namespace StudentManagement.Class1
{
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {
            DataGridViewAddClass.AllowUserToAddRows = false;
            DataGridViewAddClass.Rows.Add();
            using (QLHSEntities2 db = new QLHSEntities2())
            {
                kHOIBindingSource.DataSource = db.KHOIs.ToList();
            }
        }

        private void DataGridViewAddClass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewAddClass.Rows.Add();
                DataGridViewAddClass.CurrentCell = DataGridViewAddClass.Rows[DataGridViewAddClass.Rows.Count - 1].Cells[0];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClassDetail detailModel = new ClassDetail();
            List<ClassDetail> objectDetailList = new List<ClassDetail>();
            foreach (DataGridViewRow dgvRow in DataGridViewAddClass.Rows)
            {
                var detail = new ClassDetail()
                {

                    TENLOP = Convert.ToString(dgvRow.Cells[0].Value),
                    MAKHOI = Convert.ToString(dgvRow.Cells[1].Value),
                };
                objectDetailList.Add(detail);
                //MessageBox.Show(detail.MAKHOI);
                
            }
            detailModel = new ClassDetail();
            detailModel.add_MultipleStatementsSingleInsert(objectDetailList);
        }
    }
}
