using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessFramework;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicFramework
{
   public class dbTienDoMay
    {
        DAFramework db;
        public dbTienDoMay()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable GetDanhSachAoDangMay()
        {
            return db.ExecuteQuery("spGetAoDangDuocMay", CommandType.StoredProcedure, null);
        }
        public DataTable TimAoTheoMaHD(int key)
        {
            return db.ExecuteQuery("spTimAoTienDoTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@key", key));
        }
        public DataTable GetAoDuocMayTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetAoDuocMayTheoMaHD_TienDoMay", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable GetQuanDuocMayTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetQuanDuocMayTheoMaHD_tienDoMay", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable TimAoTheoNhieuTieuChi(string key)
        {
            return db.ExecuteQuery("spTimAoTienDoTheoNhieuTieuChi", CommandType.StoredProcedure, 
                new SqlParameter("@key",key));
        }
        public bool CatXong(ref string error, int maAo,int maTienCongMoi,int maNam,int maThang)
        {
            return db.ExcuteNoneQuery("spDaCatXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),       
                 new SqlParameter("@maTienCongMoi", maTienCongMoi),
                 new SqlParameter("@maNamXong",maNam),
                 new SqlParameter("@maThangXong",maThang)
                );
        }
        public bool MayXong(ref string error, int maAo, int maTienCongMoi, int maNam, int maThang)
        {
            return db.ExcuteNoneQuery("spDaMayXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                 new SqlParameter("@maTienCongMoi", maTienCongMoi),
                  new SqlParameter("@maNamXong", maNam),
                 new SqlParameter("@maThangXong", maThang)
                );
        }
        public bool LuongXong(ref string error, int maAo, int maTienCongMoi, int maNam, int maThang)
        {
            return db.ExcuteNoneQuery("spDaLuongXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                 new SqlParameter("@maTienCongMoi", maTienCongMoi),
                     new SqlParameter("@maNamXong", maNam),
                 new SqlParameter("@maThangXong", maThang)
                );
        }
        public bool CatQuanXong(ref string error, int maAo, int maTienCongMoi, int maNam, int maThang)
        {
            return db.ExcuteNoneQuery("spDaCatQuanXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                 new SqlParameter("@maTienCongMoi", maTienCongMoi),
                     new SqlParameter("@maNamXong", maNam),
                 new SqlParameter("@maThangXong", maThang)
                );
        }
        public bool MayQuanXong(ref string error, int maAo, int maTienCongMoi, int maNam, int maThang)
        {
            return db.ExcuteNoneQuery("spDaMayQuanXong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                 new SqlParameter("@maTienCongMoi", maTienCongMoi),
                     new SqlParameter("@maNamXong", maNam),
                 new SqlParameter("@maThangXong", maThang)
                );
        }
        public DataTable GetDSHDMayTheoKhoangThoiGian(DateTime ngayDau,DateTime ngayCuoi)
        {
            return db.ExecuteQuery("spXemTienDoMayTheoNgay", CommandType.StoredProcedure,
                   new SqlParameter("@ngayDau", ngayDau),
                 new SqlParameter("@ngayCuoi", ngayCuoi)
                );
        }
        public bool PCCat(ref string error, string maAo,int maThoCat,decimal maLuongCat, DateTime ngayPC,int maThangPC,int maNamPC)
        {
            return db.ExcuteNoneQuery("spPhanCongThoCat", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                new SqlParameter("@maThoCat", maThoCat),
                new SqlParameter("@maLuongCat", maLuongCat),
                 new SqlParameter("@ngayPhanCong", ngayPC),
                   new SqlParameter("@maThangXong", maThangPC),
                     new SqlParameter("@maNamXong",maNamPC)

                );
        }
        public bool PCMay(ref string error, string maAo, int maThoMay, decimal maLuongMay, DateTime ngayPC,int maThangPC,int maNamPC)
        {
            return db.ExcuteNoneQuery("spPhanCongThoMay", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAoMay", maAo),
                new SqlParameter("@maThoMay", maThoMay),
                new SqlParameter("@maLuongMay", maLuongMay),
                 new SqlParameter("@ngayPhanCong", ngayPC),
                 new SqlParameter("@maThangXong",maThangPC),
                      new SqlParameter("@maNamXong", maNamPC)
                );
        }
        public bool PCLuong(ref string error, string maAo, int maThoLuong, decimal maLuongLuong, DateTime ngayPC,int maThang,int maNam)
        {
            return db.ExcuteNoneQuery("spPhanCongThoLuong", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAoMay", maAo),
                new SqlParameter("@maThoLuong", maThoLuong),
                new SqlParameter("@maLuongLuong", maLuongLuong),
                 new SqlParameter("@ngayPhanCong", ngayPC),
                  new SqlParameter("@maThangXong", maThang),
                   new SqlParameter("@maNamXong", maNam)
                );
        }
        public bool PCCatQuan(ref string error, string maQuan, int maThoCatQuan ,decimal maLuongCatQuan, DateTime ngayPC,int maThangXong,int maNamXong)
        {
            return db.ExcuteNoneQuery("spPhanCongThoCatQuan", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maQuan", maQuan),
                new SqlParameter("@maThoCatQuan", maThoCatQuan),
                new SqlParameter("@maLuongCatQuan", maLuongCatQuan),
                 new SqlParameter("@ngayPC", ngayPC),
                 new SqlParameter("@maThangXong",maThangXong),
                 new SqlParameter("@maNamXong",maNamXong)
                );
        }
        public bool PCMayQuan(ref string error, string maQuan, int maThoMayQuan, decimal maLuongMayQuan, DateTime ngayPC,int maThang,int maNam)
        {
            return db.ExcuteNoneQuery("spPhanCongThoMayQuan", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maQuan", maQuan),
                new SqlParameter("@maThoMayQuan", maThoMayQuan),
                new SqlParameter("@maLuongMayQuan", maLuongMayQuan),
                 new SqlParameter("@ngayPC", ngayPC),
                 new SqlParameter("@maThangXong",maThang),
                  new SqlParameter("@maNamXong", maNam)
                );
        }
        public DataTable GetDSCTHDMayTheoKhoangThoiGian(DateTime ngayDau, DateTime ngayCuoi,int maHD)
        {
            return db.ExecuteQuery("spGetDSCTHDMayTheoKhoangThoiGian", CommandType.StoredProcedure,
                   new SqlParameter("@ngayDau", ngayDau),
                 new SqlParameter("@ngayCuoi", ngayCuoi),
                  new SqlParameter("@maHD", maHD)
                );
        }
        public DataTable SoLuongTienDoTheoThoiGian_Ao(DateTime ngayDau, DateTime ngayCuoi)
        {
            return db.ExecuteQuery("spSoLuongTienDoTheoThoiGian_Ao", CommandType.StoredProcedure,
                   new SqlParameter("@ngayDau", ngayDau),
                 new SqlParameter("@ngayCuoi", ngayCuoi)             
                );
        }
        public DataTable SoLuongTienDoTheoThoiGian_Quan(DateTime ngayDau, DateTime ngayCuoi)
        {
            return db.ExecuteQuery("spSoLuongTienDoTheoThoiGian_Quan", CommandType.StoredProcedure,
                   new SqlParameter("@ngayDau", ngayDau),
                 new SqlParameter("@ngayCuoi", ngayCuoi)
                );
        }
        public DataTable TongThuTheoThoiGian_Quan(DateTime ngayDau, DateTime ngayCuoi)
        {
            return db.ExecuteQuery("spTongThuTheoThoiGian_Quan", CommandType.StoredProcedure,
                   new SqlParameter("@ngayDau", ngayDau),
                 new SqlParameter("@ngayCuoi", ngayCuoi)
                );
        }
        public DataTable TongThuTheoThoiGian_Ao(DateTime ngayDau, DateTime ngayCuoi)
        {
            return db.ExecuteQuery("spTongThuTheoThoiGian_Ao", CommandType.StoredProcedure,
                   new SqlParameter("@ngayDau", ngayDau),
                 new SqlParameter("@ngayCuoi", ngayCuoi)
                );
        }
        public DataTable GetDSCTHDMayTheoMaHD( int maHD)
        {
            return db.ExecuteQuery("spGetDSCTHDMayTheoMaHD", CommandType.StoredProcedure,
                  new SqlParameter("@maHD", maHD)
                );
        }
        public bool CapNhatTienDoMay(ref string error, int maAo,DateTime ngayMayXong)
        {
            return db.ExcuteNoneQuery("spCapNhatTienDomay", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo),
                 new SqlParameter("@ngayMayXong",ngayMayXong)
                );
        }
        public DataTable TimAoDangMayTheoTenKH(ref string error, string tenKH)
        {
            return db.ExecuteQuery("spTimAoDangMayTheoTenKH", CommandType.StoredProcedure, new SqlParameter("@tenKH", tenKH));
        }
        public bool XoaDonHang(ref string error, int maAo)
        {
            return db.ExcuteNoneQuery("spDeleteDonHang", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo)

                );
        }
        public bool MayXongAo(ref string error, string maAo)
        {
            return db.ExcuteNoneQuery("spMayXongAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maAo", maAo)

                );
        }
        public bool MayXongQuan(ref string error, string maQuan)
        {
            return db.ExcuteNoneQuery("spMayXongQuan", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maQuan", maQuan)

                );
        }
        public bool CapNhatAnhChoAo(ref string error,byte[] anhAo,byte[] anhQuan, int maAo)
        {
            return db.ExcuteNoneQuery("spCapNhatAnhChoAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@anhAo", anhAo),
                new SqlParameter("@anhQuan", anhQuan),
                new SqlParameter("@maAo",maAo)
                );
        }

    }
}
