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
using Microsoft.Reporting.WinForms;

namespace TiemMayHaiTrieu
{
    public partial class ReportDemo : Form
    {
        public ReportDemo()
        {
            InitializeComponent();
        }
        public ReportDemo(int maHD, string tenKH,string ngayHenNhanHang):this()//hóa đơn đặt hàng
        {
            this.spGetCTHDDatHangTheoMaHDTableAdapter.Fill(this.HoaDonDatHangDataSet.spGetCTHDDatHangTheoMaHD,maHD);
            tabControl1.SelectedTab = tabHDDatHang;
            ReportParameter mahd = new ReportParameter("maHD");
            mahd.Values.Add(maHD.ToString());
            this.rvHoaDonDatHang.LocalReport.SetParameters(mahd);
            ReportParameter tenKhachHang = new ReportParameter("tenKhachHang");
            tenKhachHang.Values.Add(tenKH);
            this.rvHoaDonDatHang.LocalReport.SetParameters(tenKhachHang);
            DateTime dste = new DateTime(); dste = DateTime.Now;
            ReportParameter ngayLapHD = new ReportParameter("ngayLapHoaDon");
            ngayLapHD.Values.Add(dste.ToString());
            this.rvHoaDonDatHang.LocalReport.SetParameters(ngayLapHD);
            ReportParameter ngayHenNhan = new ReportParameter("ngayHenNhanHang");
            ngayHenNhan.Values.Add(ngayHenNhanHang);
            this.rvHoaDonDatHang.LocalReport.SetParameters(ngayHenNhan);
            this.rvHoaDonDatHang.RefreshReport();
        }
        public ReportDemo(int maHD) :this()//hóa đơn bán vải
        {

          
            // TODO: This line of code loads data into the 'HoaDonBanVaiDataSet.spXuatHoaDonBanVai' table. You can move, or remove it, as needed.
            this.spXuatHoaDonBanVaiTableAdapter.Fill(this.HoaDonBanVaiDataSet.spXuatHoaDonBanVai, maHD);
            tabControl1.SelectedTab = tabHDBanVai;
            ReportParameter mahd = new ReportParameter("MaHD");
            mahd.Values.Add(maHD.ToString());
            this.rvHDBanVai.LocalReport.SetParameters(mahd);
            ReportParameter tenKH = new ReportParameter("TenKH");
            tenKH.Values.Add(dbKhachHang.GetTenKHTheoMaHDBanVai(maHD));
            this.rvHDBanVai.LocalReport.SetParameters(tenKH);
            DateTime dste = new DateTime(); dste = DateTime.Now.Date;
            ReportParameter ngayLapHD = new ReportParameter("NgayLapHoaDon");
            ngayLapHD.Values.Add(dste.ToString());
            this.rvHDBanVai.LocalReport.SetParameters(ngayLapHD);
            this.rvHDBanVai.RefreshReport();
     
        }
        public ReportDemo(int maHD,string tenKH,DateTime ngayHenTra,DateTime ngayLapHDThueAo) :this()//hóa đơn nhận áo thue
        {
            
            // TODO: This line of code loads data into the 'HoaDonBanVaiDataSet.spXuatHoaDonBanVai' table. You can move, or remove it, as needed.
            this.spGetCTHDThueAoTheoMaHDTableAdapter.Fill(this.TiemMayHaiTrieuDataSet.spGetCTHDThueAoTheoMaHD, maHD);
            tabControl1.SelectedTab = tabPNA;
            ReportParameter mahd = new ReportParameter("maHD");
            mahd.Values.Add(maHD.ToString());
            this.rvPNA.LocalReport.SetParameters(mahd);
            ReportParameter tenKhachHang = new ReportParameter("tenKhachHang");
            tenKhachHang.Values.Add(tenKH);
            this.rvPNA.LocalReport.SetParameters(tenKhachHang);
            DateTime thisDate = new DateTime(); thisDate = DateTime.Now;
            ReportParameter homNay = new ReportParameter("thisDate");
            homNay.Values.Add(thisDate.ToString());
            this.rvPNA.LocalReport.SetParameters(homNay);
            ReportParameter ngayLapHD = new ReportParameter("ngayLapHoaDon");
            ngayLapHD.Values.Add(ngayLapHDThueAo.ToString());
            this.rvPNA.LocalReport.SetParameters(ngayLapHD);
            ReportParameter ngayHenTraAo = new ReportParameter("ngayHenTra");
            ngayHenTraAo.Values.Add(ngayHenTra.ToString());
            this.rvPNA.LocalReport.SetParameters(ngayHenTraAo);
            this.rvPNA.RefreshReport();
        }
        public ReportDemo(int maHD, string tenKH) :this()
        {
            this.spGetCTHDBanAoTheoMaHDTableAdapter.Fill(this.HoaDonBanHangDataSet.spGetCTHDBanAoTheoMaHD,maHD);
            tabControl1.SelectedTab = tabHDBanHang;
            ReportParameter mahd = new ReportParameter("maHD");
            mahd.Values.Add(maHD.ToString());
            this.rvHDBanHang.LocalReport.SetParameters(mahd);
            ReportParameter tenKhachHang = new ReportParameter("tenKH");
            tenKhachHang.Values.Add(tenKH);
            this.rvHDBanHang.LocalReport.SetParameters(tenKhachHang);
            DateTime dste = new DateTime(); dste = DateTime.Now;
            ReportParameter ngayLapHD = new ReportParameter("ngayLapHD");
            ngayLapHD.Values.Add(dste.ToString());
            this.rvHDBanHang.LocalReport.SetParameters(ngayLapHD);
            this.rvHDBanHang.RefreshReport();
        }
        public ReportDemo(int maHD, string tenKhachHang, string ngayHenThu, string tongPhiMay) :this()//hóa đơn may áo!!
        {
            this.spGetAoDuocMayTheoMaHDTableAdapter.Fill(this.HoaDonMayAo.spGetAoDuocMayTheoMaHD,maHD);
            this.spGetQuanDuocMayTheoMaHDTableAdapter.Fill(this.HoaDonMayAo.spGetQuanDuocMayTheoMaHD,maHD);
            tabControl1.SelectedTab = tabHDMayAo;
            ReportParameter mahd = new ReportParameter("maHD");
            mahd.Values.Add(maHD.ToString());
            this.rvHDMayAo.LocalReport.SetParameters(mahd);
            ReportParameter tenKH = new ReportParameter("tenKH");
            tenKH.Values.Add(tenKhachHang);
            this.rvHDMayAo.LocalReport.SetParameters(tenKH);
            DateTime dste = new DateTime(); dste = DateTime.Now;
            ReportParameter ngayLapHD = new ReportParameter("ngayLapHoaDon");
            ngayLapHD.Values.Add(dste.ToString());
            this.rvHDMayAo.LocalReport.SetParameters(ngayLapHD);
            ReportParameter ngayHenT = new ReportParameter("ngayHenThu");
            ngayHenT.Values.Add(ngayHenThu);
            this.rvHDMayAo.LocalReport.SetParameters(ngayHenT);
            ReportParameter TongPhi = new ReportParameter("tongPhiMay");
            TongPhi.Values.Add(tongPhiMay);
            this.rvHDMayAo.LocalReport.SetParameters(TongPhi);
            this.rvHDMayAo.RefreshReport();
        }
        dbKhachHang dbKhachHang = new dbKhachHang();
        private void ReportDemo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HoaDonMayAo.spGetAoDuocMayTheoMaHD' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'HoaDonMayAo.spGetQuanDuocMayTheoMaHD' table. You can move, or remove it, as needed.
          


          
            
        }

        private void spBangLuongBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
    