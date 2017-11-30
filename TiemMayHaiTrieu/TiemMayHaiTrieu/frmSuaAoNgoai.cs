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
    public partial class frmSuaAoNgoai : Form
    {
        public frmSuaAoNgoai()
        {
            InitializeComponent();
        }
		dbKhachHang dbKhachHang = new dbKhachHang(); dbNhanVien dbNhanVien = new dbNhanVien();
		dbSuaNgoai dbSuaNgoai = new dbSuaNgoai();
		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void frmSuaAoNgoai_Load(object sender, EventArgs e)
		{
			dgvAoDangSua.Visible = true;
			dgvAoDangChoThu.Visible = false;
			dgvAoDaNhan.Visible = false ;
			cbNhanVienSua.DataSource = dbNhanVien.GetNhanVien();
			cbNhanVienSua.DisplayMember = "tenNhanVien";cbNhanVienSua.ValueMember = "Id";
            gbNhapCongSua.Enabled = false;
            resetInfo();def();
		}
		int maKHThem = 0;
        void def()
        {

            MemoryStream ms = new MemoryStream();
            Properties.Resources.load_image.Save(ms, Properties.Resources.load_image.RawFormat);
            destAnh = ms.GetBuffer();
            ms.Close();
        }
		private void btnChonKhachHang_Click(object sender, EventArgs e)
		{
			new frmKhachHang(4).ShowDialog();
			maKHThem = infoClass.getMaKH();
			lbTenKhachHang.Text = dbKhachHang.GetTenKHTheoMa(maKHThem);
		}
		byte[] destAnh ;int daCoAnhVaiAo = 0;
		private void btnChonAnh_Click(object sender, EventArgs e)
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
			ofdImages.Title = "Chọn hình cho áo cần may...";
			string filePathVaiAo = "";
			if (ofdImages.ShowDialog() == DialogResult.OK)
			{
				filePathVaiAo = ofdImages.FileName;
				int temp = filePathVaiAo.LastIndexOf(@"\");
				fileName = filePathVaiAo.Substring(temp + 1);
				try
				{
					
					pbAnhDaiDien.Image = Image.FromFile(filePathVaiAo.ToString());
                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhDaiDien.Image);
                   // pbAnhDaiDien.Image.Save(ms, pbAnhDaiDien.Image.RawFormat);
                    destAnh = ms.GetBuffer();
                    ms.Close();
                
					
					////      string sourceFile = Path.Combine(sourcePath, fileName);
					//destAnh = Path.Combine(targetPath, fileName);
					//string dich = Path.Combine(Application.StartupPath, destAnh);
					//File.Copy(sourcePath, dich, true);

				}
				catch (Exception ex)
				{
					 ex.Message.ToString();
				}
			}
			//    MessageBox.Show(d
		}
        int maKH = 0;
        private void resetInfo()
        {
            maKHThem = 0; pbAnhDaiDien.Image = null;
            cbNhanVienSua.DataSource = dbNhanVien.GetNhanVien();maKH = 0;
            cbNhanVienSua.DisplayMember = "tenNhanVien"; cbNhanVienSua.ValueMember = "Id";
            btnChonAnh.Enabled = true;btnChonKhachHang.Enabled = true;txtNoiDungSua.Enabled = true;
            rtxtChiTietSua.Enabled = true;dtpNgayHenThu.Enabled = true;cbNhanVienSua.Enabled = true;
            txtCongSua.Text = "";txtNoiDungSua.Text = "";dtpNgayHenThu.Value = DateTime.Today;
            rtxtChiTietSua.Text = "";lbTenKhachHang.Text = "";gbAoDaNhan.Enabled = false;gbNhapCongSua.Enabled = false;gbThongTinSua.Enabled = false;
        }
        int inputed = 0;
		private void button1_Click(object sender, EventArgs e)
		{
            if (inputed==0)
            {
                resetInfo();
                inputed = 1;
                gbThongTinSua.Enabled = true;
            }
            else
            {
                if (MessageBox.Show("Sửa áo này ?", "Sửa áo ngoài", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string err = "";
                    if (dbSuaNgoai.YeuCauSua(ref err, destAnh, Convert.ToDateTime(dtpNgayHenThu.Value), txtNoiDungSua.Text, rtxtChiTietSua.Text,maKHThem, Int32.Parse(cbNhanVienSua.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Yêu cầu sửa thành công một áo!!");
                        inputed = 0;
                        def();
                        pbAnhDaiDien.Image = null;
                        lbTenKhachHang.Text = "...."; maKH = 0;
                        gbThongTinSua.Enabled = false;
                        txtNoiDungSua.Text = ""; rtxtChiTietSua.Text = "";
                        dgvAoDangSua.Visible = true; dgvAoDangSua.DataSource = dbSuaNgoai.GetDSAoDangSua();
                        dgvAoDaNhan.Visible = false; dgvAoDangChoThu.Visible = false;
                    }
                }

            }

        }
        int maSua = 0;int maNV = 0;
        private void dgvAoDangSua_Click(object sender, EventArgs e)
        {
            string anhVai = "";
            try
            {
                int index = dgvAoDangSua.CurrentCell.RowIndex;
                maSua = Int32.Parse(dgvAoDangSua.Rows[index].Cells["CS_maSua"].Value.ToString());
                lbTenKhachHang.Text = dgvAoDangSua.Rows[index].Cells["CS_tenKhachHang"].Value.ToString();
                maKH = Int32.Parse(dgvAoDangSua.Rows[index].Cells["CS_maKhachHang"].Value.ToString());
                dtpNgayHenThu.Value = Convert.ToDateTime(dgvAoDangSua.Rows[index].Cells["CS_ngayHenThu"].Value);
                cbNhanVienSua.Text = dgvAoDangSua.Rows[index].Cells["CS_tenNhanVien"].Value.ToString();
                txtNoiDungSua.Text = dgvAoDangSua.Rows[index].Cells["CS_noiDungSua"].Value.ToString();
                rtxtChiTietSua.Text = dgvAoDangSua.Rows[index].Cells["CS_chiTietSua"].Value.ToString();
                maNV = Int32.Parse(dgvAoDangSua.Rows[index].Cells["CS_maNhanVien"].Value.ToString());
                pbAnhDaiDien.Image = (System.Drawing.Image)dgvAoDangSua.Rows[index].Cells["CS_anhDaiDien"].FormattedValue;
               
               
                gbThongTinSua.Enabled = false;
                gbNhapCongSua.Enabled = true;gbChoThu.Enabled = false;gbAoDaNhan.Enabled = false;
                txtCongSua.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
          
        }

        private void rbChoSua_CheckedChanged(object sender, EventArgs e)
        {
            dgvAoDangSua.DataSource = dbSuaNgoai.GetDSAoDangSua();
            dgvAoDaNhan.Visible = false;dgvAoDangChoThu.Visible = false;dgvAoDangSua.Visible = true;
            resetInfo();
            gbNhapCongSua.Enabled = false;gbChoThu.Enabled = false;gbAoDaNhan.Enabled = false;
        }

        private void btnXacNhanSuaXong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hoàn tất sửa áo ?", "Sửa áo ngoài", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbSuaNgoai.SuaNgoaiXong(ref err,maSua,Convert.ToDateTime(DateTime.Now),Convert.ToDecimal(txtCongSua.Text),maKH,maNV))
                {
                    MessageBox.Show("Sửa thành công một áo!!");
                    resetInfo();
                    rbChoThu.Checked = true;
                    dgvAoDangChoThu.DataSource = dbSuaNgoai.GetDSAoDangChoThu();
                    dgvAoDangSua.Visible = false;dgvAoDaNhan.Visible = false;
                }
            }
        }

        private void rbChoThu_CheckedChanged(object sender, EventArgs e)
        {
            dgvAoDangChoThu.DataSource = dbSuaNgoai.GetDSAoDangChoThu();
            dgvAoDangSua.Visible = false;dgvAoDaNhan.Visible = false;dgvAoDangChoThu.Visible = true;resetInfo();
            gbNhapCongSua.Enabled = false; gbChoThu.Enabled = false; gbAoDaNhan.Enabled = false;
        }
    

        private void rbDaNhan_CheckedChanged(object sender, EventArgs e)
        {
            dgvAoDaNhan.DataSource = dbSuaNgoai.GetDSHangNgoaiDaNhan();
            dgvAoDangSua.Visible = false; dgvAoDaNhan.Visible = true; dgvAoDangChoThu.Visible = false;resetInfo();
        gbNhapCongSua.Enabled = false; gbChoThu.Enabled = false; gbAoDaNhan.Enabled = false;
    
        }
        decimal phiSua = 0;
        private void dgvAoDangChoThu_Click(object sender, EventArgs e)
        {
            int index = dgvAoDangChoThu.CurrentCell.RowIndex;
            try
            {
                maSua = Int32.Parse(dgvAoDangChoThu.Rows[index].Cells["CT_maSua"].Value.ToString());
                lbTenKhachHang.Text = dgvAoDangChoThu.Rows[index].Cells["CT_tenKhachHang"].Value.ToString();
                string anhVai = "";
               // dtpNgayHenThu.Value = Convert.ToDateTime(dgvAoDangSua.Rows[index].Cells["CT_ngayHenThu"].Value);
               // cbNhanVienSua.Text = dgvAoDangSua.Rows[index].Cells["CT_tenNhanVien"].Value.ToString();
                phiSua = Convert.ToDecimal(dgvAoDangChoThu.Rows[index].Cells["CT_phiSua"].Value.ToString());
                //  txtNoiDungSua.Text = dgvAoDangSua.Rows[index].Cells["CT_noiDungSua"].Value.ToString();
                pbAnhDaiDien.Image = (System.Drawing.Image)dgvAoDangChoThu.Rows[index].Cells["CT_anhDaiDien"].FormattedValue;            
                gbThongTinSua.Enabled = true;
                cbNhanVienSua.Enabled = true;txtNoiDungSua.Enabled = true;rtxtChiTietSua.Enabled = true;
                cbNhanVienSua.DataSource = dbNhanVien.GetNhanVien();
                cbNhanVienSua.DisplayMember = "tenNhanVien"; cbNhanVienSua.ValueMember = "Id";
                btnChonKhachHang.Enabled = false;gbNhapCongSua.Enabled = false;
                gbChoThu.Enabled = true;btnChonAnh.Enabled = false;
                btnLayAo.Enabled = true;
                btnSuaLai.Enabled = true;gbAoDaNhan.Enabled = false;gbNhapCongSua.Enabled = false;

            }
            catch (Exception)
            {

            }
        }

        private void btnLayAo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Thử hoàn tất, khách hàng nhận lại áo với giá tiền:  "+phiSua.ToString()+"K ?", "Sửa áo ngoài", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbSuaNgoai.LayAoNgoai(ref err, maSua, Convert.ToDateTime(DateTime.Now)))
                {
                    resetInfo();rbDaNhan.Checked = true;dgvAoDaNhan.DataSource = dbSuaNgoai.GetDSHangNgoaiDaNhan();
                    dgvAoDangSua.Visible = false;dgvAoDangChoThu.Visible = false;
                }
            }
        }

        private void btnSuaLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Thử hoàn tất,tiền công cho thợ: "+ phiSua.ToString() + "K. Kh muốn sửa lại?", "Sửa lại áo!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if(dbSuaNgoai.YeuCauThulai(ref er, maSua, Convert.ToDateTime(dtpNgayHenThu.Value), Int32.Parse(cbNhanVienSua.SelectedValue.ToString()), txtNoiDungSua.Text, rtxtChiTietSua.Text))
                {
                    resetInfo();
                    MessageBox.Show("Khách hàng đã yêu cầu sửa lại áo theo yêu cầu!!");
                    rbChoSua.Checked = true;dgvAoDangSua.DataSource = dbSuaNgoai.GetDSAoDangSua();
                    dgvAoDaNhan.Visible = false;dgvAoDangChoThu.Visible = false;

                }
            }
        }

        private void dgvAoDaNhan_Click(object sender, EventArgs e)
        {

            int index = dgvAoDaNhan.CurrentCell.RowIndex;
            try
            {
                maSua = Int32.Parse(dgvAoDaNhan.Rows[index].Cells["DN_maSua"].Value.ToString());
                lbTenKhachHang.Text = dgvAoDaNhan.Rows[index].Cells["DN_tenKhachHang"].Value.ToString();
                string anhVai = "";
                // dtpNgayHenThu.Value = Convert.ToDateTime(dgvAoDangSua.Rows[index].Cells["CT_ngayHenThu"].Value);
                // cbNhanVienSua.Text = dgvAoDangSua.Rows[index].Cells["CT_tenNhanVien"].Value.ToString();
                //  txtNoiDungSua.Text = dgvAoDangSua.Rows[index].Cells["CT_noiDungSua"].Value.ToString();


                pbAnhDaiDien.Image = (System.Drawing.Image)dgvAoDaNhan.Rows[index].Cells["DN_anhDaiDien"].FormattedValue;


                gbThongTinSua.Enabled = true;
                cbNhanVienSua.Enabled = true; txtNoiDungSua.Enabled = true; rtxtChiTietSua.Enabled = true;
                cbNhanVienSua.DataSource = dbNhanVien.GetNhanVien();btnChonAnh.Enabled = false;
                cbNhanVienSua.DisplayMember = "tenNhanVien"; cbNhanVienSua.ValueMember = "Id";
                btnChonKhachHang.Enabled = false; btnLayAo.Enabled = false; gbNhapCongSua.Enabled = false;
                gbChoThu.Enabled = false;gbAoDaNhan.Enabled = true;
                btnSuaSauKhiDaNhan.Enabled = true;

            }
            catch (Exception)
            {

            }
        }

        private void btnSuaSauKhiDaNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khách hàng muốn sửa lại áo này ?", "Sửa áo ngoài", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if (dbSuaNgoai.YeuCauThulai(ref er, maSua, Convert.ToDateTime(dtpNgayHenThu.Value), Int32.Parse(cbNhanVienSua.SelectedValue.ToString()), txtNoiDungSua.Text, rtxtChiTietSua.Text))
                {
                    resetInfo();
                    MessageBox.Show("Khách hàng đã yêu cầu sửa lại áo theo yêu cầu!!");
                    rbChoSua.Checked = true; dgvAoDangSua.DataSource = dbSuaNgoai.GetDSAoDangSua();
                    dgvAoDaNhan.Visible = false; dgvAoDangChoThu.Visible = false;

                }

            }
        }

        private void btnXemDS_Click(object sender, EventArgs e)
        {
            new frmDanhSachSuaNgoai().ShowDialog();
        }

        private void txtCongSua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
