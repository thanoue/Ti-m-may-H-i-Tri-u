using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;
using System.IO;

namespace TiemMayHaiTrieu
{
    public partial class frmBanAo : Form
    {
        public frmBanAo()
        {
            InitializeComponent();
        }
        dbAoChoThue dbAoChoThue = new dbAoChoThue();
        private void frmBanAo_Load(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAoTrongKho();
            lbMaHDBHSeThem.Text = dbAoChoThue.GetMaHDBanAoHienHanh().ToString();
            gbTTCTTungHang.Enabled = false; gbAnhAo.Enabled = false; btnChonVaiDeMua.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gbTTCTTungHang_Enter(object sender, EventArgs e)
        {

        }
        dbKhachHang dbKhachHang = new dbKhachHang();
        private void button2_Click(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAoTrongKho();
            gbTTCTTungHang.Enabled = false;gbAnhAo.Enabled = false;btnChonVaiDeMua.Enabled = false;
            
        }
        int maKH = 0;
        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            new frmKhachHang(5).ShowDialog();
            maKH = infoClass.getMaKH();
            lbTenKH.Text = dbKhachHang.GetTenKHTheoMa(maKH);
            gbKhoAo.Enabled = true;
        }
        byte[] anhAo;int maAoDuocChon = 0;
        private void dgvKhoVai_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhoVai.CurrentCell.RowIndex;
                pbAnhDaDienAoBan.Image = (System.Drawing.Image)dgvKhoVai.Rows[index].Cells["kv_anhDaiDien"].FormattedValue;
                maAoDuocChon = Int32.Parse(dgvKhoVai.Rows[index].Cells["kv_Id"].Value.ToString());
                txtDonGia.Text = dgvKhoVai.Rows[index].Cells["kv_donGia"].Value.ToString();
                nudSoLuong.Maximum = Convert.ToDecimal(dgvKhoVai.Rows[index].Cells["kv_soLuong"].Value.ToString());
                MemoryStream ms = new MemoryStream();
                pbAnhDaDienAoBan.Image.Save(ms, pbAnhDaDienAoBan.Image.RawFormat);
                pbAnhAoChonMua.Image = pbAnhDaDienAoBan.Image;
                anhAo = ms.GetBuffer();
                ms.Close();gbTTCTTungHang.Enabled = true;gbAnhAo.Enabled = true;
                btnChonVaiDeMua.Enabled = true;btnLoadAnh.Enabled = true;
            }
            catch (Exception)
            {

            }
        }



        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.AddExtension = true;
            ofdImages.CheckFileExists = true;
            //  ofdImages.Filter = "Image file (*.JPG;*.NPG;*JEPG)|*.JPG;*.NPG;*JEPG";
            ofdImages.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            ofdImages.InitialDirectory = @"Desktop";
            ofdImages.Multiselect = false;
            ofdImages.RestoreDirectory = true;
            ofdImages.Title = "Chọn hình cho áo cần may...";
            string filePathVaiQuan = "";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filePathVaiQuan = ofdImages.FileName;

                try
                {

                    pbAnhAoChonMua.Image = Image.FromFile(filePathVaiQuan.ToString());

                    //      string sourceFile = Path.Combine(sourcePath, fileName);

                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhAoChonMua.Image);
                   // pbAnhAoChonMua.Image.Save(ms, pbAnhAoChonMua.Image.RawFormat);
                    anhAo = ms.GetBuffer();
                    ms.Close();
                    //     File.Delete();

                }
                catch (Exception)
                {
                    // ex.Message.ToString();
                }
            }
        }

        private void btnChonVaiDeMua_Click(object sender, EventArgs e)
        {
            gbDanhSachHangDaChon.Enabled = true;
            gbTinhTien.Enabled = true;
            gbTTCTTungHang.Enabled = false; gbAnhAo.Enabled = false;
            try
            {
                string err = "";
                if (dbAoChoThue.InsertChiTietHoaDon(ref err, Int32.Parse(lbMaHDBHSeThem.Text), maKH, rtxtGhChu.Text, Convert.ToDateTime(dateTimePicker1.Value), maAoDuocChon, Int32.Parse(nudSoLuong.Value.ToString()),
                        Convert.ToDecimal(txtDonGia.Text), Convert.ToDecimal(lbTong.Text), anhAo))
                {
                    lbThanhTien.Text = (Convert.ToDecimal(lbTong.Text) + Convert.ToDecimal(lbThanhTien.Text)).ToString();
                    txtDonGia.Text = "0"; lbTong.Text = "000";
                    pbAnhAoChonMua.Image = null;
                    dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAoTrongKho();
                    btnChonVaiDeMua.Enabled = false;
                    btnThemHD.Enabled = true;gbAnhAo.Enabled = false;
                    btnDeleteCTHD.Enabled = false;
                    dgvDanhSachChonMua.DataSource = dbAoChoThue.GetDSCTHDBanAoTheoMaHD(Int32.Parse(lbMaHDBHSeThem.Text));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!!!");
            }
        }
        int maAoBan = 0;int maCTHD = 0;int soLuong = 0;decimal tongTien = 0;
        private void dgvDanhSachChonMua_Click(object sender, EventArgs e)
        {
            int index = dgvDanhSachChonMua.CurrentCell.RowIndex;btnDeleteCTHD.Enabled = true;
            maAoBan = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["cthd_maAoBan"].Value.ToString());
            maCTHD = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["cthd_Id"].Value.ToString());
            soLuong = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["cthd_soLuong"].Value.ToString());
            tongTien = Convert.ToDecimal(dgvDanhSachChonMua.Rows[index].Cells["cthd_tongTien"].Value.ToString());
        }

        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            string er = "";
            if(dbAoChoThue.DeleteCTHDBanAo(ref er, maCTHD, soLuong, maAoBan))
            {
                lbThanhTien.Text = (Convert.ToDecimal(lbThanhTien.Text) - tongTien).ToString();
                dgvDanhSachChonMua.DataSource = dbAoChoThue.GetDSCTHDBanAoTheoMaHD(Int32.Parse(lbMaHDBHSeThem.Text));
                dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAoTrongKho();
                maAoBan = 0;maCTHD = 0;soLuong = 0;tongTien = 0; btnDeleteCTHD.Enabled = false;btnChonVaiDeMua.Enabled = false;
                gbAnhAo.Enabled = false;gbTTCTTungHang.Enabled = false;
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hoàn tất bán áo ?", "Bán áo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if (dbAoChoThue.HoanTatMua(ref err, Int32.Parse(lbMaHDBHSeThem.Text), Convert.ToDecimal(lbThanhTien.Text)))
                {
                    dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAoTrongKho();
                    if(MessageBox.Show("Xuất hóa đơn bán hàng?","Xuất hóa đơn",MessageBoxButtons.YesNo)==DialogResult.Yes){
                        new ReportDemo(Int32.Parse(lbMaHDBHSeThem.Text), lbTenKH.Text).ShowDialog();
                    }
                    lbMaHDBHSeThem.Text = dbAoChoThue.GetMaHDBanAoHienHanh().ToString();
                    dgvDanhSachChonMua.DataSource = dbAoChoThue.GetDSCTHDBanAoTheoMaHD(0) ;
                    pbAnhDaDienAoBan.Image = null; pbAnhAoChonMua.Image = null; maKH = 0; lbTenKH.Text = "...";
                    txTienKhachDua.Text = "0"; rtxtGhChu.Text = ""; lbThanhTien.Text = "000";
                    btnThemHD.Enabled = false;
                    lbTienThoi.Text = "0";
                    MessageBox.Show("Hoàn tất bán hàng!!");
                    gbDanhSachHangDaChon.Enabled = false;gbTTCTTungHang.Enabled = false;gbAnhAo.Enabled = false;
                    btnChonVaiDeMua.Enabled = false;
                    infoClass.setmaKH(0); btnDeleteCTHD.Enabled = false;
                }
            }
        }

        private void txTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try {
                lbTienThoi.Text = (Convert.ToDecimal(txTienKhachDua.Text) - Convert.ToDecimal(lbThanhTien.Text)).ToString();
            }
            catch (Exception)
            {
                lbTienThoi.Text = "0";
            }
          
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTong.Text = (Convert.ToDecimal(txtDonGia.Text) * nudSoLuong.Value).ToString();

            }
            catch (Exception)
            {
                lbTong.Text = "";
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbTong.Text = (Convert.ToDecimal(txtDonGia.Text) * nudSoLuong.Value).ToString();

            }
            catch (Exception)
            {
                lbTong.Text = "";
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
