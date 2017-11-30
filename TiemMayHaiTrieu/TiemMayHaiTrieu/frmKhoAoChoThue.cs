using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;
namespace TiemMayHaiTrieu
{
    public partial class frmKhoAoChoThue : Form
    {
        public frmKhoAoChoThue()
        {
            InitializeComponent();
        }
        private void reset()
        {
            MemoryStream ms = new MemoryStream();
            Properties.Resources.ao.Save(ms, Properties.Resources.ao.RawFormat);
            anhAo = ms.GetBuffer();
            ms.Close();gbThongTinHang.Enabled = true;pbAnhDaiDien.Image = null;
            btnSua.Enabled = false; btnXoa.Enabled = false; btnChonAnh.Enabled = true;
            txtGiaBanDuKien.Text = "0"; txtPhiThueDuKien.Text = "0"; txtSoLuong.Text = "0";
            txtTenAo.Text = ""; rtxtGhiChu.Text = "";maAoDuocChon = 0;
        }
        dbAoChoThue dbAoChoThue = new dbAoChoThue();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        int add = 0;byte[] anhAo;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (add == 0)
            {
             reset();
                add = 1;
            }
            else
            {
                if (MessageBox.Show("Thêm áo này vào kho?", "Thêm áo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string err = "";
                    if (dbAoChoThue.ThemAoVaoKho(ref err, txtTenAo.Text, anhAo, Convert.ToDecimal(txtPhiThueDuKien.Text), Convert.ToDecimal(txtGiaBanDuKien.Text), rtxtGhiChu.Text, Int32.Parse(txtSoLuong.Text)))
                    {
                        reset();
                        add = 0;gbThongTinHang.Enabled = false;
                        dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAo();
                    }
                }

            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
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

                    pbAnhDaiDien.Image = Image.FromFile(filePathVaiQuan.ToString());

                    //      string sourceFile = Path.Combine(sourcePath, fileName);

                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhDaiDien.Image);
                  //  pbAnhDaiDien.Image.Save(ms, pbAnhDaiDien.Image.RawFormat);
                    anhAo = ms.GetBuffer();
                    ms.Close();
                    //     File.Delete();

                }
                catch (Exception )
                {
                    // ex.Message.ToString();
                }
            }
        }
        int maAoDuocChon = 0;
        private void dgvKhoVai_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvKhoVai.CurrentCell.RowIndex;
                txtTenAo.Text = dgvKhoVai.Rows[index].Cells["tenAo"].Value.ToString();
                txtPhiThueDuKien.Text = dgvKhoVai.Rows[index].Cells["phiThueDuKien"].Value.ToString();
                txtGiaBanDuKien.Text = dgvKhoVai.Rows[index].Cells["phiBanDuKien"].Value.ToString();
                txtSoLuong.Text = dgvKhoVai.Rows[index].Cells["soLuong"].Value.ToString();
                rtxtGhiChu.Text = dgvKhoVai.Rows[index].Cells["ghiChu"].Value.ToString();
                maAoDuocChon = Int32.Parse(dgvKhoVai.Rows[index].Cells["Id"].Value.ToString());
                pbAnhDaiDien.Image = (System.Drawing.Image)dgvKhoVai.Rows[index].Cells["anhDaiDien"].FormattedValue ;
                MemoryStream ms = new MemoryStream();
                pbAnhDaiDien.Image.Save(ms,pbAnhDaiDien.Image.RawFormat);
                anhAo = ms.GetBuffer();
                ms.Close();gbThongTinHang.Enabled = true;
                btnSua.Enabled = true;btnXoa.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa thông tin áo này?", "Sửa áo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbAoChoThue.SuaThongTinAo(ref err,maAoDuocChon,txtTenAo.Text,anhAo,Convert.ToDecimal(txtPhiThueDuKien.Text),Convert.ToDecimal(txtGiaBanDuKien.Text),rtxtGhiChu.Text,
                   Int32.Parse(txtSoLuong.Text)))
                {
                    MessageBox.Show("Sửa thành công thông tin của một áo!!!");
                    btnSua.Enabled = false;btnXoa.Enabled = false;
                     dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAo();
                    reset();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa áo này khỏi kho? Thao tác này không thể hồi", "Xóa áo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbAoChoThue.DeleteAo(ref err, maAoDuocChon))
                {
                    reset();dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAo();
                    btnXoa.Enabled = false;btnSua.Enabled = false;
                }
            }
        }

        private void btnThueAo_Click(object sender, EventArgs e)
        {
            new frmThueAoMoi().ShowDialog();
        }

        private void btnBanAo_Click(object sender, EventArgs e)
        {
            new frmBanAo().ShowDialog();
        }

        private void frmKhoAoChoThue_Load(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbAoChoThue.GetDanhSachAo();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
