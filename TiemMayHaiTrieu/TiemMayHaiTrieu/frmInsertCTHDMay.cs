using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BusinessLogicFramework;
using System.IO;
using System.Windows.Forms;

namespace TiemMayHaiTrieu
{
    public partial class frmInsertCTHDMay : Form
    {
        public frmInsertCTHDMay()
        {
            InitializeComponent();
        }
        int maHD = 0;int soAo = 0;int soQuan = 0;dbMayAo dbMayAo = new dbMayAo();
        int thuTuAo = 1;int thuTuQuan = 1;byte[] anhAo;byte[] anhQuan;bool firstTime = true;
        public frmInsertCTHDMay(int mHD,int soAo,int soQuan,bool firstTime) : this()
        {
            this.maHD = mHD;this.soAo = soAo;this.soQuan = soQuan;this.firstTime = firstTime;
        }
        void reset()
        {
            rtxtGhiChuAo.Text = "";rtxtGhiChuQuan.Text = "";txtPhiMayAo.Text = "";txtPhiMayQuan.Text = "";
            MemoryStream ms = new MemoryStream();
            Properties.Resources.ao.Save(ms, Properties.Resources.ao.RawFormat);
            pbVaiAo.Image = Properties.Resources.ao;
            pbVaiQuan.Image = Properties.Resources.Quan;
            anhAo = ms.GetBuffer();ms.Close(); MemoryStream ms2 = new MemoryStream();
            Properties.Resources.Quan.Save(ms2, Properties.Resources.Quan.RawFormat);
            anhQuan = ms2.GetBuffer();ms2.Close();
        }
        private void frmInsertCTHDMay_Load(object sender, EventArgs e)
        {
            
            if (firstTime)
            {
                if (soAo == 0)
                    btnThemAo.Enabled = false;
                if (soQuan == 0)
                    btnThemQuan.Enabled = false;
                lbMaAo.Text = maHD.ToString() + ".1";
                lbMaQuan.Text = maHD.ToString() + ".1";
                lbMaHD.Text = maHD.ToString();
                cbLoaiCo.DataSource = dbMayAo.GetCoAo();
                cbLoaiCo.ValueMember = "tenLoaiCo";
                cbLoaiCo.DisplayMember = "tenLoaiCo";
                cbLoaiVaiAo.Items.Add("Vải của khách hàng");
                cbLoaiVaiAo.Items.Add("Vải của tiệm");
                cbLoaiVaiAo.Text = "Vải của khách hàng";
                cbLoaiVaiQuan.Items.Add("Vải của khách hàng");
                cbLoaiVaiQuan.Text = "Vải của khách hàng";
                cbLoaiVaiQuan.Items.Add("Vải của tiệm");
                reset();
            }
            else
            {
               
                dgvDanhSachAo.DataSource = dbMayAo.GetAoDuocMayTheoMaHD(maHD);
                dgvDanhSachQuan.DataSource = dbMayAo.GetQuanDuocMayTheoMaHD(maHD);
                lbMaHD.Text = maHD.ToString();
                cbLoaiCo.DataSource = dbMayAo.GetCoAo();
                cbLoaiCo.ValueMember = "tenLoaiCo";
                cbLoaiCo.DisplayMember = "tenLoaiCo";
                cbLoaiVaiAo.Items.Add("Vải của khách hàng");
                cbLoaiVaiAo.Items.Add("Vải của tiệm");
                cbLoaiVaiQuan.Items.Add("Vải của khách hàng");
                cbLoaiVaiQuan.Items.Add("Vải của tiệm");
                cbLoaiVaiAo.Text = "Vải của khách hàng";
                cbLoaiVaiQuan.Items.Add("Vải của tiệm");
                reset();
                if (dbMayAo.MaAoLonNhat(maHD) > soAo)
                {
                    thuTuAo = dbMayAo.MaAoLonNhat(maHD);
                    lbMaAo.Text = "Xóa bớt áo!!!";
                    btnThemAo.Enabled = false;
                }
                else
                {
                    if (dbMayAo.MaAoLonNhat(maHD) == soAo)
                    {
                        thuTuAo = dbMayAo.MaAoLonNhat(maHD);
                        lbMaAo.Text = "Đã thêm đủ áo";
                        btnThemAo.Enabled = false;
                    }
                    else
                    {
                        if (dbMayAo.MaAoLonNhat(maHD) <= 0)
                        {
                            thuTuAo = 1;
                            lbMaAo.Text = maHD.ToString() + ".1";
                            if (soAo > 0)
                                btnThemAo.Enabled = true;
                            else
                                btnThemAo.Enabled = false;
                        }
                        else
                        {
                            thuTuAo = dbMayAo.MaAoLonNhat(maHD) + 1;
                            lbMaAo.Text = maHD.ToString() + "." + thuTuAo.ToString();
                            btnThemAo.Enabled = true;
                        }
                    }
                  
                }
                if (dbMayAo.MaQuanLonNhat(maHD) > soQuan)
                {
                    thuTuQuan = dbMayAo.MaQuanLonNhat(maHD);
                    lbMaQuan.Text = "Xóa bớt quần!!!";
                    btnThemQuan.Enabled = false;

                }
                else
                {
                    if (dbMayAo.MaQuanLonNhat(maHD) == soQuan)
                    {
                        thuTuQuan = dbMayAo.MaQuanLonNhat(maHD);
                        lbMaQuan.Text = "Đã thêm đủ quần";
                        btnThemQuan.Enabled = false;
                    }
                    else
                    {
                        if (dbMayAo.MaQuanLonNhat(maHD) <= 0)
                        {
                            thuTuQuan = 1;
                            lbMaQuan.Text = maHD.ToString() + ".1";
                            if (soQuan > 0)
                                btnThemQuan.Enabled = true;
                            else
                                btnThemQuan.Enabled = false;
                        }
                        else
                        {
                            thuTuAo = dbMayAo.MaQuanLonNhat(maHD) + 1;
                            lbMaQuan.Text = maHD.ToString() + "." + thuTuQuan.ToString();
                            btnThemQuan.Enabled = true;
                        }
                    }
                   
                }
            }
           
        }

