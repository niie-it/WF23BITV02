namespace Lab04
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSo01 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSo02 = new System.Windows.Forms.TextBox();
            this.TxtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadCong = new System.Windows.Forms.RadioButton();
            this.RadTru = new System.Windows.Forms.RadioButton();
            this.RadNhan = new System.Windows.Forms.RadioButton();
            this.RadChia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnTinh = new System.Windows.Forms.Button();
            this.BtnNhapLai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSo01
            // 
            this.TxtSo01.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSo01.Location = new System.Drawing.Point(287, 35);
            this.TxtSo01.Name = "TxtSo01";
            this.TxtSo01.Size = new System.Drawing.Size(256, 53);
            this.TxtSo01.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thứ hai";
            // 
            // TxtSo02
            // 
            this.TxtSo02.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSo02.Location = new System.Drawing.Point(287, 102);
            this.TxtSo02.Name = "TxtSo02";
            this.TxtSo02.Size = new System.Drawing.Size(256, 53);
            this.TxtSo02.TabIndex = 3;
            // 
            // TxtKetQua
            // 
            this.TxtKetQua.Enabled = false;
            this.TxtKetQua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKetQua.ForeColor = System.Drawing.Color.Red;
            this.TxtKetQua.Location = new System.Drawing.Point(287, 169);
            this.TxtKetQua.Name = "TxtKetQua";
            this.TxtKetQua.Size = new System.Drawing.Size(256, 53);
            this.TxtKetQua.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadChia);
            this.groupBox1.Controls.Add(this.RadNhan);
            this.groupBox1.Controls.Add(this.RadTru);
            this.groupBox1.Controls.Add(this.RadCong);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(610, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // RadCong
            // 
            this.RadCong.AutoSize = true;
            this.RadCong.Location = new System.Drawing.Point(21, 50);
            this.RadCong.Name = "RadCong";
            this.RadCong.Size = new System.Drawing.Size(245, 49);
            this.RadCong.TabIndex = 0;
            this.RadCong.Text = "Phép cộng";
            this.RadCong.UseVisualStyleBackColor = true;
            // 
            // RadTru
            // 
            this.RadTru.AutoSize = true;
            this.RadTru.Checked = true;
            this.RadTru.Location = new System.Drawing.Point(21, 110);
            this.RadTru.Name = "RadTru";
            this.RadTru.Size = new System.Drawing.Size(211, 49);
            this.RadTru.TabIndex = 0;
            this.RadTru.TabStop = true;
            this.RadTru.Text = "Phép trừ";
            this.RadTru.UseVisualStyleBackColor = true;
            // 
            // RadNhan
            // 
            this.RadNhan.AutoSize = true;
            this.RadNhan.Location = new System.Drawing.Point(21, 170);
            this.RadNhan.Name = "RadNhan";
            this.RadNhan.Size = new System.Drawing.Size(245, 49);
            this.RadNhan.TabIndex = 0;
            this.RadNhan.Text = "Phép nhân";
            this.RadNhan.UseVisualStyleBackColor = true;
            // 
            // RadChia
            // 
            this.RadChia.AutoSize = true;
            this.RadChia.Location = new System.Drawing.Point(21, 230);
            this.RadChia.Name = "RadChia";
            this.RadChia.Size = new System.Drawing.Size(240, 49);
            this.RadChia.TabIndex = 0;
            this.RadChia.Text = "Phép Chia";
            this.RadChia.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThoat.Location = new System.Drawing.Point(21, 263);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(179, 84);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnTinh
            // 
            this.BtnTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTinh.Location = new System.Drawing.Point(391, 263);
            this.BtnTinh.Name = "BtnTinh";
            this.BtnTinh.Size = new System.Drawing.Size(179, 84);
            this.BtnTinh.TabIndex = 6;
            this.BtnTinh.Text = "Tính";
            this.BtnTinh.UseVisualStyleBackColor = true;
            this.BtnTinh.Click += new System.EventHandler(this.BtnTinh_Click);
            // 
            // BtnNhapLai
            // 
            this.BtnNhapLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNhapLai.Location = new System.Drawing.Point(191, 263);
            this.BtnNhapLai.Name = "BtnNhapLai";
            this.BtnNhapLai.Size = new System.Drawing.Size(179, 84);
            this.BtnNhapLai.TabIndex = 6;
            this.BtnNhapLai.Text = "Nhập lại";
            this.BtnNhapLai.UseVisualStyleBackColor = true;
            this.BtnNhapLai.Click += new System.EventHandler(this.BtnNhapLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 380);
            this.Controls.Add(this.BtnTinh);
            this.Controls.Add(this.BtnNhapLai);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtKetQua);
            this.Controls.Add(this.TxtSo02);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSo01);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chương trình máy tính đơn giản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSo01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSo02;
        private System.Windows.Forms.TextBox TxtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadChia;
        private System.Windows.Forms.RadioButton RadNhan;
        private System.Windows.Forms.RadioButton RadTru;
        private System.Windows.Forms.RadioButton RadCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnTinh;
        private System.Windows.Forms.Button BtnNhapLai;
    }
}

