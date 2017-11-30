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
using System.Threading;


namespace TiemMayHaiTrieu
{
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
         //  Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi-VN");
            InitializeComponent();
        }
        dbHangDat dbhangDat = new dbHangDat();dbKhachHang dbKhachHang = new dbKhachHang();
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            
            lbMaHDatHang.Text = dbhangDat.GetMaHDDatHangHienHanh();
           // b//tnXacNhanXong.Enabled = true;
			dgvDanhSachHangDat.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
			dgvDanhSachHangDat.EnableHeadersVisualStyles = false;
		}

        private void btnReload_Click(object sender, EventArgs e)
        {
           

        }

     

        private void dgvDanhSachHangDat_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachHangDat.CurrentCell.RowIndex;
             //   maKH = Int32.Parse(dgvDanhSachHangDat.Rows[index].Cells["maKhachHang"].Value.ToString());
             maCTHD = Int32.Parse(dgvDanhSachHangDat.Rows[index].Cells["Id"].Value.ToString());
                btnXoaCTHD.Enabled = true;
                tongTien = Convert.ToDecimal(dgvDanhSachHangDat.Rows[index].Cells["tienCoc"].Value.ToString());
                txtTenHang.Text = dgvDanhSachHangDat.Rows[index].Cells["tenHang"].Value.ToString();
                rtxtChiTiet.Text = dgvDanhSachHangDat.Rows[index].Cells["chiTiet"].Value.ToString();
                nudSoLuong.Value = Convert.ToDecimal(dgvDanhSachHangDat.Rows[index].Cells["soLuong"].Value.ToString());
                txtTienCoc.Text = (Convert.ToDecimal(dgvDanhSachHangDat.Rows[index].Cells["tienCoc"].Value.ToString()) / nudSoLuong.Value).ToString();
                txtGiaTien.Text = (Convert.ToDecimal(dgvDanhSachHangDat.Rows[index].Cells["giaTien"].Value.ToString()) / nudSoLuong.Value).ToString();
                lbTienConlai.Text = (Convert.ToDecimal(dgvDanhSachHangDat.Rows[index].Cells["tienConLai"].Value.ToString())).ToString();
            }
            catch (Exception )
            {

            }
        }
        int maCTHD = 0;decimal tongTien = 0;
   
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            new frmHangCholay().ShowDialog();
        }

        private void gbDSDatHang_Enter(object sender, EventArgs e)
        {

        }
        int maKHDatHang = 0;
        private void btnChonKH_Click(object sender, EventArgs e)
        {
            new frmKhachHang(3).ShowDialog();
            maKHDatHang = infoClass.getMaKH();btnThemHang.Enabled = true;
            lbTenKhachHang.Text = dbKhachHang.GetTenKHTheoMa(maKHDatHang);
            
        }
        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
        void reset()
        {
            rtxtChiTiet.Text = "";txtGiaTien.Text = "0";txtTenHang.Text = "";txtTienCoc.Text = "0";nudSoLuong.Value = 0;

           
        }
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            string er = "";
            if(dbhangDat.InsertCTHDDatHang(ref er,Int32.Parse(lbMaHDatHang.Text),maKHDatHang,txtTenHang.Text,rtxtChiTiet.Text,Int32.Parse(nudSoLuong.Value.ToString()),Convert.ToDecimal(txtGiaTien.Text)*nudSoLuong.Value, Convert.ToDecimal(txtTienCoc.Text) * nudSoLuong.Value,Convert.ToDecimal(lbTienConlai.Text),
                Convert.ToDateTime(dtpNgayHenLay.Value.Date), DateTime.Now.Date, rtxtGhiChu.Text))
            {
                dgvDanhSachHangDat.DataSource = dbhangDat.GetDSCTHDTheoMaHD(Int32.Parse(lbMaHDatHang.Text));
                lbThanhTien.Text = (Convert.ToDecimal(lbThanhTien.Text) + Convert.ToDecimal(txtTienCoc.Text) * nudSoLuong.Value).ToString();
                reset();
                btnThemHoaDon.Enabled = true;

            }
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            string er = "";
            if (dbhangDat.DeleteCTHDDatHang(ref er, maCTHD))
            {
                dgvDanhSachHangDat.DataSource = dbhangDat.GetDSCTHDTheoMaHD(Int32.Parse(lbMaHDatHang.Text));
                lbThanhTien.Text = (Convert.ToDecimal(lbThanhTien.Text)-tongTien).ToString();
            }
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hoàn tất đặt hàng?","Đặt hàng xong", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Xuất hóa đơn?", "Xuất hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ReportDemo(Int32.Parse(lbMaHDatHang.Text), lbTenKhachHang.Text, dtpNgayHenLay.Value.ToShortDateString()).ShowDialog();
                }
                lbMaHDatHang.Text = dbhangDat.GetMaHDDatHangHienHanh();
                dgvDanhSachHangDat.DataSource = dbhangDat.GetDSCTHDTheoMaHD(0);
                lbThanhTien.Text = "000";
                lbMaHDatHang.Text = dbhangDat.GetMaHDDatHangHienHanh();
                lbTienThoi.Text = "00";
                btnXoaCTHD.Enabled = false;btnThemHang.Enabled = false;
                txTienKhachDua.Text = "000";
            }
        }

        private void txTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienThoi.Text = (Convert.ToDecimal(txTienKhachDua.Text) - Convert.ToDecimal(lbThanhTien.Text)).ToString();
            }
            catch(Exception) { }
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            try {
                lbTienConlai.Text = (Convert.ToDecimal(txtGiaTien.Text) * nudSoLuong.Value - Convert.ToDecimal(txtTienCoc.Text) * nudSoLuong.Value).ToString();
            }
            catch (Exception) { }
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienConlai.Text = (Convert.ToDecimal(txtGiaTien.Text) * nudSoLuong.Value - Convert.ToDecimal(txtTienCoc.Text) * nudSoLuong.Value).ToString();
            }
            catch (Exception) { }
        }
    }
}
