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
    public class dbAoDaDuocNhan
    {
        DAFramework db;
        public dbAoDaDuocNhan()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetDSAoDaDuocNhan()
        {
            return db.ExecuteQuery("spDSAoDaNhan", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSCtHD(int maHD)
        {
            return db.ExecuteQuery("spGetCTHDAoDaNhanTheoMaHD", CommandType.StoredProcedure, 
                new SqlParameter("@maHD",maHD));
        }
        public DataTable TimAoDaNhanTheoKH(string key)
        {
            return db.ExecuteQuery("spTimHDAoDaNhanTheoKH", CommandType.StoredProcedure,
                new SqlParameter("@key", key));
        }
        public DataTable TimAoDaNhanTheoMaHD(int key)
        {
            return db.ExecuteQuery("spTimHDAoDaNhanTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@key", key));
        }
        public DataTable GetHDMayAoTheoNam(int maNam,int maKH)
        {
            return db.ExecuteQuery("spGetHDMayAoTheoNam", CommandType.StoredProcedure,
                new SqlParameter("@maNam", maNam),
                new SqlParameter("@maKhachHang",maKH));
        }
        public DataTable GetAoDuocMayTheoMaHD_LuuTru(int maHD)
        {
            return db.ExecuteQuery("spGetAoDuocMayTheoMaHD_LuuTru", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable GetQuanDuocMayTheoMaHD_LuuTru(int maHD)
        {
            return db.ExecuteQuery("spGetQuanDuocMayTheoMaHD_LuuTru", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }

        public DataTable TimHDMayAoTheoMaHD_LuuTru(int maHD)
        {
            return db.ExecuteQuery("spTimHDMayAoTheoMaHD_LuuTru", CommandType.StoredProcedure,
         
                new SqlParameter("@maHD", maHD)

                );
        }
        public bool XoaHoaDon(ref string error, int maHD)
        {
            return db.ExcuteNoneQuery("deleteHoaDonMayAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHD", maHD)
                );
        }
        public DataTable TimHDMayAoTheoSDTKhachHang_LuuTru(string sdt)
        {
            return db.ExecuteQuery("spTimHDMayAoTheoSDT_LuuTru", CommandType.StoredProcedure,

                new SqlParameter("@soDienThoai", sdt)

                );
        }

    }
}
