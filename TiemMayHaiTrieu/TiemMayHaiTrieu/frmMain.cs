using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;
using System.Drawing.Imaging;

namespace TiemMayHaiTrieu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        dbMayAo dbMayAo = new dbMayAo();
        byte[] AnhDaiDienHoaDonMayAo;

        // string soDo;

        private void button11_Click(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams
        {

            get
            {

                CreateParams param = base.CreateParams;

                param.ClassStyle = param.ClassStyle | 0x200;

                return param;

            }

        }
        private void frmMayAo_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = (dbMayAo.GetMaHoaDonMaySeThem()).ToString();
            defaiult();
           // lbMaHoaDonMayAoSeThem.Text = (dbMayAo.GetMaHoaDonMaySeThem()).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        int maKHMayAo = 0; dbKhachHang dbKhachHang = new dbKhachHang();
        private void btnChonKH_Click(object sender, EventArgs e)
        {
            new frmKhachHang(1).ShowDialog();
            maKHMayAo = infoClass.getMaKH();
            lbTenKH.Text = dbKhachHang.GetTenKHTheoMa(maKHMayAo);
            btnThemCT.Enabled = true;
            if (maKHMayAo != 0)
            {
                btnThemCT.Enabled = true;

            }
        }

        private void btnLoadAnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImages = new OpenFileDialog();

            ofdImages.AddExtension = true;
            ofdImages.CheckFileExists = true;
            //  ofdImages.Filter = "Image file (*.JPG;*.NPG;*JEPG)|*.JPG;*.NPG;*JEPG";
            ofdImages.Filter = "JPEG Image|*.jpg|Windows Bitmap|*.bmp|All Files|*.*";
            ofdImages.InitialDirectory = @"Desktop";
            ofdImages.Multiselect = false;
            ofdImages.RestoreDirectory = true;
            ofdImages.Title = "Chọn hình cho áo cần may...";
            string filePathVaiQuan = "";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filePathVaiQuan = ofdImages.FileName;
                try
                {

                    pbAnhDaiDien.Image = Image.FromFile(filePathVaiQuan.ToString());

                    MemoryStream ms = new MemoryStream();
                    ms = ReSizeImage.compress(pbAnhDaiDien.Image);
                    // pbAnhDaiDien.Image.Save(ms, pbAnhDaiDien.Image.RawFormat);
                    AnhDaiDienHoaDonMayAo = ms.GetBuffer();
                    ms.Close();
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
        void reset()
        {
            maKHMayAo = 0; btnChonKH.Enabled = true; btnThemHoaDonMay.Enabled = false;
            lbTenKH.Text = ""; 
            MemoryStream ms = new MemoryStream();
            Properties.Resources.ao.Save(ms, Properties.Resources.ao.RawFormat);
            AnhDaiDienHoaDonMayAo = ms.GetBuffer(); ms.Close();
            btnThemCT.Enabled = false;
            btnThemHoaDonMay.Enabled = false;
            pbAnhDaiDien.Image = Properties.Resources.ao; string er = "";
            if (dbMayAo.DeleteHoaDonMayAo(ref er, Int32.Parse(txtMaHD.Text)))
                txtMaHD.Text = dbMayAo.GetMaHoaDonMaySeThem().ToString();
        }

        DateTime ngayLapHoaDon = new DateTime();
        private void defaiult()
        {
            ngayLapHoaDon = DateTime.Today;
            MemoryStream ms = new MemoryStream();
            Properties.Resources.ao.Save(ms, Properties.Resources.ao.RawFormat);
            AnhDaiDienHoaDonMayAo = ms.GetBuffer(); ms.Close();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //   rtxtSoDoRieng.Text = "";
        }

        private void btnThemHoaDonMay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hoàn tất thêm Hóa đơn may này?", "Hoàn tất đặt may!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormatString();
                string er = "";
                if (dbMayAo.XacNhanThemHoaDon(ref er, Int32.Parse(txtMaHD.Text), Convert.ToDecimal(lbThanhTien.Text), soDoHD, Convert.ToDateTime(dtNgayHenThu.Value.Date), Int32.Parse(nudSoAo.Value.ToString()), Int32.Parse(nudSoQuan.Value.ToString()), rtxtGhiChuHoaDon.Text))
                {
                    //reset();
                    if (MessageBox.Show("Xuất hóa đơn?", "Xuất hóa đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new ReportDemo(Int32.Parse(txtMaHD.Text), lbTenKH.Text, dtNgayHenThu.Value.Date.ToString(), lbThanhTien.Text).ShowDialog();
                    }
                    MessageBox.Show("Đã hoàn tất đặt may 1 hóa đơn!!");
                    txtMaHD.Text = (Int32.Parse(txtMaHD.Text) + 1).ToString(); soDoHD = "";
                    t1.Text = ""; t2.Text = ""; t3.Text = ""; t4.Text = ""; t5.Text = ""; t6.Text = ""; t7.Text = "";
                    t8.Text = ""; t9.Text = ""; t10.Text = ""; t11.Text = ""; t12.Text = ""; t13.Text = ""; t14.Text = "";
                    hasHD = false; rtxtGhiChuHoaDon.Text = ""; nudSoAo.Value = 0; nudSoQuan.Value = 0;
                    lbTenKH.Text = ""; maKHMayAo = 0; btnThemHoaDonMay.Enabled = false;
                    btnThemCT.Enabled = false; btnChonKH.Enabled = true;

                }

            }
        }

        private void btnThueAo_Click(object sender, EventArgs e)
        {
            new frmKhoAoChoThue().ShowDialog();
        }
        //   int maCTHD = 0;decimal tongPhi = 0;




        private void btnAoDangMay_Click(object sender, EventArgs e)
        {
            new frmAoDangMay().ShowDialog();
            if (infoClass.getMaKH() != 0)
            {
                maKHMayAo = infoClass.getMaKH();
                //   rtxtSoDoRieng.Text = infoClass.getSoDo();

                infoClass.setmaKH(0);
            }
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            new frmBangLuong().ShowDialog();
        }

        private void btnLichHomNay_Click(object sender, EventArgs e)
        {
            new frmChoThu().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmNhanVien().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new frmLuuTru().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmKhachHang().ShowDialog();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            new frmDatHang().ShowDialog();
        }

        private void btnKhoVai_Click(object sender, EventArgs e)
        {
            new frmKhoVai().ShowDialog();
        }

        private void btnBanVai_Click(object sender, EventArgs e)
        {
            new frmBanVai().ShowDialog();
        }

        private void btnSuaNgoai_Click(object sender, EventArgs e)
        {
            new frmSuaAoNgoai().ShowDialog();
        }

        private void btnDanhSachHangDat_Click(object sender, EventArgs e)
        {
            new frmDanhSachSua().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new frmThueAoMoi().ShowDialog();
        }

        private void tiếnĐộMayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAoDangMay().ShowDialog();
        }

        private void danhSáchCácLầnSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDanhSachSua().ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmKhachHang().ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thuêMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmThueAoMoi().ShowDialog();
        }

        private void theoDõiTiếnĐộThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAoChoThue().ShowDialog();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmKhoAoChoThue().ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đặtHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDatHang().ShowDialog();
        }

        private void kháchTớiTrảHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmHangCholay().ShowDialog();
        }

        private void bánVảiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoVảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmKhoVai().ShowDialog();
        }

        private void bánVảiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmBanVai().ShowDialog();
        }

        private void xemDanhSáchCácÁoChờThửToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChoThu().ShowDialog();
        }

        private void xemDanhSáchCácÁoĐangSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmChoSua().ShowDialog();
        }

        private void sửaMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSuaAoNgoai().ShowDialog();
        }

        private void danhSáchSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDanhSachSuaNgoai().ShowDialog();
        }

        private void quảnLýThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmNhanVien().ShowDialog();
        }

        private void quảnLýLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBangLuong().ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBanAo().ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLuuTru().ShowDialog();
        }
        int temp = 0;
        private void rtxtSoDoDaiDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

        }

        private void bgNhapAoMoi_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        string soDoHD = ""; bool hasHD = false;
        void FormatString()
        {

            temp = 0; soDoHD = "";
            soDoHD += t1.Text.Trim() + "\n\n"; if (t1.Text != "") temp += 1;
            soDoHD += t2.Text.Trim() + " \n\n "; if (t2.Text != "") temp += 1;
            soDoHD += t3.Text.Trim() + " \n\n "; if (t3.Text != "") temp += 1;
            soDoHD += t4.Text.Trim() + " \n\n "; if (t4.Text != "") temp += 1;
            soDoHD += t5.Text.Trim() + " \n\n "; if (t5.Text != "") temp += 1;
            soDoHD += t6.Text.Trim() + " \n\n "; if (t6.Text != "") temp += 1;
            soDoHD += t7.Text.Trim() + " \n\n "; if (t7.Text != "") temp += 1;
            soDoHD += t8.Text.Trim() + " \n\n "; if (t8.Text != "") temp += 1;
            soDoHD += t9.Text.Trim() + " \n\n "; if (t9.Text != "") temp += 1;
            soDoHD += t10.Text.Trim() + " \n\n "; if (t10.Text != "") temp += 1;
            soDoHD += t11.Text.Trim() + " \n\n "; if (t11.Text != "") temp += 1;
            soDoHD += t12.Text.Trim() + " \n\n "; if (t12.Text != "") temp += 1;
            soDoHD += t13.Text.Trim() + " \n\n "; if (t13.Text != "") temp += 1;
            soDoHD += t14.Text.Trim() + " \n\n "; if (t14.Text != "") temp += 1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FormatString();
            if (temp == 14)
            {
                if (!hasHD)
                {
                    string er = "";
                    if (dbMayAo.InsertHoaDonAoMay(ref er,Int32.Parse(txtMaHD.Text), maKHMayAo, ngayLapHoaDon, Convert.ToDateTime(dtNgayHenThu.Value.Date), rtxtGhiChuHoaDon.Text, 0, Int32.Parse(nudSoAo.Value.ToString()), Int32.Parse(nudSoQuan.Value.ToString()), AnhDaiDienHoaDonMayAo, soDoHD))
                    {

                        new frmInsertCTHDMay(Int32.Parse(txtMaHD.Text), Int32.Parse(nudSoAo.Value.ToString()), Int32.Parse(nudSoQuan.Value.ToString()), true).ShowDialog();
                        hasHD = true;
                    }
                }
                else
                {
                    new frmInsertCTHDMay(Int32.Parse(txtMaHD.Text), Int32.Parse(nudSoAo.Value.ToString()), Int32.Parse(nudSoQuan.Value.ToString()), false).ShowDialog();
                }
                lbThanhTien.Text = infoClass.getTongPhi().ToString(); btnThemHoaDonMay.Enabled = true;

            }
            else
            {
                if (temp < 14)
                {
                    MessageBox.Show("Số đo nhập chưa đầy đủ!!!");
                    temp = 0; soDoHD = "";
                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void t9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == 13)
            {
                switch (txt.Name)
                {
                    case "t1":
                        t2.Focus();
                        break;
                    case "t2":
                        t3.Focus();
                        break;
                    case "t3":
                        t4.Focus();
                        break;
                    case "t4":
                        t5.Focus();
                        break;
                    case "t5":
                        t6.Focus();
                        break;
                    case "t6":
                        t7.Focus();
                        break;
                    case "t7":
                        t8.Focus();
                        break;
                    case "t8":
                        t9.Focus();
                        break;
                    case "t9":
                        t10.Focus();
                        break;
                    case "t10":
                        t11.Focus();
                        break;
                    case "t11":
                        t12.Focus();
                        break;
                    case "t12":
                        t13.Focus();
                        break;
                    case "t13":
                        t14.Focus();
                        break;
                    default:
                        break;

                }
            }
        }

        private void lbThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void pbAnhDaiDien_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
            hasHD = false;

        }
        string soDoMoi = ""; string[] stringTemp;
        void getString()
        {
            int tem = 0; string te = ""; stringTemp = new string[200];
            foreach (char i in soDoMoi.Trim())
            {

                if (i.ToString() == "\n")
                {
                    if (te != "")
                    {
                        stringTemp[tem] = te; tem++;
                        te = "";
                    }
                }
                else
                {
                    te += i;
                }
            }
            stringTemp[13] = te;
            t1.Text = stringTemp[0]; t2.Text = stringTemp[1]; t3.Text = stringTemp[2]; t4.Text = stringTemp[3]; t5.Text = stringTemp[4];
            t6.Text = stringTemp[5]; t7.Text = stringTemp[6]; t8.Text = stringTemp[7]; t9.Text = stringTemp[8]; t10.Text = stringTemp[9];
            t11.Text = stringTemp[10]; t12.Text = stringTemp[11]; t13.Text = stringTemp[12]; t14.Text = stringTemp[13];

        }
        private void cácLầnMayÁoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new ReportDemo().ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lưuTrữToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchCácHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLuuTru().ShowDialog();
        }

        private void danhSáchHóaĐơnMayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmDanhSachHoaDonMayAo().ShowDialog();
            if (infoClass.getSoDo() != "")
            {
                soDoMoi = infoClass.getSoDo();
                infoClass.setSoDo("");
                maKHMayAo = infoClass.getMaKH();
                lbTenKH.Text = dbKhachHang.GetTenKHTheoMa(maKHMayAo);
                btnThemCT.Enabled = true;
                getString();
            }
        }
       
        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofdImages = new FolderBrowserDialog();
          
            //  ofdImages.Filter = "Image file (*.JPG;*.NPG;*JEPG)|*.JPG;*.NPG;*JEPG";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   // MessageBox.Show(ofdImages.SelectedPath);
                    string er = "";
                    string path = Path.Combine(ofdImages.SelectedPath, "TiemMayHaiTrieu.bak");
                    bool result = dbMayAo.BackupDB(ref er,path);
                    if(result==true)                                       
                       MessageBox.Show("Back up dữ liệu thành công!", "Backup dữ liệu...");   
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
