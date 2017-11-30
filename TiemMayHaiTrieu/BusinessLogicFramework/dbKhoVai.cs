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
    public class dbKhoVai
    {
        DAFramework db;
        public dbKhoVai()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetKhoVai()
        {
            return db.ExecuteQuery("spGetKhoVai", CommandType.StoredProcedure, null);
        }
        public DataTable TimVaiTrongKhoTheoTenVai(string tenLoaiVai)
        {

            return db.ExecuteQuery("spGetKhoVai", CommandType.StoredProcedure,
                new SqlParameter("@tenVai",tenLoaiVai));
        }
        public bool UpdateVaiTrongKho(ref string error, int maVai,string tenLoaiVai,int soLuong,string tamGia,byte[] anhDaiDien,string ghiChu)
        {
            return db.ExcuteNoneQuery("spUpdateKhoVai", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@maVai", maVai),
                 new SqlParameter("@tenLoaiVai", tenLoaiVai),
                new SqlParameter("@soLuong", soLuong),
                new SqlParameter ("@tamGia",tamGia),
                new SqlParameter("@anhDaiDien", anhDaiDien),
                 new SqlParameter("@ghiChu", ghiChu)

                );
        }

        public bool DeleteVaiTrongKho(ref string error, int maVai)
        {
            return db.ExcuteNoneQuery("spDeleteVai", CommandType.StoredProcedure,
                ref error,

                new SqlParameter("@maVai", maVai)
                );
        }
        public bool InsertVaiVaoKho(ref string error,  string tenLoaiVai, int soLuong, string tamGia, byte[] anhDaiDien, string ghiChu)
        {
            return db.ExcuteNoneQuery("spThemVai", CommandType.StoredProcedure,
                ref error,
                 new SqlParameter("@tenLoaiVai", tenLoaiVai),
                new SqlParameter("@soLuong", soLuong),
                new SqlParameter("@anhDaiDien", anhDaiDien),
                 new SqlParameter("@ghiChu", ghiChu)
                 , new SqlParameter("@tamGia",tamGia)
                );
        }
    }
}
