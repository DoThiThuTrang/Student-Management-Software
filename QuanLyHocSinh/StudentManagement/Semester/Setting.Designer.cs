
namespace StudentManagement.Semester
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.btnSave = new System.Windows.Forms.Button();
            this.LbDD = new System.Windows.Forms.Label();
            this.TxtDD = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
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
            this.btnSave.Location = new System.Drawing.Point(79, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LbDD
            // 
            this.LbDD.AutoSize = true;
            this.LbDD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDD.Location = new System.Drawing.Point(44, 37);
            this.LbDD.Name = "LbDD";
            this.LbDD.Size = new System.Drawing.Size(80, 23);
            this.LbDD.TabIndex = 7;
            this.LbDD.Text = "Điểm đạt";
            // 
            // TxtDD
            // 
            this.TxtDD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDD.Location = new System.Drawing.Point(141, 37);
            this.TxtDD.Name = "TxtDD";
            this.TxtDD.Size = new System.Drawing.Size(55, 23);
            this.TxtDD.TabIndex = 6;
            this.TxtDD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(247, 155);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LbDD);
            this.Controls.Add(this.TxtDD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa điểm đạt học kỳ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label LbDD;
        private System.Windows.Forms.MaskedTextBox TxtDD;
    }
}