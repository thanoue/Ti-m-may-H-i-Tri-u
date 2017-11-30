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
    public class dbChamCongTho
    {
        DAFramework db;
        
        public dbChamCongTho()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetDanhSachAoCanDuocChamCong()
        {
            return db.ExecuteQuery("spGetDanhSachAoDangChoChamCong", CommandType.StoredProcedure, null);
        }
        public string GetTenThoMay(string maAo)
        {
            return db.getTenThoMay(maAo);
        }
        public string GetTenThoCat(string maAo)
        {
            return db.getTenThoCat(maAo);
        }
        public string GetTenThoLuong(string maAo)
        {
            return db.getTenThoLuong(maAo);
        }
        public string GettenThoMayQuan(string maAo)
        {
            return db.getTenThoMayQuan(maAo);
        }
        public string GettenThoCatQuan(string maAo)
        {
            return db.getTenThoCatQuan(maAo);
        }
        public string GetCongThoCat(string maAo)
        {
            return db.getCongThoCat(maAo);
        }
        public string GetCongThoMay(string maAo)
        {
            return db.getCongThoMay(maAo);
        }
        public string GetCongThoLuong(string maAo)
        {
            return db.getCongThoLuong(maAo);
        }
        public string GetCongThoCatQuan(string maAo)
        {
            return db.getCongThoCatQuan(maAo);
        }
        public string GetCongThoMayQuan(string maAo)
        {
            return db.getCongThoMayQuan(maAo);
        }
        public bool ChamCong(ref string error, int maAo,decimal congThoCat,decimal congThoMay, decimal congThoLuong,decimal congThoMayQuan,decimal tienCong)
        {
            return db.ExcuteNoneQuery("spChamCong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo), new SqlParameter("@congThoCat", congThoCat),
                new SqlParameter("@congThoMay", congThoMay), new SqlParameter("@congThoLuong", congThoLuong),
                new SqlParameter("@congThoMayQuan",congThoMayQuan),
                new SqlParameter("@tienCong", tienCong)
                );
        }
        public bool CapNhatLuong(ref string error,  decimal congThoCat, decimal congThoMay, decimal congThoLuong,decimal CongThoMayQuan,int maThoCat,int maThoMay,int maThoLuong,int maThoMayQuan,int maThang,int maNam)
        {
            return db.ExcuteNoneQuery("spCapNhatLuongThang", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@congThoCat", congThoCat),
                new SqlParameter("@congThoMay", congThoMay), new SqlParameter("@congThoLuong", congThoLuong),
                new SqlParameter("@maThoCat",maThoCat), new SqlParameter("@maThoMay", maThoMay), new SqlParameter("@maThoLuong", maThoLuong),new SqlParameter("@maThoMayQuan",maThoMayQuan),new SqlParameter("@congThoMayQuan",CongThoMayQuan),
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam)    
                );
        }
        public DataTable TimAoChoChamCongTheoMaAo(int maAo)
        {
            return db.ExecuteQuery("spTimAoChoChamCongTheoMaAo", CommandType.StoredProcedure, new SqlParameter("@maDS", maAo));
        }
        public DataTable TimAoDeChamCongTheoTenKH(ref string error,string tenKH)
        {
            return db.ExecuteQuery("spTimAoChoChamCongTheoTenKh", CommandType.StoredProcedure, new SqlParameter("@tenKH", tenKH));
        }

    }
}
