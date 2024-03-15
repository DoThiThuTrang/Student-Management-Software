
namespace StudentManagement.Subject
{
    partial class AddCTH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCTH));
            this.LbDiemDat = new System.Windows.Forms.Label();
            this.LbMH = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBoxMH = new System.Windows.Forms.ComboBox();
            this.cbBoxKhoi = new System.Windows.Forms.ComboBox();
            this.TxtHS = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LbDiemDat
            // 
            this.LbDiemDat.AutoSize = true;
            this.LbDiemDat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDiemDat.Location = new System.Drawing.Point(34, 77);
            this.LbDiemDat.Name = "LbDiemDat";
            this.LbDiemDat.Size = new System.Drawing.Size(44, 23);
            this.LbDiemDat.TabIndex = 14;
            this.LbDiemDat.Text = "Khối";
            // 
            // LbMH
            // 
            this.LbMH.AutoSize = true;
            this.LbMH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMH.Location = new System.Drawing.Point(34, 31);
            this.LbMH.Name = "LbMH";
            this.LbMH.Size = new System.Drawing.Size(79, 23);
            this.LbMH.TabIndex = 12;
            this.LbMH.Text = "Môn học";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(115, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 54);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hệ số";
            // 
            // cbBoxMH
            // 
            this.cbBoxMH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbBoxMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxMH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbBoxMH.FormattingEnabled = true;
            this.cbBoxMH.Location = new System.Drawing.Point(119, 28);
            this.cbBoxMH.Name = "cbBoxMH";
            this.cbBoxMH.Size = new System.Drawing.Size(110, 31);
            this.cbBoxMH.TabIndex = 46;
            // 
            // cbBoxKhoi
            // 
            this.cbBoxKhoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbBoxKhoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBoxKhoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbBoxKhoi.FormattingEnabled = true;
            this.cbBoxKhoi.Location = new System.Drawing.Point(119, 74);
            this.cbBoxKhoi.Name = "cbBoxKhoi";
            this.cbBoxKhoi.Size = new System.Drawing.Size(110, 31);
            this.cbBoxKhoi.TabIndex = 47;
            // 
            // TxtHS
            // 
            this.TxtHS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtHS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtHS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHS.Location = new System.Drawing.Point(119, 123);
            this.TxtHS.Name = "TxtHS";
            this.TxtHS.Size = new System.Drawing.Size(110, 23);
            this.TxtHS.TabIndex = 48;
            this.TxtHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddCTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 228);
            this.Controls.Add(this.TxtHS);
            this.Controls.Add(this.cbBoxKhoi);
            this.Controls.Add(this.cbBoxMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LbDiemDat);
            this.Controls.Add(this.LbMH);
            this.Name = "AddCTH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm chương trình học";
            this.Load += new System.EventHandler(this.AddCTH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label LbDiemDat;
        private System.Windows.Forms.Label LbMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBoxMH;
        private System.Windows.Forms.ComboBox cbBoxKhoi;
        private System.Windows.Forms.MaskedTextBox TxtHS;
    }
}