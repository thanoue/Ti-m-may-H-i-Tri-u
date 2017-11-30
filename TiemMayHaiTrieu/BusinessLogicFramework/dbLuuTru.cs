
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
     public class dbLuuTru
    {
        DAFramework db;
        public dbLuuTru()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetDSAoDaChamCong()
        {
            return db.ExecuteQuery("spGetDSAoDaCoLuong", CommandType.StoredProcedure, null);
        }
        public DataTable GetCTHDMayTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetCTHDMayTheoMaHDMayLuuTru", CommandType.StoredProcedure, 
                 new SqlParameter("@maHD",maHD));
        }
        public DataTable TimAoDangSuaTimAoDaCoLuongTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimAoDaCoLuongTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable TimHDBanAoTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimHDBanAoTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable GetDSHoaDon()
        {
            return db.ExecuteQuery("spGetDSHoaDon", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSHoaDonBanAo()
        {
            return db.ExecuteQuery("spgetDSHoaDonBanAo", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSHoaDonMayAo()
        {
            return db.ExecuteQuery("spGetDSHDMayAo", CommandType.StoredProcedure, null);
        }
        public DataTable TimHDTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimHDTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH));
        }
        public DataTable GetCTHDBanAoTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetCTHDBanAoTheoMaHD2", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable GetCTHDTheoHD(int maHD)
        {
            return db.ExecuteQuery("spGetChiTietHDTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
       
    }
}
