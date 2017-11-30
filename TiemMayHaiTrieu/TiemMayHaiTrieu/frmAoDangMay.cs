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
using System.Threading;
namespace TiemMayHaiTrieu
{
    public partial class frmAoDangMay : Form
    {
        dbChamCongTho dbChamCongTho = new dbChamCongTho();dbLuong dbLuong = new dbLuong();
        dbTienDoMay dbTienDoMay = new dbTienDoMay();dbNhanVien dbNhanVien = new dbNhanVien();
        public frmAoDangMay()
        {
           
            InitializeComponent();

        }
        int first = 0;

        
        private void frmAoDangMay_Load(object sender, EventArgs e)
        {
            cbThoCat.DataSource = dbNhanVien.GetNhanVien();
            cbThoCat.DisplayMember = "tenNhanVien";
            cbThoCat.ValueMember = "Id";
            cbThoLuong.DataSource = dbNhanVien.GetNhanVien();
            cbThoLuong.DisplayMember = "tenNhanVien";
            cbThoLuong.ValueMember = "Id";

            cbThoMay.DataSource = dbNhanVien.GetNhanVien();
            cbThoMay.DisplayMember = "tenNhanVien";
            cbThoMay.ValueMember = "Id";       

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DateTime ngayDau = Convert.ToDateTime(dtpNgayDau.Value.Date);
            DateTime ngayCuoi =Convert.ToDateTime( dtpNgayCuoi.Value.Date);
            dgvDSHD.DataSource = dbTienDoMay.GetDSHDMayTheoKhoangThoiGian(ngayDau, ngayCuoi);
          
               

        }
        int maHD = 0;int second = 0;int third = 0;
        private void dgvTienDoMay_Click(object sender, EventArgs e)
        {
            try
            {

                if (first == 0 && second==0 && third==0)
                {

                    cbThoCatQuan.DataSource = dbNhanVien.GetNhanVien();
                    cbThoCatQuan.DisplayMember = "tenNhanVien";
                    cbThoCatQuan.ValueMember = "Id";
                
                    cbThoMayQuan.DataSource = dbNhanVien.GetNhanVien();
                    cbThoMayQuan.DisplayMember = "tenNhanVien";
                    cbThoMayQuan.ValueMember = "Id";third = 1;

                }
                int index = dgvDSHD.CurrentCell.RowIndex;
                maHD = Int32.Parse(dgvDSHD.Rows[index].Cells["dshd_Id"].Value.ToString());
                rtxtGhiChuHD.Text = dgvDSHD.Rows[index].Cells["dshd_ghiChu"].Value.ToString();
                pbAnhDaiDien.Image = (System.Drawing.Image)dgvDSHD.Rows[index].Cells["dshd_anhDaiDien"].FormattedValue;
                lbTienDoMay.Text = maHD.ToString();
                rtxtSoDoAoMay.Text = dgvDSHD.Rows[index].Cells["dshd_soDoDaiDien"].Value.ToString();
                lbNgayLapHD.Text = dgvDSHD.Rows[index].Cells["dshd_ngayLapHoaDon"].Value.ToString();
                dgvDanhSachAo.DataSource = dbTienDoMay.GetAoDuocMayTheoMaHD(maHD);
                dgvDanhSachQuan.DataSource = dbTienDoMay.GetQuanDuocMayTheoMaHD(maHD);
                               
             

            }
            catch (Exception) { }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        string  maAo = "";string ttAo = "";string ttQuan = "";
        private void dgvDSChiTietHD_Click(object sender, EventArgs e)
        {
            try
            {
               
                ////  int index = dgvDSChiTietHD.CurrentCell.RowIndex;btnXacNhanTienDoAo.Enabled = true;btnXacNhanTienDoQuan.Enabled = true;
                // // maAo = Int32.Parse(dgvDSChiTietHD.Rows[index].Cells["Id"].Value.ToString());
                // // so = dgvDSChiTietHD.Rows[index].Cells["soDo"].Value.ToString();
                //  rtxtSoDoAoMay.Text = dgvDSChiTietHD.Rows[index].Cells["soDo"].Value.ToString();
                //  pbAnhAo.Image = (System.Drawing.Image)dgvDSChiTietHD.Rows[index].Cells["anhAo"].FormattedValue;
                //  pbAnhQuan.Image = (System.Drawing.Image)dgvDSChiTietHD.Rows[index].Cells["anhQuan"].FormattedValue;
                //  rtxtGhiChuAoMay.Text = dgvDSChiTietHD.Rows[index].Cells["ghiChu"].Value.ToString();
                //  lbLoaiCo.Text = dgvDSChiTietHD.Rows[index].Cells["loaiCo"].Value.ToString();
                //  lbKichThuocCo.Text = dgvDSChiTietHD.Rows[index].Cells["kichThuocCo"].Value.ToString();
                //string tinhtrang = dgvDSChiTietHD.Rows[index].Cells["tinhTrang"].Value.ToString();
                ////  string tinhTrangQuan = dgvDSChiTietHD.Rows[index].Cells["tinhTrangQuan"].Value.ToString();
                //ttAo = tinhtrang; ttQuan = tinhTrangQuan;
                //switch (tinhtrang)
                //{
                //    case "DCX":
                //        lbTinhTrangAo.Text = "Đã cắt xong";
                //        break;
                //    case "DC":
                //        lbTinhTrangAo.Text = "Đang cắt";
                //        break;
                //    case "CPC":
                //        lbTinhTrangAo.Text = "Chưa phân công";
                //        break;
                //    case "DM":
                //        lbTinhTrangAo.Text = "Đang may";
                //        break;
                //    case "DMX":
                //        lbTinhTrangAo.Text = "Đã may xong";
                //        break;
                //    case "DL":
                //        lbTinhTrangAo.Text = "Đang luông";
                //        break;
                //    case "DHT":
                //        lbTinhTrangAo.Text = "Đã hoàn tất";
                //        btnXacNhanTienDoAo.Enabled = false;
                //        break;
                //    default:
                //        break;
                //}
                //switch (tinhTrangQuan)
                //{
                //    case "CPC":
                //        lbTinhTrangQuan.Text = "Chưa phân công";
                //        break;
                //    case "DC":
                //        lbTinhTrangQuan.Text = "Đang cắt";
                //        break;
                //    case "DCX":
                //        lbTinhTrangQuan.Text = "Đã cắt xong";
                //        break;
                //    case "DM":
                //        lbTinhTrangQuan.Text = "Đang may";
                //        break;
                //    case "DHT":
                //        lbTinhTrangQuan.Text = "Đã hoàn tất";
                //        btnXacNhanTienDoQuan.Enabled = false;
                //        break;
                //    default:
                //        break;
                //}

                //if (dgvDSChiTietHD.Rows[index].Cells["maThoCat"].Value.ToString() == "")
                //{
                //    btnPCCat.Enabled = true; cbThoCat.Enabled = true;cbLuongCat.Enabled = true;lbNgayPCCat.Text = "...";
                //}
                //else
                //{
                //    btnPCCat.Enabled = false; cbThoCat.Enabled = false;cbLuongCat.Enabled = true;
                //    cbThoCat.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maThoCat"].Value;
                //    cbLuongCat.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maCongThoCat"].Value;
                //    lbNgayPCCat.Text = dgvDSChiTietHD.Rows[index].Cells["ngayPCCat"].Value.ToString();
                //}
                //if (dgvDSChiTietHD.Rows[index].Cells["maThoMay"].Value.ToString() == "")
                //{
                //    btnPCMay.Enabled = true; cbThoMay.Enabled = true; cbLuongMay.Enabled = true;
                //    lbNgayPCMay.Text = "...";
                //}
                //else
                //{
                //    btnPCMay.Enabled = false; cbThoMay.Enabled = false;cbLuongMay.Enabled = true;
                //    cbThoMay.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maThoMay"].Value;
                //    lbNgayPCMay.Text= dgvDSChiTietHD.Rows[index].Cells["ngayPCMay"].Value.ToString();
                //    cbLuongMay.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maCongThoMay"].Value;
                //}
            
                //if (dgvDSChiTietHD.Rows[index].Cells["maThoLuong"].Value.ToString() == "")
                //{
                //    btnPCLuong.Enabled = true; cbThoLuong.Enabled = true; cbLuongLuong.Enabled = true;lbNgayPCLuong.Text = "...";
                //}
                //else
                //{
                //    btnPCLuong.Enabled = false; cbThoLuong.Enabled = false;cbLuongLuong.Enabled = true;
                //    cbThoLuong.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maThoLuong"].Value;
                //    cbLuongLuong.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maCongThoLuong"].Value;
                //    lbNgayPCLuong.Text= dgvDSChiTietHD.Rows[index].Cells["ngayPCLuong"].Value.ToString();
                //}
                //if (dgvDSChiTietHD.Rows[index].Cells["maThoCatQuan"].Value.ToString() == "")
                //{
                //    btnPCCatQuan.Enabled = true; cbThoCatQuan.Enabled = true; cbLuongCatQuan.Enabled = true;lbNgayPCCatQuan.Text = "";
                //}
                //else
                //{
                //    btnPCCatQuan.Enabled = false; cbThoCatQuan.Enabled = false;cbLuongCatQuan.Enabled = true;
                //    cbThoCatQuan.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maThoCatQuan"].Value;
                //    lbNgayPCCatQuan.Text= dgvDSChiTietHD.Rows[index].Cells["ngayPCCatQuan"].Value.ToString();
                //    cbLuongCatQuan.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maCongThoCatQuan"].Value;
                //}
                //if (dgvDSChiTietHD.Rows[index].Cells["maThoMayQuan"].Value.ToString() == "")
                //{
                //    btnPCMayQuan.Enabled = true; cbThoMayQuan.Enabled = true; cbLuongMayQuan.Enabled = true;lbNgayPCMayQuan.Text = "";
                //}
                //else
                //{
                //    btnPCMayQuan.Enabled = false; cbThoMayQuan.Enabled = false;cbLuongMayQuan.Enabled = true;
                //    cbThoMayQuan.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maThoMayQuan"].Value;
                //    lbNgayPCMayQuan.Text= dgvDSChiTietHD.Rows[index].Cells["ngayPCMayQuan"].Value.ToString();
                //    cbLuongMayQuan.SelectedValue = dgvDSChiTietHD.Rows[index].Cells["maCongThoMayQuan"].Value;
                //}


            }
            catch (Exception)
            {

            }
        }

        private void lbTinhTrangAo_Click(object sender, EventArgs e)
        {

        }

        int maKH = 0; string so = "";
        private void btnPCCatQuan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Phân công cho " + cbThoCatQuan.Text + " cắt quần này với tiền công là +" + cbLuongCatQuan.Text, "Phân công thợ cắt quần", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                DateTime today = DateTime.Now;
                if (dbTienDoMay.PCCatQuan(ref er, maQuan, Int32.Parse(cbThoCatQuan.SelectedValue.ToString()), Convert.ToDecimal(cbLuongCatQuan.Text.ToString()), today,today.Month,today.Year))
                {
                    btnPCCatQuan.Enabled = false; btnPCMayQuan.Enabled = true;
                    cbThoCatQuan.Enabled = false; cbThoMayQuan.Enabled = true;
                    cbLuongCatQuan.Enabled = false; cbLuongMayQuan.Enabled = true;
                    lbNgayPCCatQuan.Text = today.ToString();
                    dgvDanhSachQuan.DataSource = dbTienDoMay.GetQuanDuocMayTheoMaHD(maHD);
                    lbNgayPCMayQuan.Text = "...";
                }
            }
        }

