using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterItCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // kiểm tra các trường bắt buộc
            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboNganhHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một ngành học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán học phí
            double donGiaThang = 2000000; // 2 triệu/tháng
            int soThang = Convert.ToInt32(numThoiGian.Value);
            double hocPhiGoc = soThang * donGiaThang;
            double phanTramGiam = 0;

            // Xác định mức giảm giá dựa trên CheckBox
            if (chkSinhVien.Checked) phanTramGiam = 0.10;
            else if (chkNguoiDiLam.Checked) phanTramGiam = 0.05;
            else if (chkHocSinh.Checked) phanTramGiam = 0.15;

            double tongTien = hocPhiGoc * (1 - phanTramGiam);

            string nganhHoc = cboNganhHoc.SelectedItem.ToString();

            // Xử lý CheckedListBox (Kỹ năng bổ trợ)
            double phiKyNangBoTro = 0;
            string danhSachKyNang = "";
            double giaMoiKyNang = 500000; // Phí mỗi môn bổ trợ

            foreach (var item in clbKyNang.CheckedItems)
            {
                phiKyNangBoTro += giaMoiKyNang;
                danhSachKyNang += item.ToString() + ", ";
            }
            // Xóa dấu phẩy thừa ở cuối chuỗi
            danhSachKyNang = danhSachKyNang.TrimEnd(' ', ',');
            tongTien += phiKyNangBoTro;

            // Thêm vào DataGridView
            int sodong = dgvDanhSach.Rows.Count;
            dgvDanhSach.Rows.Add(
                sodong + 1,
                txtHoTen.Text,
                txtSDT.Text,
                nganhHoc,
                soThang,
                danhSachKyNang,
                tongTien.ToString("C"));
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectedTab = tabPage2; // Chuyển sang tab danh sách sau khi đăng ký thành công
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDanhSach.Rows.Clear();
        }
    }
}
