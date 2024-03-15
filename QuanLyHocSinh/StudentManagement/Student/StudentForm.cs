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


namespace StudentManagement
{
    public partial class StudentForm : Form
    {
        DateTimePicker dtp = new DateTimePicker();
        Rectangle _Retangle;
        public StudentForm()
        {
            InitializeComponent();
            DataGridViewStudent.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd-MM-yyyy";
            dtp.TextChanged += new EventHandler(dtp_TextChange);
            LoadData();
        }
        private void dtp_TextChange(Object sender, EventArgs e)
        {
            DataGridViewStudent.CurrentCell.Value = dtp.Text.ToString();
        }

        public void LoadData()
        {
            var con = ConnectionToSql.getConnection();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select MAHS,HO,TEN,NGSINH,GIOITINH,DIACHI,EMAIL from HOCSINH order by MAHS", con);
            DataTable dtStudent = new DataTable();
            sda.Fill(dtStudent);
            DataGridViewStudent.Rows.Clear();
            foreach(DataRow item in dtStudent.Rows)
            {
                int n = DataGridViewStudent.Rows.Add();
                DataGridViewStudent.Rows[n].Cells[0].Value = "false";
                DataGridViewStudent.Rows[n].Cells[1].Value = item["MAHS"].ToString();
                DataGridViewStudent.Rows[n].Cells[2].Value = item["HO"].ToString();
                DataGridViewStudent.Rows[n].Cells[3].Value = item["TEN"].ToString();
                DataGridViewStudent.Rows[n].Cells[4].Value = item["NGSINH"].ToString();
                DataGridViewStudent.Rows[n].Cells[5].Value = item["GIOITINH"].ToString();
                DataGridViewStudent.Rows[n].Cells[6].Value = item["DIACHI"].ToString();
                DataGridViewStudent.Rows[n].Cells[7].Value = item["EMAIL"].ToString();
            }
            con.Close();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.DataGridViewStudent = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewStudent
            // 
            this.DataGridViewStudent.AllowCustomTheming = true;
            this.DataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(143)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewStudent.ColumnHeadersHeight = 40;
            this.DataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.DataGridViewStudent.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewStudent.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewStudent.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewStudent.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.DataGridViewStudent.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewStudent.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.DataGridViewStudent.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.DataGridViewStudent.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.DataGridViewStudent.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewStudent.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewStudent.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(143)))), ((int)(((byte)(139)))));
            this.DataGridViewStudent.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewStudent.CurrentTheme.Name = null;
            this.DataGridViewStudent.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewStudent.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewStudent.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewStudent.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.DataGridViewStudent.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewStudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewStudent.EnableHeadersVisualStyles = false;
            this.DataGridViewStudent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.DataGridViewStudent.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.DataGridViewStudent.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewStudent.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewStudent.Location = new System.Drawing.Point(-1, 58);
            this.DataGridViewStudent.Name = "DataGridViewStudent";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewStudent.RowHeadersVisible = false;
            this.DataGridViewStudent.RowHeadersWidth = 51;
            this.DataGridViewStudent.RowTemplate.Height = 40;
            this.DataGridViewStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStudent.Size = new System.Drawing.Size(1209, 552);
            this.DataGridViewStudent.TabIndex = 0;
            this.DataGridViewStudent.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.DataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudent_CellClick);
            this.DataGridViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudent_CellContentClick);
            this.DataGridViewStudent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudent_CellEndEdit);
            this.DataGridViewStudent.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewStudent_CellLeave);
            this.DataGridViewStudent.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridViewStudent_Scroll);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Lớp";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(58, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 27);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(1004, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(31, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1036, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 27);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.BackgroundImage")));
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(12, 13);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(40, 27);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1078, -2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 54);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "Giới tính";
            this.Column6.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Địa chỉ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // StudentForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 614);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataGridViewStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.Leave += new System.EventHandler(this.StudentForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm Asf = new AddStudentForm();
            Asf.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingStudentForm Ssf = new SettingStudentForm();
            Ssf.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            foreach (DataGridViewRow item in DataGridViewStudent.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete From HOCSINH where MAHS ='" + item.Cells[1].Value.ToString() + "'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            MessageBox.Show("Đã xoá thành công...!");
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var con = ConnectionToSql.getConnection();
            con.Open();             
            SqlCommand command = new SqlCommand("update HOCSINH set HO = @HO,TEN=@TEN,NGSINH=@NGSINH,GIOITINH=@GIOITINH,DIACHI=@DIACHI,EMAIL=@EMAIL where MAHS = @MAHS", con);
            command.Parameters.Add("@HO", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@TEN", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@NGSINH", SqlDbType.Date);
            command.Parameters.Add("@GIOITINH", SqlDbType.NVarChar, 3);
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 40);
            command.Parameters.Add("@EMAIL", SqlDbType.VarChar, 30);
            command.Parameters.Add("@MAHS", SqlDbType.NChar, 8);
            foreach (DataGridViewRow item in DataGridViewStudent.Rows)
            {
                command.Parameters["@HO"].Value = Convert.ToString(item.Cells[2].Value);
                command.Parameters["@TEN"].Value = Convert.ToString(item.Cells[3].Value);
                command.Parameters["@NGSINH"].Value = Convert.ToDateTime(item.Cells[4].Value);
                command.Parameters["@GIOITINH"].Value = Convert.ToString(item.Cells[5].Value);
                command.Parameters["@DIACHI"].Value = Convert.ToString(item.Cells[6].Value);
                command.Parameters["@EMAIL"].Value = Convert.ToString(item.Cells[7].Value);
                command.Parameters["@MAHS"].Value = Convert.ToString(item.Cells[1].Value);
                command.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Cập nhật thành công!");
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm Sf = new SearchForm();
            Sf.ShowDialog();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void DataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentForm_Leave(object sender, EventArgs e)
        {

        }

        private void DataGridViewStudent_CellLeave(object sender, DataGridViewCellEventArgs e)
        {          
            switch (DataGridViewStudent.Columns[e.ColumnIndex].Name)
            {
                case "Column5":
                    dtp.Visible = false;                 
                    break;
            }
        }

        private void DataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (DataGridViewStudent.Columns[e.ColumnIndex].Name)
            {
                case "Column5":
                    _Retangle = DataGridViewStudent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(_Retangle.Width, _Retangle.Height);
                    dtp.Location = new Point(_Retangle.X, _Retangle.Y);
                    dtp.Visible = true;
                    break;

            }
        }

        private void DataGridViewStudent_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
        }

        private void DataGridViewStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            StudentDetail detailModel = new StudentDetail();
            String x;
            DateTime dDate = DateTime.Now;
            DateTime timenow = DateTime.Now;
            switch (DataGridViewStudent.Columns[e.ColumnIndex].Name)
            {
                case "Column5":
                    x = "a";
                    if (DataGridViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        x = DataGridViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    if ((DateTime.TryParse(x, out dDate)) == false)
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
