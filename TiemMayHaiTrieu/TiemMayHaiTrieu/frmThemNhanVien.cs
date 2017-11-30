using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicFramework;

namespace TiemMayHaiTrieu
{
    public partial class frmThemNhanVien : Form
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        dbNhanVien dbNhanVien = new dbNhanVien();
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            cbLoaiNhanVien.DataSource = dbNhanVien.GetLoaiNV();
            cbLoaiNhanVien.DisplayMember = "tenLoaiNhanVien";
            cbLoaiNhanVien.ValueMember = "Id";
            MemoryStream ms = new MemoryStream();
            Properties.Resources.staff_avatar.Save(ms, Properties.Resources.staff_avatar.RawFormat);
            destFileVaiQuan = ms.GetBuffer();
            pbLayAnhNV.Image = Properties.Resources.staff_avatar;
            ms.Close();
        }
        byte[] destFileVaiQuan;
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thêm nhân viên mới ?", "Thêm nhân viên ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                try
                {
                    if (dbNhanVien.InsertNhanVien(ref err, txtTenNV.Text, Int32.Parse(cbLoaiNhanVien.SelectedValue.ToString()), txtSDT.Text, destFileVaiQuan))
                    {
                        MemoryStream ms = new MemoryStream();
                        Properties.Resources.staff_avatar.Save(ms, Properties.Resources.staff_avatar.RawFormat);
                        pbLayAnhNV.Image = Properties.Resources.staff_avatar;
                        destFileVaiQuan = ms.GetBuffer();
                        ms.Close();
                        MessageBox.Show("Thêm nhân viên thành công!");
                        txtSDT.Text = ""; txtTenNV.Text = "";
                     //   daCoAnhVaiQuan = 0;
                    }
                }
               catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
     
        private void btnLayAnhNV_Click(object sender, EventArgs e)
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
            ofdImages.Title = "Chọn hình cho nhân viên...";
            string filePathVaiQuan = "";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filePathVaiQuan = ofdImages.FileName;
              
                try
                {
                   
                    pbLayAnhNV.Image = Image.FromFile(filePathVaiQuan.ToString());
                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbLayAnhNV.Image);
                   // pbLayAnhNV.Image.Save(ms,pbLayAnhNV.Image.RawFormat);
                    destFileVaiQuan = ms.GetBuffer();
                    ms.Close();

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void gbThemNV_Enter(object sender, EventArgs e)
        {

        }
    }
}
