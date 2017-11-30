using DataAcessFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicFramework
{
   public  class dbMayAo
    {
        DAFramework db;
        public dbMayAo()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
       
        public DataTable GetCoAo()
        {
            return db.ExecuteQuery("spGetCoAo", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSChiTietAomay(int maHD)
        {
            return db.ExecuteQuery("spDanhSachAoMayTheoMaHoaDonMay", CommandType.StoredProcedure,
                new SqlParameter("@maHD",maHD));
        }

        public DataTable GetAoDuocMayTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetAoDuocMayTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable GetQuanDuocMayTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetQuanDuocMayTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public int GetMaHoaDonMaySeThem()
        {
            return db.GetmaHoaDonMayAoHienHanh();
        }
        public bool DeleteHoaDonMayAo(ref string er,int maHD)
        {
            return db.ExcuteNoneQuery("spDeleteHoaDonMayAo", CommandType.StoredProcedure, ref er,
                new SqlParameter("@maHD", maHD));
        }
        public int MaAoLonNhat(int maHD)
        {
            return db.GetMaAoLonNhatTheoMaHDMayAo(maHD);
        }
        public int MaQuanLonNhat(int maHD)
        {
            return db.GetMaQuanLonNhatTheoMaHDMayAo(maHD);
        }
        public bool DeleteAoDuocMay(ref string er, string maCT)
        {
            return db.ExcuteNoneQuery("spDeleteAoDuocMay", CommandType.StoredProcedure, ref er,
                new SqlParameter("@maCT", maCT));
        }
        public bool DeleteQuanDuocMay(ref string er, string maCT)
        {
            return db.ExcuteNoneQuery("spDeleteQuanDuocMay", CommandType.StoredProcedure, ref er,
                new SqlParameter("@maCT", maCT));
        }
        public bool XacNhanThemHoaDon(ref string er, int maHD,decimal tongTien,string soDo,DateTime ngayHenThu,int soAo,int soQuan,string ghiChu)
        {
            return db.ExcuteNoneQuery("spUpdateHoaDonMayAo", CommandType.StoredProcedure, ref er,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@thanhTien", tongTien),
                  new SqlParameter("@soDo", soDo),
                     new SqlParameter("@ngayHenThu", ngayHenThu),
                     new SqlParameter("@soAo", soAo),
                     new SqlParameter("@soQuan", soQuan),
                     new SqlParameter("@ghiChu", ghiChu));
        }
        public bool BackupDB(ref string er,string path)
        {
            return db.ExcuteNoneQuery("spBackUpDataBase", CommandType.StoredProcedure, ref er,
               new SqlParameter("@adress", path));
        }
        public bool InsertAoDuocMay(ref string error,byte[] anhAo,string Id,string ghiChu,string loaiVai,decimal phiMay,int maHoaDonMay,
            string loaiCo,string kichThuocCo,int ma)
        {

            return db.ExcuteNoneQuery("spInsertAoDuocMay", CommandType.StoredProcedure, ref error,
                new SqlParameter("@anhDaiDien",anhAo),
                   new SqlParameter("@Id",Id)
                   ,new SqlParameter("@ghiChu", ghiChu),
                new SqlParameter("@loaiVai", loaiVai),
                   new SqlParameter("@phiMay", phiMay),
                    new SqlParameter("@maHoaDonMay", maHoaDonMay),
                 new SqlParameter("@loaiCo",loaiCo), new SqlParameter("@kichThuocCo", kichThuocCo)
                , new SqlParameter("@ma",ma)
                );
        }
        public bool InsertQuanDuocMay(ref string error, byte[] anhAo, string Id, string ghiChu, string loaiVai, decimal phiMay, int maHoaDonMay,int ma
        )
        {

            return db.ExcuteNoneQuery("spInsertQuanDuocMay", CommandType.StoredProcedure, ref error,
                new SqlParameter("@anhDaiDien", anhAo),
                   new SqlParameter("@Id", Id)
                   , new SqlParameter("@ghiChu", ghiChu),
                new SqlParameter("@loaiVai", loaiVai),
                   new SqlParameter("@phiMay", phiMay),
                    new SqlParameter("@maHoaDonMay", maHoaDonMay), new SqlParameter("@ma", ma)
                );
        }

        public bool InsertHoaDonAoMay(ref string error,int maHD ,int maKhachHang ,DateTime ngayLapHoaDon ,DateTime ngayHenThu ,                                
                                 string ghiChu, decimal tongPhiMay,int soAo,int soQuan,
                               byte[] anhDaiDien,string soDoDaiDien)
        {

            return db.ExcuteNoneQuery("spInsertHoaDonMayAo", CommandType.StoredProcedure, ref error,
                 new SqlParameter("@maHD", maHD),
                new SqlParameter("@maKhachHang", maKhachHang),
                new SqlParameter("@ngayLapHoaDon", ngayLapHoaDon),
                new SqlParameter("@ngayHenThu", ngayHenThu),                
                       new SqlParameter("@soDoDaiDien", soDoDaiDien),
                          new SqlParameter("@anhDaiDien", anhDaiDien),
              new SqlParameter("@ghiChu", ghiChu),
                 new SqlParameter("@soAo", soAo), new SqlParameter("@soQuan", soQuan),
                   new SqlParameter("@tongPhiMay", tongPhiMay)

                );
        }

    }
}
