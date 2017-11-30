using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessFramework;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicFramework
{
    public class dbSuaNgoai
    {
        DAFramework db;
        public dbSuaNgoai()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetDSAoDangSua()
        {
            return db.ExecuteQuery("spGetDSHangNgoaiDangSua", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSAoDangChoThu()
        {
            return db.ExecuteQuery("spGetDSHangNgoaiDanChoThu", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSHangNgoaiDaNhan()
        {
            return db.ExecuteQuery("spGetDSHangNgoaiDaNhan", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSPhiSuaNgoaiChuaThanhToan()
        {
            return db.ExecuteQuery("spGetPhiSuaNgoaiChuaThanhToan", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSPhiSuaNgoaiDaThanhToan()
        {
            return db.ExecuteQuery("spGetPhiSuaNgoaiDaThanhToan", CommandType.StoredProcedure, null);
        }
        public bool YeuCauSua(ref string error,byte[] anhDaiDien,DateTime ngayHenLay,string noiDungSua,string chiTietSua,int maKhachHang,int maNhanVien)
        {
            return db.ExcuteNoneQuery("spInsertSuaNgoai", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@anhDaiDien", anhDaiDien),
     
                 new SqlParameter("@ngayHenLay", ngayHenLay),
                 new SqlParameter("@noiDungSua", noiDungSua),
                 new SqlParameter("@chiTietSua", chiTietSua),
                 new SqlParameter("@maKhachHang", maKhachHang),
                    new SqlParameter("@maNhanVien", maNhanVien)
                );
        }
        public bool SuaNgoaiXong(ref string error, int maSua, DateTime ngaySuaXong,decimal phiSua, int maKhachHang, int maNhanVien)
        {
            return db.ExcuteNoneQuery("spSuaAoNgoaiXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maSua", maSua),
                 new SqlParameter("@ngaySuaXong", ngaySuaXong),
                 new SqlParameter("@phiSua", phiSua),
                 new SqlParameter("@maKhachHang", maKhachHang),
                    new SqlParameter("@maNhanVien", maNhanVien)
                );
        }
        public bool LayAoNgoai( ref string err, int maSua, DateTime ngayLay)
        {
            return db.ExcuteNoneQuery("spLayHangSuaNgoai", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maSua", maSua),
                  new SqlParameter("@ngayLay", ngayLay));
        }
        public bool ThanhToanCongSua(ref string err, int maPhi)
        {
            return db.ExcuteNoneQuery("spThanhToanCongSuaNgoai", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maPhi", maPhi)
                 );
        }
        public bool YeuCauThulai(ref string err, int maSua, DateTime ngayHenThulai,int maNVSua,string noiDungSua,string chiTietSua)
        {
            return db.ExcuteNoneQuery("spYCSuaLaiHangNgoai", CommandType.StoredProcedure, ref err,
                 new SqlParameter("@maSua", maSua),
                  new SqlParameter("@ngayHenThulai", ngayHenThulai),
                  new SqlParameter("@maNhanVienSua", maNVSua),
                  new SqlParameter("@noiDungSua", noiDungSua),
                  new SqlParameter("@chiTietSua", chiTietSua));
        }
    }
   
}
