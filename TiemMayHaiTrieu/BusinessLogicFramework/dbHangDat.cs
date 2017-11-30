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
   public class dbHangDat
    {
        DAFramework db;
        public dbHangDat()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }


        public bool InsertCTHDDatHang(ref string error,int maHD, int maKH,string tenHang,string chiTiet,int soLuong,decimal giaTien,decimal tiencoc,decimal tienConLai,DateTime ngayHenLay,DateTime ngayLapHD,string ghiChu)
        {
            return db.ExcuteNoneQuery("spInsertChiTietHoaDonDatHang", CommandType.StoredProcedure,
                ref error,
                 new SqlParameter("@maHD", maHD),
                new SqlParameter("@maKhachHang", maKH),
                 new SqlParameter("@tenHang", tenHang),
                  new SqlParameter("@chiTiet", chiTiet),
                   new SqlParameter("@giaTien", giaTien),
                    new SqlParameter("@tienCoc", tiencoc),
                     new SqlParameter("@tienConLai", tienConLai),
                           new SqlParameter("@soLuong", soLuong),
                          new SqlParameter("@ngayLapHoaDon", ngayLapHD),
                      new SqlParameter("@ngayHenlay", ngayHenLay),
                         new SqlParameter("@ghiChu", ghiChu)
                );
        }
        public bool HangLamXong(ref string error, int maHangDat,  DateTime ngayThoGiao)
        {
            return db.ExcuteNoneQuery("spHangLamXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHangDat", maHangDat),
                 new SqlParameter("@ngayThoGiao", ngayThoGiao)
                 

                );
        }
        public DataTable TimHangDatChuaDT(string tenKH)
        {
            return db.ExecuteQuery("spTimHangDatChuaDTTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable GetDSHDDatHangChuaDatTho()
        {
            return db.ExecuteQuery("spgetDSHDDatHangChuaDatTho", CommandType.StoredProcedure,null);
        }

        public DataTable TimHangDatDaDT(string tenKH)
        {
            return db.ExecuteQuery("spTimHangDatDaDTTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }

        public DataTable TimHangDatTheoTen(string tenKH)
        {
            return db.ExecuteQuery("spTimHangDatTheotenKha", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable TimHangDatChalayTheoMaHang(int maHang)
        {
            return db.ExecuteQuery("spTimHangDatChuaLayTheoNaHang", CommandType.StoredProcedure,
                new SqlParameter("@maHang", maHang));
        }
        public DataTable TimHangDalayTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimHangDaLayTheoTenKh", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable TimHangDatChalayTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimHangDatChuaLayTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable GetDanhSachHDDatHangChoNhan()
        {
            return db.ExecuteQuery("spGetDSHDDatHangChoNhan", CommandType.StoredProcedure, null);
        }
        public DataTable GetDanhSachHDDatHangDaNhan()
        {
            return db.ExecuteQuery("spGetDSHDDatHangDaNhan", CommandType.StoredProcedure, null);
        }
        public DataTable GetCTHDDatHangTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("sdGetCTHDDatHangTheoMaHD", CommandType.StoredProcedure, new SqlParameter("@maHD",maHD));
        }
        public decimal TongTienConLaiCacCTHDDatHang(int maHD)
        {
            return db.TongTienConLaiCacCTHDDatHang(maHD);
        }
        public decimal TongTienCocCacCTHDDatHang(int maHD)
        {
            return db.TongTienCocCacCTHDDatHang(maHD);
        }

        public bool NhanHang(ref string error, int maHD, DateTime ngayLay)
        {
            return db.ExcuteNoneQuery("spNhanHang", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@ngaylay", ngayLay)


                );
        }
        public bool DatTho(ref string error, int maHD, DateTime ngayDatTho)
        {
            return db.ExcuteNoneQuery("spDatTho", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@ngayDatTho", ngayDatTho)
                );
        }
        public bool Giaohang(ref string error, int maHD, DateTime ngayThoGiao)
        {
            return db.ExcuteNoneQuery("spGiaohang", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@ngayThoGiao", ngayThoGiao)
                );
        }
        public string GetMaHDDatHangHienHanh()
        {
            return db.GetMaHDDatHangHienHanh().ToString();
        }
        public bool DeleteCTHDDatHang(ref string error, int Id)
        {
            return db.ExcuteNoneQuery("spDeleteCTHDDatHang", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@Id", Id)


                );
        }

        public DataTable GetDSHDDatHangDaDatTho()
        {
            return db.ExecuteQuery("spGetDSHDDatHangDaDatTho", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSCTHDTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetCTHDDatHangTheoMaHD", CommandType.StoredProcedure, 
                new SqlParameter("@maHD",maHD));
        }
        public DataTable GetDanhSachHangDaNhan()
        {
            return db.ExecuteQuery("spDanhSachHangDaNhan", CommandType.StoredProcedure, null);
        }
    }
}
