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
    public partial class frmThemKhachHang : Form
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        dbKhachHang dbKhachHang = new dbKhachHang();
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            txtTenKH.Focus();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string err = "";
            if (MessageBox.Show("Chắc chắn thêm khách hàng này ?", "Thêm KH", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                if (dbKhachHang.InsertKhachHang(ref err, txtTenKH.Text.Trim(), txtSoDienThoai.Text.Trim(), txtDiaChi.Text.Trim(),
                    txtGhiChuKH.Text.Trim()))
                {
                    MessageBox.Show("Thêm KH thành công");
                    this.Close();
                }
                    


            }

        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == 13)
            {
                switch (txt.Name)
                {
                    case "txtTenKhachHang":
                        txtSoDienThoai.Focus();
                        break;
                    case "txtSoDienThoai":
                        txtDiaChi.Focus();
                        break;
                    case "txtDiaChi":
                        txtGhiChuKH.Focus();
                        break;
                    case "txtGhiChuKH":
                        btnThemKH.Focus();
                        break;
                    default:
                        break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
