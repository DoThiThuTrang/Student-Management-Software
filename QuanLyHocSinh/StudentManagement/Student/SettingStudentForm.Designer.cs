
namespace StudentManagement.Student
{
    partial class SettingStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingStudentForm));
            this.TxtMinAge = new System.Windows.Forms.MaskedTextBox();
            this.LbMinAge = new System.Windows.Forms.Label();
            this.LbMaxAge = new System.Windows.Forms.Label();
            this.TxtMaxAge = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtMinAge
            // 
            this.TxtMinAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMinAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMinAge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinAge.Location = new System.Drawing.Point(151, 41);
            this.TxtMinAge.Name = "TxtMinAge";
            this.TxtMinAge.Size = new System.Drawing.Size(55, 23);
            this.TxtMinAge.TabIndex = 1;
            this.TxtMinAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbMinAge
            // 
            this.LbMinAge.AutoSize = true;
            this.LbMinAge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMinAge.Location = new System.Drawing.Point(34, 41);
            this.LbMinAge.Name = "LbMinAge";
            this.LbMinAge.Size = new System.Drawing.Size(111, 23);
            this.LbMinAge.TabIndex = 2;
            this.LbMinAge.Text = "Tuổi tối thiểu";
            // 
            // LbMaxAge
            // 
            this.LbMaxAge.AutoSize = true;
            this.LbMaxAge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaxAge.Location = new System.Drawing.Point(34, 87);
            this.LbMaxAge.Name = "LbMaxAge";
            this.LbMaxAge.Size = new System.Drawing.Size(111, 23);
            this.LbMaxAge.TabIndex = 4;
            this.LbMaxAge.Text = "Tuổi tối đa    ";
            // 
            // TxtMaxAge
            // 
            this.TxtMaxAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMaxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMaxAge.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxAge.Location = new System.Drawing.Point(151, 87);
            this.TxtMaxAge.Name = "TxtMaxAge";
            this.TxtMaxAge.Size = new System.Drawing.Size(55, 23);
            this.TxtMaxAge.TabIndex = 3;
            this.TxtMaxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(90, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 54);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SettingStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(247, 207);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LbMaxAge);
            this.Controls.Add(this.TxtMaxAge);
            this.Controls.Add(this.LbMinAge);
            this.Controls.Add(this.TxtMinAge);
            this.Name = "SettingStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa ràng buộc tuổi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TxtMinAge;
        private System.Windows.Forms.Label LbMinAge;
        private System.Windows.Forms.Label LbMaxAge;
        private System.Windows.Forms.MaskedTextBox TxtMaxAge;
        private System.Windows.Forms.Button btnSave;
    }
}