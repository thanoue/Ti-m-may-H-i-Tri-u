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
   public class dbKhachHang
    {
        DAFramework db;
        public dbKhachHang()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetKhachHang()
        {
            return db.ExecuteQuery("spGetKhachHang", CommandType.StoredProcedure, null);
        }
        public string GetTenKHTheoMa(int maKH)
        {
            return db.GetTenKHTheoMaKH(maKH);
        }
        public string GetTenKHTheoMaHDBanVai(int maHD)
        {
            return db.GetTenKHTheoMaHDBanVai(maHD);
        }
        public DataTable TimKhachHangTheoTen(string tenKhachHang)
        {
            return db.ExecuteQuery("spTimKHTheoTen", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKhachHang));
        }
        public bool InsertKhachHang(ref string error, string tenKhachHang, string soDienThoai,
       string diaChi, string ghiChu)
        {

            return db.ExcuteNoneQuery("spInsertKhachHang", CommandType.StoredProcedure, ref error,

                new SqlParameter("@tenKhachHang", tenKhachHang),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@diaChi", diaChi),
                new SqlParameter("@ghiChu",ghiChu)
                );
        }
        public bool DeleteKhachHang(ref string error, int maKhachHang)
        {
            return db.ExcuteNoneQuery("spDeleteKH", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maKH", maKhachHang));
        }

        public bool UpdateKhachHang(ref string error, int maKhachHang, string tenKhachHang, string soDienThoai,
            string diaChi, string ghiChu)
        {
            return db.ExcuteNoneQuery("spUpdateKhachHang", CommandType.StoredProcedure, ref error,
               new SqlParameter("@Id", maKhachHang),
               new SqlParameter("@tenKhachHang", tenKhachHang),
               new SqlParameter("@soDienThoai", soDienThoai),
               new SqlParameter("@diaChi", diaChi),
               new SqlParameter("@ghiChu", ghiChu));
        }

    }
}
