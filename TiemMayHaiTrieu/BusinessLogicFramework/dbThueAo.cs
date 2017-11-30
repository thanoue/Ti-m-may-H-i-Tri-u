using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessFramework;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicFramework
{
     public class dbThueAo
    {
        DAFramework db;
        public dbThueAo()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public decimal TongTienCoc(int maHD)
        {
            return db.TongTienCocCacCTHD(maHD);
        }
        public decimal TongTienGiuCho(int maHD)
        {
            return db.TongTienGiuChoCacCTHD(maHD);
        }
        public DataTable GetDSHDThueChoLay()
        {
            return db.ExecuteQuery("spDanhSachHoaDonThueCholay", CommandType.StoredProcedure, null);
        }

        public DataTable GetDSHDThueChoTra()
        {
            return db.ExecuteQuery("spDanhSachHoaDonThueChoTra", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSHDThueDaTra()
        {
            return db.ExecuteQuery("spDanhSachHoaDonThueDaTra", CommandType.StoredProcedure, null);
        }
        public bool NhanAoThue(ref string err, int maHD, DateTime ngayLayAo,DateTime ngayHenTra)
        {
            return db.ExcuteNoneQuery("spNhanAoThue", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHD", maHD), new SqlParameter("@ngayLayAo", ngayLayAo),
                new SqlParameter("@ngayHenTra", ngayHenTra)
               );
        }
        public bool TraAoThue(ref string err, int maHD, DateTime ngayTraAo,decimal thanhTien)
        {
            return db.ExcuteNoneQuery("spTraAoThue", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHD", maHD), new SqlParameter("@ngayTra", ngayTraAo),
                  new SqlParameter("@thanhTien", thanhTien)
               );
        }
        public DataTable GetDSHDThueQuaHanTra(DateTime ngayHienTai)
        {
            return db.ExecuteQuery("spDanhSachHoaDonThueQuaHanTra", CommandType.StoredProcedure,
                new SqlParameter("@ngayHienTai",ngayHienTai));
        }
        public bool XoaHDThueAo(ref string er,int maHD)
        {
            return db.ExcuteNoneQuery("spDeleteHDThueAo", CommandType.StoredProcedure, ref er,
             new SqlParameter("@maHD", maHD)
            );
        }
        public DataTable GetDSHDThueQuaHanLay(DateTime ngayHienTai)
        {
            return db.ExecuteQuery("spGetDanhSachHoaDonThueQuaHanLay", CommandType.StoredProcedure,
                new SqlParameter("@ngayHienTai", ngayHienTai));
        }
    }
}
