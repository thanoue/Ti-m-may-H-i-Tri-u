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
 public class dbThuAo
    {
        DAFramework db;
        public dbThuAo()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable TimHDChoThuTheoKh(string key)
        {
            return db.ExecuteQuery("spTimHDChoThuTheoKH", CommandType.StoredProcedure,
                new SqlParameter("@key",key));
        }
        public DataTable TimHDChoThuTheMaHD(int key)
        {
            return db.ExecuteQuery("spTimHDChoThuTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@key", key));
        }
        public DataTable GetDanhSachAoCanThu()
        {
            return db.ExecuteQuery("spDanhSacHDCoAoChoThu", CommandType.StoredProcedure, null);
        }
        public DataTable GetAoDuocMayChoThu(int mmaHD)
        {
            return db.ExecuteQuery("spGetAoDuocMayChoThu", CommandType.StoredProcedure,
                new SqlParameter("@maHD", mmaHD)
               );
        }
        public DataTable GetQuanDuocMayChoThu(int mmaHD)
        {
            return db.ExecuteQuery("spGetQuanDuocMayChoThu", CommandType.StoredProcedure,
                new SqlParameter("@maHD", mmaHD)
               );
        }
        public DataTable TimAoDanChoThuTheoTenKH(string tenKH)
        {
            return db.ExecuteQuery("spTimAoDanChoThuTheoTenKH", CommandType.StoredProcedure,
                 new SqlParameter("@tenKH", tenKH)
                );
        }
        public bool YeuCauSuaAo(ref string error, string maAo,string noiDungYC,decimal phiSua,int maNhanVien,DateTime ngayHenThuLai)
        {
            return db.ExcuteNoneQuery("spYeuCauSuaAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                new SqlParameter("@maNhanVien",maNhanVien),
                new SqlParameter("@congSua", phiSua),
                 new SqlParameter("@noiDungYC", noiDungYC),               
                   new SqlParameter("@ngayhenThulai", ngayHenThuLai)
                );
        }
        public bool YeuCauSuaQuan(ref string error, string maQuan, string noiDungYC, decimal phiSua, int maNhanVien, DateTime ngayHenThuLai)
        {
            return db.ExcuteNoneQuery("spYeuCauSuaQuan", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maquan", maQuan),
                new SqlParameter("@maNhanVien", maNhanVien),
                new SqlParameter("@congSua", phiSua),
                 new SqlParameter("@noiDungYC", noiDungYC),
                   new SqlParameter("@ngayhenThulai", ngayHenThuLai)
                );
        }

        public DataTable TimAoDanChoThuTheoMaAo(int maAo)
        {
            return db.ExecuteQuery("spTimAoDangChoThuTheoMaAo", CommandType.StoredProcedure,
                 new SqlParameter("@maAo", maAo)
                );
        }
        public bool NhanAo(ref string error, string maAo)
        {
            return db.ExcuteNoneQuery("spNhanAo", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@maAo", maAo)
                 
                );
        }
        public bool NhanQuan(ref string error, string maQuan)
        {
            return db.ExcuteNoneQuery("spNhanQuan", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@maQuan", maQuan)

                );
        }
    }
}
