
namespace StudentManagement
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
            this.LbMaxSS = new System.Windows.Forms.Label();
            this.TxtMaxSS = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbMaxSS
            // 
            this.LbMaxSS.AutoSize = true;
            this.LbMaxSS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMaxSS.Location = new System.Drawing.Point(12, 44);
            this.LbMaxSS.Name = "LbMaxSS";
            this.LbMaxSS.Size = new System.Drawing.Size(104, 23);
            this.LbMaxSS.TabIndex = 9;
            this.LbMaxSS.Text = "Sĩ số tối đa  ";
            // 
            // TxtMaxSS
            // 
            this.TxtMaxSS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtMaxSS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMaxSS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxSS.Location = new System.Drawing.Point(134, 44);
            this.TxtMaxSS.Name = "TxtMaxSS";
            this.TxtMaxSS.Size = new System.Drawing.Size(76, 23);
            this.TxtMaxSS.TabIndex = 8;
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
            this.btnSave.Location = new System.Drawing.Point(93, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(247, 190);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.LbMaxSS);
            this.Controls.Add(this.TxtMaxSS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa sĩ số tối đa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label LbMaxSS;
        private System.Windows.Forms.MaskedTextBox TxtMaxSS;
    }
}