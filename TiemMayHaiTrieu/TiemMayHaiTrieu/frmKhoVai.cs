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
    public partial class frmKhoVai : Form
    {
        public frmKhoVai()
        {
            InitializeComponent(); gbThongTinHang.Enabled = false;
            btnSua.Enabled = false; btnXoa.Enabled = false;
        }
        dbKhoVai dbKhoVai = new dbKhoVai();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void reset()
        {
            txtSoLuong.Text = "";
            txtTamGia.Text = "";
            txtTenLoaiVai.Text = "";rtxtGhiChu.Text = "";
            pbAnhDaiDien.Image = null;
            MemoryStream ms = new MemoryStream();
            Properties.Resources.ao.Save(ms, Properties.Resources.ao.RawFormat);
            anhVai = ms.GetBuffer();
            ms.Close();

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbKhoVai.GetKhoVai();gbThongTinHang.Enabled = false;
            btnSua.Enabled = false;btnXoa.Enabled = false;reset();
        }
        int maLoaiVai = 0; byte[] anhVai;
        private void dgvKhoVai_Click(object sender, EventArgs e)
        {
            try
            {
                gbThongTinHang.Enabled = true;
                int index = dgvKhoVai.CurrentCell.RowIndex;
                maLoaiVai = Int32.Parse(dgvKhoVai.Rows[index].Cells["Id"].Value.ToString());
                if (dgvKhoVai.Rows[index].Cells["tenLoaiVai"].Value.ToString() != null)
                    txtTenLoaiVai.Text = dgvKhoVai.Rows[index].Cells["tenloaiVai"].Value.ToString();
                else txtTenLoaiVai.Text = "";
                if (dgvKhoVai.Rows[index].Cells["soLuong"].Value.ToString() != "")
                    txtSoLuong.Text = dgvKhoVai.Rows[index].Cells["soLuong"].Value.ToString();
                else txtSoLuong.Text = "";
                if (dgvKhoVai.Rows[index].Cells["tamGia"].Value.ToString() != "")
                    txtTamGia.Text = dgvKhoVai.Rows[index].Cells["tamGia"].Value.ToString();
                else txtTamGia.Text = "";
                if (dgvKhoVai.Rows[index].Cells["ghiChu"].Value.ToString() != "")
                    rtxtGhiChu.Text = dgvKhoVai.Rows[index].Cells["ghiChu"].Value.ToString();
                else rtxtGhiChu.Text = "";

                pbAnhDaiDien.Image = (System.Drawing.Image)dgvKhoVai.Rows[index].Cells["anhDaiDien"].FormattedValue;

                btnSua.Enabled = true; btnXoa.Enabled = true;
            }
            catch (Exception) { }
          
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa thông tin vải ?", "Sửa vải", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbKhoVai.UpdateVaiTrongKho(ref err, maLoaiVai, txtTenLoaiVai.Text, int.Parse(txtSoLuong.Text), txtTamGia.Text, anhVai, rtxtGhiChu.Text))
                {
                    dgvKhoVai.DataSource = dbKhoVai.GetKhoVai();reset();
                    MessageBox.Show("Sửa thành công!!");btnSua.Enabled = false;btnXoa.Enabled = false;
                    reset();
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            string fileName = "";
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
                int temp = filePathVaiQuan.LastIndexOf(@"\");
                fileName = filePathVaiQuan.Substring(temp + 1);
                try
                {

                    pbAnhDaiDien.Image = Image.FromFile(filePathVaiQuan.ToString());
                  
                    //      string sourceFile = Path.Combine(sourcePath, fileName);
                  
                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhDaiDien.Image);
                   // pbAnhDaiDien.Image.Save(ms, pbAnhDaiDien.Image.RawFormat);
                    anhVai = ms.GetBuffer();
                    ms.Close();
                    //     File.Delete();

                }
                catch (Exception ex)
                {
                   // ex.Message.ToString();
                }
            }
        }
        int added = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            gbThongTinHang.Enabled = true;
            if (added == 0)
            {
                txtSoLuong.Text = "";txtTenLoaiVai.Text = "";txtTamGia.Text = "";rtxtGhiChu.Text = "";
                pbAnhDaiDien.Image = null; added = 1;
            }
            else
            {
                if (MessageBox.Show("Nhập vải mới?", "Nhập vải", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string er = "";
                    if (dbKhoVai.InsertVaiVaoKho(ref er, txtTenLoaiVai.Text, Int32.Parse(txtSoLuong.Text), txtTamGia.Text, anhVai, rtxtGhiChu.Text))
                    {
                        dgvKhoVai.DataSource = dbKhoVai.GetKhoVai();
                        reset(); btnXoa.Enabled = false;btnSua.Enabled = false;
                        MessageBox.Show("Thêm vải thành công!!");
                    }
                }
                added = 0;
            }
          

        }

        private void frmKhoVai_Load(object sender, EventArgs e)
        {
            reset();
           // this.reportViewer1.RefreshReport();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn xóa loại vải này khỏi kho? Thao tác này không thể hồi lại", "Xóa vải", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if (dbKhoVai.DeleteVaiTrongKho(ref er, maLoaiVai))
                {
                    MessageBox.Show("Xóa thành công một loại vải trong kho !");
                    reset();btnXoa.Enabled = false; btnSua.Enabled = false;
                }
                  

            }
        }

        private void tbTimKiemAo_Click(object sender, EventArgs e)
        {
            tbTimKiemAo.Text = "";
        }

        private void tbTimKiemAo_TextChanged(object sender, EventArgs e)
        {
            dgvKhoVai.DataSource = dbKhoVai.TimVaiTrongKhoTheoTenVai(tbTimKiemAo.Text);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
