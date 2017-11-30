using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicFramework
{
  public static  class infoClass
    {
        public static int maAoMoiMayXong;
        public static int maKhachHang;
        public static string tenDangNhap= "";
        public static string soDo = "";
        public static decimal tongPhi = 0;
        public static byte[] anhMacDinh;
        public static decimal getTongPhi()
        {
            return tongPhi;
        }
        public static void setTongPhi(decimal tong)
        {
            tongPhi = tong;
        }
        public static byte[] getAnhMacDinh()
        {
            return anhMacDinh;
        }
        public static void setAnhmacDinh(byte[] anhMD)
        {
            anhMacDinh = anhMD;
        }
        public static string getSoDo()
        {
            return soDo;
        }
        public static void setSoDo(string soD)
        {
            soDo = soD;
        }
        public static int getmaAoMoiMayXong (){
            return maAoMoiMayXong;
        }
        public static string getTenDanNhap()
        {
            return tenDangNhap;

        }
        public static void setTenDangNhp(string tendn)
        {
            tenDangNhap = tendn;
        }
        public static void setmaAoMoiMayXong(int maAo)
        {
            maAoMoiMayXong = maAo;
        }
        public static int getMaKH()
        {
            return maKhachHang;
        }
        public static void setmaKH(int maKH)
        {
            maKhachHang = maKH;
        }
    }
}
