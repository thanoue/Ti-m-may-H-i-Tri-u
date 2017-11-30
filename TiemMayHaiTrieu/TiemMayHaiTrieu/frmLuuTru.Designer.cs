namespace TiemMayHaiTrieu
{
    partial class frmLuuTru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuuTru));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDSHDBanAo = new System.Windows.Forms.RadioButton();
            this.rbDSHDBanVai = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.dshd_maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dshd_anhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dsHD_tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsHd_ngaylapHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsHD_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachChonMua = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ds_tenLoaiVai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_anhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.ds_maVai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChonMua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDSHDBanAo);
            this.groupBox1.Controls.Add(this.rbDSHDBanVai);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dgvDSHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(126, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các áo đã may :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbDSHDBanAo
            // 
            this.rbDSHDBanAo.AutoSize = true;
            this.rbDSHDBanAo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDSHDBanAo.Location = new System.Drawing.Point(360, 74);
            this.rbDSHDBanAo.Name = "rbDSHDBanAo";
            this.rbDSHDBanAo.Size = new System.Drawing.Size(180, 20);
            this.rbDSHDBanAo.TabIndex = 14;
            this.rbDSHDBanAo.TabStop = true;
            this.rbDSHDBanAo.Text = "Danh sách hóa đơn bán áo ";
            this.rbDSHDBanAo.UseVisualStyleBackColor = true;
            this.rbDSHDBanAo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbDSHDBanVai
            // 
            this.rbDSHDBanVai.AutoSize = true;
            this.rbDSHDBanVai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDSHDBanVai.Location = new System.Drawing.Point(360, 47);
            this.rbDSHDBanVai.Name = "rbDSHDBanVai";
            this.rbDSHDBanVai.Size = new System.Drawing.Size(179, 20);
            this.rbDSHDBanVai.TabIndex = 13;
            this.rbDSHDBanVai.TabStop = true;
            this.rbDSHDBanVai.Text = "Danh sách hóa đơn bán vải";
            this.rbDSHDBanVai.UseVisualStyleBackColor = true;
            this.rbDSHDBanVai.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(304, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.button1, "Tải lại danh sách ");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(61, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 23);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Nhập tên KH để tìm...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TiemMayHaiTrieu.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(15, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AllowUserToAddRows = false;
            this.dgvDSHoaDon.AllowUserToDeleteRows = false;
            this.dgvDSHoaDon.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDSHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dshd_maHD,
            this.dshd_anhDaiDien,
            this.Column3,
            this.dsHD_tenKhachHang,
            this.dsHd_ngaylapHoaDon,
            this.dsHD_tongTien});
            this.dgvDSHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(16, 100);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.ReadOnly = true;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(524, 182);
            this.dgvDSHoaDon.TabIndex = 0;
            this.dgvDSHoaDon.Click += new System.EventHandler(this.dgvDSHoaDon_Click);
            // 
            // dshd_maHD
            // 
            this.dshd_maHD.DataPropertyName = "maHD";
            this.dshd_maHD.HeaderText = "ma hD";
            this.dshd_maHD.Name = "dshd_maHD";
            this.dshd_maHD.ReadOnly = true;
            this.dshd_maHD.Visible = false;
            // 
            // dshd_anhDaiDien
            // 
            this.dshd_anhDaiDien.DataPropertyName = "anhDaiDien";
            this.dshd_anhDaiDien.HeaderText = "anh dai dien";
            this.dshd_anhDaiDien.Name = "dshd_anhDaiDien";
            this.dshd_anhDaiDien.ReadOnly = true;
            this.dshd_anhDaiDien.Visible = false;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            // 
            // dsHD_tenKhachHang
            // 
            this.dsHD_tenKhachHang.DataPropertyName = "tenKhachHang";
            this.dsHD_tenKhachHang.HeaderText = "Tên khách hàng";
            this.dsHD_tenKhachHang.Name = "dsHD_tenKhachHang";
            this.dsHD_tenKhachHang.ReadOnly = true;
            this.dsHD_tenKhachHang.Width = 150;
            // 
            // dsHd_ngaylapHoaDon
            // 
            this.dsHd_ngaylapHoaDon.DataPropertyName = "ngayLapHoaDon";
            this.dsHd_ngaylapHoaDon.HeaderText = "Ngày lập hóa đơn";
            this.dsHd_ngaylapHoaDon.Name = "dsHd_ngaylapHoaDon";
            this.dsHd_ngaylapHoaDon.ReadOnly = true;
            this.dsHd_ngaylapHoaDon.Width = 150;
            // 
            // dsHD_tongTien
            // 
            this.dsHD_tongTien.DataPropertyName = "tongTien";
            this.dsHD_tongTien.HeaderText = "Tổng tiền";
            this.dsHD_tongTien.Name = "dsHD_tongTien";
            this.dsHD_tongTien.ReadOnly = true;
            this.dsHD_tongTien.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(13, 302);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(791, 270);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết :";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(633, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDanhSachChonMua);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(7, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(619, 231);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách các mặt hàng từng hóa đơn :";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // dgvDanhSachChonMua
            // 
            this.dgvDanhSachChonMua.AllowUserToAddRows = false;
            this.dgvDanhSachChonMua.AllowUserToDeleteRows = false;
            this.dgvDanhSachChonMua.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhSachChonMua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachChonMua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachChonMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachChonMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.ds_tenLoaiVai,
            this.ds_anhDaiDien,
            this.ds_maVai,
            this.ds_Id,
            this.ds_maHoaDon,
            this.ds_soLuong,
            this.ds_donGia,
            this.ds_tongTien});
            this.dgvDanhSachChonMua.EnableHeadersVisualStyles = false;
            this.dgvDanhSachChonMua.Location = new System.Drawing.Point(7, 17);
            this.dgvDanhSachChonMua.Name = "dgvDanhSachChonMua";
            this.dgvDanhSachChonMua.ReadOnly = true;
            this.dgvDanhSachChonMua.Size = new System.Drawing.Size(606, 208);
            this.dgvDanhSachChonMua.TabIndex = 12;
            this.dgvDanhSachChonMua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachChonMua_CellContentClick);
            this.dgvDanhSachChonMua.Click += new System.EventHandler(this.dgvDanhSachChonMua_Click);
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 30;
            // 
            // ds_tenLoaiVai
            // 
            this.ds_tenLoaiVai.DataPropertyName = "tenLoaiVai";
            this.ds_tenLoaiVai.HeaderText = "Tên loại vải";
            this.ds_tenLoaiVai.Name = "ds_tenLoaiVai";
            this.ds_tenLoaiVai.ReadOnly = true;
            this.ds_tenLoaiVai.Width = 150;
            // 
            // ds_anhDaiDien
            // 
            this.ds_anhDaiDien.DataPropertyName = "anhDaiDien";
            this.ds_anhDaiDien.HeaderText = "anh dai dien";
            this.ds_anhDaiDien.Name = "ds_anhDaiDien";
            this.ds_anhDaiDien.ReadOnly = true;
            this.ds_anhDaiDien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ds_anhDaiDien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ds_anhDaiDien.Visible = false;
            // 
            // ds_maVai
            // 
            this.ds_maVai.DataPropertyName = "maVai";
            this.ds_maVai.HeaderText = "ma vai";
            this.ds_maVai.Name = "ds_maVai";
            this.ds_maVai.ReadOnly = true;
            this.ds_maVai.Visible = false;
            // 
            // ds_Id
            // 
            this.ds_Id.DataPropertyName = "id";
            this.ds_Id.HeaderText = "id";
            this.ds_Id.Name = "ds_Id";
            this.ds_Id.ReadOnly = true;
            this.ds_Id.Visible = false;
            // 
            // ds_maHoaDon
            // 
            this.ds_maHoaDon.DataPropertyName = "maHoaDon";
            this.ds_maHoaDon.HeaderText = "ma hoa don";
            this.ds_maHoaDon.Name = "ds_maHoaDon";
            this.ds_maHoaDon.ReadOnly = true;
            this.ds_maHoaDon.Visible = false;
            // 
            // ds_soLuong
            // 
            this.ds_soLuong.DataPropertyName = "soLuong";
            this.ds_soLuong.HeaderText = "Số lượng";
            this.ds_soLuong.Name = "ds_soLuong";
            this.ds_soLuong.ReadOnly = true;
            // 
            // ds_donGia
            // 
            this.ds_donGia.DataPropertyName = "donGia";
            this.ds_donGia.HeaderText = "Đơn giá";
            this.ds_donGia.Name = "ds_donGia";
            this.ds_donGia.ReadOnly = true;
            this.ds_donGia.Width = 130;
            // 
            // ds_tongTien
            // 
            this.ds_tongTien.DataPropertyName = "tongTien";
            this.ds_tongTien.HeaderText = "Tổng tiền";
            this.ds_tongTien.Name = "ds_tongTien";
            this.ds_tongTien.ReadOnly = true;
            this.ds_tongTien.Width = 130;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmLuuTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(811, 584);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLuuTru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lưu trữ thông tin về các áo đã may, các hóa đơn ";
            this.Load += new System.EventHandler(this.frmLuuTru_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChonMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.DataGridView dgvDanhSachChonMua;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbDSHDBanAo;
        private System.Windows.Forms.RadioButton rbDSHDBanVai;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dshd_maHD;
        private System.Windows.Forms.DataGridViewImageColumn dshd_anhDaiDien;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsHD_tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsHd_ngaylapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsHD_tongTien;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tenLoaiVai;
        private System.Windows.Forms.DataGridViewImageColumn ds_anhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_maVai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_tongTien;
    }
}