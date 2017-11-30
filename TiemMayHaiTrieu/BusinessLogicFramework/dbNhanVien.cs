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
    public class dbNhanVien
    {
        DAFramework db;
      public dbNhanVien()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetNVCat()
        {
            return db.ExecuteQuery("spGetNVCat", CommandType.StoredProcedure, null);
        }
        public DataTable GetNVMay()
        {
            return db.ExecuteQuery("spGetNVMay", CommandType.StoredProcedure, null);
        }
        public DataTable GetNVLuong()
        {
            return db.ExecuteQuery("spGetNVLuong", CommandType.StoredProcedure, null);
        }
        public DataTable GetLoaiNV()
        {
            return db.ExecuteQuery("spGetLoaiNhanVien", CommandType.StoredProcedure, null);
        }
        public string GetTenNV(int maNV)
        {
            return db.getTenNVSua(maNV);
        }
        public bool UpdateNhanVien(ref string error, int maNhanVien,string tenNhanVien,int maLoaiNhanVien,string soDienThoai,byte[] anhDaiDien) 
        {
            return db.ExcuteNoneQuery("spUpdateNhanVien", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter(@"maLoaiNhanVien", maLoaiNhanVien),
                new SqlParameter("@soDienThoai", soDienThoai),
                new SqlParameter("@tenNhanVien",tenNhanVien),
                new SqlParameter("@anhDaiDien", anhDaiDien)
                );
        }
        public bool DeleteNhanVien(ref string error, int maNhanVien)
        {
            return db.ExcuteNoneQuery("spDeleteNhanVien", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maNhanVien", maNhanVien)
               
                );
        }

        public DataTable GetNhanVien()
        {
            return db.ExecuteQuery("spGetNhanVien", CommandType.StoredProcedure, null);
        }
        public bool InsertNhanVien(ref string error,string tenNhanVien,int maLoaiNV,string SDT,byte[] anhDaiDien)
        {
            return db.ExcuteNoneQuery("spInsertNhanVien", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@tenNhanVien", tenNhanVien),
                new SqlParameter("@maLoaiNhanVien", maLoaiNV),
                new SqlParameter("@soDienThoai", SDT),
                new SqlParameter("@anhDaiDien", anhDaiDien)

                );
        }

    }
}
