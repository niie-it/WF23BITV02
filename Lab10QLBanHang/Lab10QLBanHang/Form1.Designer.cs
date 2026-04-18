namespace Lab10QLBanHang
{
    partial class Form1
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
            this.CboHoaDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnXuatHd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CboHoaDon
            // 
            this.CboHoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboHoaDon.FormattingEnabled = true;
            this.CboHoaDon.Location = new System.Drawing.Point(215, 55);
            this.CboHoaDon.Name = "CboHoaDon";
            this.CboHoaDon.Size = new System.Drawing.Size(754, 53);
            this.CboHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn";
            // 
            // BtnXuatHd
            // 
            this.BtnXuatHd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXuatHd.Location = new System.Drawing.Point(1121, 55);
            this.BtnXuatHd.Name = "BtnXuatHd";
            this.BtnXuatHd.Size = new System.Drawing.Size(387, 77);
            this.BtnXuatHd.TabIndex = 2;
            this.BtnXuatHd.Text = "Xuất HĐ (Excel)";
            this.BtnXuatHd.UseVisualStyleBackColor = true;
            this.BtnXuatHd.Click += new System.EventHandler(this.BtnXuatHd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 450);
            this.Controls.Add(this.BtnXuatHd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboHoaDon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnXuatHd;
    }
}

