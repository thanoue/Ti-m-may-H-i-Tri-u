namespace TiemMayHaiTrieu
{
    partial class frmCapNhatHeSoLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhatHeSoLuong));
            this.rbCat = new System.Windows.Forms.RadioButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.rbLuong = new System.Windows.Forms.RadioButton();
            this.rbMay = new System.Windows.Forms.RadioButton();
            this.btnXacNhanCapNhat = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbCatQuan = new System.Windows.Forms.RadioButton();
            this.rbMayQuan = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // rbCat
            // 
            this.rbCat.AutoSize = true;
            this.rbCat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbCat.Location = new System.Drawing.Point(12, 32);
            this.rbCat.Name = "rbCat";
            this.rbCat.Size = new System.Drawing.Size(85, 19);
            this.rbCat.TabIndex = 0;
            this.rbCat.Text = "Lương cắt :";
            this.rbCat.UseVisualStyleBackColor = true;
            this.rbCat.CheckedChanged += new System.EventHandler(this.rbCat_CheckedChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(149, 9);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(116, 22);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(149, 159);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(116, 22);
            this.txt6.TabIndex = 2;
            this.txt6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(149, 129);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(116, 22);
            this.txt5.TabIndex = 3;
            this.txt5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(149, 99);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(116, 22);
            this.txt4.TabIndex = 4;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(149, 69);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(116, 22);
            this.txt3.TabIndex = 5;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(149, 39);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(116, 22);
            this.txt2.TabIndex = 6;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // rbLuong
            // 
            this.rbLuong.AutoSize = true;
            this.rbLuong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLuong.Location = new System.Drawing.Point(12, 82);
            this.rbLuong.Name = "rbLuong";
            this.rbLuong.Size = new System.Drawing.Size(100, 19);
            this.rbLuong.TabIndex = 7;
            this.rbLuong.Text = "Lương luông :";
            this.rbLuong.UseVisualStyleBackColor = true;
            this.rbLuong.CheckedChanged += new System.EventHandler(this.rbLuong_CheckedChanged);
            // 
            // rbMay
            // 
            this.rbMay.AutoSize = true;
            this.rbMay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMay.Location = new System.Drawing.Point(12, 57);
            this.rbMay.Name = "rbMay";
            this.rbMay.Size = new System.Drawing.Size(91, 19);
            this.rbMay.TabIndex = 8;
            this.rbMay.Text = "Lương may :";
            this.rbMay.UseVisualStyleBackColor = true;
            this.rbMay.CheckedChanged += new System.EventHandler(this.rbMay_CheckedChanged);
            // 
            // btnXacNhanCapNhat
            // 
            this.btnXacNhanCapNhat.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources._checked;
            this.btnXacNhanCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXacNhanCapNhat.Enabled = false;
            this.btnXacNhanCapNhat.FlatAppearance.BorderSize = 0;
            this.btnXacNhanCapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXacNhanCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanCapNhat.Location = new System.Drawing.Point(271, 43);
            this.btnXacNhanCapNhat.Name = "btnXacNhanCapNhat";
            this.btnXacNhanCapNhat.Size = new System.Drawing.Size(47, 46);
            this.btnXacNhanCapNhat.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnXacNhanCapNhat, "Xác nhận đổi hệ số lương");
            this.btnXacNhanCapNhat.UseVisualStyleBackColor = true;
            this.btnXacNhanCapNhat.Click += new System.EventHandler(this.btnXacNhanCapNhat_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::TiemMayHaiTrieu.Properties.Resources.close;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(271, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 46);
            this.btnClear.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnClear, "Nhập lại ");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbCatQuan
            // 
            this.rbCatQuan.AutoSize = true;
            this.rbCatQuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbCatQuan.Location = new System.Drawing.Point(12, 107);
            this.rbCatQuan.Name = "rbCatQuan";
            this.rbCatQuan.Size = new System.Drawing.Size(115, 19);
            this.rbCatQuan.TabIndex = 11;
            this.rbCatQuan.Text = "Lương cắt quần :";
            this.rbCatQuan.UseVisualStyleBackColor = true;
            this.rbCatQuan.CheckedChanged += new System.EventHandler(this.rbCatQuan_CheckedChanged);
            // 
            // rbMayQuan
            // 
            this.rbMayQuan.AutoSize = true;
            this.rbMayQuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMayQuan.Location = new System.Drawing.Point(12, 132);
            this.rbMayQuan.Name = "rbMayQuan";
            this.rbMayQuan.Size = new System.Drawing.Size(121, 19);
            this.rbMayQuan.TabIndex = 12;
            this.rbMayQuan.Text = "Lương may quần :";
            this.rbMayQuan.UseVisualStyleBackColor = true;
            this.rbMayQuan.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // frmCapNhatHeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(331, 185);
            this.Controls.Add(this.rbMayQuan);
            this.Controls.Add(this.rbCatQuan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXacNhanCapNhat);
            this.Controls.Add(this.rbMay);
            this.Controls.Add(this.rbLuong);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.rbCat);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCapNhatHeSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật hệ số lương";
            this.Load += new System.EventHandler(this.frmCapNhatHeSoLuong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCat;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.RadioButton rbLuong;
        private System.Windows.Forms.RadioButton rbMay;
        private System.Windows.Forms.Button btnXacNhanCapNhat;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbCatQuan;
        private System.Windows.Forms.RadioButton rbMayQuan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}