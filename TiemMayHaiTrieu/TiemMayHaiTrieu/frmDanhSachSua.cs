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
    public partial class frmDanhSachSua : Form
    {
        public frmDanhSachSua()
        {
            InitializeComponent();
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		dbSuaAo dbSuaAo = new dbSuaAo();
		private void rbDaThanhToan_CheckedChanged(object sender, EventArgs e)
		{
			
            resetAnh();
			btnThanhToanAo.Enabled = false;
		}

		private void rbChuaThanhToan_CheckedChanged(object sender, EventArgs e)
		{
		
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Xác nhận thanh toán tiền công cho thợ sửa áo !!", "Thanh toán công sửa", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				string err = "";
				if(dbSuaAo.ThanhToanCongSuaAo(ref err,maSuaAo))
				{
                    btnThanhToanAo.Enabled = false;
                    dgvDanhSachAo.DataSource = dbSuaAo.GetDSAoSuaTheoMaHD_DaSua(maHD);
                }
			}
		}
		int maAo = 0;
		

		private void btnlayDanhSach_Click(object sender, EventArgs e)
		{
            dgvDSHD.DataSource = dbSuaAo.getDSHDCoAoSuaXong();
		}
        void resetAnh()
        {
            pbAo.Image = null;pbQuan.Image = null;
        }
		private void txtTimKiemAoDaNhan_Click(object sender, EventArgs e)
		{
			txtTimKiemAoDaNhan.Text = "";
		}

		private void txtTimKiemAoDaNhan_TextChanged(object sender, EventArgs e)
		{
            dgvDSHD.DataSource = dbSuaAo.getDSHDCoAoSuaXongTheoTenKH(txtTimKiemAoDaNhan.Text);
		}

        private void dgvDanhSachSua_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDanhSachSua_Load(object sender, EventArgs e)
        {
         
        }

        private void dgvDanhSachSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int maHD = 0;
        private void dgvDSHD_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDSHD.CurrentCell.RowIndex;
                maHD = Int32.Parse(dgvDSHD.Rows[index].Cells["dshd_Id"].Value.ToString());
                dgvDanhSachAo.DataSource = dbSuaAo.GetDSAoSuaTheoMaHD_DaSua(maHD);
                dgvDanhSachQuan.DataSource = dbSuaAo.GetDSQuanSuaTheoMaHD_DaSua(maHD);
            }
            catch (Exception)
            {

            }
        }
        int maSuaAo = 0;int maSuaQuan = 0;
        private void dgvDanhSachAo_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachAo.CurrentCell.RowIndex;
                maSuaAo = Int32.Parse(dgvDanhSachAo.Rows[index].Cells["dsa_Id"].Value.ToString());
                pbAo.Image = (System.Drawing.Image)dgvDanhSachAo.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                string dathanhToan = dgvDanhSachAo.Rows[index].Cells["dsa_daThanhToan"].Value.ToString();
                if (dathanhToan == "0")
                {
                    btnThanhToanAo.Enabled = true; btnThanhToanQuan.Enabled = false;
                }
                else
                {
                    btnThanhToanAo.Enabled = false; btnThanhToanQuan.Enabled = false;
                }
               
            }
            catch (Exception)
            {

            }
        }

        private void dgvDanhSachQuan_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvDanhSachQuan.CurrentCell.RowIndex;
                maSuaQuan = Int32.Parse(dgvDanhSachQuan.Rows[index].Cells["dsq_Id"].Value.ToString());
                pbQuan.Image = (System.Drawing.Image)dgvDanhSachQuan.Rows[index].Cells["dsq_anhDaiDien"].FormattedValue;
                string dathanhToan = dgvDanhSachQuan.Rows[index].Cells["dsq_daThanhToan"].Value.ToString();
                if (dathanhToan == "0")
                {
                    btnThanhToanAo.Enabled = false; btnThanhToanQuan.Enabled = true;
                }
                else
                {
                    btnThanhToanAo.Enabled = false; btnThanhToanQuan.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnThanhToanQuan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thanh toán tiền công cho thợ sửa quần ?", "Thanh toán công sửa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string err = "";
                if (dbSuaAo.ThanhToanCongSuaQuan(ref err, maSuaQuan))
                {
                    btnThanhToanQuan.Enabled = false;
                    dgvDanhSachQuan.DataSource = dbSuaAo.GetDSQuanSuaTheoMaHD_DaSua(maHD);
                }
            }
        }
    }
}
