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
    public partial class frmThueAoMoi : Form
    {
        public frmThueAoMoi()
        {
            InitializeComponent();
        }
        dbAoChoThue dbAoChoThue = new dbAoChoThue();
        private void gbTTCTTungHang_Enter(object sender, EventArgs e)
        {

        }

        private void rtxtGhChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvDSCTThoaMan.DataSource = dbAoChoThue.GetCTHDThueThoaMan(Convert.ToDateTime(dpChonNgayLayAo.Value.Date));
        }

        private void frmThueAoMoi_Load(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbAoChoThue.GetDSAoDeThue();
            lbMaHDBHSeThem.Text = dbAoChoThue.GetmaHDThueAoHienHanh().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbAoChoThue.GetDSAoDeThue();
            gbAnhAo.Enabled = false;gbDanhSachHangDaChon.Enabled = false;gbTTCTTungHang.Enabled = false;

        }
        int maAo = 0;byte[] anhAo;
        private void dgvKhoVai_Click(object sender, EventArgs e)
        {
            try
            {
             //   string srr = "";
                int index = dgvKhoVai.CurrentCell.RowIndex;
                maAo = Int32.Parse(dgvKhoVai.Rows[index].Cells["dsa_Id"].Value.ToString());// mã áo dc chọn
                btnChonVaiDeMua.Enabled = true;
                txtTienCoc.Text = dgvKhoVai.Rows[index].Cells["dsa_phiBanMacDinh"].Value.ToString();
                txtDonGia.Text = dgvKhoVai.Rows[index].Cells["dsa_donGia"].Value.ToString();
                nrSoLuong.Maximum = Convert.ToDecimal(dgvKhoVai.Rows[index].Cells["dsa_soLuong"].Value.ToString());
              //  pbAnhDaDienAoBan.Image = (System.Drawing.Image)dgvKhoVai.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                pbAnhAoChonMua.Image = (System.Drawing.Image)dgvKhoVai.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                MemoryStream ms = new MemoryStream();loai = 1;maCTHDCu = 0;
                gbTTCTTungHang.Enabled = true;gbAnhAo.Enabled = true;btnLoadAnh.Enabled = true;
                pbAnhAoChonMua.Image.Save(ms, pbAnhAoChonMua.Image.RawFormat);
                anhAo = ms.GetBuffer();
                ms.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
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
                 //   pbAnhAoChonMua.Image.Save(ms, pbAnhAoChonMua.Image.RawFormat);
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
        int loai = 0;
        private void btnChonVaiDeMua_Click(object sender, EventArgs e)
        {
            string er = "";
            rbLayNgayKhiThue.Enabled = false;
            rbLaySau.Enabled = false;
            
        
                if (rbLayNgayKhiThue.Checked == true)
                {
                    DateTime ngayHenlay = new DateTime();
                    ngayHenlay = DateTime.Now; DateTime ngaylay = new DateTime(); ngaylay = ngayHenlay;
                    if (dbAoChoThue.InsertChiTietHoaDonThueAo(ref er, Int32.Parse(lbMaHDBHSeThem.Text), maKH, Convert.ToDateTime(DateTime.Now), ngayHenlay, Convert.ToDateTime(dpChonNgayTraAo.Value),
                        rtxtGhChu.Text, maAo, anhAo, Int32.Parse(nrSoLuong.Value.ToString()), nrSoLuong.Value * Convert.ToDecimal(txtDonGia.Text),
                        nrSoLuong.Value * Convert.ToDecimal(txtTienCoc.Text), 0, Convert.ToDecimal(txtDonGia.Text), ngaylay,maCTHDCu,loai))
                    {
                        lbThanhTien.Text = (Convert.ToDecimal(txtTienCoc.Text) * nrSoLuong.Value + Convert.ToDecimal(lbThanhTien.Text)).ToString();
                        reset();
                        btnLoadAnh.Enabled = false; btnChonVaiDeMua.Enabled = true; btnThemHD.Enabled = true;
                        dgvDanhSachChonMua.DataSource = dbAoChoThue.GetCTHDThueAoTheoMaHD(Int32.Parse(lbMaHDBHSeThem.Text));
                        dgvKhoVai.DataSource = dbAoChoThue.GetDSAoDeThue();
                       dgvDSCTThoaMan.DataSource = dbAoChoThue.GetCTHDThueThoaMan(Convert.ToDateTime(dpChonNgayLayAo.Value.Date));
                         gbDanhSachHangDaChon.Enabled = true; btnDeleteCTHD.Enabled = false;
                    }

                }
                else
              if (rbLaySau.Checked == true)
                {
                    DateTime ngayHenlay = new DateTime();
                    ngayHenlay = Convert.ToDateTime(dpChonNgayLayAo.Value); DateTime ngaylay = new DateTime(); ngaylay = DateTime.Now;
                    if (dbAoChoThue.InsertChiTietHoaDonThueAo(ref er, Int32.Parse(lbMaHDBHSeThem.Text), maKH, Convert.ToDateTime(DateTime.Now), ngayHenlay, Convert.ToDateTime(dpChonNgayTraAo.Value),
                        rtxtGhChu.Text, maAo, anhAo, Int32.Parse(nrSoLuong.Value.ToString()), nrSoLuong.Value * Convert.ToDecimal(txtDonGia.Text),
                        nrSoLuong.Value * Convert.ToDecimal(txtTienCoc.Text), nrSoLuong.Value * Convert.ToDecimal(txtTienGiuCho.Text), Convert.ToDecimal(txtDonGia.Text), ngaylay,maCTHDCu,loai))
                    {
                        lbThanhTien.Text = (Convert.ToDecimal(txtTienGiuCho.Text) * nrSoLuong.Value + Convert.ToDecimal(lbThanhTien.Text)).ToString();
                        reset();
                        btnLoadAnh.Enabled = false; btnChonVaiDeMua.Enabled = true; btnThemHD.Enabled = true;
                        dgvDanhSachChonMua.DataSource = dbAoChoThue.GetCTHDThueAoTheoMaHD(Int32.Parse(lbMaHDBHSeThem.Text));
                       dgvDSCTThoaMan.DataSource = dbAoChoThue.GetCTHDThueThoaMan(Convert.ToDateTime(dpChonNgayLayAo.Value.Date));
                         dgvKhoVai.DataSource = dbAoChoThue.GetDSAoDeThue(); gbDanhSachHangDaChon.Enabled = true; btnDeleteCTHD.Enabled = false;
                    }
                }
    
   
        
        }
        private void reset()
        {
            maAo = 0;pbAnhAoChonMua.Image = null;
            txtDonGia.Text="0";txtTienCoc.Text = "0";txtTienGiuCho.Text = "0";
            nrSoLuong.Value = 1;
        }
        private void rbLayNgayKhiThue_CheckedChanged(object sender, EventArgs e)
        {
            dpChonNgayTraAo.Enabled = true;dpChonNgayLayAo.Enabled = false;
            txtTienGiuCho.Enabled = false;txtTienGiuCho.Text = "0";gbDanhSachAo.Enabled = true;
            dgvKhoVai.Enabled = true;
           
        }
        int maKH = 0;dbKhachHang dbKhachHang = new dbKhachHang();
        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            new frmKhachHang(6).ShowDialog();
            maKH = infoClass.getMaKH();
            btnChonKhachHang.Enabled = false;
            lbTenKH.Text = dbKhachHang.GetTenKHTheoMa(maKH);rbLaySau.Enabled = true;rbLayNgayKhiThue.Enabled = true;
            rbLayNgayKhiThue.Checked = false;rbLaySau.Checked = false;
        }

        private void rbLaySau_CheckedChanged(object sender, EventArgs e)
        {
            dpChonNgayLayAo.Enabled = true; dpChonNgayTraAo.Enabled = false;
            txtTienGiuCho.Enabled = true;  txtTienGiuCho.Text = "0";gbDanhSachAo.Enabled = true;
            dgvKhoVai.Enabled = true;
        }

        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            string er = "";
            if(dbAoChoThue.DeleteCTHDThueAo(ref er, maCTHDThue))
            {
                dgvDanhSachChonMua.DataSource = dbAoChoThue.GetCTHDThueAoTheoMaHD(Int32.Parse(lbMaHDBHSeThem.Text));
                dgvKhoVai.DataSource = dbAoChoThue.GetDSAoDeThue();
                dgvDSCTThoaMan.DataSource = dbAoChoThue.GetCTHDThueThoaMan(Convert.ToDateTime(dpChonNgayLayAo.Value.Date));
                btnDeleteCTHD.Enabled = false;
                if (rbLayNgayKhiThue.Checked == true)
                    lbThanhTien.Text = (Convert.ToDecimal(lbThanhTien.Text) - tienDAtCoc).ToString();
                if(rbLaySau.Checked==true)
                    lbThanhTien.Text = (Convert.ToDecimal(lbThanhTien.Text) - tienGiuCho).ToString();

            }
        }
        int maCTHDThue = 0;decimal tienGiuCho = 0;decimal tienDAtCoc = 0;
        private void dgvDanhSachChonMua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachChonMua.CurrentCell.RowIndex;
                btnDeleteCTHD.Enabled = true; btnChonVaiDeMua.Enabled = false; gbAnhAo.Enabled = false; gbTTCTTungHang.Enabled = false;
                //maAo = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["cthd_maAo"].Value.ToString());
                maCTHDThue = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["cthd_Id"].Value.ToString());
                //soLuong = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["cthd_soLuong"].Value.ToString());
                //tongPhiThue = Convert.ToDecimal(dgvDanhSachChonMua.Rows[index].Cells["cthd_tongTien"].Value.ToString());
                //tienDAtCoc = Convert.ToDecimal(dgvDanhSachChonMua.Rows[index].Cells["dthd_tienCoc"].Value.ToString());
                //tienGiuCho = Convert.ToDecimal(dgvDanhSachChonMua.Rows[index].Cells["cthd_tienGiuCho"].Value.ToString());
            }
            catch(Exception ex) {
                MessageBox.Show(ex.ToString());            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hoàn tất thuê áo!!", "Thuê áo");
            if (rbLayNgayKhiThue.Checked == true)
            {
                if (MessageBox.Show("Xuất hóa đơn nhận hàng?", "Xuất hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ReportDemo(Int32.Parse(lbMaHDBHSeThem.Text), lbTenKH.Text,dpChonNgayTraAo.Value.Date, DateTime.Now.Date).ShowDialog();
                   
                }
            }
            reset();
            gbAnhAo.Enabled = false;gbTTCTTungHang.Enabled = false;
            maKH = 0;gbDanhSachAo.Enabled = false;dgvKhoVai.Enabled = false;
            lbTenKH.Text = "...";txTienKhachDua.Text = "0";lbTienThoi.Text = "0";
            lbThanhTien.Text = "0";btnChonVaiDeMua.Enabled = false;btnThemHD.Enabled = false;
            btnChonKhachHang.Enabled = true;rbLayNgayKhiThue.Enabled = true;rbLaySau.Enabled = true;
            rbLayNgayKhiThue.Checked = false;rbLaySau.Checked = false;
            lbMaHDBHSeThem.Text = dbAoChoThue.GetmaHDThueAoHienHanh().ToString();
        }

        private void txTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienThoi.Text= (Convert.ToDecimal(txTienKhachDua.Text) -Convert.ToDecimal( lbThanhTien.Text)).ToString();
                
            }
            catch (Exception)
            {
                lbTienThoi.Text = "";
            }
        }
        int maCTHDCu = 0;
        private void dgvDSCTThoaMan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSCTThoaMan.CurrentCell.RowIndex;
                maAo = Int32.Parse(dgvDSCTThoaMan.Rows[index].Cells["DSCT_maAo"].Value.ToString());// mã áo dc chọn
                btnChonVaiDeMua.Enabled = true;
                txtTienCoc.Text = dgvDSCTThoaMan.Rows[index].Cells["DSCT_phiBan"].Value.ToString();
                txtDonGia.Text = dgvDSCTThoaMan.Rows[index].Cells["DSCT_donGia"].Value.ToString();
                maCTHDCu = Int32.Parse(dgvDSCTThoaMan.Rows[index].Cells["DSCT_Id"].Value.ToString());
                nrSoLuong.Maximum = Convert.ToDecimal(dgvDSCTThoaMan.Rows[index].Cells["DSCT_soLuongConLai"].Value.ToString());
                //  pbAnhDaDienAoBan.Image = (System.Drawing.Image)dgvDSCTThoaMan.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                pbAnhAoChonMua.Image = (System.Drawing.Image)dgvDSCTThoaMan.Rows[index].Cells["DSCT_anhDaiDien"].FormattedValue;
                MemoryStream ms = new MemoryStream();loai = 2;
                gbTTCTTungHang.Enabled = true; gbAnhAo.Enabled = true; btnLoadAnh.Enabled = true;
                pbAnhAoChonMua.Image.Save(ms, pbAnhAoChonMua.Image.RawFormat);
                anhAo = ms.GetBuffer();
                ms.Close();
            }
            catch (Exception)
            {

            }
        }

        private void txtTimKiemAo_TextChanged(object sender, EventArgs e)
        {
            dgvDSCTThoaMan.DataSource = dbAoChoThue.TimDSCTHDThueConlaiTheoTenhang(Convert.ToDateTime(dpChonNgayLayAo.Value.Date), txtTimKiemAo.Text);
            dgvKhoVai.DataSource = dbAoChoThue.TimAoTrongKhoTheoTenHang(txtTimKiemAo.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void txtTienGiuCho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
