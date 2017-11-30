namespace TiemMayHaiTrieu
{
    partial class frmDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.dgvDanhSachHangDat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienConlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThemHangDat = new System.Windows.Forms.GroupBox();
            this.lbTienConlai = new System.Windows.Forms.Label();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rtxtChiTiet = new System.Windows.Forms.RichTextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonKH = new System.Windows.Forms.Button();
            this.lbTenKhachHang = new System.Windows.Forms.Label();
            this.dtpNgayHenLay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.btnXoaCTHD = new System.Windows.Forms.Button();
            this.lbMaHDatHang = new System.Windows.Forms.Label();
            this.gbTinhTien = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTienThoi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txTienKhachDua = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangDat)).BeginInit();
            this.gbThemHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.gbTinhTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachHangDat
            // 
            this.dgvDanhSachHangDat.AllowUserToAddRows = false;
            this.dgvDanhSachHangDat.AllowUserToDeleteRows = false;
            this.dgvDanhSachHangDat.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhSachHangDat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHangDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachHangDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.soLuong,
            this.tenHang,
            this.chiTiet,
            this.giaTien,
            this.tienCoc,
            this.tienConlai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachHangDat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachHangDat.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.dgvDanhSachHangDat, "dgvDanhSachHangDat");
            this.dgvDanhSachHangDat.Name = "dgvDanhSachHangDat";
            this.dgvDanhSachHangDat.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachHangDat.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachHangDat.Click += new System.EventHandler(this.dgvDanhSachHangDat_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            resources.ApplyResources(this.soLuong, "soLuong");
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenHang";
            resources.ApplyResources(this.tenHang, "tenHang");
            this.tenHang.Name = "tenHang";
            this.tenHang.ReadOnly = true;
            // 
            // chiTiet
            // 
            this.chiTiet.DataPropertyName = "chiTiet";
            resources.ApplyResources(this.chiTiet, "chiTiet");
            this.chiTiet.Name = "chiTiet";
            this.chiTiet.ReadOnly = true;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "giaTien";
            resources.ApplyResources(this.giaTien, "giaTien");
            this.giaTien.Name = "giaTien";
            this.giaTien.ReadOnly = true;
            // 
            // tienCoc
            // 
            this.tienCoc.DataPropertyName = "tienCoc";
            resources.ApplyResources(this.tienCoc, "tienCoc");
            this.tienCoc.Name = "tienCoc";
            this.tienCoc.ReadOnly = true;
            // 
            // tienConlai
            // 
            this.tienConlai.DataPropertyName = "tienConlai";
            resources.ApplyResources(this.tienConlai, "tienConlai");
            this.tienConlai.Name = "tienConlai";
            this.tienConlai.ReadOnly = true;
            // 
            // gbThemHangDat
            // 
            this.gbThemHangDat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbThemHangDat.Controls.Add(this.lbTienConlai);
            this.gbThemHangDat.Controls.Add(this.btnThemHang);
            this.gbThemHangDat.Controls.Add(this.label10);
            this.gbThemHangDat.Controls.Add(this.nudSoLuong);
            this.gbThemHangDat.Controls.Add(this.label9);
            this.gbThemHangDat.Controls.Add(this.label8);
            this.gbThemHangDat.Controls.Add(this.label7);
            this.gbThemHangDat.Controls.Add(this.label5);
            this.gbThemHangDat.Controls.Add(this.txtTienCoc);
            this.gbThemHangDat.Controls.Add(this.label4);
            this.gbThemHangDat.Controls.Add(this.txtGiaTien);
            this.gbThemHangDat.Controls.Add(this.label3);
            this.gbThemHangDat.Controls.Add(this.label14);
            this.gbThemHangDat.Controls.Add(this.rtxtChiTiet);
            this.gbThemHangDat.Controls.Add(this.txtTenHang);
            this.gbThemHangDat.Controls.Add(this.label1);
            resources.ApplyResources(this.gbThemHangDat, "gbThemHangDat");
            this.gbThemHangDat.Name = "gbThemHangDat";
            this.gbThemHangDat.TabStop = false;
            // 
            // lbTienConlai
            // 
            resources.ApplyResources(this.lbTienConlai, "lbTienConlai");
            this.lbTienConlai.Name = "lbTienConlai";
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.arrow;
            resources.ApplyResources(this.btnThemHang, "btnThemHang");
            this.btnThemHang.FlatAppearance.BorderSize = 0;
            this.btnThemHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThemHang.Name = "btnThemHang";
            this.toolTip1.SetToolTip(this.btnThemHang, resources.GetString("btnThemHang.ToolTip"));
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // nudSoLuong
            // 
            resources.ApplyResources(this.nudSoLuong, "nudSoLuong");
            this.nudSoLuong.Name = "nudSoLuong";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtTienCoc
            // 
            resources.ApplyResources(this.txtTienCoc, "txtTienCoc");
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            this.txtTienCoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtGiaTien
            // 
            resources.ApplyResources(this.txtGiaTien, "txtGiaTien");
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // rtxtChiTiet
            // 
            resources.ApplyResources(this.rtxtChiTiet, "rtxtChiTiet");
            this.rtxtChiTiet.Name = "rtxtChiTiet";
            // 
            // txtTenHang
            // 
            resources.ApplyResources(this.txtTenHang, "txtTenHang");
            this.txtTenHang.Name = "txtTenHang";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnChonKH
            // 
            this.btnChonKH.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.customer;
            resources.ApplyResources(this.btnChonKH, "btnChonKH");
            this.btnChonKH.FlatAppearance.BorderSize = 0;
            this.btnChonKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnChonKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChonKH.Name = "btnChonKH";
            this.btnChonKH.UseVisualStyleBackColor = true;
            this.btnChonKH.Click += new System.EventHandler(this.btnChonKH_Click);
            // 
            // lbTenKhachHang
            // 
            resources.ApplyResources(this.lbTenKhachHang, "lbTenKhachHang");
            this.lbTenKhachHang.Name = "lbTenKhachHang";
            // 
            // dtpNgayHenLay
            // 
            resources.ApplyResources(this.dtpNgayHenLay, "dtpNgayHenLay");
            this.dtpNgayHenLay.Name = "dtpNgayHenLay";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.add;
            resources.ApplyResources(this.btnThemHoaDon, "btnThemHoaDon");
            this.btnThemHoaDon.FlatAppearance.BorderSize = 0;
            this.btnThemHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThemHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.toolTip1.SetToolTip(this.btnThemHoaDon, resources.GetString("btnThemHoaDon.ToolTip"));
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // btnXoaCTHD
            // 
            this.btnXoaCTHD.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.delete;
            resources.ApplyResources(this.btnXoaCTHD, "btnXoaCTHD");
            this.btnXoaCTHD.FlatAppearance.BorderSize = 0;
            this.btnXoaCTHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoaCTHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnXoaCTHD.Name = "btnXoaCTHD";
            this.toolTip1.SetToolTip(this.btnXoaCTHD, resources.GetString("btnXoaCTHD.ToolTip"));
            this.btnXoaCTHD.UseVisualStyleBackColor = true;
            this.btnXoaCTHD.Click += new System.EventHandler(this.btnXoaCTHD_Click);
            // 
            // lbMaHDatHang
            // 
            resources.ApplyResources(this.lbMaHDatHang, "lbMaHDatHang");
            this.lbMaHDatHang.Name = "lbMaHDatHang";
            // 
            // gbTinhTien
            // 
            this.gbTinhTien.Controls.Add(this.label11);
            this.gbTinhTien.Controls.Add(this.label13);
            this.gbTinhTien.Controls.Add(this.label12);
            this.gbTinhTien.Controls.Add(this.btnThemHoaDon);
            this.gbTinhTien.Controls.Add(this.lbTienThoi);
            this.gbTinhTien.Controls.Add(this.label15);
            this.gbTinhTien.Controls.Add(this.txTienKhachDua);
            this.gbTinhTien.Controls.Add(this.label16);
            this.gbTinhTien.Controls.Add(this.lbThanhTien);
            this.gbTinhTien.Controls.Add(this.label17);
            resources.ApplyResources(this.gbTinhTien, "gbTinhTien");
            this.gbTinhTien.Name = "gbTinhTien";
            this.gbTinhTien.TabStop = false;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // lbTienThoi
            // 
            resources.ApplyResources(this.lbTienThoi, "lbTienThoi");
            this.lbTienThoi.Name = "lbTienThoi";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // txTienKhachDua
            // 
            resources.ApplyResources(this.txTienKhachDua, "txTienKhachDua");
            this.txTienKhachDua.Name = "txTienKhachDua";
            this.txTienKhachDua.TextChanged += new System.EventHandler(this.txTienKhachDua_TextChanged);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // lbThanhTien
            // 
            resources.ApplyResources(this.lbThanhTien, "lbThanhTien");
            this.lbThanhTien.BackColor = System.Drawing.Color.Tomato;
            this.lbThanhTien.Name = "lbThanhTien";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // rtxtGhiChu
            // 
            resources.ApplyResources(this.rtxtGhiChu, "rtxtGhiChu");
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // frmDatHang
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.btnXoaCTHD);
            this.Controls.Add(this.gbTinhTien);
            this.Controls.Add(this.dgvDanhSachHangDat);
            this.Controls.Add(this.lbMaHDatHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNgayHenLay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChonKH);
            this.Controls.Add(this.lbTenKhachHang);
            this.Controls.Add(this.gbThemHangDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDatHang";
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangDat)).EndInit();
            this.gbThemHangDat.ResumeLayout(false);
            this.gbThemHangDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.gbTinhTien.ResumeLayout(false);
            this.gbTinhTien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDanhSachHangDat;
        private System.Windows.Forms.GroupBox gbThemHangDat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtxtChiTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayHenLay;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChonKH;
        private System.Windows.Forms.Label lbTenKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lbMaHDatHang;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.GroupBox gbTinhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTienThoi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txTienKhachDua;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbThanhTien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnXoaCTHD;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbTienConlai;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienConlai;
    }
}