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
   public class dbSuaAo
    {
        DAFramework db;
        public dbSuaAo()
        {
            db = new DAFramework(infoClass.getTenDanNhap()) ;
        }
        public DataTable GetDSHDCoAoChoSua()
        {
            return db.ExecuteQuery("spGetDSHDCoAoChoSua", CommandType.StoredProcedure, null);
        }
		public DataTable GetDSDaThanhToan()
		{
			return db.ExecuteQuery("spgetSuaDaThanhToan", CommandType.StoredProcedure, null);
		}
        public DataTable TimDSHDCoAoChoSuaTheoTTKH(string key)
        {
            return db.ExecuteQuery("spTimDSHDCoAoChoSuaTheoTTKH", CommandType.StoredProcedure,
                new SqlParameter("@key", key));
        }
        public DataTable GetDSAoSuaTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetDSAoSuaTheoMaHD", CommandType.StoredProcedure, 
                new SqlParameter("@maHD", maHD));
        }
        public DataTable GetDSQuanSuaTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetDSQuanSuaTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHd", maHD));
        }
        public DataTable TimDSHDCoAoChoSuaTheoMaHD(int key)
        {
            return db.ExecuteQuery("spTimDSHDCoAoChoSuaTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@key", key));
        }
        public DataTable TimSuaChuaTTTheoTenKh(string tenKH)
		{
			return db.ExecuteQuery("spTimAoSuaChuaThanhToanTheoTenKH", CommandType.StoredProcedure,
				new SqlParameter("@tenKhachHang",tenKH));
		}
		public DataTable TimSuaDaTTTheoTenKh(string tenKH)
		{
			return db.ExecuteQuery("spTimAoSuaDaThanhToanTheoTenKH", CommandType.StoredProcedure,
				new SqlParameter("@tenKhachHang", tenKH));
		}
		public DataTable GetDSChuaThanhToan()
		{
			return db.ExecuteQuery("spgetSuaChuaThanhToan", CommandType.StoredProcedure, null);
		}
		public bool ThanhToanSua(ref string error,int maSua)
		{
			return db.ExcuteNoneQuery("spThanhToanSua", CommandType.StoredProcedure, ref error,
				new SqlParameter("@maSua", maSua));
		}
		public bool SuaAoXong(ref string error, int maSua,string maAo,decimal phi)
        {
            return db.ExcuteNoneQuery("spSuaAoXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maSua", maSua),
                new SqlParameter("@maAo", maAo),
                new SqlParameter("@tienCongSua", phi)
                );
        }
        public bool SuaQuanXong(ref string error, int maSua, string maQuan, decimal phi)
        {
            return db.ExcuteNoneQuery("spSuaQuanXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maSua", maSua),
                new SqlParameter("@maQuan", maQuan),
                new SqlParameter("@tienCongSua", phi)
                );
        }
        public bool ThanhToanCongSuaAo(ref string error, int maSua)
        {
            return db.ExcuteNoneQuery("spThanhToanCongSuaAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maSua", maSua)            
                );
        }
        public bool ThanhToanCongSuaQuan(ref string error, int maSua)
        {
            return db.ExcuteNoneQuery("spThanhToanCongSuaQuan", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maSua", maSua)
                );
        }

        public string GetTenNVSua(int maNV)
        {
            return db.getTenNVSua(maNV);
        }
        public DataTable GetCTHDTheoHD(int maHD)
        {
            return db.ExecuteQuery("spGetChiTietHDTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable getDSHDCoAoSuaXong()
        {
            return db.ExecuteQuery("spgetDSHDCoAoSuaXong", CommandType.StoredProcedure,
               null);
        }
        public DataTable getDSHDCoAoSuaXongTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spgetDSHDCoAoSuaXongTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH",tenKH));
        }
        public DataTable GetDSAoSuaTheoMaHD_DaSua(int maHD)
        {
            return db.ExecuteQuery("spGetDSAoSuaTheoMaHD_DaSua", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }

        public DataTable GetDSQuanSuaTheoMaHD_DaSua(int maHD)
        {
            return db.ExecuteQuery("spGetDSQuanSuaTheoMaHD_DaSua", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
    }
}
