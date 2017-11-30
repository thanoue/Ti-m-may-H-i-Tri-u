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
    public partial class frmChietLuongThangNV : Form
    {
        public frmChietLuongThangNV()
        {
            InitializeComponent();
        }
        int maNV;int maThang;int maNam;
        public frmChietLuongThangNV(int maNV,int maThang,int maNam):this()
        {
            this.maNV = maNV;this.maThang = maThang;this.maNam = maNam;
        }
        dbNhanVien dbNhanVien = new dbNhanVien(); dbBangLuong dbBangLuong = new dbBangLuong();
        private void frmChietLuongThangNV_Load(object sender, EventArgs e)
        {
            lbTenNV.Text = dbNhanVien.GetTenNV(maNV);
            lbThang.Text = maThang.ToString();
            lbNam.Text = maNam.ToString();
            dgvDanhSachCat.DataSource = dbBangLuong.DSAoDaCat(maNV, maThang, maNam);
            dgvDanhSachMay.DataSource = dbBangLuong.DSAoDaMay(maNV, maThang, maNam);
            dgvDanhSachLuong.DataSource = dbBangLuong.DSAoDaLuong(maNV, maThang, maNam);
            dgvDanhSachCatQuan.DataSource = dbBangLuong.DSQuanDaCat(maNV, maThang, maNam);
            dgvDanhSachMayQuan.DataSource = dbBangLuong.DSQuanDaMay(maNV, maThang, maNam);
        }

        private void dgvDanhSachCat_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachCat.CurrentCell.RowIndex;
                pbAnhAo.Image = (System.Drawing.Image)dgvDanhSachCat.Rows[index].Cells["dsc_anhDaiDien"].FormattedValue;
            }
            catch (Exception)
            {

            }
           
        }

        private void dgvDanhSachMay_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachMay.CurrentCell.RowIndex;
                pbAnhAo.Image = (System.Drawing.Image)dgvDanhSachMay.Rows[index].Cells["dsm_anhDaiDien"].FormattedValue;
            }
            catch (Exception)
            {

            }

        }

        private void dgvDanhSachLuong_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachLuong.CurrentCell.RowIndex;
                pbAnhAo.Image = (System.Drawing.Image)dgvDanhSachLuong.Rows[index].Cells["dsl_anhDaiDien"].FormattedValue;
            }
            catch (Exception)
            {

            }
        }

        private void dgvDanhSachCatQuan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachCatQuan.CurrentCell.RowIndex;
                pbAnhQuan.Image = (System.Drawing.Image)dgvDanhSachCatQuan.Rows[index].Cells["dscq_anhDaiDien"].FormattedValue;
            }
            catch (Exception)
            {

            }
        }

        private void dgvDanhSachMayQuan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachMayQuan.CurrentCell.RowIndex;
                pbAnhQuan.Image = (System.Drawing.Image)dgvDanhSachMayQuan.Rows[index].Cells["dsmq_anhDaiDien"].FormattedValue;
            }
            catch (Exception)
            {

            }
        }
    }
}
