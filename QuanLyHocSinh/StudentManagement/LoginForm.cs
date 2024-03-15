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

namespace StudentManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=QLHS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from LOGIN where USERNAME= '" + TxtUsername.Text + "' and PASSWORD= '" + TxtPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MainForm1 mf = new MainForm1();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc tài khoản");
            }
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text.Equals(@"Tài khoản"))
            {
                TxtUsername.Text = "";
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text.Equals(""))
            {
                TxtUsername.Text = @"Tài khoản";
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text.Equals(@"Mật khẩu"))
            {
                TxtPassword.Text = "";
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text.Equals(""))
            {
                TxtPassword.Text = @"Mật khẩu";
            }
        }

    }
}
