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
    public partial class frmChoSua : Form
    {
        public frmChoSua()
        {
            InitializeComponent();
        }
        dbSuaAo dbSuaAo = new dbSuaAo();
        private void frmChoSua_Load(object sender, EventArgs e)
        {

        }

        private void btnTaiLaiBang_Click(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbSuaAo.GetDSHDCoAoChoSua();

        }
        int maSua = 0;
       
        string maAo = "";string maQuan = "";
        private void button8_Click(object sender, EventArgs e)
        {
            new frmDanhSachSua().ShowDialog();
        }

        private void gbThongTinSuaAo_Enter(object sender, EventArgs e)
        {

        }

        private void btnXacNhanSuaXong_Click(object sender, EventArgs e)
        {
            if (chonAo)
            {
                if (MessageBox.Show("Sửa xong áo này?!", "sửa xong áo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string er = "";
                    if(dbSuaAo.SuaAoXong(ref er, dsa_maSua, maAo, Convert.ToDecimal(txtPhiSuaAo.Text)))
                    {
                        btnXacNhanSuaXong.Enabled = false;
                        dgvDanhSachAo.DataSource = dbSuaAo.GetDSAoSuaTheoMaHD(maHD);
                        rtxtNoiDungSua.Text = "";txtPhiSuaAo.Text = "0";
                        pbVaiAoSua.Image = null;pbVaiQuanSua.Image = null;
                    }
                    
                }
            }
            else
            {
                if (MessageBox.Show("Sửa xong quần này?!", "sửa xong áo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string er = "";
                    if (dbSuaAo.SuaQuanXong(ref er, dsq_maSua, maQuan, Convert.ToDecimal(txtPhiSuaAo.Text)))
                    {
                        btnXacNhanSuaXong.Enabled = false;
                        dgvDanhSachQuan.DataSource = dbSuaAo.GetDSQuanSuaTheoMaHD(maHD);
                        rtxtNoiDungSua.Text = ""; txtPhiSuaAo.Text = "0";
                        pbVaiAoSua.Image = null; pbVaiQuanSua.Image = null;
                    }

                }
            }
            
        }

        private void gbChoSua_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimAoDeSua_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "0";txtTimAoDeSua.Text = "";
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {       
                    dgvDSHD.DataSource = dbSuaAo.TimDSHDCoAoChoSuaTheoMaHD(Int32.Parse(txtMaHD.Text));
            }
            catch (Exception)
            {

            }
       
        }
        private void txtTimAoDeSua_TextChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbSuaAo.TimDSHDCoAoChoSuaTheoTTKH(txtTimAoDeSua.Text);
        }
        int maHD = 0;
        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentCell.RowIndex;
                maHD = Int32.Parse(dgvDSHD.Rows[index].Cells["dshd_Id"].Value.ToString());
                lbMaHoaDonMay.Text = maHD.ToString();
                pbAnhDaiDienHD.Image = (System.Drawing.Image)dgvDSHD.Rows[index].Cells["dshd_anhDaiDien"].FormattedValue;
                dgvDanhSachAo.DataSource = dbSuaAo.GetDSAoSuaTheoMaHD(maHD);
                dgvDanhSachQuan.DataSource = dbSuaAo.GetDSQuanSuaTheoMaHD(maHD);btnXacNhanSuaXong.Enabled = false;
            }
            catch (Exception) { }
        }
        int dsa_maSua = 0;int dsq_maSua = 0;bool chonAo = false;
        private void dgvDanhSachAo_Click(object sender, EventArgs e)
        {
            try
            {
                btnXacNhanSuaXong.Enabled = true;
                int index = dgvDanhSachAo.CurrentCell.RowIndex;chonAo = true;
                maAo = dgvDanhSachAo.Rows[index].Cells["dsa_maAo"].Value.ToString();
                dsa_maSua = Int32.Parse(dgvDanhSachAo.Rows[index].Cells["dsa_Id"].Value.ToString());
                rtxtNoiDungSua.Text = dgvDanhSachAo.Rows[index].Cells["dsa_noiDungSua"].Value.ToString();
                pbVaiAoSua.Image = (System.Drawing.Image)dgvDanhSachAo.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                txtPhiSuaAo.Text = dgvDanhSachAo.Rows[index].Cells["dsa_congSua"].Value.ToString();

            }
            catch (Exception) { }
        }

        private void dgvDanhSachQuan_Click(object sender, EventArgs e)
        {
            try
            {
                btnXacNhanSuaXong.Enabled = true;
                int index = dgvDanhSachQuan.CurrentCell.RowIndex; chonAo = false ;
                maQuan = dgvDanhSachQuan.Rows[index].Cells["dsq_maQuan"].Value.ToString();
                dsq_maSua = Int32.Parse(dgvDanhSachQuan.Rows[index].Cells["dsq_Id"].Value.ToString());
                rtxtNoiDungSua.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_noiDungSua"].Value.ToString();
                pbVaiQuanSua.Image = (System.Drawing.Image)dgvDanhSachQuan.Rows[index].Cells["dsq_anhDaiDien"].FormattedValue;
                txtPhiSuaAo.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_congSua"].Value.ToString(); 

            }
            catch (Exception) { }
        }
    }
}
