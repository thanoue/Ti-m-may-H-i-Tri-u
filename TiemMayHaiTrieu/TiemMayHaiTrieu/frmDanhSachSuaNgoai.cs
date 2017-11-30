using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicFramework;
using System.IO;

namespace TiemMayHaiTrieu
{
    public partial class frmDanhSachSuaNgoai : Form
    {
        public frmDanhSachSuaNgoai()
        {
            InitializeComponent();
        }
        dbSuaNgoai dbSuaNgoai = new dbSuaNgoai();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbDaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSachSua.DataSource = dbSuaNgoai.GetDSPhiSuaNgoaiDaThanhToan();
            btnThanhToan.Enabled = false;
        }

        private void rbChuaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSachSua.DataSource = dbSuaNgoai.GetDSPhiSuaNgoaiChuaThanhToan();
            btnThanhToan.Enabled = false;
        }
        int maPhiSuaNgoai = 0;
        private void dgvDanhSachSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachSua.CurrentCell.RowIndex;
                
                pbAo.Image = (System.Drawing.Image)dgvDanhSachSua.Rows[index].Cells["anhDaiDien"].FormattedValue;
                maPhiSuaNgoai = Int32.Parse(dgvDanhSachSua.Rows[index].Cells["maPhi"].Value.ToString());
                if (rbDaThanhToan.Checked == true)
                    btnThanhToan.Enabled = false;
                else btnThanhToan.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Trả công cho thơ sửa?", "thanh toán công sửa ngoài!! ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if(dbSuaNgoai.ThanhToanCongSua(ref er, maPhiSuaNgoai))
                {
                    MessageBox.Show("Thanh toán tiền công sửa cho 1 áo xong!");
                    dgvDanhSachSua.DataSource = dbSuaNgoai.GetDSPhiSuaNgoaiDaThanhToan();
                    btnThanhToan.Enabled = false;
                    rbDaThanhToan.Checked = true;
                    btnThanhToan.Enabled = false;
                    pbAo.Image = null;
                    maPhiSuaNgoai = 0;
                }
            }
        }

        private void frmDanhSachSuaNgoai_Load(object sender, EventArgs e)
        {
            rbChuaThanhToan.Checked = true;
            dgvDanhSachSua.DataSource = dbSuaNgoai.GetDSPhiSuaNgoaiChuaThanhToan();
        }

        private void dgvDanhSachSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
