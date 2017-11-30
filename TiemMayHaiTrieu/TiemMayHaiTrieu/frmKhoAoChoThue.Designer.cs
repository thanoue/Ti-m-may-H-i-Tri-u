namespace TiemMayHaiTrieu
{
    partial class frmKhoAoChoThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoAoChoThue));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBanAo = new System.Windows.Forms.Button();
            this.btnThueAo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.pbAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhiThueDuKien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenAo = new System.Windows.Forms.TextBox();
            this.gbThongTinHang = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaBanDuKien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimKiemAo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvKhoVai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenAo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiThueDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phiBanDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDien)).BeginInit();
            this.gbThongTinHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoVai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.choose_image;
            this.btnChonAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChonAnh.FlatAppearance.BorderSize = 0;
            this.btnChonAnh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChonAnh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Location = new System.Drawing.Point(601, 21);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(30, 30);
            this.btnChonAnh.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnChonAnh, "Chọn ảnh đại diện cho áo");
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.delete;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(670, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa áo khỏi kho");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.edit;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(670, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSua, "Sửa thông tin áo");
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.add;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(670, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnThem, "Nhập hàng");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.Synchronize_520;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(226, 27);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(40, 40);
            this.btnReload.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnReload, "Tải lại danh sách ");
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnBanAo
            // 
            this.btnBanAo.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.sell;
            this.btnBanAo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBanAo.FlatAppearance.BorderSize = 0;
            this.btnBanAo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnBanAo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnBanAo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanAo.Location = new System.Drawing.Point(601, 21);
            this.btnBanAo.Name = "btnBanAo";
            this.btnBanAo.Size = new System.Drawing.Size(50, 50);
            this.btnBanAo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnBanAo, "Bán áo");
            this.btnBanAo.UseVisualStyleBackColor = true;
            this.btnBanAo.Click += new System.EventHandler(this.btnBanAo_Click);
            // 
            // btnThueAo
            // 
            this.btnThueAo.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.for_rent;
            this.btnThueAo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThueAo.FlatAppearance.BorderSize = 0;
            this.btnThueAo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnThueAo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnThueAo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThueAo.Location = new System.Drawing.Point(533, 21);
            this.btnThueAo.Name = "btnThueAo";
            this.btnThueAo.Size = new System.Drawing.Size(50, 50);
            this.btnThueAo.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnThueAo, "Thuê áo");
            this.btnThueAo.UseVisualStyleBackColor = true;
            this.btnThueAo.Click += new System.EventHandler(this.btnThueAo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ghi chú :";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtGhiChu.Location = new System.Drawing.Point(395, 84);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(236, 96);
            this.rtxtGhiChu.TabIndex = 7;
            this.rtxtGhiChu.Text = "";
            // 
            // pbAnhDaiDien
            // 
            this.pbAnhDaiDien.Location = new System.Drawing.Point(637, 10);
            this.pbAnhDaiDien.Name = "pbAnhDaiDien";
            this.pbAnhDaiDien.Size = new System.Drawing.Size(125, 170);
            this.pbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnhDaiDien.TabIndex = 6;
            this.pbAnhDaiDien.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phí thuê dự kiến :";
            // 
            // txtPhiThueDuKien
            // 
            this.txtPhiThueDuKien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhiThueDuKien.Location = new System.Drawing.Point(153, 121);
            this.txtPhiThueDuKien.Name = "txtPhiThueDuKien";
            this.txtPhiThueDuKien.Size = new System.Drawing.Size(161, 26);
            this.txtPhiThueDuKien.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(153, 85);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(161, 26);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.Text = "0";
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.Location = new System.Drawing.Point(71, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng :";
            // 
            // txtTenAo
            // 
            this.txtTenAo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenAo.Location = new System.Drawing.Point(153, 51);
            this.txtTenAo.Name = "txtTenAo";
            this.txtTenAo.Size = new System.Drawing.Size(161, 26);
            this.txtTenAo.TabIndex = 1;
            // 
            // gbThongTinHang
            // 
            this.gbThongTinHang.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbThongTinHang.Controls.Add(this.label5);
            this.gbThongTinHang.Controls.Add(this.txtGiaBanDuKien);
            this.gbThongTinHang.Controls.Add(this.btnChonAnh);
            this.gbThongTinHang.Controls.Add(this.label4);
            this.gbThongTinHang.Controls.Add(this.rtxtGhiChu);
            this.gbThongTinHang.Controls.Add(this.pbAnhDaiDien);
            this.gbThongTinHang.Controls.Add(this.label3);
            this.gbThongTinHang.Controls.Add(this.txtPhiThueDuKien);
            this.gbThongTinHang.Controls.Add(this.txtSoLuong);
            this.gbThongTinHang.Controls.Add(this.label2);
            this.gbThongTinHang.Controls.Add(this.txtTenAo);
            this.gbThongTinHang.Controls.Add(this.label1);
            this.gbThongTinHang.Enabled = false;
            this.gbThongTinHang.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTinHang.Location = new System.Drawing.Point(13, 12);
            this.gbThongTinHang.Name = "gbThongTinHang";
            this.gbThongTinHang.Size = new System.Drawing.Size(768, 186);
            this.gbThongTinHang.TabIndex = 3;
            this.gbThongTinHang.TabStop = false;
            this.gbThongTinHang.Text = "Thông tin áo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.Location = new System.Drawing.Point(27, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá bán dự kiến :";
            // 
            // txtGiaBanDuKien
            // 
            this.txtGiaBanDuKien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBanDuKien.Location = new System.Drawing.Point(153, 157);
            this.txtGiaBanDuKien.Name = "txtGiaBanDuKien";
            this.txtGiaBanDuKien.Size = new System.Drawing.Size(161, 26);
            this.txtGiaBanDuKien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.Location = new System.Drawing.Point(85, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên áo :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbTimKiemAo
            // 
            this.tbTimKiemAo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTimKiemAo.Location = new System.Drawing.Point(43, 43);
            this.tbTimKiemAo.Name = "tbTimKiemAo";
            this.tbTimKiemAo.Size = new System.Drawing.Size(177, 23);
            this.tbTimKiemAo.TabIndex = 5;
            this.tbTimKiemAo.Text = "Nhập tên loại vải để tìm...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.search;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(8, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dgvKhoVai
            // 
            this.dgvKhoVai.AllowUserToAddRows = false;
            this.dgvKhoVai.AllowUserToDeleteRows = false;
            this.dgvKhoVai.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvKhoVai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhoVai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoVai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoVai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tenAo,
            this.Id,
            this.soLuong,
            this.phiThueDuKien,
            this.phiBanDuKien,
            this.anhDaiDien,
            this.ghiChu});
            this.dgvKhoVai.EnableHeadersVisualStyles = false;
            this.dgvKhoVai.Location = new System.Drawing.Point(7, 72);
            this.dgvKhoVai.Name = "dgvKhoVai";
            this.dgvKhoVai.ReadOnly = true;
            this.dgvKhoVai.Size = new System.Drawing.Size(643, 230);
            this.dgvKhoVai.TabIndex = 0;
            this.dgvKhoVai.Click += new System.EventHandler(this.dgvKhoVai_Click);
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
            // tenAo
            // 
            this.tenAo.DataPropertyName = "tenAo";
            this.tenAo.HeaderText = "Tên áo";
            this.tenAo.Name = "tenAo";
            this.tenAo.ReadOnly = true;
            this.tenAo.Width = 130;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "maAo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng tồn";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 120;
            // 
            // phiThueDuKien
            // 
            this.phiThueDuKien.DataPropertyName = "phiThueMacDinh";
            this.phiThueDuKien.HeaderText = "Phí thuê";
            this.phiThueDuKien.Name = "phiThueDuKien";
            this.phiThueDuKien.ReadOnly = true;
            // 
            // phiBanDuKien
            // 
            this.phiBanDuKien.DataPropertyName = "phiBanMacDinh";
            this.phiBanDuKien.HeaderText = "Phí bán";
            this.phiBanDuKien.Name = "phiBanDuKien";
            this.phiBanDuKien.ReadOnly = true;
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
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            this.ghiChu.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnThueAo);
            this.groupBox1.Controls.Add(this.btnBanAo);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.tbTimKiemAo);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.dgvKhoVai);
            this.groupBox1.Location = new System.Drawing.Point(13, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(768, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kho hàng ";
            // 
            // frmKhoAoChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(794, 527);
            this.Controls.Add(this.gbThongTinHang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKhoAoChoThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho áo cho thuê";
            this.Load += new System.EventHandler(this.frmKhoAoChoThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDien)).EndInit();
            this.gbThongTinHang.ResumeLayout(false);
            this.gbThongTinHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoVai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.PictureBox pbAnhDaiDien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhiThueDuKien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenAo;
        private System.Windows.Forms.GroupBox gbThongTinHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimKiemAo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvKhoVai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaBanDuKien;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenAo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phiThueDuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn phiBanDuKien;
        private System.Windows.Forms.DataGridViewImageColumn anhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.Button btnThueAo;
        private System.Windows.Forms.Button btnBanAo;
    }
}