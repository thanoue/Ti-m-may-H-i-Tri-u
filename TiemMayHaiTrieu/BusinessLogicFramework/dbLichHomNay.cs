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
   public class dbLichHomNay
    {
        DAFramework db;
        public dbLichHomNay()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable DSHomNayThu(int maNgay,int maThang,int maNam)
        {
            return db.ExecuteQuery("spHanThuao", CommandType.StoredProcedure,
                new  SqlParameter("@maNgay",maNgay),
                new SqlParameter("@maThang", maThang),
                new SqlParameter("@maNam", maNam)

                );
        }
        public DataTable DSHomNayNhan(int maNgay, int maThang, int maNam)
        {
            return db.ExecuteQuery("spHanNhanHangDat", CommandType.StoredProcedure,
                new SqlParameter("@maNgay", maNgay),
                new SqlParameter("@maThang", maThang),
                new SqlParameter("@maNam", maNam)

                );
        }
        public DataTable DSHangNhanDatQuaHan(DateTime ngayHienTai)
        {
            return db.ExecuteQuery("spHangNhanQuaHan", CommandType.StoredProcedure,
                new SqlParameter("@ngayHienTai", ngayHienTai)
              
                );
        }
        public bool DeleteAo(ref string error, int maAo)
        {
            return db.ExcuteNoneQuery("spDeleteDonHang", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo));
        }
        public bool DeleteHangDat(ref string error, int maHangDat)
        {
            return db.ExcuteNoneQuery("spDeleteHangDat", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHangDat", maHangDat));
        }
     
        public DataTable DSQuaHanThu(DateTime ngayHienTai)
        {
            return db.ExecuteQuery("spHangQuaHan", CommandType.StoredProcedure,
                new SqlParameter("@ngayHienTai", ngayHienTai)
                

                );
        }
        public DataTable TimAoToihanThuTheoTenKH(string tenKH,int maNgay, int maThang, int maNam)
        {
            return db.ExecuteQuery("spTimAoToiHanThuTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH",tenKH),
                new SqlParameter("@maNgay", maNgay),
                new SqlParameter("@maThang", maThang),
                new SqlParameter("@maNam", maNam)

                );
        }
        public DataTable TimAoQuaHanTheoTenKH(string tenKH,DateTime ngayHienTai)
        {
            return db.ExecuteQuery("spTimHAoQuaHanTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH),
                new SqlParameter("@ngayHienTai", ngayHienTai)


                );
        }
        public DataTable TimHangToiHanTheotenKH(string tenKH, int maNgay, int maThang, int maNam)
        {
            return db.ExecuteQuery("spTimHangDatToiHanTheoTenKH", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH),
                new SqlParameter("@maNgay", maNgay),
                new SqlParameter("@maThang", maThang),
                new SqlParameter("@maNam", maNam)

                );
        }
        public DataTable TimHangDatQuaHanTheoTenKH(string tenKH, DateTime ngayHienTai)
        {
            return db.ExecuteQuery("spTimHangNhanQuaHanTheoTenKH ", CommandType.StoredProcedure,
                new SqlParameter("@tenKH", tenKH),
                new SqlParameter("@ngayHienTai", ngayHienTai)


                );
        }
    }
}
