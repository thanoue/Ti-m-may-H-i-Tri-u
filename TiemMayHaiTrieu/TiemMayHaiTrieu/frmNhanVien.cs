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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        dbNhanVien dbNhanVien = new dbNhanVien(); byte[] destFileVaiQuan;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
			dgvNhanVien.DataSource = dbNhanVien.GetNhanVien();
            cbLoaiNV.DataSource = dbNhanVien.GetLoaiNV();
            cbLoaiNV.DisplayMember = "tenLoaiNhanVien";
            cbLoaiNV.ValueMember = "Id";
          
        }
        int maNhanVien = 0;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

               // string anhDaiDien = "";
                int index = dgvNhanVien.CurrentCell.RowIndex;
                
                pbAnhDaiDienNV.Image = (System.Drawing.Image)dgvNhanVien.Rows[index].Cells["anhDaiDien"].FormattedValue;
                cbLoaiNV.SelectedValue = dgvNhanVien.Rows[index].Cells["Id1"].Value;
                maNhanVien = Int32.Parse(dgvNhanVien.Rows[index].Cells["Id"].Value.ToString());
                txtSDTNhanVien.Text = dgvNhanVien.Rows[index].Cells["soDienThoai"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[index].Cells["tenNhanVien"].Value.ToString();
                groupBox1.Enabled = true;

            }
            catch (Exception  )
            {
                //MessageBox.Show(ex.ToString());
            }
        }
        void def()
        {
            MemoryStream ms = new MemoryStream();
            Properties.Resources.staff_avatar.Save(ms, Properties.Resources.staff_avatar.RawFormat);
            destFileVaiQuan = ms.GetBuffer();
            ms.Close();

        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string err = "";
            if (MessageBox.Show("Sửa thông tin nhân viên?", "Sửa thông tin nhân viên!! ", MessageBoxButtons.YesNo) == DialogResult.Yes){
                if(dbNhanVien.UpdateNhanVien(ref err, maNhanVien, txtTenNV.Text, Int32.Parse(cbLoaiNV.SelectedValue.ToString()), txtSDTNhanVien.Text, destFileVaiQuan))
                {
                    def();
                    dgvNhanVien.DataSource = dbNhanVien.GetNhanVien();
                    MessageBox.Show("Sửa thông tin nhân viên thành công!");
                    groupBox1.Enabled = false;

                }
            }

        }

        private void btnDoiAnhNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();
            string fileName = ""; string filePathAnhNV = "";
            ofdImages.AddExtension = true;
            ofdImages.CheckFileExists = true;
            //  ofdImages.Filter = "Image file (*.JPG;*.NPG;*JEPG)|*.JPG;*.NPG;*JEPG";
            ofdImages.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            ofdImages.InitialDirectory = @"Documents";
            ofdImages.Multiselect = false;
            ofdImages.RestoreDirectory = true;
            ofdImages.Title = "Chọn hình nhân viên...";

            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filePathAnhNV = ofdImages.FileName;
                int temp = filePathAnhNV.LastIndexOf(@"\");
                fileName = filePathAnhNV.Substring(temp + 1);
                try
                {
                    
                    pbAnhDaiDienNV.Image = Image.FromFile(filePathAnhNV.ToString());
                  
                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhDaiDienNV.Image);
                //    pbAnhDaiDienNV.Image.Save(ms, pbAnhDaiDienNV.Image.RawFormat);
                    destFileVaiQuan = ms.GetBuffer();
                    ms.Close();
                    //     File.Delete();

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            string err = "";
            if (MessageBox.Show("Xóa nhân viên ? thao tác này không thể phục hồi", "Xóa nhân viên... ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbNhanVien.DeleteNhanVien(ref err, maNhanVien))
                    MessageBox.Show("Xóa thành công 1 nhân viên");
                groupBox1.Enabled = false;
                dgvNhanVien.DataSource = dbNhanVien.GetNhanVien();
            }
            
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

            new frmThemNhanVien().ShowDialog();
            dgvNhanVien.DataSource = dbNhanVien.GetNhanVien();
            
        }
    }
}
