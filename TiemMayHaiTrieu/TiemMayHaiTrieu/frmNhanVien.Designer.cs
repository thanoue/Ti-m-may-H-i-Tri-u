namespace TiemMayHaiTrieu
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoiAnhNV = new System.Windows.Forms.Button();
            this.btXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.cbLoaiNV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAnhDaiDienNV = new System.Windows.Forms.PictureBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDienNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnDoiAnhNV);
            this.groupBox1.Controls.Add(this.btXoaNV);
            this.groupBox1.Controls.Add(this.btnSuaNV);
            this.groupBox1.Controls.Add(this.cbLoaiNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDTNhanVien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pbAnhDaiDienNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên :";
            // 
            // btnDoiAnhNV
            // 
            this.btnDoiAnhNV.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.choose_image;
            this.btnDoiAnhNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoiAnhNV.FlatAppearance.BorderSize = 0;
            this.btnDoiAnhNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnDoiAnhNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDoiAnhNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiAnhNV.Location = new System.Drawing.Point(133, 19);
            this.btnDoiAnhNV.Name = "btnDoiAnhNV";
            this.btnDoiAnhNV.Size = new System.Drawing.Size(40, 40);
            this.btnDoiAnhNV.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnDoiAnhNV, "Cập nhật ảnh đại diện ");
            this.btnDoiAnhNV.UseVisualStyleBackColor = true;
            this.btnDoiAnhNV.Click += new System.EventHandler(this.btnDoiAnhNV_Click);
            // 
            // btXoaNV
            // 
            this.btXoaNV.BackColor = System.Drawing.Color.Transparent;
            this.btXoaNV.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.delete;
            this.btXoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaNV.FlatAppearance.BorderSize = 0;
            this.btXoaNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btXoaNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaNV.Location = new System.Drawing.Point(498, 46);
            this.btXoaNV.Name = "btXoaNV";
            this.btXoaNV.Size = new System.Drawing.Size(54, 54);
            this.btXoaNV.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btXoaNV, "Xóa nhân viên");
            this.btXoaNV.UseVisualStyleBackColor = false;
            this.btXoaNV.Click += new System.EventHandler(this.btXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaNV.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.edit;
            this.btnSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSuaNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.Location = new System.Drawing.Point(438, 46);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(54, 54);
            this.btnSuaNV.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnSuaNV, "Sửa thông tin nhân viên ");
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // cbLoaiNV
            // 
            this.cbLoaiNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiNV.FormattingEnabled = true;
            this.cbLoaiNV.Location = new System.Drawing.Point(278, 94);
            this.cbLoaiNV.Name = "cbLoaiNV";
            this.cbLoaiNV.Size = new System.Drawing.Size(142, 27);
            this.cbLoaiNV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(166, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Loại nhân viên :";
            // 
            // txtSDTNhanVien
            // 
            this.txtSDTNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDTNhanVien.Location = new System.Drawing.Point(278, 59);
            this.txtSDTNhanVien.Name = "txtSDTNhanVien";
            this.txtSDTNhanVien.Size = new System.Drawing.Size(142, 26);
            this.txtSDTNhanVien.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(174, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.Location = new System.Drawing.Point(278, 27);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(142, 26);
            this.txtTenNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(212, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên :";
            // 
            // pbAnhDaiDienNV
            // 
            this.pbAnhDaiDienNV.BackColor = System.Drawing.Color.Transparent;
            this.pbAnhDaiDienNV.Location = new System.Drawing.Point(6, 19);
            this.pbAnhDaiDienNV.Name = "pbAnhDaiDienNV";
            this.pbAnhDaiDienNV.Size = new System.Drawing.Size(121, 153);
            this.pbAnhDaiDienNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnhDaiDienNV.TabIndex = 0;
            this.pbAnhDaiDienNV.TabStop = false;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNV.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.add;
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnThemNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Location = new System.Drawing.Point(560, 36);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(54, 54);
            this.btnThemNV.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnThemNV, "Thêm nhân viên mới");
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.tenNhanVien,
            this.loaiNhanVien,
            this.soDienThoai,
            this.anhDaiDien,
            this.Id,
            this.Id1});
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvNhanVien.Location = new System.Drawing.Point(22, 36);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.ShowCellToolTips = false;
            this.dgvNhanVien.Size = new System.Drawing.Size(532, 187);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // loaiNhanVien
            // 
            this.loaiNhanVien.DataPropertyName = "tenLoaiNhanVien";
            this.loaiNhanVien.HeaderText = "Loại NV";
            this.loaiNhanVien.Name = "loaiNhanVien";
            this.loaiNhanVien.ReadOnly = true;
            this.loaiNhanVien.Width = 150;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            this.soDienThoai.Width = 150;
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "mã nv";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Id1
            // 
            this.Id1.DataPropertyName = "maLoaiNhanVien";
            this.Id1.HeaderText = "Column1";
            this.Id1.Name = "Id1";
            this.Id1.ReadOnly = true;
            this.Id1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 245);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên :";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(652, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên ";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhDaiDienNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnDoiAnhNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.ComboBox cbLoaiNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAnhDaiDienNV;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewImageColumn anhDaiDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
    }
}