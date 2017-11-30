namespace TiemMayHaiTrieu
{
    partial class frmChiTietThuTheoNgay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietThuTheoNgay));
            this.grAo = new System.Windows.Forms.GroupBox();
            this.dgvTongSLAo = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ao_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ao_tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongThuAo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ao_tongPhiMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ao_tongCongCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ao_tongCongQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ao_tongCongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ao_Phi_tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNgayDau = new System.Windows.Forms.Label();
            this.lbNgayCuoi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTongSLQuan = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTongThuQuan = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grAo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongSLAo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongThuAo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongSLQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongThuQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // grAo
            // 
            this.grAo.Controls.Add(this.dgvTongSLAo);
            this.grAo.Controls.Add(this.dgvTongThuAo);
            this.grAo.Location = new System.Drawing.Point(12, 32);
            this.grAo.Name = "grAo";
            this.grAo.Size = new System.Drawing.Size(936, 276);
            this.grAo.TabIndex = 0;
            this.grAo.TabStop = false;
            this.grAo.Text = "Áo";
            // 
            // dgvTongSLAo
            // 
            this.dgvTongSLAo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTongSLAo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTongSLAo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTongSLAo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongSLAo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Ao_soLuong,
            this.Ao_tinhTrang});
            this.dgvTongSLAo.Location = new System.Drawing.Point(625, 21);
            this.dgvTongSLAo.Name = "dgvTongSLAo";
            this.dgvTongSLAo.Size = new System.Drawing.Size(291, 233);
            this.dgvTongSLAo.TabIndex = 21;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 30;
            // 
            // Ao_soLuong
            // 
            this.Ao_soLuong.DataPropertyName = "soLuong";
            this.Ao_soLuong.HeaderText = "Số lượng";
            this.Ao_soLuong.Name = "Ao_soLuong";
            // 
            // Ao_tinhTrang
            // 
            this.Ao_tinhTrang.DataPropertyName = "tinhTrang";
            this.Ao_tinhTrang.HeaderText = "Tình trạng";
            this.Ao_tinhTrang.Name = "Ao_tinhTrang";
            // 
            // dgvTongThuAo
            // 
            this.dgvTongThuAo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTongThuAo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTongThuAo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTongThuAo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongThuAo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Ao_tongPhiMay,
            this.Ao_tongCongCat,
            this.Ao_tongCongQuan,
            this.Ao_tongCongLuong,
            this.Ao_Phi_tinhTrang});
            this.dgvTongThuAo.Location = new System.Drawing.Point(17, 21);
            this.dgvTongThuAo.Name = "dgvTongThuAo";
            this.dgvTongThuAo.Size = new System.Drawing.Size(586, 233);
            this.dgvTongThuAo.TabIndex = 20;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Ao_tongPhiMay
            // 
            this.Ao_tongPhiMay.DataPropertyName = "tongPhiMay";
            this.Ao_tongPhiMay.HeaderText = "Tổng phí may";
            this.Ao_tongPhiMay.Name = "Ao_tongPhiMay";
            // 
            // Ao_tongCongCat
            // 
            this.Ao_tongCongCat.DataPropertyName = "tongCongCat";
            this.Ao_tongCongCat.HeaderText = "Tổng công cắt";
            this.Ao_tongCongCat.Name = "Ao_tongCongCat";
            // 
            // Ao_tongCongQuan
            // 
            this.Ao_tongCongQuan.DataPropertyName = "tongCongMay";
            this.Ao_tongCongQuan.HeaderText = "Tổng công may";
            this.Ao_tongCongQuan.Name = "Ao_tongCongQuan";
            // 
            // Ao_tongCongLuong
            // 
            this.Ao_tongCongLuong.DataPropertyName = "tongCongLuong";
            this.Ao_tongCongLuong.HeaderText = "Tổng công luông";
            this.Ao_tongCongLuong.Name = "Ao_tongCongLuong";
            // 
            // Ao_Phi_tinhTrang
            // 
            this.Ao_Phi_tinhTrang.DataPropertyName = "tinhTrang";
            this.Ao_Phi_tinhTrang.HeaderText = "Tình trạng";
            this.Ao_Phi_tinhTrang.Name = "Ao_Phi_tinhTrang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến ngày :";
            // 
            // lbNgayDau
            // 
            this.lbNgayDau.AutoSize = true;
            this.lbNgayDau.Location = new System.Drawing.Point(311, 14);
            this.lbNgayDau.Name = "lbNgayDau";
            this.lbNgayDau.Size = new System.Drawing.Size(112, 15);
            this.lbNgayDau.TabIndex = 3;
            this.lbNgayDau.Text = "...................................";
            // 
            // lbNgayCuoi
            // 
            this.lbNgayCuoi.AutoSize = true;
            this.lbNgayCuoi.Location = new System.Drawing.Point(536, 15);
            this.lbNgayCuoi.Name = "lbNgayCuoi";
            this.lbNgayCuoi.Size = new System.Drawing.Size(112, 15);
            this.lbNgayCuoi.TabIndex = 4;
            this.lbNgayCuoi.Text = "...................................";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTongSLQuan);
            this.groupBox1.Controls.Add(this.dgvTongThuQuan);
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 276);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quần";
            // 
            // dgvTongSLQuan
            // 
            this.dgvTongSLQuan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTongSLQuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTongSLQuan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTongSLQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongSLQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTongSLQuan.Location = new System.Drawing.Point(625, 21);
            this.dgvTongSLQuan.Name = "dgvTongSLQuan";
            this.dgvTongSLQuan.Size = new System.Drawing.Size(291, 233);
            this.dgvTongSLQuan.TabIndex = 22;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "soLuong";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tinhTrang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dgvTongThuQuan
            // 
            this.dgvTongThuQuan.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvTongThuQuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTongThuQuan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvTongThuQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongThuQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn3,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn19});
            this.dgvTongThuQuan.Location = new System.Drawing.Point(17, 21);
            this.dgvTongThuQuan.Name = "dgvTongThuQuan";
            this.dgvTongThuQuan.Size = new System.Drawing.Size(586, 233);
            this.dgvTongThuQuan.TabIndex = 22;
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewButtonColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewButtonColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn3.HeaderText = "";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.Width = 30;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "tongPhiMay";
            this.dataGridViewTextBoxColumn15.HeaderText = "Tổng phí may";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 120;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "tongCongCat";
            this.dataGridViewTextBoxColumn16.HeaderText = "Tổng công cắt";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "tongCongMay";
            this.dataGridViewTextBoxColumn17.HeaderText = "Tổng công may";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 120;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "tinhTrang";
            this.dataGridViewTextBoxColumn19.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 120;
            // 
            // frmChiTietThuTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(960, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNgayCuoi);
            this.Controls.Add(this.lbNgayDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grAo);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChiTietThuTheoNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết thu theo ngày";
            this.Load += new System.EventHandler(this.frmChiTietThuTheoNgay_Load);
            this.grAo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongSLAo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongThuAo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongSLQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongThuQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grAo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNgayDau;
        private System.Windows.Forms.Label lbNgayCuoi;
        private System.Windows.Forms.DataGridView dgvTongSLAo;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_tinhTrang;
        private System.Windows.Forms.DataGridView dgvTongThuAo;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_tongPhiMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_tongCongCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_tongCongQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_tongCongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ao_Phi_tinhTrang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTongSLQuan;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvTongThuQuan;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}