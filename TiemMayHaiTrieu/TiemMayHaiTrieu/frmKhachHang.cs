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
namespace TiemMayHaiTrieu
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
         dbKhachHang dbKhachHang = new dbKhachHang();
        int mafrm = 0;
        public frmKhachHang(int maform) :this()
        {
            mafrm = maform;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tbTimKiemAo_TextChanged(object sender, EventArgs e)
        {
            dgvDanhSachKH.DataSource = dbKhachHang.TimKhachHangTheoTen(tbTimKiemAo.Text);
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            new frmThemKhachHang().ShowDialog();
            dgvDanhSachKH.DataSource = dbKhachHang.GetKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            btnSuaKH.Enabled = false;
            btnThemKH.Enabled = true;
            btnXoaKH.Enabled = false;
            dgvDanhSachKH.DataSource = dbKhachHang.GetKhachHang();
            tbTimKiemAo.Enabled = true;
            btnChonKHMayAo.Enabled = false;
            btnChonKHBanAo.Enabled = false;
            btnChonKHDeDat.Enabled = false;
            btnSuaNgoai.Enabled = false;
            btnBanAo.Enabled = false; btnThueAo.Enabled = false;


        }
        int maKH = 0;
        private void dgvDanhSachKH_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachKH.CurrentCell.RowIndex;
                maKH = Int32.Parse(dgvDanhSachKH.Rows[index].Cells["Id"].Value.ToString());
                if (dgvDanhSachKH.Rows[index].Cells["tenKhachHang"].Value.ToString() != "")
                    txtTenKh.Text = dgvDanhSachKH.Rows[index].Cells["tenKhachHang"].Value.ToString();
                else txtTenKh.Text = "";
                if (dgvDanhSachKH.Rows[index].Cells["soDienThoai"].Value.ToString() != "")
                    txtSoDienThoai.Text = dgvDanhSachKH.Rows[index].Cells["soDienThoai"].Value.ToString();
                else txtSoDienThoai.Text = "";
                if (dgvDanhSachKH.Rows[index].Cells["diaChi"].Value.ToString() != "")
                    txtDiaChi.Text = dgvDanhSachKH.Rows[index].Cells["diaChi"].Value.ToString();
                else txtDiaChi.Text = "";
                if (dgvDanhSachKH.Rows[index].Cells["ghiChu"].Value.ToString() != "")
                    rtxtGhiChu.Text = dgvDanhSachKH.Rows[index].Cells["ghiChu"].Value.ToString();
                else rtxtGhiChu.Text = "";
                btnSuaKH.Enabled = true; btnXoaKH.Enabled = true;
                if (mafrm == 2)
                {
                    btnChonKHBanAo.Enabled = true;
                    btnChonKHMayAo.Enabled = false;
                    btnChonKHDeDat.Enabled = false;
                    btnSuaNgoai.Enabled = false; btnBanAo.Enabled = false;
                    btnThueAo.Enabled = false;
                    btnChonKHXemHDMay.Enabled = false;
                }
                else
                {
                    if (mafrm == 1)
                    {
                        btnChonKHMayAo.Enabled = true;
                        btnChonKHBanAo.Enabled = false;
                        btnChonKHDeDat.Enabled = false;
                        btnSuaNgoai.Enabled = false; btnBanAo.Enabled = false; btnThueAo.Enabled = false;
                        btnChonKHXemHDMay.Enabled = false;
                    }
                    else
                    {
                        if (mafrm == 3)
                        {
                            btnChonKHDeDat.Enabled = true;
                            btnChonKHMayAo.Enabled = false;
                            btnChonKHBanAo.Enabled = false;
                            btnSuaNgoai.Enabled = false; btnBanAo.Enabled = false; btnThueAo.Enabled = false;
                            btnChonKHXemHDMay.Enabled = false;
                        }

                        else
                        {
                            if (mafrm == 4)
                            {
                                btnChonKHDeDat.Enabled = false;
                                btnChonKHMayAo.Enabled = false;
                                btnChonKHBanAo.Enabled = false;
                                btnSuaNgoai.Enabled = true;
                                btnBanAo.Enabled = false; btnThueAo.Enabled = false;
                                btnChonKHXemHDMay.Enabled = false;
                            }
                            else
                            {
                                if (mafrm == 5)
                                {
                                    btnChonKHDeDat.Enabled = false;
                                    btnChonKHMayAo.Enabled = false;
                                    btnChonKHBanAo.Enabled = false;
                                    btnSuaNgoai.Enabled = false;
                                    btnBanAo.Enabled = true; btnThueAo.Enabled = false;
                                    btnChonKHXemHDMay.Enabled = false;
                                }
                                else
                                {
                                    if (mafrm == 6)
                                    {
                                        btnChonKHDeDat.Enabled = false;
                                        btnChonKHMayAo.Enabled = false;
                                        btnChonKHBanAo.Enabled = false;
                                        btnSuaNgoai.Enabled = false;
                                        btnBanAo.Enabled = false; btnThueAo.Enabled = true; ;
                                        btnChonKHXemHDMay.Enabled = false;
                                    }
                                    else
                                    {
                                        if (mafrm == 7)
                                        {
                                            btnChonKHMayAo.Enabled = false;
                                            btnChonKHBanAo.Enabled = false;
                                            btnChonKHDeDat.Enabled = false;
                                            btnSuaNgoai.Enabled = false;
                                            btnBanAo.Enabled = false; btnThueAo.Enabled = false; btnChonKHXemHDMay.Enabled = true;
                                        }
                                        else
                                        {
                                            btnChonKHMayAo.Enabled = false;
                                            btnChonKHBanAo.Enabled = false;
                                            btnChonKHDeDat.Enabled = false;
                                            btnSuaNgoai.Enabled = false;
                                            btnBanAo.Enabled = false; btnThueAo.Enabled = false; btnChonKHXemHDMay.Enabled = false;
                                        }
                                      
                                    }


                                }

                            }

                        }

                    }
                }

            }
            catch (Exception) { }

        }

        private void btnChonKHMayAo_Click(object sender, EventArgs e)
        {
            infoClass.setmaKH(maKH);
            this.Close();
        }

        private void btnChonKHBanAo_Click(object sender, EventArgs e)
        {
            infoClass.setmaKH(maKH);
            this.Close();
        }

        private void tbTimKiemAo_Click(object sender, EventArgs e)
        {
            tbTimKiemAo.Text = "";
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa thông tin khách hàng  ?", "Sửa thông tin KH", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if(dbKhachHang.UpdateKhachHang(ref err, maKH, txtTenKh.Text, txtSoDienThoai.Text, txtDiaChi.Text, rtxtGhiChu.Text))
                {
                    dgvDanhSachKH.DataSource = dbKhachHang.GetKhachHang();
                    MessageBox.Show("Sửa xong thông tin của khách hàng!!");
                    btnSuaKH.Enabled = false;
                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa KH này ? Thao tác này không thể hoàn lại!!", "Xóa KH", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if (dbKhachHang.DeleteKhachHang(ref err, maKH))
                {
                    dgvDanhSachKH.DataSource = dbKhachHang.GetKhachHang();
                    MessageBox.Show("Sửa xong thông tin của khách hàng!!");
                    btnSuaKH.Enabled = false;btnXoaKH.Enabled = false;
                }
            }
        }

        private void btnChonKHDeDat_Click(object sender, EventArgs e)
        {

            infoClass.setmaKH(maKH);
            this.Close();
        }

		private void btnSuaNgoai_Click(object sender, EventArgs e)
		{

			infoClass.setmaKH(maKH);
			this.Close();
		}

        private void btnBanAo_Click(object sender, EventArgs e)
        {
            infoClass.setmaKH(maKH);
            this.Close();
        }

        private void btnThueAo_Click(object sender, EventArgs e)
        {
            infoClass.setmaKH(maKH);
            this.Close();
        }

        private void btnChonKHXemHDMay_Click(object sender, EventArgs e)
        {
            infoClass.setmaKH(maKH);
            this.Close();
        }
    }
}
