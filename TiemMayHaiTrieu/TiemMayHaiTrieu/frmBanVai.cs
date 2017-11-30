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
    public partial class frmBanVai : Form
    {
        public frmBanVai()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTong.Text = (Convert.ToDecimal(txtDonGia.Text) * nudSoLuong.Value).ToString();

            }
            catch (Exception)
            {
                lbTong.Text = "0";
            }

        }

        private void dgvKhoVai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hoàn tất bán vải ?", "bán vải ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbBanVai.HoanTatMua(ref err,Int32.Parse(lbMaHDBHSeThem.Text),Convert.ToDecimal(lbThanhTien.Text)))
                {
                    dgvKhoVai.DataSource = dbBanVai.GetDanhSachVaiDeChonMua();
                    lbMaHDBHSeThem.Text =dbBanVai.GetMaHoaDonBanHangHienHanh().ToString();
                    dgvDanhSachChonMua.DataSource = dbBanVai.GetCTHDTheoHD(0);
                    pbAnhDaDienLoaiVai.Image = null; pbAnhVai.Image = null; maKH = 0; lbTenKH.Text = "...";
                    txTienKhachDua.Text = "0";rtxtGhChu.Text = "";lbThanhTien.Text = "000";
                    btnThemHD.Enabled = false;
                    lbTienThoi.Text = "0";
                         MessageBox.Show("Hoàn tất bán hàng!!");
                    gbDanhSachHangDaChon.Enabled = false;groupBox1.Enabled = false;
                    infoClass.setmaKH(0);btnDeleteCTHD.Enabled = false;
                    if (MessageBox.Show("Xuất hóa đơn?", "Xuất hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new ReportDemo(Int32.Parse(lbMaHDBHSeThem.Text) - 1).ShowDialog();
                    }
                   
                }
            }
        }
        int maKH = 0;dbKhachHang dbKH = new dbKhachHang();
        private void btnChonKhachHang_Click(object sender, EventArgs e)
        {
            new frmKhachHang(2).ShowDialog();
            maKH = infoClass.getMaKH();
            lbTenKH.Text = dbKH.GetTenKHTheoMa(maKH);btnThemHD.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void frmBanVai_Load(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbBanVai.GetDanhSachVaiDeChonMua();
            lbMaHDBHSeThem.Text = dbBanVai.GetMaHoaDonBanHangHienHanh().ToString();
            dgvDanhSachChonMua.EnableHeadersVisualStyles = false;
            dgvDanhSachChonMua.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray ;
            groupBox1.Enabled = false;

        }
        dbBanVai dbBanVai = new dbBanVai();
        private void button2_Click(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbBanVai.GetDanhSachVaiDeChonMua();btnChonVaiDeMua.Enabled = false;
        }

        private void txtTimKiemAo_Click(object sender, EventArgs e)
        {
            txtTimKiemAo.Text = "";
        }

        private void txtTimKiemAo_TextChanged(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbBanVai.TimVaiDeChonTheoTenVai(txtTimKiemAo.Text);
        }
        int maVaiTrongKhoDeChonMua = 0;string anhLoaiVaiDeChonMua = "";byte[] anhVai;
        private void dgvKhoVai_Click(object sender, EventArgs e)
        {
            int index = dgvKhoVai.CurrentCell.RowIndex;
            try {
                maVaiTrongKhoDeChonMua = Int32.Parse(dgvKhoVai.Rows[index].Cells["kv_Id"].Value.ToString());
               
                btnLoadAnh.Enabled = true;
                btnChonVaiDeMua.Enabled = true; lbTong.Text = "0"; lbTienThoi.Text = "0"; txTienKhachDua.Text = "0";
                pbAnhDaDienLoaiVai.Image = (System.Drawing.Image)dgvKhoVai.Rows[index].Cells["kv_anhDaiDien"].FormattedValue;
                nudSoLuong.Maximum = Convert.ToDecimal(dgvKhoVai.Rows[index].Cells["kv_soLuong"].Value.ToString());
                pbAnhVai.Image = pbAnhDaDienLoaiVai.Image;
                MemoryStream ms = new MemoryStream();
                pbAnhVai.Image.Save(ms, pbAnhVai.Image.RawFormat);
                anhVai = ms.GetBuffer();
                ms.Close();
                pbAnhVai.Image = pbAnhDaDienLoaiVai.Image;
                groupBox2.Enabled = true; gbTTCTTungHang.Enabled = true;
            }
            catch (Exception) { }
            

        }

        private void btnChonVaiDeMua_Click(object sender, EventArgs e)
        {
            gbDanhSachHangDaChon.Enabled = true;
            gbTinhTien.Enabled = true;
            gbTTCTTungHang.Enabled = false;groupBox2.Enabled = false;
            try
            {
                string err = "";
                if(dbBanVai.InsertChiTietHoaDon(ref err,Int32.Parse(lbMaHDBHSeThem.Text),infoClass.getMaKH(),rtxtGhChu.Text,Convert.ToDateTime(dateTimePicker1.Value),maVaiTrongKhoDeChonMua,Int32.Parse(nudSoLuong.Value.ToString()),
                        Convert.ToDecimal(txtDonGia.Text),Convert.ToDecimal(lbTong.Text),anhVai))
                {
                    lbThanhTien.Text = (Convert.ToDecimal(lbTong.Text) + Convert.ToDecimal(lbThanhTien.Text)).ToString();
                    txtDonGia.Text = "0";lbTong.Text = "000";
                    pbAnhVai.Image = null;
                    dgvKhoVai.DataSource = dbBanVai.GetDanhSachVaiDeChonMua();
                    btnChonVaiDeMua.Enabled = false;
                    btnThemHD.Enabled = true;
                    btnDeleteCTHD.Enabled = false;
                    dgvDanhSachChonMua.DataSource = dbBanVai.GetCTHDTheoHD(Int32.Parse(lbMaHDBHSeThem.Text));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ!!!");
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofdImages = new OpenFileDialog();
            string fileName = "";
            ofdImages.AddExtension = true;
            ofdImages.CheckFileExists = true;
            //  ofdImages.Filter = "Image file (*.JPG;*.NPG;*JEPG)|*.JPG;*.NPG;*JEPG";
            ofdImages.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            ofdImages.InitialDirectory = @"C:\";
            ofdImages.Multiselect = false;
            ofdImages.RestoreDirectory = true;
            ofdImages.Title = "Chọn ảnh mới cho vải bán ...";
            string filePathVaiAo = "";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filePathVaiAo = ofdImages.FileName;
                int temp = filePathVaiAo.LastIndexOf(@"\");
                fileName = filePathVaiAo.Substring(temp + 1);
                try
                {
                    pbAnhVai.Image = Image.FromFile(filePathVaiAo.ToString());

                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhVai.Image);
                    //pbAnhVai.Image.Save(ms, pbAnhVai.Image.RawFormat);
                    anhVai = ms.GetBuffer();
                    ms.Close();
                    //      string sourceFile = Path.Combine(sourcePath, fileName);
                    //anhVai = Path.Combine(targetPath, fileName);
                    //string dich = Path.Combine(Application.StartupPath, anhVai);
                    ////////////////////////////////
                    //File.Copy(sourcePath, dich, true);

                }
                catch (Exception ex)
                {
                    // ex.Message.ToString();
                }
            }
        }
        int maCTHD = 0; int soLuong = 0;int maVai = 0; decimal tongTienTrenTungMathang = 0;
        private void dgvDanhSachChonMua_Click(object sender, EventArgs e)
        {
            int index = dgvDanhSachChonMua.CurrentCell.RowIndex;
            try
            {
                btnDeleteCTHD.Enabled = true;
                maCTHD = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["ds_Id"].Value.ToString());
                soLuong = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["ds_soLuong"].Value.ToString());
                maVai = Int32.Parse(dgvDanhSachChonMua.Rows[index].Cells["ds_maVai"].Value.ToString());
                tongTienTrenTungMathang = Convert.ToDecimal(dgvDanhSachChonMua.Rows[index].Cells["ds_tongTien"].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string err = "";
                if (dbBanVai.DeleteCTHD(ref err, maCTHD, soLuong,maVai))
                {
                    dgvDanhSachChonMua.DataSource = dbBanVai.GetCTHDTheoHD(Int32.Parse(lbMaHDBHSeThem.Text));
                    dgvKhoVai.DataSource = dbBanVai.GetDanhSachVaiDeChonMua();
                    lbThanhTien.Text =  (Convert.ToDecimal(lbThanhTien.Text) - tongTienTrenTungMathang).ToString();
                    btnDeleteCTHD.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        private void txTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienThoi.Text = (Convert.ToDecimal(txTienKhachDua.Text) - Convert.ToDecimal(lbThanhTien.Text)).ToString();

            }
            catch (Exception)
            {
                lbTienThoi.Text = "0";
            }

        }

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbTong.Text = (Convert.ToDecimal(txtDonGia.Text) * nudSoLuong.Value).ToString();

            }
            catch (Exception)
            {
                lbTong.Text = "0";
            }
        }
    }
}
