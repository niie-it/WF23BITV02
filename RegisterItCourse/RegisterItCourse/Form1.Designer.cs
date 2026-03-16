namespace RegisterItCourse
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dudMaGiamGia = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHocSinh = new System.Windows.Forms.CheckBox();
            this.chkNguoiDiLam = new System.Windows.Forms.CheckBox();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numThoiGian = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.clbKyNang = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNganhHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NganhHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSKyNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2285, 909);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLamMoi);
            this.tabPage1.Controls.Add(this.btnDangKy);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(10, 62);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2265, 837);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng ký mới";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(1094, 656);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(321, 118);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(707, 656);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(321, 118);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dudMaGiamGia);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.chkHocSinh);
            this.groupBox3.Controls.Add(this.chkNguoiDiLam);
            this.groupBox3.Controls.Add(this.chkSinhVien);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1703, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 505);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ưu đãi & Mã giảm giá";
            // 
            // dudMaGiamGia
            // 
            this.dudMaGiamGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dudMaGiamGia.Items.Add("KM2026");
            this.dudMaGiamGia.Items.Add("CHUYENCAN");
            this.dudMaGiamGia.Items.Add("TET2027");
            this.dudMaGiamGia.Location = new System.Drawing.Point(47, 410);
            this.dudMaGiamGia.Name = "dudMaGiamGia";
            this.dudMaGiamGia.Size = new System.Drawing.Size(393, 53);
            this.dudMaGiamGia.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 45);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã ưu đãi đặc biệt";
            // 
            // chkHocSinh
            // 
            this.chkHocSinh.AutoSize = true;
            this.chkHocSinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHocSinh.Location = new System.Drawing.Point(47, 237);
            this.chkHocSinh.Name = "chkHocSinh";
            this.chkHocSinh.Size = new System.Drawing.Size(209, 49);
            this.chkHocSinh.TabIndex = 0;
            this.chkHocSinh.Text = "Học sinh";
            this.chkHocSinh.UseVisualStyleBackColor = true;
            // 
            // chkNguoiDiLam
            // 
            this.chkNguoiDiLam.AutoSize = true;
            this.chkNguoiDiLam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNguoiDiLam.Location = new System.Drawing.Point(47, 156);
            this.chkNguoiDiLam.Name = "chkNguoiDiLam";
            this.chkNguoiDiLam.Size = new System.Drawing.Size(286, 49);
            this.chkNguoiDiLam.TabIndex = 0;
            this.chkNguoiDiLam.Text = "Người đi làm";
            this.chkNguoiDiLam.UseVisualStyleBackColor = true;
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSinhVien.Location = new System.Drawing.Point(47, 85);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(216, 49);
            this.chkSinhVien.TabIndex = 0;
            this.chkSinhVien.Text = "Sinh viên";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numThoiGian);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.clbKyNang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboNganhHoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(961, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 527);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khóa học";
            // 
            // numThoiGian
            // 
            this.numThoiGian.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThoiGian.Location = new System.Drawing.Point(454, 469);
            this.numThoiGian.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numThoiGian.Name = "numThoiGian";
            this.numThoiGian.Size = new System.Drawing.Size(213, 53);
            this.numThoiGian.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 45);
            this.label7.TabIndex = 4;
            this.label7.Text = "Thời gian học (tháng)";
            // 
            // clbKyNang
            // 
            this.clbKyNang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbKyNang.FormattingEnabled = true;
            this.clbKyNang.Items.AddRange(new object[] {
            "Tiếng Anh chuyên ngành",
            "Kỹ năng thuyết trình",
            "Tư duy logic",
            "Git/Github"});
            this.clbKyNang.Location = new System.Drawing.Point(42, 250);
            this.clbKyNang.Name = "clbKyNang";
            this.clbKyNang.Size = new System.Drawing.Size(625, 154);
            this.clbKyNang.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 45);
            this.label6.TabIndex = 2;
            this.label6.Text = "Các môn kỹ năng bổ trợ";
            // 
            // cboNganhHoc
            // 
            this.cboNganhHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganhHoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNganhHoc.FormattingEnabled = true;
            this.cboNganhHoc.Items.AddRange(new object[] {
            "Lập trình di động",
            "Lập trình web",
            "Khai phá dữ liệu",
            "Đồ họa đa phương tiện"});
            this.cboNganhHoc.Location = new System.Drawing.Point(307, 88);
            this.cboNganhHoc.Name = "cboNganhHoc";
            this.cboNganhHoc.Size = new System.Drawing.Size(360, 53);
            this.cboNganhHoc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngành học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(252, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 97);
            this.panel1.TabIndex = 6;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(249, 30);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(113, 49);
            this.radNu.TabIndex = 0;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(28, 30);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(142, 49);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(252, 325);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(571, 53);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(252, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(571, 53);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(252, 139);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(571, 53);
            this.txtSDT.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(252, 65);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(571, 53);
            this.txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXuatFile);
            this.tabPage2.Controls.Add(this.btnXoa);
            this.tabPage2.Controls.Add(this.dgvDanhSach);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(10, 62);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2265, 837);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách học viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(1145, 657);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(335, 139);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất file";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(554, 657);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(335, 139);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HoTen,
            this.SDT,
            this.NganhHoc,
            this.SoThang,
            this.DSKyNang,
            this.TongTien});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 3);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 102;
            this.dgvDanhSach.RowTemplate.Height = 40;
            this.dgvDanhSach.Size = new System.Drawing.Size(2259, 603);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 12;
            this.STT.Name = "STT";
            this.STT.Width = 250;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 12;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 250;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 12;
            this.SDT.Name = "SDT";
            this.SDT.Width = 250;
            // 
            // NganhHoc
            // 
            this.NganhHoc.HeaderText = "Ngành học";
            this.NganhHoc.MinimumWidth = 12;
            this.NganhHoc.Name = "NganhHoc";
            this.NganhHoc.Width = 250;
            // 
            // SoThang
            // 
            this.SoThang.HeaderText = "Số tháng";
            this.SoThang.MinimumWidth = 12;
            this.SoThang.Name = "SoThang";
            this.SoThang.Width = 250;
            // 
            // DSKyNang
            // 
            this.DSKyNang.HeaderText = "Kỹ năng";
            this.DSKyNang.MinimumWidth = 12;
            this.DSKyNang.Name = "DSKyNang";
            this.DSKyNang.Width = 250;
            // 
            // TongTien
            // 
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 12;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2285, 909);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Quản lý Đăng ký Khóa học IT";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiGian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DomainUpDown dudMaGiamGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkHocSinh;
        private System.Windows.Forms.CheckBox chkNguoiDiLam;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.NumericUpDown numThoiGian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbKyNang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboNganhHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NganhHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSKyNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}

