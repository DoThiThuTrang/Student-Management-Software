
namespace StudentManagement.Student
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.AddMultiRow = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.HO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AddMultiRow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMultiRow
            // 
            this.AddMultiRow.AllowCustomTheming = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.AddMultiRow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AddMultiRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMultiRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddMultiRow.BackgroundColor = System.Drawing.Color.White;
            this.AddMultiRow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddMultiRow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AddMultiRow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(143)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddMultiRow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AddMultiRow.ColumnHeadersHeight = 40;
            this.AddMultiRow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HO,
            this.TEN,
            this.NGSINH,
            this.GIOITINH,
            this.DIACHI,
            this.EMAIL});
            this.AddMultiRow.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AddMultiRow.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddMultiRow.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AddMultiRow.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.AddMultiRow.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AddMultiRow.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.AddMultiRow.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.AddMultiRow.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.AddMultiRow.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.AddMultiRow.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AddMultiRow.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(143)))), ((int)(((byte)(139)))));
            this.AddMultiRow.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AddMultiRow.CurrentTheme.Name = null;
            this.AddMultiRow.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AddMultiRow.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddMultiRow.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AddMultiRow.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.AddMultiRow.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AddMultiRow.DefaultCellStyle = dataGridViewCellStyle6;
            this.AddMultiRow.EnableHeadersVisualStyles = false;
            this.AddMultiRow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(251)))));
            this.AddMultiRow.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.AddMultiRow.HeaderBgColor = System.Drawing.Color.Empty;
            this.AddMultiRow.HeaderForeColor = System.Drawing.Color.White;
            this.AddMultiRow.Location = new System.Drawing.Point(21, 62);
            this.AddMultiRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMultiRow.Name = "AddMultiRow";
            this.AddMultiRow.RowHeadersVisible = false;
            this.AddMultiRow.RowHeadersWidth = 51;
            this.AddMultiRow.RowTemplate.Height = 40;
            this.AddMultiRow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddMultiRow.Size = new System.Drawing.Size(767, 377);
            this.AddMultiRow.TabIndex = 3;
            this.AddMultiRow.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.AddMultiRow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddMultiRow_CellClick);
            this.AddMultiRow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddMultiRow_CellContentClick);
            this.AddMultiRow.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddMultiRow_CellEndEdit);
            this.AddMultiRow.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddMultiRow_CellLeave);
            this.AddMultiRow.Scroll += new System.Windows.Forms.ScrollEventHandler(this.AddMultiRow_Scroll);
            this.AddMultiRow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddMultiRow_KeyDown);
            // 
            // HO
            // 
            this.HO.HeaderText = "Họ";
            this.HO.MinimumWidth = 6;
            this.HO.Name = "HO";
            // 
            // TEN
            // 
            this.TEN.HeaderText = "Tên";
            this.TEN.MinimumWidth = 6;
            this.TEN.Name = "TEN";
            // 
            // NGSINH
            // 
            this.NGSINH.HeaderText = "Ngày sinh";
            this.NGSINH.MinimumWidth = 6;
            this.NGSINH.Name = "NGSINH";
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GIOITINH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GIOITINH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GIOITINH.Width = 128;
            // 
            // DIACHI
            // 
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(628, -14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 60);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Thêm";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(21, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 34);
            this.panel1.TabIndex = 4;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddMultiRow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm học sinh";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddMultiRow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private Bunifu.UI.WinForms.BunifuDataGridView AddMultiRow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINH;
        private System.Windows.Forms.DataGridViewComboBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
    }
}