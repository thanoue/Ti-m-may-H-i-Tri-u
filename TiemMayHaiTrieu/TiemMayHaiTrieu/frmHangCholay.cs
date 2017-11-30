using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicFramework;
namespace TiemMayHaiTrieu
{
    public partial class frmHangCholay : Form
    {
        public frmHangCholay()
        {
            InitializeComponent();
        }
        dbHangDat dbHangDat = new dbHangDat();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int mahangtoihan = 0;
        public frmHangCholay(int maHang):this()
        {
            mahangtoihan = maHang;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void frmHangCholay_Load(object sender, EventArgs e)
        {
            
        }
        int maHDDatHang = 0;
        private void dgvDanhSachHangChoNhan_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception)
            { }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
          
        }

        private void txtTimTheoTenKh_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimTheoTenKh_Click(object sender, EventArgs e)
        {
          
        }
        
        private void rbDSHDChuaDatTho_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbHangDat.GetDSHDDatHangChuaDatTho();
          
        }

        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentCell.RowIndex;
                maHDDatHang = Int32.Parse(dgvDSHD.Rows[index].Cells["maHD"].Value.ToString());
                lbTongTienCoc.Text = dbHangDat.TongTienCocCacCTHDDatHang(maHDDatHang).ToString();
                lbTongTienConlai.Text = dbHangDat.TongTienConLaiCacCTHDDatHang(maHDDatHang).ToString();
                dgvDSCTHD.DataSource = dbHangDat.GetCTHDDatHangTheoMaHD(maHDDatHang);
                if (rbDSHDChuaDatTho.Checked == true)
                {
                    btnDatTho.Enabled = true; btnGiaoHang.Enabled = false; btnlayhang.Enabled = false;
                }
                else
                {
                    if (rbDSHDChoThoGiao.Checked == true)
                    {
                        btnDatTho.Enabled = false; btnGiaoHang.Enabled = true; btnlayhang.Enabled = false;
                    }
                    else
                    {
                        if (rbDSHDChoNhan.Checked == true)
                        {
                            btnDatTho.Enabled = false; btnGiaoHang.Enabled = false; btnlayhang.Enabled = true;
                        }
                        else
                        {
                            btnDatTho.Enabled = false; btnGiaoHang.Enabled = false; btnlayhang.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btnDatTho_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hoàn tất đặt thợ cho hóa đơn này?","Đặt thợ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if (dbHangDat.DatTho(ref er, maHDDatHang, DateTime.Now.Date))
                {
                    btnDatTho.Enabled = false;
                    MessageBox.Show("Đã đặt thợ cho một hóa đơn!");
                    dgvDSHD.DataSource = dbHangDat.GetDSHDDatHangChuaDatTho();
                }
            }
        }

        private void rbDSHDChoThoGiao_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbHangDat.GetDSHDDatHangDaDatTho();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thợ đã giao hàng cho hóa đơn này?", "Thợ giao hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if (dbHangDat.Giaohang(ref err, maHDDatHang, DateTime.Now.Date))
                {
                    dgvDSHD.DataSource = dbHangDat.GetDSHDDatHangDaDatTho();
                    btnGiaoHang.Enabled = false;
                }
            }
        }

        private void rbDSHDChoNhan_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbHangDat.GetDanhSachHDDatHangChoNhan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận khách hàng lấy hàng?", "Lấy hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if(dbHangDat.NhanHang(ref er, maHDDatHang, DateTime.Now.Date))
                {
                    MessageBox.Show("Nhận hàng xong!");
                    dgvDSHD.DataSource = dbHangDat.GetDanhSachHDDatHangChoNhan();
                    btnlayhang.Enabled = false;
                }
            }
        }

        private void rbDSHDDaNhan_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbHangDat.GetDanhSachHDDatHangDaNhan();
        }
    }
}
