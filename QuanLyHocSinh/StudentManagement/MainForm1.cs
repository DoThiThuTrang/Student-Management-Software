using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Semester;
using StudentManagement.Subject;
using StudentManagement.Class1;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            LoadData();
            AbrirFormInPanel(new StudentForm());
            label2.Visible = true;
        }

        private void LoadData()
        {
            gunaButton1.Text = "Quản lý" + Environment.NewLine + "học sinh";
            gunaButton1.TextAlign = HorizontalAlignment.Left;
            gunaButton2.Text = "Quản lý" + Environment.NewLine + "lớp học";
            gunaButton2.TextAlign = HorizontalAlignment.Left;
            gunaButton3.Text = "Báo cáo" + Environment.NewLine + "thống kê"; 
            gunaButton3.TextAlign = HorizontalAlignment.Left;
            gunaButton4.Text = "Quản lý" + Environment.NewLine + "điểm";
            gunaButton4.TextAlign = HorizontalAlignment.Left;
            gunaButton5.Text = "Quản lý" + Environment.NewLine + "chương trình học" ;
            gunaButton6.Text = "Báo cáo" + Environment.NewLine + "môn học";
            gunaButton7.Text = "Báo cáo" + Environment.NewLine + "học kỳ";
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelContainer.Controls.Count > 0)
                this.PanelContainer.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fh);
            this.PanelContainer.Tag = fh;
            fh.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new StudentForm());
            label1.Visible = false;
            label2.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ClassForm1());
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ScoreSubjectForm());
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CTHForm());
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel2.Height += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel2.Height -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReportSubject());
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ReportSemester());
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
        }
    }
}
