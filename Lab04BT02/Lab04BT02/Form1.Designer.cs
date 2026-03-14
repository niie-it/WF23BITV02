namespace Lab04BT02
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
            this.LlbSoDong = new System.Windows.Forms.Label();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.lblSoCot = new System.Windows.Forms.Label();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.btnVe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LlbSoDong
            // 
            this.LlbSoDong.AutoSize = true;
            this.LlbSoDong.Location = new System.Drawing.Point(43, 51);
            this.LlbSoDong.Name = "LlbSoDong";
            this.LlbSoDong.Size = new System.Drawing.Size(120, 32);
            this.LlbSoDong.TabIndex = 0;
            this.LlbSoDong.Text = "Số dòng";
            // 
            // txtSoDong
            // 
            this.txtSoDong.Location = new System.Drawing.Point(215, 45);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(192, 38);
            this.txtSoDong.TabIndex = 1;
            // 
            // lblSoCot
            // 
            this.lblSoCot.AutoSize = true;
            this.lblSoCot.Location = new System.Drawing.Point(43, 129);
            this.lblSoCot.Name = "lblSoCot";
            this.lblSoCot.Size = new System.Drawing.Size(94, 32);
            this.lblSoCot.TabIndex = 0;
            this.lblSoCot.Text = "Số cột";
            this.lblSoCot.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoCot
            // 
            this.txtSoCot.Location = new System.Drawing.Point(215, 123);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(192, 38);
            this.txtSoCot.TabIndex = 2;
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(426, 45);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(176, 116);
            this.btnVe.TabIndex = 3;
            this.btnVe.Text = "Vẽ bảng";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 194);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.lblSoCot);
            this.Controls.Add(this.LlbSoDong);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NHẬP LIỆU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LlbSoDong;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.Label lblSoCot;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Button btnVe;
    }
}

