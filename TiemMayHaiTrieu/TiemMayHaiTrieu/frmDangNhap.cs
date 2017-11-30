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
using TiemMayHaiTrieu.Properties;
using System.Data.SqlClient;
using System.Threading;

namespace TiemMayHaiTrieu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string servername = "";
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtServerName.Enabled = false;
            if (Properties.Settings.Default.sername == "0")
            {
                txtServerName.Enabled = true; txtServerName.Visible = true;label1.Visible = true;
            }
            else
            {
                txtServerName.Text = Properties.Settings.Default.sername;
                label1.Visible = false;
                servername = Properties.Settings.Default.sername; txtServerName.Visible = false;
              //  label1.Visible = false;
            }
                
          
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

			DangNhap();
           
        }
		void DangNhap()
		{
			if (Properties.Settings.Default.sername == "0")
			{
				Properties.Settings.Default.sername = txtServerName.Text;
				Properties.Settings.Default.Save();
				infoClass.setTenDangNhp(txtServerName.Text);
				string sqlConnect = @"data source =" + txtServerName.Text + "; initial catalog =TiemMayHaiTrieu; integrated security = true";

				// Tạo một connection tới máy chủ
				SqlConnection conn = new SqlConnection(sqlConnect);
				// QUA TRINH KET NOI
				try
				{
					conn.Open();
					if (txtUserName.Text == "admin" && txtPassWord.Text == "admin")
					{
						new frmMain().ShowDialog(); conn.Close(); txtServerName.Visible = false; label1.Visible = false;
                        txtServerName.Enabled = false;
					}
					else
						if (txtUserName.Text == "staff" && txtPassWord.Text == "staff")
					{

					//	new frmMain2().ShowDialog(); conn.Close(); txtServerName.Visible = false; label1.Visible = false;
                        txtServerName.Enabled = false;
					}
					else MessageBox.Show("Sai thông tin Đăng nhập!!");

				}
				catch (SqlException )
				{
					MessageBox.Show("Đăng nhập thất bại !!!");
				}
				finally
				{

					conn.Close();
				}

			}
			else
			{
				infoClass.setTenDangNhp(txtServerName.Text);
				string sqlConnect = @"data source =" + txtServerName.Text + "; initial catalog =TiemMayHaiTrieu; integrated security = true";

				// Tạo một connection tới máy chủ
				SqlConnection conn = new SqlConnection(sqlConnect);
				// QUA TRINH KET NOI
				try
				{
					conn.Open(); conn.Close();
					if (txtUserName.Text == "admin" && txtPassWord.Text == "admin")
					{
                        
                         new frmMain().ShowDialog();
                      

                        txtServerName.Visible = false;label1.Visible = false;
						txtServerName.Enabled = false;
					}
					else
					 if (txtUserName.Text == "staff" && txtPassWord.Text == "staff")
					{

                     //   new frmMain2().ShowDialog();                    
                        conn.Close(); txtServerName.Visible = false; label1.Visible = false;
                        txtServerName.Enabled = false;
					}
					else MessageBox.Show("Sai thông tin Đăng nhập!!");

				}
				catch (SqlException )
				{
					MessageBox.Show("Đăng nhập thất bại !!!");
				}
				finally
				{

					conn.Close();
				}
			}
		}

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sername = txtServerName.Text;
            Properties.Settings.Default.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtServerName.Enabled = true;
        }

		private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				DangNhap();
			}
		}

        private void label2_Click(object sender, EventArgs e)
        {
            txtServerName.Enabled = true;
            txtServerName.Visible = true;
            label1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
