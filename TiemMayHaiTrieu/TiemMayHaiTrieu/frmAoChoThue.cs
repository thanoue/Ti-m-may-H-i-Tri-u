using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;
namespace TiemMayHaiTrieu
{
    public partial class frmAoChoThue : Form
    {
        public frmAoChoThue()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        dbThueAo dbThueAo = new dbThueAo();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAoChoThue_Load(object sender, EventArgs e)
        {
           
        }

        private void rbDanhSachChoTra_CheckedChanged(object sender, EventArgs e)
        {        
           dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueChoTra();
            //    btnTraAo.Enabled = true;btnLayAo.Enabled = false;
          //  btnDeleteHoaDon.Enabled = false;
            btnLayAo.Enabled = false;
            btnTraAo.Enabled = false;
        }

        private void rbDanhSachQuaHanTra_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueQuaHanTra(Convert.ToDateTime(DateTime.Now));
         //   btnDeleteHoaDon.Enabled = false;
            btnLayAo.Enabled = false;
            btnTraAo.Enabled = false;
            //   btnTraAo.Enabled = true; btnLayAo.Enabled = false;
        }

        private void rbDanhSachDaTra_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueDaTra();
         //   btnDeleteHoaDon.Enabled = false;
            btnLayAo.Enabled = false;
            btnTraAo.Enabled = false;
        }

        private void rbDanhSachChoLay_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueChoLay();
         //   btnDeleteHoaDon.Enabled = false;
            btnLayAo.Enabled = false;
            btnTraAo.Enabled = false;
            //     btnLayAo.Enabled = true;btnTraAo.Enabled = false;
        }

        private void rbDSQuaHanLay_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueQuaHanLay(Convert.ToDateTime(DateTime.Now));
         //   btnDeleteHoaDon.Enabled = false;
            btnLayAo.Enabled = false;
            btnTraAo.Enabled = false;
            //   btnLayAo.Enabled = true; btnTraAo.Enabled = false;
        }
        int maHD = 0; dbAoChoThue dbAoChoThue = new dbAoChoThue();
        string tenKH = ""; DateTime ngayLapHD;
        private void dgvDSHDThue_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSHDThue.CurrentCell.RowIndex;
                maHD = Int32.Parse(dgvDSHDThue.Rows[index].Cells["dshd_Id"].Value.ToString());
                dgvDanhSachChonMua.DataSource = dbAoChoThue.GetCTHDThueAoTheoMaHD(maHD);
                if(rbDanhSachChoLay.Checked==true || rbDSQuaHanLay.Checked == true)
                {
                    lbNgayHenLay.Text = dgvDSHDThue.Rows[index].Cells["dshd_ngayHenLay"].Value.ToString();
                    lbTienCoc.Text = dbThueAo.TongTienCoc(maHD).ToString();
                    tenKH = dgvDSHDThue.Rows[index].Cells["dshd_tenKhachHang"].Value.ToString();
                    ngayLapHD = Convert.ToDateTime(dgvDSHDThue.Rows[index].Cells["dshd_ngayLapHoaDon"].Value);
                    txtPhiThue.Enabled = false;txtPhiThue.Enabled = false;
                    lbngayTra.Text = "...";lbNgayLay.Text = "...";
                    btnLayAo.Enabled = true;
                    txtPhiThue.Text = dgvDSHDThue.Rows[index].Cells["dshd_thanhTien"].Value.ToString();
                    lbTienGiuCho.Text = dbThueAo.TongTienGiuCho(maHD).ToString();
                    //btnDeleteHoaDon.Enabled = true ;
                    btnTraAo.Enabled = false;
                }
                else
                    if (rbDanhSachChoTra.Checked == true || rbDanhSachQuaHanTra.Checked == true)
                    {
                        // btnDeleteHoaDon.Enabled = false;
                        lbNgayHenLay.Text = "";txtPhiThue.Enabled = true;
                        lbTienCoc.Text = dbThueAo.TongTienCoc(maHD).ToString();
                        lbTienGiuCho.Text = dbThueAo.TongTienGiuCho(maHD).ToString();
                        lbNgayLay.Text = dgvDSHDThue.Rows[index].Cells["dshd_ngayLay"].Value.ToString();
                        dtpNgayHenTra.Value= Convert.ToDateTime(dgvDSHDThue.Rows[index].Cells["dshd_ngayHenTra"].Value.ToString());
                        txtPhiThue.Text = dgvDSHDThue.Rows[index].Cells["dshd_thanhTien"].Value.ToString();
                         btnTraAo.Enabled = true;btnLayAo.Enabled = false;
                        lbngayTra.Text = "...";
                    }
                    else if (rbDanhSachDaTra.Checked == true)
                    {
                   //    btnDeleteHoaDon.Enabled = false;
                    btnLayAo.Enabled = false;btnTraAo.Enabled = false;
                        lbNgayHenLay.Text = "...";lbNgayLay.Text = "...";
                        lbngayTra.Text = dgvDSHDThue.Rows[index].Cells["dshd_ngayTra"].Value.ToString();
                     }
            }
            catch (Exception)
            {

            }
        }

        private void dgvDanhSachChonMua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachChonMua.CurrentCell.RowIndex;
                pictureBox1.Image = (System.Drawing.Image)dgvDanhSachChonMua.Rows[index].Cells["anhDaiDien"].FormattedValue;
            }
            catch (Exception)
            {

            }
        }

        private void btnLayAo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khách hàng tới lấy áo thuê?", "Lấy áo thuê!! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
                string er = "";
                if(dbThueAo.NhanAoThue(ref er, maHD, Convert.ToDateTime(DateTime.Now),Convert.ToDateTime( dtpNgayHenTra.Value.Date)))
                {
                    if (MessageBox.Show("Xuất phiếu nhận?", "Xuất phiếu nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new ReportDemo(maHD, tenKH, dtpNgayHenTra.Value,ngayLapHD).ShowDialog();
                    }
                    if (rbDanhSachChoLay.Checked == true)
                        dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueChoLay();
                    else dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueQuaHanLay(Convert.ToDateTime(DateTime.Now));
                    btnLayAo.Enabled = false;//btnDeleteHoaDon.Enabled = false;btnTraAo.Enabled = false;
                }

            }

        }

        private void btnTraAo_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Khách hàng tới trả áo?", "Trả áo thuê!! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if (dbThueAo.TraAoThue(ref er, maHD, Convert.ToDateTime(DateTime.Now),Convert.ToDecimal( txtPhiThue.Text)))
                {
                    MessageBox.Show("Đã trả hàng thuê", "Trả");
                    if (rbDanhSachChoTra.Checked == true)
                        dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueChoTra();
                    else dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueQuaHanTra(Convert.ToDateTime(DateTime.Now));
                    btnTraAo.Enabled = false;//btnDeleteHoaDon.Enabled = false;btnLayAo.Enabled = false;
                }

            }
        }

        private void btnDeleteHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy đơn hàng này??", "Hủy đơn hàng!! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if(dbThueAo.XoaHDThueAo(ref er, maHD))
                {
                    if (rbDanhSachChoTra.Checked == true)
                        dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueChoTra();
                    else {
                        if (rbDanhSachQuaHanTra.Checked == true)
                            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueQuaHanTra(Convert.ToDateTime(DateTime.Now));
                        else
                            if (rbDSQuaHanLay.Checked == true)
                            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueQuaHanLay(Convert.ToDateTime(DateTime.Now));
                            else if(rbDanhSachChoLay.Checked==true)
                            dgvDSHDThue.DataSource = dbThueAo.GetDSHDThueChoLay();

                    }
               //     btnDeleteHoaDon.Enabled = false;
                    btnLayAo.Enabled = false;
                    btnTraAo.Enabled = false;
                }
            }
        }
    }
}
