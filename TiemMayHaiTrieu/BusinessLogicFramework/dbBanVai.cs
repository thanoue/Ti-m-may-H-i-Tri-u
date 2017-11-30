
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessFramework;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicFramework
{
    public  class dbBanVai
    {
        DAFramework db;
        public dbBanVai()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
     
        public DataTable GetDanhSachVaiDeChonMua()
        {
            return db.ExecuteQuery("spGetVaiDeChonMua", CommandType.StoredProcedure, null);
        }
        public DataTable TimVaiDeChonTheoTenVai(string tenLoaiVai)
        {
            return db.ExecuteQuery("TimAoTrongKhoDeChonTheoTenVai", CommandType.StoredProcedure,
                new SqlParameter("@tenLoaiVai", tenLoaiVai));
        }
        public int GetMaHoaDonBanHangHienHanh()
        {
            return db.GetmaHDBHHienHanh();
        }
        public bool InsertChiTietHoaDon(ref string error,int maHD,int maKH,string ghiChu,DateTime ngayLapHoaDon, int maLoaiVai, int soLuong,Decimal donGia,Decimal tongTien, byte[] anhDaiDien)

        {
            return db.ExcuteNoneQuery("spInsertChiTietHoaDon", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@maKH", maKH),
                 new SqlParameter("@ngayLapHoaDon",ngayLapHoaDon),
                 new SqlParameter("@ghiChu",ghiChu),
                 new SqlParameter("@maLoaiVai", maLoaiVai),
                   new SqlParameter("@soLuong", soLuong),
                     new SqlParameter("@donGia", donGia),
                       new SqlParameter("@tongTien", tongTien),
                         new SqlParameter("@anhDaiDien", anhDaiDien)
                );
        }
        public bool XoaVaiHetHang()
        {
            return db.XoaVaiHetHang();
        }
        public bool HoanTatMua(ref string err, int maHD,Decimal thanhTien)
        {
            return db.ExcuteNoneQuery("spHoanTatMua", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHD", maHD), new SqlParameter("@thanhTien", thanhTien)
               );
        }
        public bool DeleteCTHD(ref string err ,int maCTHD,int soLuong,int maVai)
        {
            return db.ExcuteNoneQuery("spDeLeteCTHD", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maCTHD",maCTHD), new SqlParameter("@soLuong",soLuong),
                new SqlParameter("@maVai",maVai));
        }
        public DataTable GetCTHDTheoHD(int maHD)
        {
            return db.ExecuteQuery("spGetChiTietHDTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
    }
}
