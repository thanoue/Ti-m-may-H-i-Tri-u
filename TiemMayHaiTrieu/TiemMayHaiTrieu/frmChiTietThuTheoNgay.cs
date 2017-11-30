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
    public partial class frmChiTietThuTheoNgay : Form
    {
        public frmChiTietThuTheoNgay()
        {
            InitializeComponent();
        }
        DateTime ngayDau; DateTime ngayCuoi;
        public frmChiTietThuTheoNgay(DateTime ngayDau,DateTime ngayCuoi):this()
        {
            this.ngayDau = ngayDau;
            this.ngayCuoi = ngayCuoi;
        }
        dbTienDoMay dbTienDoMay = new dbTienDoMay();
        private void frmChiTietThuTheoNgay_Load(object sender, EventArgs e)
        {
            lbNgayDau.Text = ngayDau.ToShortDateString(); lbNgayCuoi.Text = ngayCuoi.ToShortDateString();
            dgvTongThuAo.DataSource = dbTienDoMay.TongThuTheoThoiGian_Ao(ngayDau, ngayCuoi);
            dgvTongThuQuan.DataSource = dbTienDoMay.TongThuTheoThoiGian_Quan(ngayDau, ngayCuoi);
            dgvTongSLAo.DataSource = dbTienDoMay.SoLuongTienDoTheoThoiGian_Ao(ngayDau, ngayCuoi);
            dgvTongSLQuan.DataSource = dbTienDoMay.SoLuongTienDoTheoThoiGian_Quan(ngayDau, ngayCuoi);
        }
    }
}
