using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcessFramework;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicFramework
{
    public class dbAoChoThue
    {
        DAFramework db;
        public dbAoChoThue()
        {
            db = new DAFramework(infoClass.getTenDanNhap());
        }
        public DataTable TimAoTrongKhoTheoTenHang(string tenHang)
        {
            return db.ExecuteQuery("spTimDSAoThueTheoTenHang", CommandType.StoredProcedure,
                new SqlParameter("@tenAo", tenHang));
        }
        public DataTable TimDSCTHDThueConlaiTheoTenhang(DateTime ngayHenLay, string tenHang)
        {
            return db.ExecuteQuery("spTimDSCTHDThueConLaiTheoTenHang", CommandType.StoredProcedure,
                new SqlParameter("@tenHang", tenHang),
                new SqlParameter("@ngayHenLay", ngayHenLay));
        }
        public bool ThemAoVaoKho(ref string error,  string tenAo,byte[] anhDaiDien,decimal phiThueMacDinh,decimal giaBanMacDinh,string ghiChu,int soLuong)
        {
            return db.ExcuteNoneQuery("spInsertAoChoThue", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@tenAo", tenAo),
                  new SqlParameter("@anhDaiDien", anhDaiDien),
                   new SqlParameter("@phiThueMacDinh", phiThueMacDinh),
                     new SqlParameter("@phiBanMacDinh", giaBanMacDinh),
                      new SqlParameter("@ghiChu", ghiChu),
                       new SqlParameter("@soLuong",soLuong )


                );
        }
        public bool SuaThongTinAo(ref string error,int maAo, string tenAo, byte[] anhDaiDien, decimal phiThueMacDinh, decimal giaBanMacDinh, string ghiChu, int soLuong)
        {
            return db.ExcuteNoneQuery("spUpdateAoChoThue", CommandType.StoredProcedure,
                ref error,
                   new SqlParameter("@maAo", maAo),
                new SqlParameter("@tenAo", tenAo),
                  new SqlParameter("@anhDaiDien", anhDaiDien),
                   new SqlParameter("@phiThueMacDinh", phiThueMacDinh),
                     new SqlParameter("@phiBanMacDinh", giaBanMacDinh),
                      new SqlParameter("@ghiChu", ghiChu),
                       new SqlParameter("@soLuong", soLuong)


                );
        }
        public bool DeleteAo(ref string error, int maAo)
        {
            return db.ExcuteNoneQuery("spDeleteAoChoThue", CommandType.StoredProcedure,
                ref error,
                   new SqlParameter("@maAo", maAo)
             

                );
        }
        public bool DeleteCTHDThueAo(ref string error, int maCTHD)
        {
            return db.ExcuteNoneQuery("spDeleteCTHDThueAo", CommandType.StoredProcedure,
                ref error,
                   new SqlParameter("@maCTHD", maCTHD)
                );
        }
        public bool DeleteCTHDBanAo(ref string error, int maCTHD,int soLuong,int maAo)
        {
            return db.ExcuteNoneQuery("spDeleteChiTietHDBanAo", CommandType.StoredProcedure,
                ref error,
                   new SqlParameter("@maCTHD", maCTHD),
                   new SqlParameter("@soLuong",soLuong),
                   new SqlParameter("@maAo",maAo)


                );
        }
        public bool HoanTatMua(ref string err, int maHD, Decimal thanhTien)
        {
            return db.ExcuteNoneQuery("spHoanTatMuaAo", CommandType.StoredProcedure, ref err,
                new SqlParameter("@maHD", maHD), new SqlParameter("@thanhTien", thanhTien)
               );
        }

        public bool InsertChiTietHoaDonThueAo(ref string er,int maHD,int maKH,DateTime ngayLapHD,DateTime ngayHenLay,
            DateTime ngayHenTra,string ghiChu, int maAo,byte[] anhDaiDien,int soLuong,decimal tongPhiThue,decimal tienCoc,
            decimal tienGiuCho,decimal donGia,DateTime ngayLay,int maCTHDCu,int loai)
        {
            return db.ExcuteNoneQuery("spInsertCTHDThueAo", CommandType.StoredProcedure,
                ref er,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@maKhachHang", maKH),
                 new SqlParameter("@ngayLapHoaDon", ngayLapHD),new SqlParameter("@ngayHenLay",ngayHenLay),
                 new SqlParameter("@ngayHentra",ngayHenTra),
                 new SqlParameter("@ghiChu", ghiChu),
                 new SqlParameter("@maAo", maAo),
                   new SqlParameter("@soLuong", soLuong),
                     new SqlParameter("@donGia", donGia),
                       new SqlParameter("@tongPhiThue", tongPhiThue),
                          new SqlParameter("@tienCoc", tienCoc),
                           new SqlParameter("@tienGiuCho", tienGiuCho),
                           new SqlParameter("@ngayLay",ngayLay),
                         new SqlParameter("@anhDaiDien", anhDaiDien),
                         new SqlParameter("@maCTHDCu",maCTHDCu),
                         new SqlParameter("@loai",loai)
                );
        }
        public bool InsertChiTietHoaDon(ref string error, int maHD, int maKH, string ghiChu, DateTime ngayLapHoaDon, int maAo, int soLuong, Decimal donGia, Decimal tongTien, byte[] anhDaiDien)

        {
            return db.ExcuteNoneQuery("spInsertCTHDBanAo", CommandType.StoredProcedure,
                ref error,
                new SqlParameter("@maHD", maHD),
                 new SqlParameter("@maKhachHang", maKH),
                 new SqlParameter("@ngayLapHoaDon", ngayLapHoaDon),
                 new SqlParameter("@ghiChu", ghiChu),
                 new SqlParameter("@maAo", maAo),
                   new SqlParameter("@soLuong", soLuong),
                     new SqlParameter("@donGia", donGia),
                       new SqlParameter("@tongTien", tongTien),
                         new SqlParameter("@anhDaiDien", anhDaiDien)
                );
        }

        public int GetMaHDBanAoHienHanh()
        {
            return db.GetmaHDBanAoHienHanh();
        }
        public int GetmaHDThueAoHienHanh()
        {
            return db.GetmaHDThueAoHienHanh();
        }
        public DataTable GetCTHDThueAoTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetCTHDThueAoTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD", maHD));
        }
        public DataTable GetCTHDThueThoaMan(DateTime ngayHenLay)
        {
            return db.ExecuteQuery("spGetDSCTHDThueConLai", CommandType.StoredProcedure,
                new SqlParameter("@ngayHenLay", ngayHenLay));
        }
        public DataTable GetDanhSachAoTrongKho()
        {
            return db.ExecuteQuery("spGetDSAo", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSCTHDBanAoTheoMaHD(int maHD)
        {
            return db.ExecuteQuery("spGetCTHDBanAoTheoMaHD", CommandType.StoredProcedure,
                new SqlParameter("@maHD",maHD));
        }
        public DataTable GetDanhSachAo()
        {
            return db.ExecuteQuery("spGetDSAoChoThue", CommandType.StoredProcedure, null);
        }
        public DataTable GetDSAoDeThue()
        {
            return db.ExecuteQuery("spDSAoThue", CommandType.StoredProcedure, null);
        }
    }
}