        private void pnChiTietMay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemAo_Click(object sender, EventArgs e)
        {
            string er = "";
            if(dbMayAo.InsertAoDuocMay(ref er, anhAo, lbMaAo.Text, rtxtGhiChuAo.Text, cbLoaiVaiAo.Text, Convert.ToDecimal(txtPhiMayAo.Text), Int32.Parse(lbMaHD.Text), cbLoaiCo.SelectedValue.ToString(), txtKichThuocCoAo.Text,thuTuAo))
            {
                dgvDanhSachAo.DataSource = dbMayAo.GetAoDuocMayTheoMaHD(Int32.Parse(lbMaHD.Text));
                lbTongTien.Text = (Convert.ToDecimal(lbTongTien.Text) + Convert.ToDecimal(txtPhiMayAo.Text)).ToString();
                thuTuAo += 1;
                if (thuTuAo > soAo)
                {
                    btnThemAo.Enabled = false;
                    lbMaAo.Text = "Đã thêm đủ số lượng áo";
                }
                else
                {
                    lbMaAo.Text = maHD.ToString() + "." + thuTuAo.ToString();
                }
                reset();

            }
        }

        private void btnThemQuan_Click(object sender, EventArgs e)
        {
            string er = "";
            if(dbMayAo.InsertQuanDuocMay(ref er, anhQuan, lbMaQuan.Text, rtxtGhiChuQuan.Text, cbLoaiVaiQuan.Text, Convert.ToDecimal(txtPhiMayQuan.Text),Int32.Parse(lbMaHD.Text),thuTuQuan))
            {
                dgvDanhSachQuan.DataSource = dbMayAo.GetQuanDuocMayTheoMaHD(Int32.Parse(lbMaHD.Text));
                lbTongTien.Text = (Convert.ToDecimal(lbTongTien.Text) + Convert.ToDecimal(txtPhiMayQuan.Text)).ToString();
                thuTuQuan += 1;
                if (thuTuQuan > soQuan)
                {
                    btnThemQuan.Enabled = false;
                    lbMaQuan.Text = "Đã thêm đủ số lượng quần";
                }
                else
                {
                    lbMaQuan.Text = maHD.ToString() + "." + thuTuQuan.ToString();
                }
                reset();
            }
        }

