using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicFramework;
using System.IO;

namespace TiemMayHaiTrieu
{
    public partial class frmBangLuong : Form
    {
        dbBangLuong dbBangLuong = new dbBangLuong();
        public frmBangLuong()
        {
            InitializeComponent();
        }

        private void pbAvartar_Click(object sender, EventArgs e)
        {

        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
           // dgvBangLuong.DataSource = dbBangLuong.GetBangLuong();
            string[] thangs = {"Tháng 1", "Tháng 2" , "Tháng 3" , "Tháng 4" , "Tháng 5" , "Tháng 6" , "Tháng 7" , "Tháng 8" , "Tháng 9",
            "Tháng 10","Tháng 11","Tháng 12"};
            foreach(var i in thangs)
            {
                cbNhanVien2.Items.Add(i);
            }
        }
        int Thang = 0;int Nam = 0;
        private void dgvBangLuong_Click(object sender, EventArgs e)
        {
            try {
                //string anhNV = "";
                int index = dgvBangLuong.CurrentCell.RowIndex;
                pbAvartar.Image = (System.Drawing.Image)dgvBangLuong.Rows[index].Cells["anhDaiDien"].FormattedValue;
               
                lbSDTNV.Text = dgvBangLuong.Rows[index].Cells["soDienThoai"].Value.ToString();
                maNV = Int32.Parse(dgvBangLuong.Rows[index].Cells["maNhanVien"].Value.ToString());
                Thang = Int32.Parse(dgvBangLuong.Rows[index].Cells["maThang"].Value.ToString());
                Nam =Int32.Parse( dgvBangLuong.Rows[index].Cells["maNam"].Value.ToString());
                lbTongLuongCacThang.Text = dbBangLuong.GetLuongNamCuaNV(maNV, Int32.Parse(dgvBangLuong.Rows[index].Cells["maThang"].Value.ToString()), Int32.Parse(dgvBangLuong.Rows[index].Cells["maNam"].Value.ToString())).ToString();
                lbTongLuongCacNam.Text = dbBangLuong.GetTongLuongCacNam(maNV, Int32.Parse(dgvBangLuong.Rows[index].Cells["maNam"].Value.ToString())).ToString();
                dgvChiTIetLuongNV.DataSource = dbBangLuong.XemChiTietLuong(Thang, Nam, maNV);

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
           
        }
        int maNV = 0;
        private void btnXemLuong_Click(object sender, EventArgs e)
        {
            dgvBangLuong.DataSource = dbBangLuong.XemBangLuongThang(Int32.Parse(cbNhanVien2.Text.Substring(cbNhanVien2.Text.Length - 1)), Int32.Parse(txtNam2.Text));

        }

        private void lbTongLuongCacThang_Click(object sender, EventArgs e)
        {

        }

        private void lbTongLuongCacNam_Click(object sender, EventArgs e)
        {

        }

        private void dgvBangLuong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNam2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            new frmCapNhatHeSoLuong().ShowDialog();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            new frmChietLuongThangNV(maNV, Int32.Parse(cbNhanVien2.Text.Substring(cbNhanVien2.Text.Length - 1)), Int32.Parse(txtNam2.Text)).ShowDialog();
        }
    }
}
