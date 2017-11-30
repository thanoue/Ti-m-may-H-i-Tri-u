namespace TiemMayHaiTrieu
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChonKHXemHDMay = new System.Windows.Forms.Button();
            this.dgvDanhSachKH = new System.Windows.Forms.DataGridView();
            this.tbTimKiemAo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChonKHBanAo = new System.Windows.Forms.Button();
            this.btnChonKHMayAo = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChonKHDeDat = new System.Windows.Forms.Button();
            this.btnSuaNgoai = new System.Windows.Forms.Button();
            this.btnBanAo = new System.Windows.Forms.Button();
            this.btnThueAo = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnChonKHXemHDMay);
            this.groupBox1.Controls.Add(this.dgvDanhSachKH);
            this.groupBox1.Controls.Add(this.tbTimKiemAo);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(34, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng ";
            // 
            // btnChonKHXemHDMay
            // 
            this.btnChonKHXemHDMay.BackColor = System.Drawing.Color.Transparent;
            this.btnChonKHXemHDMay.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.detail;
            this.btnChonKHXemHDMay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonKHXemHDMay.FlatAppearance.BorderSize = 0;
            this.btnChonKHXemHDMay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChonKHXemHDMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonKHXemHDMay.Location = new System.Drawing.Point(731, 17);
            this.btnChonKHXemHDMay.Name = "btnChonKHXemHDMay";
            this.btnChonKHXemHDMay.Size = new System.Drawing.Size(40, 40);
            this.btnChonKHXemHDMay.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnChonKHXemHDMay, "Chọn khách hàng để may");
            this.btnChonKHXemHDMay.UseVisualStyleBackColor = false;
            this.btnChonKHXemHDMay.Click += new System.EventHandler(this.btnChonKHXemHDMay_Click);
            // 
            // dgvDanhSachKH
            // 
            this.dgvDanhSachKH.AllowUserToAddRows = false;
            this.dgvDanhSachKH.AllowUserToDeleteRows = false;
            this.dgvDanhSachKH.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhSachKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Id,
            this.tenKhachHang,
            this.soDienThoai,
            this.diaChi,
            this.ghiChu});
            this.dgvDanhSachKH.EnableHeadersVisualStyles = false;
            this.dgvDanhSachKH.Location = new System.Drawing.Point(20, 63);
            this.dgvDanhSachKH.Name = "dgvDanhSachKH";
            this.dgvDanhSachKH.ReadOnly = true;
            this.dgvDanhSachKH.Size = new System.Drawing.Size(750, 214);
            this.dgvDanhSachKH.TabIndex = 4;
            this.dgvDanhSachKH.Click += new System.EventHandler(this.dgvDanhSachKH_Click);
            // 
            // tbTimKiemAo
            // 
            this.tbTimKiemAo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTimKiemAo.Location = new System.Drawing.Point(289, 27);
            this.tbTimKiemAo.Name = "tbTimKiemAo";
            this.tbTimKiemAo.Size = new System.Drawing.Size(235, 23);
            this.tbTimKiemAo.TabIndex = 3;
            this.tbTimKiemAo.Text = "Nhập tên khách hàng để tìm kiếm ...";
            this.tbTimKiemAo.Click += new System.EventHandler(this.tbTimKiemAo_Click);
            this.tbTimKiemAo.TextChanged += new System.EventHandler(this.tbTimKiemAo_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TiemMayHaiTrieu.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(248, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đầy đủ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số điện thoại :";
            // 
            // txtTenKh
            // 
            this.txtTenKh.Location = new System.Drawing.Point(128, 13);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(178, 23);
            this.txtTenKh.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(128, 43);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(178, 23);
            this.txtSoDienThoai.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(128, 71);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(178, 23);
            this.txtDiaChi.TabIndex = 12;
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(385, 11);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(173, 83);
            this.rtxtGhiChu.TabIndex = 5;
            this.rtxtGhiChu.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ghi chú :";
            // 
            // btnChonKHBanAo
            // 
            this.btnChonKHBanAo.BackColor = System.Drawing.Color.Transparent;
            this.btnChonKHBanAo.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.sell;
            this.btnChonKHBanAo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonKHBanAo.FlatAppearance.BorderSize = 0;
            this.btnChonKHBanAo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChonKHBanAo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonKHBanAo.Location = new System.Drawing.Point(817, 274);
            this.btnChonKHBanAo.Name = "btnChonKHBanAo";
            this.btnChonKHBanAo.Size = new System.Drawing.Size(40, 40);
            this.btnChonKHBanAo.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnChonKHBanAo, "Chọn khách hàng để bán");
            this.btnChonKHBanAo.UseVisualStyleBackColor = false;
            this.btnChonKHBanAo.Click += new System.EventHandler(this.btnChonKHBanAo_Click);
            // 
            // btnChonKHMayAo
            // 
            this.btnChonKHMayAo.BackColor = System.Drawing.Color.Transparent;
            this.btnChonKHMayAo.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.sew;
            this.btnChonKHMayAo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonKHMayAo.FlatAppearance.BorderSize = 0;
            this.btnChonKHMayAo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChonKHMayAo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonKHMayAo.Location = new System.Drawing.Point(817, 228);
            this.btnChonKHMayAo.Name = "btnChonKHMayAo";
            this.btnChonKHMayAo.Size = new System.Drawing.Size(40, 40);
            this.btnChonKHMayAo.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnChonKHMayAo, "Chọn khách hàng để may");
            this.btnChonKHMayAo.UseVisualStyleBackColor = false;
            this.btnChonKHMayAo.Click += new System.EventHandler(this.btnChonKHMayAo_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaKH.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.delete;
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaKH.FlatAppearance.BorderSize = 0;
            this.btnXoaKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Location = new System.Drawing.Point(740, 32);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(60, 60);
            this.btnXoaKH.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnXoaKH, "Xóa khách hàng");
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.Transparent;
            this.btnThemKH.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.add;
            this.btnThemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Location = new System.Drawing.Point(586, 32);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(60, 60);
            this.btnThemKH.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnThemKH, "Thêm khách hàng mới ");
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaKH.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.edit;
            this.btnSuaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaKH.FlatAppearance.BorderSize = 0;
            this.btnSuaKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKH.Location = new System.Drawing.Point(663, 32);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(60, 60);
            this.btnSuaKH.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSuaKH, "Sửa thông tin khách hàng");
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnChonKHDeDat
            // 
            this.btnChonKHDeDat.BackColor = System.Drawing.Color.Transparent;
            this.btnChonKHDeDat.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.purchase_order;
            this.btnChonKHDeDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonKHDeDat.FlatAppearance.BorderSize = 0;
            this.btnChonKHDeDat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChonKHDeDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonKHDeDat.Location = new System.Drawing.Point(817, 320);
            this.btnChonKHDeDat.Name = "btnChonKHDeDat";
            this.btnChonKHDeDat.Size = new System.Drawing.Size(40, 40);
            this.btnChonKHDeDat.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnChonKHDeDat, "Chọn Khách hàng để đặt hàng ");
            this.btnChonKHDeDat.UseVisualStyleBackColor = false;
            this.btnChonKHDeDat.Click += new System.EventHandler(this.btnChonKHDeDat_Click);
            // 
            // btnSuaNgoai
            // 
            this.btnSuaNgoai.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaNgoai.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.Settings_520;
            this.btnSuaNgoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaNgoai.FlatAppearance.BorderSize = 0;
            this.btnSuaNgoai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSuaNgoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNgoai.Location = new System.Drawing.Point(817, 366);
            this.btnSuaNgoai.Name = "btnSuaNgoai";
            this.btnSuaNgoai.Size = new System.Drawing.Size(40, 40);
            this.btnSuaNgoai.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnSuaNgoai, "Chọn khách hàng để bán");
            this.btnSuaNgoai.UseVisualStyleBackColor = false;
            this.btnSuaNgoai.Click += new System.EventHandler(this.btnSuaNgoai_Click);
            // 
            // btnBanAo
            // 
            this.btnBanAo.BackColor = System.Drawing.Color.Transparent;
            this.btnBanAo.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.sold_real_estate_hanging_signal;
            this.btnBanAo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanAo.FlatAppearance.BorderSize = 0;
            this.btnBanAo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBanAo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanAo.Location = new System.Drawing.Point(817, 182);
            this.btnBanAo.Name = "btnBanAo";
            this.btnBanAo.Size = new System.Drawing.Size(40, 40);
            this.btnBanAo.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnBanAo, "Chọn khách hàng để bán");
            this.btnBanAo.UseVisualStyleBackColor = false;
            this.btnBanAo.Click += new System.EventHandler(this.btnBanAo_Click);
            // 
            // btnThueAo
            // 
            this.btnThueAo.BackColor = System.Drawing.Color.Transparent;
            this.btnThueAo.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.for_rent;
            this.btnThueAo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThueAo.FlatAppearance.BorderSize = 0;
            this.btnThueAo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThueAo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThueAo.Location = new System.Drawing.Point(817, 136);
            this.btnThueAo.Name = "btnThueAo";
            this.btnThueAo.Size = new System.Drawing.Size(40, 40);
            this.btnThueAo.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnThueAo, "Chọn khách hàng thuê áo ");
            this.btnThueAo.UseVisualStyleBackColor = false;
            this.btnThueAo.Click += new System.EventHandler(this.btnThueAo_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Họ và tên";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            this.tenKhachHang.Width = 150;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            this.soDienThoai.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 150;
            // 
            // ghiChu
            // 
            this.ghiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.FillWeight = 200F;
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(929, 416);
            this.Controls.Add(this.btnThueAo);
            this.Controls.Add(this.btnBanAo);
            this.Controls.Add(this.btnSuaNgoai);
            this.Controls.Add(this.btnChonKHDeDat);
            this.Controls.Add(this.btnChonKHBanAo);
            this.Controls.Add(this.btnChonKHMayAo);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenKh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnSuaKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng ";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTimKiemAo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.DataGridView dgvDanhSachKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnChonKHMayAo;
        private System.Windows.Forms.Button btnChonKHBanAo;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChonKHDeDat;
        private System.Windows.Forms.Button btnSuaNgoai;
        private System.Windows.Forms.Button btnBanAo;
        private System.Windows.Forms.Button btnThueAo;
        private System.Windows.Forms.Button btnChonKHXemHDMay;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}