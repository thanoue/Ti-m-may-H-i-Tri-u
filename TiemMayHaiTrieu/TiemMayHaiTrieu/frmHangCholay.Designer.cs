namespace TiemMayHaiTrieu
{
    partial class frmHangCholay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangCholay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTongTienConlai = new System.Windows.Forms.Label();
            this.lbTongTienCoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlayhang = new System.Windows.Forms.Button();
            this.btnGiaoHang = new System.Windows.Forms.Button();
            this.btnDatTho = new System.Windows.Forms.Button();
            this.dgvDSCTHD = new System.Windows.Forms.DataGridView();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHenLay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbDSHDDaNhan = new System.Windows.Forms.RadioButton();
            this.rbDSHDChoNhan = new System.Windows.Forms.RadioButton();
            this.rbDSHDChoThoGiao = new System.Windows.Forms.RadioButton();
            this.rbDSHDChuaDatTho = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.lbTongTienConlai);
            this.groupBox1.Controls.Add(this.lbTongTienCoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnlayhang);
            this.groupBox1.Controls.Add(this.btnGiaoHang);
            this.groupBox1.Controls.Add(this.btnDatTho);
            this.groupBox1.Controls.Add(this.dgvDSCTHD);
            this.groupBox1.Controls.Add(this.dgvDSHD);
            this.groupBox1.Controls.Add(this.rbDSHDDaNhan);
            this.groupBox1.Controls.Add(this.rbDSHDChoNhan);
            this.groupBox1.Controls.Add(this.rbDSHDChoThoGiao);
            this.groupBox1.Controls.Add(this.rbDSHDChuaDatTho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1199, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng đặt đợi lấy  :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbTongTienConlai
            // 
            this.lbTongTienConlai.AutoSize = true;
            this.lbTongTienConlai.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienConlai.Location = new System.Drawing.Point(347, 104);
            this.lbTongTienConlai.Name = "lbTongTienConlai";
            this.lbTongTienConlai.Size = new System.Drawing.Size(29, 17);
            this.lbTongTienConlai.TabIndex = 13;
            this.lbTongTienConlai.Text = "000";
            // 
            // lbTongTienCoc
            // 
            this.lbTongTienCoc.AutoSize = true;
            this.lbTongTienCoc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienCoc.Location = new System.Drawing.Point(347, 71);
            this.lbTongTienCoc.Name = "lbTongTienCoc";
            this.lbTongTienCoc.Size = new System.Drawing.Size(29, 17);
            this.lbTongTienCoc.TabIndex = 12;
            this.lbTongTienCoc.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng tiên còn lại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng tiền cọc :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiemMayHaiTrieu.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(576, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnlayhang
            // 
            this.btnlayhang.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.get;
            this.btnlayhang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlayhang.Enabled = false;
            this.btnlayhang.FlatAppearance.BorderSize = 0;
            this.btnlayhang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlayhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlayhang.Location = new System.Drawing.Point(639, 64);
            this.btnlayhang.Name = "btnlayhang";
            this.btnlayhang.Size = new System.Drawing.Size(50, 50);
            this.btnlayhang.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnlayhang, "Khách hàng xác nhận lấy hàng");
            this.btnlayhang.UseVisualStyleBackColor = true;
            this.btnlayhang.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGiaoHang
            // 
            this.btnGiaoHang.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.truck;
            this.btnGiaoHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiaoHang.Enabled = false;
            this.btnGiaoHang.FlatAppearance.BorderSize = 0;
            this.btnGiaoHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaoHang.Location = new System.Drawing.Point(573, 63);
            this.btnGiaoHang.Name = "btnGiaoHang";
            this.btnGiaoHang.Size = new System.Drawing.Size(50, 50);
            this.btnGiaoHang.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnGiaoHang, "Thợ giao hàng");
            this.btnGiaoHang.UseVisualStyleBackColor = true;
            this.btnGiaoHang.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDatTho
            // 
            this.btnDatTho.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources._1489778515_whatsapp_logo;
            this.btnDatTho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDatTho.Enabled = false;
            this.btnDatTho.FlatAppearance.BorderSize = 0;
            this.btnDatTho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDatTho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatTho.Location = new System.Drawing.Point(508, 63);
            this.btnDatTho.Name = "btnDatTho";
            this.btnDatTho.Size = new System.Drawing.Size(50, 50);
            this.btnDatTho.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDatTho, "Tiến hành đặt thợ");
            this.btnDatTho.UseVisualStyleBackColor = true;
            this.btnDatTho.Click += new System.EventHandler(this.btnDatTho_Click);
            // 
            // dgvDSCTHD
            // 
            this.dgvDSCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHang,
            this.chiTiet,
            this.giaTien,
            this.soLuong});
            this.dgvDSCTHD.Location = new System.Drawing.Point(639, 131);
            this.dgvDSCTHD.Name = "dgvDSCTHD";
            this.dgvDSCTHD.Size = new System.Drawing.Size(540, 195);
            this.dgvDSCTHD.TabIndex = 5;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenHang";
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.Name = "tenHang";
            this.tenHang.Width = 130;
            // 
            // chiTiet
            // 
            this.chiTiet.DataPropertyName = "chiTiet";
            this.chiTiet.HeaderText = "Chi tiết";
            this.chiTiet.Name = "chiTiet";
            this.chiTiet.Width = 150;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "giaTien";
            this.giaTien.HeaderText = "Giá tiền";
            this.giaTien.Name = "giaTien";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tenKhachHang,
            this.maHD,
            this.ngayLapHoaDon,
            this.ngayHenLay,
            this.tongTien});
            this.dgvDSHD.Location = new System.Drawing.Point(19, 131);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.Size = new System.Drawing.Size(540, 195);
            this.dgvDSHD.TabIndex = 4;
            this.dgvDSHD.Click += new System.EventHandler(this.dgvDSHD_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "tên Khách hàng";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.Width = 120;
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "Id";
            this.maHD.HeaderText = "id";
            this.maHD.Name = "maHD";
            this.maHD.Visible = false;
            // 
            // ngayLapHoaDon
            // 
            this.ngayLapHoaDon.DataPropertyName = "ngayLapHoaDon";
            this.ngayLapHoaDon.HeaderText = "Ngày Lập HD";
            this.ngayLapHoaDon.Name = "ngayLapHoaDon";
            this.ngayLapHoaDon.Width = 120;
            // 
            // ngayHenLay
            // 
            this.ngayHenLay.DataPropertyName = "ngayHenLay";
            this.ngayHenLay.HeaderText = "Ngày hẹn lấy";
            this.ngayHenLay.Name = "ngayHenLay";
            this.ngayHenLay.Width = 120;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.Name = "tongTien";
            // 
            // rbDSHDDaNhan
            // 
            this.rbDSHDDaNhan.AutoSize = true;
            this.rbDSHDDaNhan.Location = new System.Drawing.Point(19, 105);
            this.rbDSHDDaNhan.Name = "rbDSHDDaNhan";
            this.rbDSHDDaNhan.Size = new System.Drawing.Size(205, 19);
            this.rbDSHDDaNhan.TabIndex = 3;
            this.rbDSHDDaNhan.TabStop = true;
            this.rbDSHDDaNhan.Text = "Danh sách hóa đơn đã được nhận";
            this.rbDSHDDaNhan.UseVisualStyleBackColor = true;
            this.rbDSHDDaNhan.CheckedChanged += new System.EventHandler(this.rbDSHDDaNhan_CheckedChanged);
            // 
            // rbDSHDChoNhan
            // 
            this.rbDSHDChoNhan.AutoSize = true;
            this.rbDSHDChoNhan.Location = new System.Drawing.Point(19, 80);
            this.rbDSHDChoNhan.Name = "rbDSHDChoNhan";
            this.rbDSHDChoNhan.Size = new System.Drawing.Size(182, 19);
            this.rbDSHDChoNhan.TabIndex = 2;
            this.rbDSHDChoNhan.TabStop = true;
            this.rbDSHDChoNhan.Text = "Danh sách hóa đơn chờ nhận";
            this.rbDSHDChoNhan.UseVisualStyleBackColor = true;
            this.rbDSHDChoNhan.CheckedChanged += new System.EventHandler(this.rbDSHDChoNhan_CheckedChanged);
            // 
            // rbDSHDChoThoGiao
            // 
            this.rbDSHDChoThoGiao.AutoSize = true;
            this.rbDSHDChoThoGiao.Location = new System.Drawing.Point(19, 55);
            this.rbDSHDChoThoGiao.Name = "rbDSHDChoThoGiao";
            this.rbDSHDChoThoGiao.Size = new System.Drawing.Size(199, 19);
            this.rbDSHDChoThoGiao.TabIndex = 1;
            this.rbDSHDChoThoGiao.TabStop = true;
            this.rbDSHDChoThoGiao.Text = "Danh sách hóa đơn chờ thợ giao";
            this.rbDSHDChoThoGiao.UseVisualStyleBackColor = true;
            this.rbDSHDChoThoGiao.CheckedChanged += new System.EventHandler(this.rbDSHDChoThoGiao_CheckedChanged);
            // 
            // rbDSHDChuaDatTho
            // 
            this.rbDSHDChuaDatTho.AutoSize = true;
            this.rbDSHDChuaDatTho.Location = new System.Drawing.Point(19, 30);
            this.rbDSHDChuaDatTho.Name = "rbDSHDChuaDatTho";
            this.rbDSHDChuaDatTho.Size = new System.Drawing.Size(199, 19);
            this.rbDSHDChuaDatTho.TabIndex = 0;
            this.rbDSHDChuaDatTho.TabStop = true;
            this.rbDSHDChuaDatTho.Text = "Danh sách hóa đơn chưa đặt thợ";
            this.rbDSHDChuaDatTho.UseVisualStyleBackColor = true;
            this.rbDSHDChuaDatTho.CheckedChanged += new System.EventHandler(this.rbDSHDChuaDatTho_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmHangCholay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1223, 351);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmHangCholay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng chờ lấy ";
            this.Load += new System.EventHandler(this.frmHangCholay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGiaoHang;
        private System.Windows.Forms.Button btnDatTho;
        private System.Windows.Forms.DataGridView dgvDSCTHD;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.RadioButton rbDSHDDaNhan;
        private System.Windows.Forms.RadioButton rbDSHDChoNhan;
        private System.Windows.Forms.RadioButton rbDSHDChoThoGiao;
        private System.Windows.Forms.RadioButton rbDSHDChuaDatTho;
        private System.Windows.Forms.Button btnlayhang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHenLay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.Label lbTongTienConlai;
        private System.Windows.Forms.Label lbTongTienCoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
    }
}