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
   public  class dbPhanCongTho
    {
        DAFramework db;
        public dbPhanCongTho()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetDSChoPhanCong()
        {
            return db.ExecuteQuery("spDanhSachChoPhanCong", CommandType.StoredProcedure, null);
        }
        public DataTable TimAoChoPCTheoMaAo(int maAo)
        {
            return db.ExecuteQuery("spTimAoCPCTheoMaAo", CommandType.StoredProcedure, new SqlParameter("@maAoMay", maAo));
        }
        public DataTable TimAoChoPCTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimAoCPCTheoTenKH", CommandType.StoredProcedure, new SqlParameter("@tenKhachHang", tenKH));
        }
        public bool PhanCongTho(ref string error, int maAo,int maThoCat,int maThoMay,int maThoLuong,int maThomayQuan)
        {
            return db.ExcuteNoneQuery("spPhanCongThoChoAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@mAo",maAo ),
                 new SqlParameter("@maThoCat", maThoCat),
                  new SqlParameter("@maThoMay", maThoMay),
                   new SqlParameter("@maThoLuong",maThoLuong),
                   new SqlParameter("@maThoMayQuan", maThomayQuan)
                );
        }
    }
}