        private void btnPCMayQuan_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Phân công cho " + cbThoMayQuan.Text + " may quần này với tiền công là +" + cbLuongMayQuan.Text, "Phân công thợ may quần", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                DateTime today = DateTime.Now;
                if (dbTienDoMay.PCMayQuan(ref er, maQuan, Int32.Parse(cbThoMayQuan.SelectedValue.ToString()),Convert.ToDecimal(cbLuongMayQuan.Text.ToString()), today,today.Month,today.Year))
                {
                    btnPCMayQuan.Enabled = false; cbThoMayQuan.Enabled = false;cbLuongMayQuan.Enabled = false;
                    lbNgayPCMayQuan.Text = today.ToString();btnQuanXong.Enabled = true;
                    dgvDanhSachQuan.DataSource = dbTienDoMay.GetQuanDuocMayTheoMaHD(maHD);
                }
            }
        }

        
     

        private void btnReload_Click(object sender, EventArgs e)
        {

        }
    

  

        private void tbTimKiemAo_Click(object sender, EventArgs e)
        {
            tbTimKiemAo.Text = "";
        }

        private void tbTimKiemAo_TextChanged(object sender, EventArgs e)
        {
            dgvDSHD.DataSource = dbTienDoMay.TimAoTheoNhieuTieuChi(tbTimKiemAo.Text);
         
        }

        private void txtTimHDTheoMahd_Click(object sender, EventArgs e)
        {
            txtTimHDTheoMahd.Text = "0";
        }

        private void txtTimHDTheoMahd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvDSHD.DataSource = dbTienDoMay.TimAoTheoMaHD(Int32.Parse(txtTimHDTheoMahd.Text));
             

            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string maQuan = "";
        private void dgvDanhSachAo_Click(object sender, EventArgs e)
        {
            try
            {
                if (first ==0 )
                {

                   
                   
                   
                    first = 1;
                   
                }
                int index = dgvDanhSachAo.CurrentCell.RowIndex;
                maAo = dgvDanhSachAo.Rows[index].Cells["dsa_Id"].Value.ToString();
                pbAnhAo.Image = (System.Drawing.Image)dgvDanhSachAo.Rows[index].Cells["dsa_anhDaiDien"].FormattedValue;
                rtxtGhiChuAoMay.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ghiChu"].Value.ToString();
                lbLoaiCo.Text = dgvDanhSachAo.Rows[index].Cells["dsa_loaiCo"].Value.ToString();
                lbKichThuocCo.Text = dgvDanhSachAo.Rows[index].Cells["dsa_kichThuocCo"].Value.ToString();
                string tinhTrang = dgvDanhSachAo.Rows[index].Cells["dsa_tinhTrang"].Value.ToString();
                lbMaAo.Text = maAo;
                if (tinhTrang== "Chưa phân công")
                {
                    btnPCCat.Enabled = true;btnPCMay.Enabled = false;btnPCLuong.Enabled = false;
                    cbLuongCat.Enabled = true; cbThoCat.Enabled = true;
                    cbThoMay.Enabled = false; cbLuongMay.Enabled = false; cbThoLuong.Enabled = false; cbLuongLuong.Enabled = false;
                    lbNgayPCCat.Text = "...";lbNgayPCMay.Text = "...";lbNgayPCLuong.Text = "...";
                    btnAoXong.Enabled = false; cbLuongMay.Text = ""; cbLuongLuong.Text = "";
                    cbLuongCat.DataSource = dbLuong.GetLuongTheoNhom("cat");
                    cbLuongCat.DisplayMember = "tienCong";
                    cbLuongCat.ValueMember = "Id";

                }
                else
                {
                    if(tinhTrang=="Đang cắt")
                    {
                        btnPCCat.Enabled = false; btnPCMay.Enabled = true; btnPCLuong.Enabled = false;
                        cbThoCat.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_maThoCat"].Value;cbThoCat.Enabled = false;
                        cbLuongCat.Text = dgvDanhSachAo.Rows[index].Cells["dsa_maCongCat"].Value.ToString();cbLuongCat.Enabled = false;
                        cbThoMay.Enabled = true;cbLuongMay.Enabled = true;cbLuongLuong.Enabled = false;cbThoLuong.Enabled = false;
                        lbNgayPCCat.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ngayPCCat"].Value.ToString() ; lbNgayPCMay.Text = "..."; lbNgayPCLuong.Text = "...";
                        btnAoXong.Enabled = false; cbLuongLuong.Text = "";
                        cbLuongMay.DataSource = dbLuong.GetLuongTheoNhom("may");
                        cbLuongMay.DisplayMember = "tienCong";
                        cbLuongMay.ValueMember = "Id";

                    }
                    else
                    {
                        if(tinhTrang=="Đang may")
                        {
                            btnPCCat.Enabled = false; btnPCMay.Enabled = false; btnPCLuong.Enabled = true;
                            cbThoCat.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_maThoCat"].Value; cbThoCat.Enabled = false;
                            cbLuongCat.Text = dgvDanhSachAo.Rows[index].Cells["dsa_maCongCat"].Value.ToString(); cbLuongCat.Enabled = false;
                            cbThoMay.Enabled = false; cbLuongMay.Enabled = false; cbThoLuong.Enabled = true; cbLuongLuong.Enabled = true;
                            cbThoMay.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_maThoMay"].Value;
                            cbLuongMay.Text = dgvDanhSachAo.Rows[index].Cells["dsa_maCongMay"].Value.ToString();
                            lbNgayPCCat.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ngayPCCat"].Value.ToString();
                            lbNgayPCMay.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ngayPCMay"].Value.ToString(); lbNgayPCLuong.Text = "...";
                            btnAoXong.Enabled = false;
                            cbLuongLuong.DataSource = dbLuong.GetLuongTheoNhom("luong");
                            cbLuongLuong.DisplayMember = "tienCong";
                            cbLuongLuong.ValueMember = "Id";
                        }
                        else
                        {
                            btnPCCat.Enabled = false; btnPCMay.Enabled = false; btnPCLuong.Enabled = false;
                            cbThoCat.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_maThoCat"].Value; cbThoCat.Enabled = false;
                            cbLuongCat.Text = dgvDanhSachAo.Rows[index].Cells["dsa_maCongCat"].Value.ToString(); cbLuongCat.Enabled = false;
                            cbThoMay.Enabled = false; cbLuongMay.Enabled = false; cbThoLuong.Enabled = false; cbLuongLuong.Enabled = false;
                            cbThoMay.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_maThoMay"].Value;
                            cbLuongMay.Text = dgvDanhSachAo.Rows[index].Cells["dsa_maCongMay"].Value.ToString();
                            cbThoLuong.SelectedValue = dgvDanhSachAo.Rows[index].Cells["dsa_maThoLuong"].Value;
                            cbLuongLuong.Text = dgvDanhSachAo.Rows[index].Cells["dsa_maCongLuong"].Value.ToString();
                            lbNgayPCCat.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ngayPCCat"].Value.ToString();
                            lbNgayPCMay.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ngayPCMay"].Value.ToString();
                            lbNgayPCLuong.Text = dgvDanhSachAo.Rows[index].Cells["dsa_ngayPCLuong"].Value.ToString();
                            if(tinhTrang=="Đang luông")
                                btnAoXong.Enabled = true;
                            else
                                btnAoXong.Enabled = false;
                        }
                    }
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
                if(second==0)
                {
                  
                   
                }
                int index = dgvDanhSachQuan.CurrentCell.RowIndex;
                maQuan =dgvDanhSachQuan.Rows[index].Cells["dsq_Id"].Value.ToString();lbMaQuan.Text = maQuan;
                pbAnhQuan.Image = (System.Drawing.Image)dgvDanhSachQuan.Rows[index].Cells["dsq_anhDaiDien"].FormattedValue;
                rtxtGhiChuQuanMay.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_ghiChu"].Value.ToString();
                string tinhTrang = dgvDanhSachQuan.Rows[index].Cells["dsq_tinhTrang"].Value.ToString();
                if (tinhTrang == "Chưa phân công")
                {
                    btnPCCatQuan.Enabled = true; btnPCMayQuan.Enabled = false;
                    cbThoCatQuan.Enabled = true;cbThoMayQuan.Enabled = false;
                    cbLuongCatQuan.Enabled = true;cbLuongMayQuan.Enabled = false;
                    lbNgayPCCatQuan.Text = "...";lbNgayPCMayQuan.Text = "..."; btnQuanXong.Enabled = false;
                    cbLuongCatQuan.DataSource = dbLuong.GetLuongTheoNhom("catQuan");
                    cbLuongCatQuan.DisplayMember = "tienCong";
                    cbLuongCatQuan.ValueMember = "Id"; cbLuongMayQuan.Text = "";
                }
                else
                {
                    if(tinhTrang=="Đang cắt")
                    {
                        btnPCCatQuan.Enabled = false; btnPCMayQuan.Enabled = true;
                        cbThoCatQuan.Enabled = false; cbThoMayQuan.Enabled = true;
                        cbLuongCatQuan.Enabled = false; cbLuongMayQuan.Enabled = true;
                        cbThoCatQuan.SelectedValue = dgvDanhSachQuan.Rows[index].Cells["dsq_maThoCat"].Value;
                        cbLuongCatQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_maCongCat"].Value.ToString();
                        lbNgayPCCatQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_ngayPCCat"].Value.ToString();
                        lbNgayPCMayQuan.Text = "..."; btnQuanXong.Enabled = false;
                        cbLuongMayQuan.DataSource = dbLuong.GetLuongTheoNhom("mayQuan");
                        cbLuongMayQuan.DisplayMember = "tienCong";
                        cbLuongMayQuan.ValueMember = "Id";
                        second = 1;
                    }
                    else
                    {
                        btnPCCatQuan.Enabled = false; btnPCMayQuan.Enabled = false;
                        cbThoCatQuan.Enabled = false; cbThoMayQuan.Enabled = false;
                        cbLuongCatQuan.Enabled = false; cbLuongMayQuan.Enabled = false;
                        cbThoCatQuan.SelectedValue = dgvDanhSachQuan.Rows[index].Cells["dsq_maThoCat"].Value;
                        cbLuongCatQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_maCongCat"].Value.ToString();
                        cbThoMayQuan.SelectedValue = dgvDanhSachQuan.Rows[index].Cells["dsq_maThoMay"].Value;
                        cbLuongMayQuan.Text= dgvDanhSachQuan.Rows[index].Cells["dsq_maCongMay"].Value.ToString();
                        lbNgayPCCatQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_ngayPCCat"].Value.ToString();
                        lbNgayPCMayQuan.Text = dgvDanhSachQuan.Rows[index].Cells["dsq_ngayPCMay"].Value.ToString();
                        if(tinhTrang=="Đang may")
                            btnQuanXong.Enabled = true;
                        else
                            btnQuanXong.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnPCCat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Phân công cho " + cbThoCat.Text + "cắt áo này với tiền công là +" + cbLuongCat.Text, "Phân công thợ cắt", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
               
                if (dbTienDoMay.PCCat(ref er,maAo,Int32.Parse(cbThoCat.SelectedValue.ToString()),Convert.ToDecimal(cbLuongCat.Text.ToString()),DateTime.Now,DateTime.Today.Month,DateTime.Today.Year))
                {
                    btnPCCat.Enabled = false; cbThoCat.Enabled = false; cbLuongCat.Enabled = false;
                    dgvDanhSachAo.DataSource = dbTienDoMay.GetAoDuocMayTheoMaHD(maHD);
                    btnPCMay.Enabled = true; btnPCLuong.Enabled = false;
                    cbThoCat.Enabled = false;
                     cbLuongCat.Enabled = false;
                    cbThoMay.Enabled = true; cbLuongMay.Enabled = true; cbThoLuong.Enabled = false; cbLuongLuong.Enabled = false;
                    lbNgayPCCat.Text = DateTime.Now.ToString(); lbNgayPCMay.Text = "..."; lbNgayPCLuong.Text = "...";

                }
            }
        }

        private void btnPCMay_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Phân công cho " + cbThoMay.Text + " may áo này với tiền công là +" + cbLuongMay.Text, "Phân công thợ may", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
               
                DateTime today = DateTime.Now;
                if (dbTienDoMay.PCMay(ref er, maAo, Int32.Parse(cbThoMay.SelectedValue.ToString()),Convert.ToDecimal(cbLuongMay.Text.ToString()), today,today.Month,today.Year))
                {
                    btnPCMay.Enabled = false; cbThoMay.Enabled = false;
                    dgvDanhSachAo.DataSource = dbTienDoMay.GetAoDuocMayTheoMaHD(maHD);
                    lbNgayPCMay.Text = today.ToString();
                    //
                    btnPCCat.Enabled = false;  btnPCLuong.Enabled = true;
                   cbThoCat.Enabled = false;
                    cbLuongCat.Enabled = false;
                    cbThoMay.Enabled = false; cbLuongMay.Enabled = false; cbThoLuong.Enabled = true; cbLuongLuong.Enabled = true;                              
                   lbNgayPCLuong.Text = "...";

                }
            }
        }

        private void btnPCLuong_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Phân công cho " + cbThoLuong.Text + " luông áo này với tiền công là +" + cbLuongLuong.Text, "Phân công thợ luông", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
              
                DateTime today = DateTime.Now;
                if (dbTienDoMay.PCLuong(ref er, maAo, Int32.Parse(cbThoLuong.SelectedValue.ToString()), Convert.ToDecimal(cbLuongLuong.Text.ToString()), today,today.Month,today.Year))
                {
                    dgvDanhSachAo.DataSource = dbTienDoMay.GetAoDuocMayTheoMaHD(maHD);
                    btnAoXong.Enabled = true;
                    btnPCLuong.Enabled = false; cbThoLuong.Enabled = false;
                    lbNgayPCLuong.Text = today.ToString();cbLuongLuong.Enabled = false;
                }
            }
        }

        private void btnAoXong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("May xong áo này? " , "May xong áo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if(dbTienDoMay.MayXongAo(ref er, maAo))
                {
                    dgvDanhSachAo.DataSource = dbTienDoMay.GetAoDuocMayTheoMaHD(maHD);
                    btnAoXong.Enabled = false;
                }
            }
        }

        private void btnQuanXong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("May xong quần này? ", "May xong quần", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string er = "";
                if (dbTienDoMay.MayXongQuan(ref er, maQuan))
                {
                    dgvDanhSachAo.DataSource = dbTienDoMay.GetAoDuocMayTheoMaHD(maHD);
                    btnQuanXong.Enabled = false;
                    dgvDanhSachQuan.DataSource = dbTienDoMay.GetQuanDuocMayTheoMaHD(maHD);
                }
            }
        }

        private void btnChiTietThu_Click(object sender, EventArgs e)
        {
            new frmChiTietThuTheoNgay(Convert.ToDateTime(dtpNgayDau.Value.Date), Convert.ToDateTime(dtpNgayCuoi.Value.Date)).ShowDialog();
        }
    }
}
