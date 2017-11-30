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
using System.IO;
namespace TiemMayHaiTrieu
{
    public partial class frmLuuTru : Form
    {
        public frmLuuTru()
        {
            InitializeComponent();
        }
        dbLuuTru dbLuuTru = new dbLuuTru();dbChamCongTho dbChamCongTho = new dbChamCongTho();
        private void pbAo_Click(object sender, EventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbDSHDBanVai.Checked == true)
                dgvDSHoaDon.DataSource = dbLuuTru.GetDSHoaDon();
            else
                if (rbDSHDBanAo.Checked == true)
                dgvDSHoaDon.DataSource = dbLuuTru.GetDSHoaDonBanAo();
        }
        int maHoaDon = 0;
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(rbDSHDBanVai.Checked==true)
            dgvDSHoaDon.DataSource = dbLuuTru.TimHDTheoTenKH(textBox1.Text);
            else if(rbDSHDBanAo.Checked==true)
                dgvDSHoaDon.DataSource = dbLuuTru.TimHDBanAoTheoTenKH(textBox1.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDSHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDSHDBanVai.Checked == true)
                {
                    int index = dgvDSHoaDon.CurrentCell.RowIndex;
                    maHoaDon = Int32.Parse(dgvDSHoaDon.Rows[index].Cells["dshd_maHD"].Value.ToString());
                    dgvDanhSachChonMua.DataSource = dbLuuTru.GetCTHDTheoHD(maHoaDon);
                }
                else if (rbDSHDBanAo.Checked == true)
                {
                    int index = dgvDSHoaDon.CurrentCell.RowIndex;
                    maHoaDon = Int32.Parse(dgvDSHoaDon.Rows[index].Cells["dshd_maHD"].Value.ToString());
                    dgvDanhSachChonMua.DataSource = dbLuuTru.GetCTHDBanAoTheoMaHD(maHoaDon);
                }
                
            }
            catch (Exception) { }
           
        }
        string anh;
        private void dgvDanhSachChonMua_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbDSHDBanVai.Checked==true || rbDSHDBanAo.Checked == true)
                {
                    int index = dgvDanhSachChonMua.CurrentCell.RowIndex;
                    pictureBox2.Image = (System.Drawing.Image)dgvDanhSachChonMua.Rows[index].Cells["ds_anhDaiDien"].FormattedValue;
                }

               
                //dgvDanhSachChonMua.DataSource = dbLuuTru.GetCTHDTheoHD(maHoaDon);
            }
            catch (Exception) { }
        }

        private void frmLuuTru_Load(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachChonMua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHoaDon.DataSource = dbLuuTru.GetDSHoaDonBanAo();
            dgvDanhSachChonMua.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dgvDSHoaDon.DataSource = dbLuuTru.GetDSHoaDon();
            dgvDanhSachChonMua.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
