using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessFramework
{
     public class DAFramework
    {
        private string sqlConnect;//= @"data source =ANDONGNHI\SQLEXPRESS; initial catalog =BarneyShopGaming; integrated security = true";
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public DAFramework()
        {
            sqlConnect = @"data source =DESKTOP-JFSJJDK\SQLEXPRESS; initial catalog =TiemMayHaiTrieu; integrated security = true";
            conn = new SqlConnection(sqlConnect);
            cmd = conn.CreateCommand();
        }
        public DAFramework(string sername)
        {
            sqlConnect = @"data source =" + sername + "; initial catalog =TiemMayHaiTrieu; integrated security = true";
            conn = new SqlConnection(sqlConnect);
            cmd = conn.CreateCommand();
        }
        public int GetMaHDDatHangHienHanh()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(Id) from HoaDonDatHang ", conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                SqlConnection conn2 = new SqlConnection(sqlConnect);
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT(HoaDonDatHang, RESEED, 0)", conn2);
                cmd2.ExecuteNonQuery();
                if (conn2.State == ConnectionState.Open)
                    conn2.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 1;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq + 1;
        }
        public int GetMaAoLonNhatTheoMaHDMayAo(int maHD)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(ma) from AoDuocMay where maHoaDonMay="+maHD.ToString(), conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                return 0;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq ;
        }
        public int GetMaQuanLonNhatTheoMaHDMayAo(int maHD)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(ma) from QuanDuocMay where maHoaDonMay=" + maHD.ToString(), conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                return 0;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }

        public int GetmaHoaDonMayAoHienHanh()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(Id) from HoaDonMayAo  ", conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                SqlConnection conn2 = new SqlConnection(sqlConnect);
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT(HoaDonMayAo, RESEED, 399)", conn2);
                cmd2.ExecuteNonQuery();
                if (conn2.State == ConnectionState.Open)
                    conn2.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 400;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq + 1;
        }
        public int GetmaHDThueAoHienHanh()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(Id) from HoaDonThueAo  ", conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                SqlConnection conn2 = new SqlConnection(sqlConnect);
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT(HoaDonThueAo, RESEED, 0)", conn2);
                cmd2.ExecuteNonQuery();
                if (conn2.State == ConnectionState.Open)
                    conn2.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 1;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq + 1;
        }
        public int GetmaHDBanAoHienHanh()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(Id) from HoaDonBanAo  ", conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                SqlConnection conn2 = new SqlConnection(sqlConnect);
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT(HoaDonBanAo, RESEED, 0)", conn2);
                cmd2.ExecuteNonQuery();
                if (conn2.State == ConnectionState.Open)
                    conn2.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 1;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq + 1;
        }
        public decimal TongTienGiuChoCacCTHD(int maHD)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(tienGiuCho) from ChiTietHoaDonThueAo where maHoaDonThueAo=" + maHD.ToString(), conn);
            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }
        public decimal TongTienConLaiCacCTHDDatHang(int maHD)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select sum(tienConLai) from ChiTietHoaDonDatHang where maHoaDon=" + maHD.ToString(), conn);
            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }
        public decimal TongTienCocCacCTHDDatHang(int maHD)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select sum(tienCoc) from ChiTietHoaDonDatHang where maHoaDon=" + maHD.ToString(), conn);
            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }
        public decimal TongTienCocCacCTHD(int maHD)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select sum(tienCoc) from ChiTietHoaDonThueAo where maHoaDonThueAo="+maHD.ToString(), conn);
            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();

            }
            catch (Exception)
            {            
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }
        public int GetmaHDBHHienHanh()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select max(Id) from HoaDonBanVai ", conn);
            int kq = 0;
            try
            {
                kq = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                SqlConnection conn2 = new SqlConnection(sqlConnect);
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT(HoaDonBanVai, RESEED, 0)", conn2);
                cmd2.ExecuteNonQuery();
                if (conn2.State == ConnectionState.Open)
                    conn2.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 1;
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq +1;
        }
        public string  GetTenKHTheoMaKH(int maKH)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select KhachHang.tenKhachHang from KhachHang where Id = " + maKH.ToString(), conn);
            string kq = "";
            kq = (string)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
        }
        public string getTenThoCat(string  maAo)
        {
            conn.Open();

           SqlCommand cmd = new SqlCommand("select NhanVien.tenNhanVien from  NhanVien inner join AoDuocMay on NhanVien.Id = AoDuocMay.maThoCat where AoDuocMay.id = "+maAo, conn);
            string kq = "";
            try
            {
                kq = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }

            //    conn.Close();
        }
        public string GetTenKHTheoMaHDBanVai(int maHD)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select KhachHang.tenKhachHang from  KhachHang inner join HoaDonBanVai on KhachHang.Id = HoaDonBanVai.maKhachHang where HoaDonBanVai.id = " + maHD, conn);
            string kq = "";
            try
            {
                kq = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }

            //    conn.Close();
        }
         /// <summary>
         /// //////////////////////////////////////////////////////////////////////////////////////////
         /// </summary>
         /// <param name="address"></param>
         /// <returns></returns>
        public bool BackUp(string address)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"backup database TiemMayHaiTrieu to disk = " +address+ "WITH INIT", conn);

            bool kq = false;
            try
            {
                kq = (bool)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return false;
            }

        }
        public string getTenThoMay(string maAo)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select NhanVien.tenNhanVien from  NhanVien inner join AoDuocMay on NhanVien.Id = AoDuocMay.maThoMay where AoDuocMay.id = " + maAo, conn);
           
            string kq = "";
            try
            {
                kq = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
          
        }
        public string getTenThoLuong(string maAo)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select NhanVien.tenNhanVien from  NhanVien inner join AoDuocMay on NhanVien.Id = AoDuocMay.maThoLuong where AoDuocMay.id = " + maAo, conn);

            string kq = "";
            try
            {
                kq = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
          
            //    conn.Close();
        }
        public string getCongThoCat(string maAo)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select AoDuocMay.maCongCat from AoDuocMay where Id="+ maAo, conn);
            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq.ToString();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
          
            //   conn.Close();
        }
        public string getCongThoMay(string maAo)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select AoDuocMay.maCongMay from AoDuocMay where Id=" + maAo , conn);
            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq.ToString();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
           
            //   conn.Close();
        }
        public string getCongThoLuong(string maAo)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select AoDuocMay.maCongLuong from AoDuocMay where Id=" + maAo, conn);

            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq.ToString();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
           
            //   conn.Close();
        }
        public string getTenThoCatQuan(string maQuan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select NhanVien.tenNhanVien from  NhanVien inner join QuanDuocMay on NhanVien.Id = QuanDuocMay.maThoCat where QuanDuocMay.id = " + maQuan, conn);

            string kq = "";
            try
            {
                kq = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
          
            //    conn.Close();
        }
        public string getTenThoMayQuan(string maQuan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select NhanVien.tenNhanVien from  NhanVien inner join QuanDuocMay on NhanVien.Id = QuanDuocMay.maThoMay where QuanDuocMay.id = " + maQuan, conn);

            string kq = "";
            try
            {
                kq = (string)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq;
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
            
            //    conn.Close();
        }
       
        public string getCongThoCatQuan(string maQuan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select QuanDuocMay.maCongCat from QuanDuocMay where Id=" + maQuan, conn);

            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq.ToString();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
          
            //   conn.Close();
        }
        public string getCongThoMayQuan(string maQuan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select QuanDuocMay.maCongMay from QuanDuocMay where Id=" + maQuan, conn);

            decimal kq = 0;
            try
            {
                kq = (decimal)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return kq.ToString();
            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return "";
            }
         
            //   conn.Close();
        }
        public string getTenNVSua(int maNV)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select NhanVien.tenNhanVien from  NhanVien  where Id = " + maNV.ToString(), conn);

            string kq = "";
            kq = (string)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return kq;
            //   conn.Close();
        }
        public decimal GetTongLuongCacThangTrongNam(int maNV,int maThang, int maNam)
        {
            decimal tong = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select dbo.fcTinhLuongThangChoNV(" + maNV.ToString()+","+maNam.ToString()+","+maThang.ToString()+") ", conn);
            tong = (decimal)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return tong;
        }
        public decimal GetTongLuongCacNam(int maNV,  int maNam)
        {
            decimal tong = 0;
            conn.Open();
            SqlCommand cmd = new SqlCommand("declare @mo money set @mo = dbo.fcTongLuongCacNam(" + maNV.ToString() + "," + maNam.ToString() +") select @mo", conn);
            tong = (decimal)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            return tong;
        }

        public int getMaAoLonNhat()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select max (Id) from dbo.MayAo", conn);
            int kq = 0;
            try
            {   
                kq = (int)cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            catch (Exception)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
            
            return kq;

        }
        public bool UpdateTaiKhoan(ref string error, string username, string pass)
        {
            return ExcuteNoneQuery("spUpdateTaiKhoan ", CommandType.StoredProcedure, ref error,
                new SqlParameter("@ID", username),
                new SqlParameter("@passWord", pass)
                );
        }
        public bool InsertUserDefault(ref string error)
        {

            return ExcuteNoneQuery("spInsertLoginBanDau", CommandType.StoredProcedure, ref error
                );
        }
        public DAFramework(string servername, string username, string password)
        {
            sqlConnect = @"data source=" + servername + "; initial catalog =BarneyShopGaming; User ID =" + username + "; password=" + password;
            conn = new SqlConnection(sqlConnect);
            cmd = conn.CreateCommand();
        }

        public bool CheckConnection()
        {
            try
            {

                SqlConnection cnn;
                cnn = new SqlConnection(sqlConnect);
                cnn.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
                //  Console.Write(es.Message);

            }
        }
        public int testxconn()
        {
            try
            {
                conn.Open();
                return 1;
            }
            catch (SqlException ex)
            {
                return 0;
            }
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable ExecuteQuery(string cmdText, CommandType cmdType, params SqlParameter[] sqlParam)
        {

            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 60;
            cmd.Parameters.Clear();

            try
            {
                foreach (SqlParameter param in sqlParam)
                    cmd.Parameters.Add(param);

            }
            catch (Exception)
            {
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool XoaVaiHetHang()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete dbo.KhoVai where soLuong=0 ", conn);
            bool kq = (bool)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();

            return kq;
        }
        public bool ExcuteNoneQuery(string cmdText, CommandType cmdType, ref string error, params SqlParameter[] sqlParam)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.CommandText = cmdText;
            cmd.CommandType = cmdType;
            cmd.CommandTimeout = 60;
            cmd.Parameters.Clear();

            foreach (SqlParameter param in sqlParam)
                cmd.Parameters.Add(param);

            bool excuteSuccess = false;
            try
            {
                cmd.ExecuteNonQuery();
                excuteSuccess = true;
            }
            catch (SqlException sqlException)
            {
                error = sqlException.Message;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return excuteSuccess;

        }
    }
}

