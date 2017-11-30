using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessFramework;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicFramework
{
    public class dbLuong
    {
        DAFramework db;
        public dbLuong()
        {
            db = new DAFramework(infoClass.tenDangNhap);
        }
        public DataTable GetLuongTheoNhom(string maLoaiNV)
        {
            return db.ExecuteQuery("spGetLuongTungLoai", CommandType.StoredProcedure,
                new System.Data.SqlClient.SqlParameter("@maNhomTienCong",maLoaiNV));
        }
        public bool CapNhatLuongCat(ref string error,decimal a,decimal b,decimal c,decimal d,decimal e,decimal f)
        {
            return db.ExcuteNoneQuery("spCapNhatLuongCat", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@1", a),
                 new SqlParameter("@2", b),
                new SqlParameter("@3", c),
                new SqlParameter("@4", d),
                new SqlParameter("@5", e),
                 new SqlParameter("@6", f)
                );
        }
        public bool CapNhatLuongMay(ref string error, decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            return db.ExcuteNoneQuery("spCapNhatLuongMay", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@1", a),
                 new SqlParameter("@2", b),
                new SqlParameter("@3", c),
                new SqlParameter("@4", d),
                new SqlParameter("@5", e),
                 new SqlParameter("@6", f)
                );
        }
        public bool CapNhatLuongLuong(ref string error, decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            return db.ExcuteNoneQuery("spCapNhatLuongLuong", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@1", a),
                 new SqlParameter("@2", b),
                new SqlParameter("@3", c),
                new SqlParameter("@4", d),
                new SqlParameter("@5", e),
                 new SqlParameter("@6", f)
                );
        }
        public bool CapNhatLuongCatQuan(ref string error, decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            return db.ExcuteNoneQuery("spCapNhatLuongCatQuan", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@1", a),
                 new SqlParameter("@2", b),
                new SqlParameter("@3", c),
                new SqlParameter("@4", d),
                new SqlParameter("@5", e),
                 new SqlParameter("@6", f)
                );
        }
        public bool CapNhatLuongMayQuan(ref string error, decimal a, decimal b, decimal c, decimal d, decimal e, decimal f)
        {
            return db.ExcuteNoneQuery("spCapNhatMayQuan", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@1", a),
                 new SqlParameter("@2", b),
                new SqlParameter("@3", c),
                new SqlParameter("@4", d),
                new SqlParameter("@5", e),
                 new SqlParameter("@6", f)
                );
        }
     
    }
}
