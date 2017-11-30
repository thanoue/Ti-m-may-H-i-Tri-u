using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;

namespace TiemMayHaiTrieu
{
    public partial class frmDanhSachHoaDonMayAo : Form
    {
        public frmDanhSachHoaDonMayAo()
        {
            InitializeComponent();
        }
        dbAoDaDuocNhan dbAoDaDuocNhan = new dbAoDaDuocNhan();
        int maKH = 0;
        private void frmDanhSachHoaDonMayAo_Load(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            try {
                dgvDSHD.DataSource = dbAoDaDuocNhan.GetHDMayAoTheoNam(Int32.Parse(txtNam.Text), maKH);

            }
            catch (Exception) { }

        }
        dbKhachHang dbKhachHang = new dbKhachHang();
        private void btnChonKH_Click(object sender, EventArgs e)
        {
            new frmKhachHang(7).ShowDialog();
            maKH = infoClass.getMaKH();
            lbTenKH.Text = dbKhachHang.GetTenKHTheoMa(maKH);
        }
        int maHD = 0;
        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentCell.RowIndex;
                maHD = Int32.Parse(dgvDSHD.Rows[index].Cells["dshd_Id"].Value.ToString());
                rtxtSoDo.Text = dgvDSHD.Rows[index].Cells["dshd_soDoDaiDien"].Value.ToString();
                pbAnhDaiDienHD.Image = (System.Drawing.Image)dgvDSHD.Rows[index].Cells["dshd_anhDaiDien"].FormattedValue;
                lbTongPhiMay.Text= dgvDSHD.Rows[index].Cells["dshd_tongPhiMay"].Value.ToString();
                dgvDanhSachAo.DataSource = dbAoDaDuocNhan.GetAoDuocMayTheoMaHD_LuuTru(maHD);
                dgvDanhSachQuan.DataSource = dbAoDaDuocNhan.GetQuanDuocMayTheoMaHD_LuuTru(maHD);
                maKH = Int32.Parse(dgvDSHD.Rows[index].Cells["dshd_maKH"].Value.ToString());

            }
            catch (Exception) { }
        }

        private void lbTongPhiMay_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSHD.DataSource = dbAoDaDuocNhan.TimHDMayAoTheoMaHD_LuuTru(Int32.Parse(txtMaHD.Text));
            }
            catch (Exception) { }
          
        }
        dbChamCongTho dbChamCongTho = new dbChamCongTho();
        private void dgvDanhSachAo_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachAo.CurrentCell.RowIndex;
                pbAnhAo.Image = (System.Drawing.Image)dgvDanhSachAo.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                string maAo = dgvDanhSachAo.Rows[index].Cells["dsa_Id"].Value.ToString();
                lbTenThoCat.Text = dbChamCongTho.GetTenThoCat(maAo);lbTenThoMay.Text = dbChamCongTho.GetTenThoMay(maAo);
                lbTenThoLuong.Text = dbChamCongTho.GetTenThoLuong(maAo);lbCongCat.Text = dbChamCongTho.GetCongThoCat(maAo);
                lbCongMay.Text = dbChamCongTho.GetCongThoMay(maAo);lbCongLuong.Text = dbChamCongTho.GetCongThoLuong(maAo);
            }
            catch (Exception) { }
        }

        private void dgvDanhSachQuan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachQuan.CurrentCell.RowIndex;
                pbAnhQuan.Image = (System.Drawing.Image)dgvDanhSachQuan.Rows[index].Cells["dsq_anhDaiDien"].FormattedValue;
                string maQuan= dgvDanhSachQuan.Rows[index].Cells["dsq_Id"].Value.ToString();
                lbTenthoCatQuan.Text = dbChamCongTho.GettenThoCatQuan(maQuan);lbTenThoMayQuan.Text = dbChamCongTho.GettenThoMayQuan(maQuan);
                lbCongCatQuan.Text = dbChamCongTho.GetCongThoCatQuan(maQuan);lbCongMayQuan.Text = dbChamCongTho.GetCongThoMayQuan(maQuan);
            }
            catch (Exception) { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thêm áo mới từ số đo này ?","Thêm áo mới", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                infoClass.setSoDo(rtxtSoDo.Text);
                infoClass.setmaKH(maKH);
                this.Close();
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            try
            {
                dgvDSHD.DataSource = dbAoDaDuocNhan.TimHDMayAoTheoSDTKhachHang_LuuTru(txtSDT.Text);
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa hóa đơn này? Thao tác không thể hoàn lại", "Xóa hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er="";
                if (dbAoDaDuocNhan.XoaHoaDon(ref er,maHD))
                {
                    MessageBox.Show("Xóa thành công một hóa đơn!!");
                    dgvDSHD.DataSource = dbAoDaDuocNhan.TimHDMayAoTheoSDTKhachHang_LuuTru(txtSDT.Text);
                }
            }
        }
    }
}
