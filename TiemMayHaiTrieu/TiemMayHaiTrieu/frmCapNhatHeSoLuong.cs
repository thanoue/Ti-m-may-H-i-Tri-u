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
    public partial class frmCapNhatHeSoLuong : Form
    {
        public frmCapNhatHeSoLuong()
        {
            InitializeComponent();
        }
        dbLuong dbLuong = new dbLuong();
        private void rbCat_CheckedChanged(object sender, EventArgs e)
        {
            string[] s = new string[6];
            a = dbLuong.GetLuongTheoNhom("cat");int temp = 0;
            foreach(DataRow i in a.Rows)
            {
                s[temp] = i["tienCong"].ToString();
                temp++;
            }
            txt1.Text = s[0]; txt2.Text = s[1];
            txt3.Text = s[2];
            txt4.Text = s[3];
            txt5.Text = s[4];
            txt6.Text = s[5];
            btnClear.Enabled = true;btnXacNhanCapNhat.Enabled = true;
        }
        DataTable a = new DataTable();
        private void frmCapNhatHeSoLuong_Load(object sender, EventArgs e)
        {
            
        }

        private void rbMay_CheckedChanged(object sender, EventArgs e)
        {
            string[] s = new string[6];
            a = dbLuong.GetLuongTheoNhom("may"); int temp = 0;
            foreach (DataRow i in a.Rows)
            {
                s[temp] = i["tienCong"].ToString();
                temp++;
            }
            txt1.Text = s[0]; txt2.Text = s[1];
            txt3.Text = s[2];
            txt4.Text = s[3];
            txt5.Text = s[4];
            txt6.Text = s[5];
            btnClear.Enabled = true; btnXacNhanCapNhat.Enabled = true;
        }

        private void rbLuong_CheckedChanged(object sender, EventArgs e)
        {
            string[] s = new string[6];
            a = dbLuong.GetLuongTheoNhom("luong"); int temp = 0;
            foreach (DataRow i in a.Rows)
            {
                s[temp] = i["tienCong"].ToString();
                temp++;
            }
            txt1.Text = s[0]; txt2.Text = s[1];
            txt3.Text = s[2];
            txt4.Text = s[3];
            txt5.Text = s[4];
            btnClear.Enabled = true; btnXacNhanCapNhat.Enabled = true;
            txt6.Text = s[5];
        }

        private void rbCatQuan_CheckedChanged(object sender, EventArgs e)
        {
            string[] s = new string[6];
            a = dbLuong.GetLuongTheoNhom("catQuan"); int temp = 0;
            foreach (DataRow i in a.Rows)
            {
                s[temp] = i["tienCong"].ToString();
                temp++;
            }
            txt1.Text = s[0]; txt2.Text = s[1];
            txt3.Text = s[2];
            txt4.Text = s[3];
            txt5.Text = s[4];
            txt6.Text = s[5];
            btnClear.Enabled = true; btnXacNhanCapNhat.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string[] s = new string[6];
            a = dbLuong.GetLuongTheoNhom("mayQuan"); int temp = 0;
            foreach (DataRow i in a.Rows)
            {
                s[temp] = i["tienCong"].ToString();
                temp++;
            }
            txt1.Text = s[0]; txt2.Text = s[1];
            txt3.Text = s[2];
            txt4.Text = s[3];
            txt5.Text = s[4];
            txt6.Text = s[5];
            btnClear.Enabled = true; btnXacNhanCapNhat.Enabled = true;
        }
        private void btnXacNhanCapNhat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận sửa hệ số lương?","Sửa hệ số lương", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if (rbCat.Checked == true)
                {
                    if(dbLuong.CapNhatLuongCat(ref er,Convert.ToDecimal(txt1.Text), Convert.ToDecimal(txt2.Text), Convert.ToDecimal(txt3.Text), Convert.ToDecimal(txt4.Text), Convert.ToDecimal(txt5.Text), Convert.ToDecimal(txt6.Text)))
                    {
                        MessageBox.Show("Sửa thành công!");
                        rbCat.Checked =false;
                        btnXacNhanCapNhat.Enabled = false;btnClear.Enabled = false;

                    }

                }
                else
                {
                    if (rbMay.Checked == true)
                    {
                        if (dbLuong.CapNhatLuongMay(ref er, Convert.ToDecimal(txt1.Text), Convert.ToDecimal(txt2.Text), Convert.ToDecimal(txt3.Text), Convert.ToDecimal(txt4.Text), Convert.ToDecimal(txt5.Text), Convert.ToDecimal(txt6.Text)))
                        {
                            MessageBox.Show("Sửa thành công!");
                            rbMay.Checked = false;
                            btnXacNhanCapNhat.Enabled = false; btnClear.Enabled = false;

                        }
                    }
                    else
                    {
                        if (rbLuong.Checked == true)
                        {
                            if (dbLuong.CapNhatLuongLuong(ref er, Convert.ToDecimal(txt1.Text), Convert.ToDecimal(txt2.Text), Convert.ToDecimal(txt3.Text), Convert.ToDecimal(txt4.Text), Convert.ToDecimal(txt5.Text), Convert.ToDecimal(txt6.Text)))
                            {
                                MessageBox.Show("Sửa thành công!");
                                rbLuong.Checked = false;
                                btnXacNhanCapNhat.Enabled = false; btnClear.Enabled = false;

                            }
                        }
                        else
                        {
                            if (rbCatQuan.Checked == true)
                            {
                                if (dbLuong.CapNhatLuongCatQuan(ref er, Convert.ToDecimal(txt1.Text), Convert.ToDecimal(txt2.Text), Convert.ToDecimal(txt3.Text), Convert.ToDecimal(txt4.Text), Convert.ToDecimal(txt5.Text), Convert.ToDecimal(txt6.Text)))
                                {
                                    MessageBox.Show("Sửa thành công!");
                                    rbCatQuan.Checked = false;
                                    btnXacNhanCapNhat.Enabled = false; btnClear.Enabled = false;

                                }
                            }
                            else
                            {
                                if (rbMayQuan.Checked == true)
                                {

                                    if (dbLuong.CapNhatLuongMayQuan(ref er, Convert.ToDecimal(txt1.Text), Convert.ToDecimal(txt2.Text), Convert.ToDecimal(txt3.Text), Convert.ToDecimal(txt4.Text), Convert.ToDecimal(txt5.Text), Convert.ToDecimal(txt6.Text)))
                                    {
                                        MessageBox.Show("Sửa thành công!");
                                        rbMayQuan.Checked = false;
                                        btnXacNhanCapNhat.Enabled = false; btnClear.Enabled = false;

                                    }
                                }
                            }
                        }
                    }
                }
            }
           
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1.Text = "0";txt2.Text = "0";txt3.Text = "0";txt4.Text = "0";txt5.Text = "0";txt6.Text = "0";
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == 13)
            {
                switch (txt.Name)
                {
                    case "txt1":
                        txt2.Focus();
                        break;
                    case "txt2":
                        txt3.Focus();
                        break;
                    case "txt3":
                        txt4.Focus();
                        break;
                    case "txt4":
                        txt5.Focus();
                        break;
                    case "txt5":
                        txt6.Focus();
                        break;
                    default:
                        break;

                }
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