        private void btnXoaAo_Click(object sender, EventArgs e)
        {
            string er = "";
            if (dbMayAo.DeleteAoDuocMay(ref er, maAo))
            {
                thuTuAo -= 1;
                if (thuTuAo < soAo)
                {
                    lbMaAo.Text = maHD.ToString() + "." + thuTuAo.ToString();
                    btnThemAo.Enabled = true;
                }
                else
                {
                    lbMaAo.Text = "Xóa thêm áo!!";
                    btnThemAo.Enabled = false;
                }
                dgvDanhSachAo.DataSource = dbMayAo.GetAoDuocMayTheoMaHD(maHD);
                lbTongTien.Text = (Convert.ToDecimal(lbTongTien.Text) - phiMayAo).ToString();
                btnXoaAo.Enabled = false;
             
            }
        }
        string maAo = "";decimal phiMayAo = 0;decimal phiMayQuan = 0;
        private void dgvDanhSachAo_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachAo.CurrentCell.RowIndex;
                cbLoaiCo.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_loaiCo"].Value.ToString();
                txtKichThuocCoAo.Text  = dgvDanhSachAo.Rows[index].Cells["dsa_kichThuocCo"].Value.ToString();
                txtPhiMayAo.Text = dgvDanhSachAo.Rows[index].Cells["dsa_phimay"].Value.ToString();
                cbLoaiVaiAo.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_loaiVai"].Value.ToString();
                rtxtGhiChuAo.Text= dgvDanhSachAo.Rows[index].Cells["dsa_ghiChu"].Value.ToString();
                pbVaiAo.Image = (System.Drawing.Image)dgvDanhSachAo.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                maAo = dgvDanhSachAo.Rows[index].Cells["dsa_Id"].Value.ToString();
                phiMayAo = Convert.ToDecimal(dgvDanhSachAo.Rows[index].Cells["dsa_phiMay"].Value.ToString());
                //  btnThemAo.Enabled = true;
                btnXoaAo.Enabled = true;
            }
            catch (Exception)
            {

            }
        }
     string maQuan = "";
        private void dgvDanhSachQuan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachQuan.CurrentCell.RowIndex;               
                txtPhiMayQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_phimay"].Value.ToString();
                cbLoaiVaiQuan.SelectedValue = dgvDanhSachQuan.Rows[index].Cells["dsq_loaiVai"].Value.ToString();
                rtxtGhiChuQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_ghiChu"].Value.ToString();
                pbVaiQuan.Image = (System.Drawing.Image)dgvDanhSachQuan.Rows[index].Cells["dsq_anhDaiDien"].FormattedValue;
                maQuan =dgvDanhSachQuan.Rows[index].Cells["dsq_Id"].Value.ToString();
                phiMayQuan = Convert.ToDecimal(dgvDanhSachQuan.Rows[index].Cells["dsq_phiMay"].Value.ToString());
                btnXoaQuan.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void btnResetAo_Click(object sender, EventArgs e)
        {
            rtxtGhiChuAo.Text = ""; txtPhiMayAo.Text = "";
            MemoryStream ms = new MemoryStream();
            Properties.Resources.ao.Save(ms, Properties.Resources.ao.RawFormat);
            anhAo = ms.GetBuffer(); ms.Close();
        }

        private void btnResetQuan_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Properties.Resources.Quan.Save(ms, Properties.Resources.Quan.RawFormat);
            anhQuan = ms.GetBuffer(); ms.Close(); rtxtGhiChuQuan.Text = "";  txtPhiMayQuan.Text = "";
        }

        private void btnXoaQuan_Click(object sender, EventArgs e)
        {
            string er = "";
            if(dbMayAo.DeleteQuanDuocMay(ref er, maQuan))
            {
                thuTuQuan -= 1;
                if (thuTuQuan < soQuan)
                {
                    lbMaQuan.Text = maHD.ToString() + "." + thuTuQuan.ToString();
                    btnThemQuan.Enabled = true;
                }
                else
                {
                    lbMaQuan.Text = "Xóa thêm áo!!!";
                    btnThemQuan.Enabled = false;
                }
               
                lbTongTien.Text = (Convert.ToDecimal(lbTongTien.Text) - phiMayQuan).ToString();
                dgvDanhSachQuan.DataSource = dbMayAo.GetQuanDuocMayTheoMaHD(maHD);
                btnXoaQuan.Enabled = false;
               // btnThemQuan.Enabled = true;

            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hoàn tất thêm?","Thêm xong!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                infoClass.setTongPhi(Convert.ToDecimal(lbTongTien.Text));
                this.Close();
            }
        }

        private void btnLayVaiAo_Click(object sender, EventArgs e)
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

                    pbVaiAo.Image = Image.FromFile(filePathVaiQuan.ToString());

                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbVaiAo.Image);
                 //   pbVaiAo.Image.Save(ms, pbVaiAo.Image.RawFormat);
                    anhAo = ms.GetBuffer();
                    ms.Close();
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void btnLayVaiQuan_Click(object sender, EventArgs e)
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

                    pbVaiQuan.Image = Image.FromFile(filePathVaiQuan.ToString());

                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbVaiQuan.Image);
                 //   pbVaiQuan.Image.Save(ms, pbVaiQuan.Image.RawFormat);
                    anhQuan = ms.GetBuffer();
                    ms.Close();
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
    }
}
