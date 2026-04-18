using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10QLBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //đổ data vào combo box
            var sql = "select  hd.MaHd, concat(hd.MaHd, ' - ', kh.TenCty, ' - ', hd.NgayLapHD) as TTHD from HoaDon hd JOIN KhachHang kh ON hd.MaKh = kh.MaKh order by hd.NgayLapHD DESC";
            var dtHoaDon = DataProvider.TruyVan_LayDuLieu(sql);
            CboHoaDon.DisplayMember = "TTHD";
            CboHoaDon.ValueMember = "MaHd";
            CboHoaDon.DataSource = dtHoaDon;
        }

        private void BtnXuatHd_Click(object sender, EventArgs e)
        {
            var maHd = CboHoaDon.SelectedValue.ToString();
            // MessageBox.Show("Xuất hóa đơn có mã: " + maHd);
            var fullPath = Path.Combine(Application.StartupPath, "Hoa-don-ban-hang-template.xlsx"); //giả sử file template Hoa-don-ban-hang-template.xlsx đặt cùng chỗ chương trình chạy

            FileInfo path = new FileInfo(fullPath);
            if (path.Exists)
            {
                ExcelPackage.License.SetNonCommercialPersonal("My Name");
                using (ExcelPackage p = new ExcelPackage(path))
                {
                    ExcelWorksheet ws = p.Workbook.Worksheets["Sheet1"];
                    // Lấy thông tin hóa đơn
                    var sql = $"select  hd.MaHd, kh.TenCty, kh.DiaChi from HoaDon hd JOIN KhachHang kh ON hd.MaKh = kh.MaKh WHERE hd.MaHd = '{maHd}'";
                    var ttHoaDon = DataProvider.TruyVan_LayDuLieu(sql);

                    ws.Cells["A4"].Value = $"Tên khách hàng: {ttHoaDon.Rows[0]["TenCty"]}";
                    ws.Cells["A5"].Value = $"Địa chỉ: {ttHoaDon.Rows[0]["DiaChi"]}";

                    // Lấy thông tin chi tiết hóa đơn
                    var sqlCTDH = $"SELECT ct.MaHd, ct.SoLuong, sp.TenSp, sp.DonGia, ct.SoLuong * sp.DonGia as ThanhTien FROM ChiTietHoaDon ct JOIN SanPham sp ON ct.MaSp = sp.MaSp WHERE ct.MaHd = '{maHd}'";
                    var invData = DataProvider.TruyVan_LayDuLieu(sqlCTDH);
                    int soDong = invData.Rows.Count;
                    //chèn số dòng đúng với số lượng sản phẩm mua
                    ws.InsertRow(9, soDong - 1);

                    //Set số thứ tự
                    ws.Cells[$"A8:A{8 + soDong - 1}"].FillNumber(x => x.StartValue = 1);
                    ws.Cells[$"C{8 + soDong}"].Formula = $"=SUM(C8:C{8 + soDong - 1})";
                    ws.Cells[$"E{8 + soDong}"].Formula = $"=SUM(E8:E{8 + soDong - 1})";
                    var i = 0;
                    foreach (DataRow dr in invData.Rows)
                    {
                        ws.Cells[8 + i, 1].Value = (i + 1).ToString();
                        ws.Cells[8 + i, 2].Value = dr["TenSp"].ToString();
                        ws.Cells[8 + i, 3].Value = dr["SoLuong"].ToString();
                        ws.Cells[8 + i, 4].Value = dr["DonGia"].ToString();
                        ws.Cells[8 + i, 5].Value = dr["ThanhTien"].ToString();
                        i++;
                    }

                    p.SaveAs($"INV{maHd}.xlsx"); // có thể đổi tên file

                }

            }
        }
    }
}
