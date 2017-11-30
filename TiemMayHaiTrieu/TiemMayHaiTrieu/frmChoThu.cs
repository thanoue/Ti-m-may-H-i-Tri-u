using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;
namespace TiemMayHaiTrieu
{
    public partial class frmChoThu : Form
    {
        public frmChoThu()
        {
            InitializeComponent();
            cbChonThoSua.DataSource = dbNhanVien.GetNhanVien();
            cbChonThoSua.DisplayMember = "tenNhanVien";
            cbChonThoSua.ValueMember = "Id";
        }
        dbThuAo dbThuAo = new dbThuAo();dbNhanVien dbNhanVien = new dbNhanVien();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbThuAo.GetDanhSachAoCanThu();

        }
        int maHD = 0;int maKH = 0;string so = "";
     
        int maCthd = 0;
        private void btnXacNhanSua_Click(object sender, EventArgs e)
        {
            if (chonAo)
            {
                if (MessageBox.Show("Sửa áo với nội dung vừa nhập?", "Sửa áo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DateTime ngayHenThu = dtpNgayHenThulai.Value.Date;
                    string er = "";
                    if (dbThuAo.YeuCauSuaAo(ref er, maAo, rtbNoiDungSua.Text, Convert.ToDecimal(txtPhiSua.Text), Int32.Parse(cbChonThoSua.SelectedValue.ToString()), ngayHenThu))
                    {
                        rtbNoiDungSua.Text = ""; txtPhiSua.Text = "0";
                        pbVaiMayAo.Image = null;  pbVaiMayQuan.Image = null; btnXacNhanSua.Enabled = false;
                        dgvDanhSachAo.DataSource = dbThuAo.GetAoDuocMayChoThu(maHD);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Sửa quần với nội dung vừa nhập?", "Sửa quần!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DateTime ngayHenThu = dtpNgayHenThulai.Value.Date;
                    string er = "";
                    if (dbThuAo.YeuCauSuaQuan(ref er, maQuan, rtbNoiDungSua.Text, Convert.ToDecimal(txtPhiSua.Text), Int32.Parse(cbChonThoSua.SelectedValue.ToString()), ngayHenThu))
                    {
                        rtbNoiDungSua.Text = ""; txtPhiSua.Text = "0";
                        pbVaiMayAo.Image = null; pbVaiMayQuan.Image = null; btnXacNhanSua.Enabled = false;
                        dgvDanhSachQuan.DataSource = dbThuAo.GetQuanDuocMayChoThu(maHD);
                    }
                }
            }
           
        }
        private void frmChoThu_Load(object sender, EventArgs e)
        {
                           
                
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtKH.Text = "";txtMaHD.Text = "";
        }

        private void txtKH_TextChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbThuAo.TimHDChoThuTheoKh(txtKH.Text);
        }

        private void grDSHD_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSHD.DataSource = dbThuAo.TimHDChoThuTheMaHD(Int32.Parse(txtMaHD.Text));

            }
            catch (Exception) { }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dgvDSHD_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentCell.RowIndex;
                maHD = Int32.Parse(dgvDSHD.Rows[index].Cells["dshd_Id"].Value.ToString());
                pbAnhDaiDienHD.Image = (System.Drawing.Image)dgvDSHD.Rows[index].Cells["dshd_anhDaiDien"].FormattedValue;
                // dgvDSChiTietHD.DataSource = dbThuAo.GetDSCTHDMayAoChoThuTheMaHD(maHD);
                dgvDanhSachAo.DataSource = dbThuAo.GetAoDuocMayChoThu(maHD);
                dgvDanhSachQuan.DataSource = dbThuAo.GetQuanDuocMayChoThu(maHD);
                btnXacNhanSua.Enabled = false;btnNhanAo.Enabled = false;
                lbMaHoaDonMay.Text = maHD.ToString(); gbSuaAo.Enabled = false;
                rtbNoiDungSua.Text = ""; txtPhiSua.Text = "0"; 
                pbVaiMayAo.Image = null; ; pbVaiMayQuan.Image = null; btnXacNhanSua.Enabled = false; 
               
            }
            catch (Exception) { }
        }
        string maAo = "";string maQuan = "";bool chonAo = false;
        private void dgvDanhSachAo_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachAo.CurrentCell.RowIndex;
                maAo = dgvDanhSachAo.Rows[index].Cells["dsa_Id"].Value.ToString();
                pbVaiMayAo.Image = (System.Drawing.Image)dgvDanhSachAo.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                chonAo = true;
                phi = Convert.ToDecimal(dgvDanhSachAo.Rows[index].Cells["dsa_phiMay"].Value.ToString());
                if(dgvDanhSachAo.Rows[index].Cells["dsa_tinhTrang"].Value.ToString()=="Chờ thử")
                {
                    gbSuaAo.Enabled = true; btnXacNhanSua.Enabled = true; btnNhanAo.Enabled = true;
                }
                else
                {
                    gbSuaAo.Enabled = false; btnXacNhanSua.Enabled = false; btnNhanAo.Enabled = false;
                }
               
            }
            catch (Exception)
            {

            }
        }

        private void dgvDanhSachQuan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachQuan.CurrentCell.RowIndex;
                maQuan = dgvDanhSachQuan.Rows[index].Cells["dsq_Id"].Value.ToString();
                pbVaiMayQuan.Image = (System.Drawing.Image)dgvDanhSachQuan.Rows[index].Cells["dsq_anhDaiDien"].FormattedValue;
                chonAo = false;btnXacNhanSua.Enabled = true;btnNhanAo.Enabled = true;
                phi = Convert.ToDecimal(dgvDanhSachQuan.Rows[index].Cells["dsq_phiMay"].Value.ToString());
                gbSuaAo.Enabled = true;
                if(dgvDanhSachQuan.Rows[index].Cells["dsq_tinhTrang"].Value.ToString()=="Chờ thử")
                {
                    gbSuaAo.Enabled = true; btnXacNhanSua.Enabled = true; btnNhanAo.Enabled = true;
                }
                else
                {
                    gbSuaAo.Enabled = false; btnXacNhanSua.Enabled = false; btnNhanAo.Enabled = false;
                }

            }
            catch (Exception)
            {

            }
        }
        decimal phi = 0;
        private void btnNhanAo_Click(object sender, EventArgs e)
        {
            if (chonAo)
            {
                if (MessageBox.Show("Nhận áo này ?", "Nhận áo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string er = "";
                    if (dbThuAo.NhanAo(ref er, maAo))
                    {
                        btnNhanAo.Enabled = false;
                        pbVaiMayAo.Image = null;
                        pbVaiMayQuan.Image = null;
                        dgvDanhSachAo.DataSource = dbThuAo.GetAoDuocMayChoThu(maHD);
                    }                   
                }
            }
            else
            {
                if (MessageBox.Show("Nhận quần này ?", "Nhận quần!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string er = "";
                    if (dbThuAo.NhanQuan(ref er, maQuan))
                    {
                        btnNhanAo.Enabled = false;
                        pbVaiMayAo.Image = null;
                        pbVaiMayQuan.Image = null;
                        dgvDanhSachQuan.DataSource = dbThuAo.GetQuanDuocMayChoThu(maHD);
                    }
                }
            }
            lbThanhTien.Text = (Convert.ToDecimal(lbThanhTien.Text)+phi).ToString();
        }

        private void txTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienThoi.Text = (Convert.ToDecimal(txTienKhachDua.Text)-Convert.ToDecimal(lbThanhTien)).ToString();
            }
            catch (Exception) { }
        }

        private void txtPhiSua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
        }
    }
}
