
namespace StudentManagement.Subject
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.LbDiemDat = new System.Windows.Forms.Label();
            this.TxtDD = new System.Windows.Forms.MaskedTextBox();
            this.LbMH = new System.Windows.Forms.Label();
            this.TxtMH = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbDiemDat
            // 
            this.LbDiemDat.AutoSize = true;
            this.LbDiemDat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDiemDat.Location = new System.Drawing.Point(37, 83);
            this.LbDiemDat.Name = "LbDiemDat";
            this.LbDiemDat.Size = new System.Drawing.Size(80, 23);
            this.LbDiemDat.TabIndex = 9;
            this.LbDiemDat.Text = "Điểm đạt";
            // 
            // TxtDD
            // 
            this.TxtDD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDD.Location = new System.Drawing.Point(152, 83);
            this.TxtDD.Name = "TxtDD";
            this.TxtDD.Size = new System.Drawing.Size(110, 23);
            this.TxtDD.TabIndex = 8;
            this.TxtDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LbMH
            // 
            this.LbMH.AutoSize = true;
            this.LbMH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMH.Location = new System.Drawing.Point(37, 37);
            this.LbMH.Name = "LbMH";
            this.LbMH.Size = new System.Drawing.Size(109, 23);
            this.LbMH.TabIndex = 7;
            this.LbMH.Text = "Tên môn học";
            // 
            // TxtMH
            // 
            this.TxtMH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMH.Location = new System.Drawing.Point(152, 37);
            this.TxtMH.Name = "TxtMH";
            this.TxtMH.Size = new System.Drawing.Size(110, 23);
            this.TxtMH.TabIndex = 6;
            this.TxtMH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnAdd.Location = new System.Drawing.Point(148, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 54);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 195);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LbDiemDat);
            this.Controls.Add(this.TxtDD);
            this.Controls.Add(this.LbMH);
            this.Controls.Add(this.TxtMH);
            this.Name = "AddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label LbDiemDat;
        private System.Windows.Forms.MaskedTextBox TxtDD;
        private System.Windows.Forms.Label LbMH;
        private System.Windows.Forms.MaskedTextBox TxtMH;
    }
}