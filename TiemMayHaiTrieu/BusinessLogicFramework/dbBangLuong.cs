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
     public class dbBangLuong
    {
        DAFramework db;
        public dbBangLuong()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetBangLuong()
        {
            return db.ExecuteQuery("spBangLuong", CommandType.StoredProcedure, null);
        }
        public DataTable XemBangLuongThang(int maThang,int maNam)
        {
            return db.ExecuteQuery("spXemLuongThang", CommandType.StoredProcedure,
                new SqlParameter("@maThang",maThang), new SqlParameter("@maNam",maNam)
                );
        }
        public DataTable DSAoDaCat(int maNV,int maThang, int maNam)
        {
            return db.ExecuteQuery("spDSAoDaCat", CommandType.StoredProcedure,
                 new SqlParameter("@maNV", maNV),
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam)
                );
        }
        public DataTable DSAoDaMay(int maNV, int maThang, int maNam)
        {
            return db.ExecuteQuery("spDSAoDaMay", CommandType.StoredProcedure,
                 new SqlParameter("@maNV", maNV),
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam)
                );
        }
        public DataTable DSAoDaLuong(int maNV, int maThang, int maNam)
        {
            return db.ExecuteQuery("spDSAoDaLuong", CommandType.StoredProcedure,
                 new SqlParameter("@maNV", maNV),
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam)
                );
        }
        public DataTable DSQuanDaCat(int maNV, int maThang, int maNam)
        {
            return db.ExecuteQuery("spDSQuanDaCat", CommandType.StoredProcedure,
                 new SqlParameter("@maNV", maNV),
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam)
                );
        }
        public DataTable DSQuanDaMay(int maNV, int maThang, int maNam)
        {
            return db.ExecuteQuery("spDSQuanDaMay", CommandType.StoredProcedure,
                 new SqlParameter("@maNV", maNV),
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam)
                );
        }
        public DataTable XemChiTietLuong(int maThang, int maNam,int maNV)
        {
            return db.ExecuteQuery("spGetChiTietLuongThang", CommandType.StoredProcedure,
                new SqlParameter("@maThang", maThang), new SqlParameter("@maNam", maNam),
                new SqlParameter("@maNV",maNV)
                );
        }
        public decimal GetLuongNamCuaNV(int maNV, int maThang,int maNam)
        {
            return db.GetTongLuongCacThangTrongNam(maNV, maThang, maNam);
        }
        public decimal GetTongLuongCacNam(int maNV, int maNam)
        {
            return db.GetTongLuongCacNam(maNV, maNam);
        }

    }
}   
