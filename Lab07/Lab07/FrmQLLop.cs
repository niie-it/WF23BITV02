using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class FrmQLLop : Form
    {
        public FrmQLLop()
        {
            InitializeComponent();
        }

        private void FrmQLLop_Load(object sender, EventArgs e)
        {
            layDanhSachLop();
            cboListType.SelectedIndex = 1;//Large Icon
        }

        private void layDanhSachLop()
        {
            var sql = "SELECT * FROM Lop";
            var dtLop = DataProvider.TruyVan_LayDuLieu(sql);
            //duyệt từng dòng dataTableLop để thêm vô listview lớp
            foreach (DataRow dr in dtLop.Rows)
            {
                var item = new ListViewItem(dr["MaLop"].ToString());
                item.Tag = dr["MaLop"].ToString();
                item.SubItems.Add(dr["TenLop"].ToString());
                item.SubItems.Add(dr["SiSo"].ToString());
                lvLop.Items.Add(item);
            }
        }

        private void cboListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvLop.View = (View)cboListType.SelectedIndex;
        }

        private void lvLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvLop_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //sự kiện chọn Item trên listView sẽ hiển thị thông tin chi tiết của lớp đó lên các TextBox bên dưới
            txtMaLop.Text = e.Item.SubItems[0].Text;
            txtTenLop.Text = e.Item.SubItems[1].Text;
            txtSiSo.Text = e.Item.SubItems[2].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //lấy thông tin cần thêm
            var maLop = txtMaLop.Text;
            var tenLop = txtTenLop.Text;
            if (!int.TryParse(txtSiSo.Text, out int siSo) || siSo < 1)
            {
                MessageBox.Show("Sĩ số phải là số nguyên dương");
                return;
            }

            string sql = "INSERT INTO Lop(MaLop, TenLop, SiSo) VALUES (@MaLop,@TenLop, @SiSo)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaLop", maLop),
                new SqlParameter("@TenLop", tenLop),
                new SqlParameter("@SiSo", siSo)
            };
            try
            {
                DataProvider.ExcuteNonQuery(sql, CommandType.Text, parameters);
                layDanhSachLop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message);
                return;
            }
        }
    }
