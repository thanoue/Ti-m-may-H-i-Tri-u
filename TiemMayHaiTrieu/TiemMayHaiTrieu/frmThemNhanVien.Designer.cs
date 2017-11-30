namespace TiemMayHaiTrieu
{
    partial class frmThemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhanVien));
            this.gbThemNV = new System.Windows.Forms.GroupBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.cbLoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLayAnhNV = new System.Windows.Forms.Button();
            this.pbLayAnhNV = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbThemNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayAnhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThemNV
            // 
            this.gbThemNV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbThemNV.Controls.Add(this.btnThemNV);
            this.gbThemNV.Controls.Add(this.cbLoaiNhanVien);
            this.gbThemNV.Controls.Add(this.label3);
            this.gbThemNV.Controls.Add(this.txtSDT);
            this.gbThemNV.Controls.Add(this.label2);
            this.gbThemNV.Controls.Add(this.txtTenNV);
            this.gbThemNV.Controls.Add(this.label1);
            this.gbThemNV.Controls.Add(this.btnLayAnhNV);
            this.gbThemNV.Controls.Add(this.pbLayAnhNV);
            this.gbThemNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbThemNV.Location = new System.Drawing.Point(12, 13);
            this.gbThemNV.Name = "gbThemNV";
            this.gbThemNV.Size = new System.Drawing.Size(584, 161);
            this.gbThemNV.TabIndex = 0;
            this.gbThemNV.TabStop = false;
            this.gbThemNV.Text = "Nhập thông tin NV :";
            this.gbThemNV.Enter += new System.EventHandler(this.gbThemNV_Enter);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNV.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.add;
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemNV.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.Location = new System.Drawing.Point(443, 39);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(98, 94);
            this.btnThemNV.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnThemNV, "Thêm nhân viên");
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // cbLoaiNhanVien
            // 
            this.cbLoaiNhanVien.FormattingEnabled = true;
            this.cbLoaiNhanVien.Location = new System.Drawing.Point(259, 106);
            this.cbLoaiNhanVien.Name = "cbLoaiNhanVien";
            this.cbLoaiNhanVien.Size = new System.Drawing.Size(165, 27);
            this.cbLoaiNhanVien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(138, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loại nhân viên :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(259, 74);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(165, 26);
            this.txtSDT.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(151, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số điện thoại :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(258, 42);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(166, 26);
            this.txtTenNV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(172, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và tên :";
            // 
            // btnLayAnhNV
            // 
            this.btnLayAnhNV.BackColor = System.Drawing.Color.Transparent;
            this.btnLayAnhNV.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.choose_image;
            this.btnLayAnhNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLayAnhNV.FlatAppearance.BorderSize = 0;
            this.btnLayAnhNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLayAnhNV.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLayAnhNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayAnhNV.Location = new System.Drawing.Point(119, 20);
            this.btnLayAnhNV.Name = "btnLayAnhNV";
            this.btnLayAnhNV.Size = new System.Drawing.Size(30, 30);
            this.btnLayAnhNV.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnLayAnhNV, "Chọn ảnh đại diện");
            this.btnLayAnhNV.UseVisualStyleBackColor = false;
            this.btnLayAnhNV.Click += new System.EventHandler(this.btnLayAnhNV_Click);
            // 
            // pbLayAnhNV
            // 
            this.pbLayAnhNV.Location = new System.Drawing.Point(6, 20);
            this.pbLayAnhNV.Name = "pbLayAnhNV";
            this.pbLayAnhNV.Size = new System.Drawing.Size(107, 130);
            this.pbLayAnhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLayAnhNV.TabIndex = 0;
            this.pbLayAnhNV.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(608, 183);
            this.Controls.Add(this.gbThemNV);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên vào hệ thống";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.gbThemNV.ResumeLayout(false);
            this.gbThemNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLayAnhNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThemNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.ComboBox cbLoaiNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLayAnhNV;
        private System.Windows.Forms.PictureBox pbLayAnhNV;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}