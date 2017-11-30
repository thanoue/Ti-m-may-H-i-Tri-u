namespace TiemMayHaiTrieu
{
    partial class frmDanhSachSuaNgoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachSuaNgoai));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbAo = new System.Windows.Forms.PictureBox();
            this.rbChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rbDaThanhToan = new System.Windows.Forms.RadioButton();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.dgvDanhSachSua = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noiDungSua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySuaXong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSua)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.pbAo);
            this.groupBox1.Controls.Add(this.rbChuaThanhToan);
            this.groupBox1.Controls.Add(this.rbDaThanhToan);
            this.groupBox1.Controls.Add(this.btnThanhToan);
            this.groupBox1.Controls.Add(this.dgvDanhSachSua);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(876, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các lần sửa :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbAo
            // 
            this.pbAo.Location = new System.Drawing.Point(702, 77);
            this.pbAo.Margin = new System.Windows.Forms.Padding(4);
            this.pbAo.Name = "pbAo";
            this.pbAo.Size = new System.Drawing.Size(157, 194);
            this.pbAo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAo.TabIndex = 10;
            this.pbAo.TabStop = false;
            // 
            // rbChuaThanhToan
            // 
            this.rbChuaThanhToan.AutoSize = true;
            this.rbChuaThanhToan.Location = new System.Drawing.Point(8, 53);
            this.rbChuaThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.rbChuaThanhToan.Name = "rbChuaThanhToan";
            this.rbChuaThanhToan.Size = new System.Drawing.Size(117, 19);
            this.rbChuaThanhToan.TabIndex = 9;
            this.rbChuaThanhToan.TabStop = true;
            this.rbChuaThanhToan.Text = "Chưa thanh toán ";
            this.rbChuaThanhToan.UseVisualStyleBackColor = true;
            this.rbChuaThanhToan.CheckedChanged += new System.EventHandler(this.rbChuaThanhToan_CheckedChanged);
            // 
            // rbDaThanhToan
            // 
            this.rbDaThanhToan.AutoSize = true;
            this.rbDaThanhToan.Location = new System.Drawing.Point(8, 24);
            this.rbDaThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.rbDaThanhToan.Name = "rbDaThanhToan";
            this.rbDaThanhToan.Size = new System.Drawing.Size(104, 19);
            this.rbDaThanhToan.TabIndex = 8;
            this.rbDaThanhToan.TabStop = true;
            this.rbDaThanhToan.Text = "Đã thanh toán ";
            this.rbDaThanhToan.UseVisualStyleBackColor = true;
            this.rbDaThanhToan.CheckedChanged += new System.EventHandler(this.rbDaThanhToan_CheckedChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources._checked;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Location = new System.Drawing.Point(178, 15);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(59, 58);
            this.btnThanhToan.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnThanhToan, "Thanh toán công thợ sửa");
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvDanhSachSua
            // 
            this.dgvDanhSachSua.AllowUserToAddRows = false;
            this.dgvDanhSachSua.AllowUserToDeleteRows = false;
            this.dgvDanhSachSua.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhSachSua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.maSua,
            this.maPhi,
            this.tenKhachHang,
            this.PhiSua,
            this.noiDungSua,
            this.anhDaiDien,
            this.tenNhanVien,
            this.ngaySuaXong});
            this.dgvDanhSachSua.EnableHeadersVisualStyles = false;
            this.dgvDanhSachSua.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDanhSachSua.Location = new System.Drawing.Point(8, 77);
            this.dgvDanhSachSua.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachSua.Name = "dgvDanhSachSua";
            this.dgvDanhSachSua.ReadOnly = true;
            this.dgvDanhSachSua.Size = new System.Drawing.Size(686, 194);
            this.dgvDanhSachSua.TabIndex = 0;
            this.dgvDanhSachSua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSua_CellContentClick);
            this.dgvDanhSachSua.Click += new System.EventHandler(this.dgvDanhSachSua_Click);
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
            // maSua
            // 
            this.maSua.DataPropertyName = "maSua";
            this.maSua.HeaderText = "ma sua";
            this.maSua.Name = "maSua";
            this.maSua.ReadOnly = true;
            this.maSua.Visible = false;
            // 
            // maPhi
            // 
            this.maPhi.DataPropertyName = "maPhi";
            this.maPhi.HeaderText = "ma phi";
            this.maPhi.Name = "maPhi";
            this.maPhi.ReadOnly = true;
            this.maPhi.Visible = false;
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.DataPropertyName = "tenKhachHang";
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.Name = "tenKhachHang";
            this.tenKhachHang.ReadOnly = true;
            this.tenKhachHang.Width = 130;
            // 
            // PhiSua
            // 
            this.PhiSua.DataPropertyName = "PhiSua";
            this.PhiSua.HeaderText = "Tiền công";
            this.PhiSua.Name = "PhiSua";
            this.PhiSua.ReadOnly = true;
            // 
            // noiDungSua
            // 
            this.noiDungSua.DataPropertyName = "noiDungSua";
            this.noiDungSua.HeaderText = "Nội dung sửa";
            this.noiDungSua.Name = "noiDungSua";
            this.noiDungSua.ReadOnly = true;
            this.noiDungSua.Width = 150;
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
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Nhân viên sửa";
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Width = 120;
            // 
            // ngaySuaXong
            // 
            this.ngaySuaXong.DataPropertyName = "ngaySuaXong";
            this.ngaySuaXong.HeaderText = "Ngày sửa xong";
            this.ngaySuaXong.Name = "ngaySuaXong";
            this.ngaySuaXong.ReadOnly = true;
            this.ngaySuaXong.Width = 130;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmDanhSachSuaNgoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(894, 301);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDanhSachSuaNgoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách áo sửa ngoài chờ thanh toán";
            this.Load += new System.EventHandler(this.frmDanhSachSuaNgoai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbAo;
        private System.Windows.Forms.RadioButton rbChuaThanhToan;
        private System.Windows.Forms.RadioButton rbDaThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridView dgvDanhSachSua;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn noiDungSua;
        private System.Windows.Forms.DataGridViewImageColumn anhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySuaXong;
    }
}