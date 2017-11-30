namespace TiemMayHaiTrieu
{
    partial class frmBangLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.pbAvartar = new System.Windows.Forms.PictureBox();
            this.btnXemLuong = new System.Windows.Forms.Button();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.maNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNhanVien2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNam2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSDTNV = new System.Windows.Forms.Label();
            this.gbLuongNV = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTongLuongCacNam = new System.Windows.Forms.Label();
            this.lbTongLuongCacThang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSuaLuong = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.gbChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvChiTIetLuongNV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLuongThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soAoCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soAoMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soAoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soQuanCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soQuanMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.gbLuongNV.SuspendLayout();
            this.gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTIetLuongNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAvartar
            // 
            this.pbAvartar.Image = global::TiemMayHaiTrieu.Properties.Resources.staff_avatar;
            this.pbAvartar.Location = new System.Drawing.Point(12, 26);
            this.pbAvartar.Margin = new System.Windows.Forms.Padding(4);
            this.pbAvartar.Name = "pbAvartar";
            this.pbAvartar.Size = new System.Drawing.Size(101, 130);
            this.pbAvartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvartar.TabIndex = 6;
            this.pbAvartar.TabStop = false;
            this.pbAvartar.Click += new System.EventHandler(this.pbAvartar_Click);
            // 
            // btnXemLuong
            // 
            this.btnXemLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnXemLuong.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.see_things;
            this.btnXemLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXemLuong.FlatAppearance.BorderSize = 0;
            this.btnXemLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnXemLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemLuong.Location = new System.Drawing.Point(434, 12);
            this.btnXemLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemLuong.Name = "btnXemLuong";
            this.btnXemLuong.Size = new System.Drawing.Size(40, 40);
            this.btnXemLuong.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnXemLuong, "Xem lương tháng");
            this.btnXemLuong.UseVisualStyleBackColor = false;
            this.btnXemLuong.Click += new System.EventHandler(this.btnXemLuong_Click);
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            this.dgvBangLuong.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBangLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tenNhanVien,
            this.maNhanVien,
            this.soDienThoai,
            this.maThang,
            this.anhDaiDien,
            this.maNam,
            this.tongLuong});
            this.dgvBangLuong.EnableHeadersVisualStyles = false;
            this.dgvBangLuong.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBangLuong.Location = new System.Drawing.Point(18, 62);
            this.dgvBangLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangLuong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBangLuong.Size = new System.Drawing.Size(593, 219);
            this.dgvBangLuong.TabIndex = 1;
            this.dgvBangLuong.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangLuong_CellValueChanged);
            this.dgvBangLuong.Click += new System.EventHandler(this.dgvBangLuong_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Width = 150;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "ma nhan vien";
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Visible = false;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "SDT";
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            // 
            // maThang
            // 
            this.maThang.DataPropertyName = "maThang";
            this.maThang.HeaderText = "Tháng ";
            this.maThang.Name = "maThang";
            this.maThang.ReadOnly = true;
            // 
            // anhDaiDien
            // 
            this.anhDaiDien.DataPropertyName = "anhDaiDien";
            this.anhDaiDien.HeaderText = "anh dai dien";
            this.anhDaiDien.Name = "anhDaiDien";
            this.anhDaiDien.ReadOnly = true;
            this.anhDaiDien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.anhDaiDien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.anhDaiDien.Visible = false;
            // 
            // maNam
            // 
            this.maNam.DataPropertyName = "maNam";
            this.maNam.HeaderText = "Năm";
            this.maNam.Name = "maNam";
            this.maNam.ReadOnly = true;
            this.maNam.Visible = false;
            // 
            // tongLuong
            // 
            this.tongLuong.DataPropertyName = "tongLuong";
            this.tongLuong.HeaderText = "Tổng lương";
            this.tongLuong.Name = "tongLuong";
            this.tongLuong.ReadOnly = true;
            this.tongLuong.Width = 150;
            // 
            // cbNhanVien2
            // 
            this.cbNhanVien2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVien2.FormattingEnabled = true;
            this.cbNhanVien2.Location = new System.Drawing.Point(95, 20);
            this.cbNhanVien2.Margin = new System.Windows.Forms.Padding(4);
            this.cbNhanVien2.Name = "cbNhanVien2";
            this.cbNhanVien2.Size = new System.Drawing.Size(122, 27);
            this.cbNhanVien2.TabIndex = 9;
            this.cbNhanVien2.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tháng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Năm :";
            // 
            // txtNam2
            // 
            this.txtNam2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam2.Location = new System.Drawing.Point(286, 20);
            this.txtNam2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam2.Name = "txtNam2";
            this.txtNam2.Size = new System.Drawing.Size(140, 26);
            this.txtNam2.TabIndex = 8;
            this.txtNam2.Text = "2017";
            this.txtNam2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "SDT :";
            // 
            // lbSDTNV
            // 
            this.lbSDTNV.AutoSize = true;
            this.lbSDTNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTNV.Location = new System.Drawing.Point(51, 171);
            this.lbSDTNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSDTNV.Name = "lbSDTNV";
            this.lbSDTNV.Size = new System.Drawing.Size(24, 16);
            this.lbSDTNV.TabIndex = 11;
            this.lbSDTNV.Text = "....";
            // 
            // gbLuongNV
            // 
            this.gbLuongNV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbLuongNV.Controls.Add(this.label6);
            this.gbLuongNV.Controls.Add(this.label7);
            this.gbLuongNV.Controls.Add(this.lbTongLuongCacNam);
            this.gbLuongNV.Controls.Add(this.lbTongLuongCacThang);
            this.gbLuongNV.Controls.Add(this.label5);
            this.gbLuongNV.Controls.Add(this.label2);
            this.gbLuongNV.Controls.Add(this.pbAvartar);
            this.gbLuongNV.Controls.Add(this.lbSDTNV);
            this.gbLuongNV.Controls.Add(this.label1);
            this.gbLuongNV.Location = new System.Drawing.Point(618, 62);
            this.gbLuongNV.Name = "gbLuongNV";
            this.gbLuongNV.Size = new System.Drawing.Size(395, 219);
            this.gbLuongNV.TabIndex = 12;
            this.gbLuongNV.TabStop = false;
            this.gbLuongNV.Text = "Lương của nhân viên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "K";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "K";
            // 
            // lbTongLuongCacNam
            // 
            this.lbTongLuongCacNam.AutoSize = true;
            this.lbTongLuongCacNam.BackColor = System.Drawing.Color.Transparent;
            this.lbTongLuongCacNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongLuongCacNam.Location = new System.Drawing.Point(141, 171);
            this.lbTongLuongCacNam.Name = "lbTongLuongCacNam";
            this.lbTongLuongCacNam.Size = new System.Drawing.Size(62, 31);
            this.lbTongLuongCacNam.TabIndex = 15;
            this.lbTongLuongCacNam.Text = "000";
            this.lbTongLuongCacNam.Click += new System.EventHandler(this.lbTongLuongCacNam_Click);
            // 
            // lbTongLuongCacThang
            // 
            this.lbTongLuongCacThang.AutoSize = true;
            this.lbTongLuongCacThang.BackColor = System.Drawing.Color.Transparent;
            this.lbTongLuongCacThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongLuongCacThang.Location = new System.Drawing.Point(141, 88);
            this.lbTongLuongCacThang.Name = "lbTongLuongCacThang";
            this.lbTongLuongCacThang.Size = new System.Drawing.Size(62, 31);
            this.lbTongLuongCacThang.TabIndex = 14;
            this.lbTongLuongCacThang.Text = "000";
            this.lbTongLuongCacThang.Click += new System.EventHandler(this.lbTongLuongCacThang_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tổng lương các năm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng lương các tháng trong năm :";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnSuaLuong
            // 
            this.btnSuaLuong.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaLuong.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.edit;
            this.btnSuaLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaLuong.FlatAppearance.BorderSize = 0;
            this.btnSuaLuong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSuaLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLuong.Location = new System.Drawing.Point(966, 20);
            this.btnSuaLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLuong.Name = "btnSuaLuong";
            this.btnSuaLuong.Size = new System.Drawing.Size(40, 40);
            this.btnSuaLuong.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSuaLuong, "Sửa hệ số lương");
            this.btnSuaLuong.UseVisualStyleBackColor = false;
            this.btnSuaLuong.Click += new System.EventHandler(this.btnSuaLuong_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.btnChiTiet.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.enter_small;
            this.btnChiTiet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.Location = new System.Drawing.Point(925, 298);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(40, 40);
            this.btnChiTiet.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnChiTiet, "Chi tiết công việc ");
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // gbChiTiet
            // 
            this.gbChiTiet.Controls.Add(this.dgvChiTIetLuongNV);
            this.gbChiTiet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChiTiet.Location = new System.Drawing.Point(121, 288);
            this.gbChiTiet.Name = "gbChiTiet";
            this.gbChiTiet.Size = new System.Drawing.Size(797, 140);
            this.gbChiTiet.TabIndex = 13;
            this.gbChiTiet.TabStop = false;
            this.gbChiTiet.Text = "Chi tiết lương của nhân viên được chọn :";
            // 
            // dgvChiTIetLuongNV
            // 
            this.dgvChiTIetLuongNV.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvChiTIetLuongNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTIetLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTIetLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.maLuongThang,
            this.soAoCat,
            this.soAoMay,
            this.soAoLuong,
            this.soQuanCat,
            this.soQuanMay});
            this.dgvChiTIetLuongNV.Location = new System.Drawing.Point(49, 25);
            this.dgvChiTIetLuongNV.Name = "dgvChiTIetLuongNV";
            this.dgvChiTIetLuongNV.Size = new System.Drawing.Size(700, 83);
            this.dgvChiTIetLuongNV.TabIndex = 0;
            this.dgvChiTIetLuongNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Column2";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // maLuongThang
            // 
            this.maLuongThang.DataPropertyName = "maLuongThang";
            this.maLuongThang.HeaderText = "Column2";
            this.maLuongThang.Name = "maLuongThang";
            this.maLuongThang.Visible = false;
            // 
            // soAoCat
            // 
            this.soAoCat.DataPropertyName = "soAoCat";
            this.soAoCat.HeaderText = "Số áo đã cắt";
            this.soAoCat.Name = "soAoCat";
            this.soAoCat.Width = 120;
            // 
            // soAoMay
            // 
            this.soAoMay.DataPropertyName = "soAoMay";
            this.soAoMay.HeaderText = "Số áo đã may";
            this.soAoMay.Name = "soAoMay";
            this.soAoMay.Width = 130;
            // 
            // soAoLuong
            // 
            this.soAoLuong.DataPropertyName = "soAoLuong";
            this.soAoLuong.HeaderText = "Số áo đã luông";
            this.soAoLuong.Name = "soAoLuong";
            this.soAoLuong.Width = 130;
            // 
            // soQuanCat
            // 
            this.soQuanCat.DataPropertyName = "soQuanCat";
            this.soQuanCat.HeaderText = "Số quần đã cắt";
            this.soQuanCat.Name = "soQuanCat";
            this.soQuanCat.Width = 130;
            // 
            // soQuanMay
            // 
            this.soQuanMay.DataPropertyName = "soQuanMay";
            this.soQuanMay.HeaderText = "Số quần đã may";
            this.soQuanMay.Name = "soQuanMay";
            this.soQuanMay.Width = 130;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1025, 440);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnSuaLuong);
            this.Controls.Add(this.gbChiTiet);
            this.Controls.Add(this.gbLuongNV);
            this.Controls.Add(this.btnXemLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNhanVien2);
            this.Controls.Add(this.txtNam2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBangLuong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.gbLuongNV.ResumeLayout(false);
            this.gbLuongNV.PerformLayout();
            this.gbChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTIetLuongNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAvartar;
        private System.Windows.Forms.Button btnXemLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.ComboBox cbNhanVien2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNam2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSDTNV;
        private System.Windows.Forms.GroupBox gbLuongNV;
        private System.Windows.Forms.Label lbTongLuongCacNam;
        private System.Windows.Forms.Label lbTongLuongCacThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThang;
        private System.Windows.Forms.DataGridViewImageColumn anhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongLuong;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTIetLuongNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLuongThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soAoCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soAoMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn soAoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQuanCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soQuanMay;
        private System.Windows.Forms.Button btnSuaLuong;
        private System.Windows.Forms.Button btnChiTiet;
    }
}