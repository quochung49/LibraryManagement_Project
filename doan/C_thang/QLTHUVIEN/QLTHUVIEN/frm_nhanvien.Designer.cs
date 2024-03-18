namespace WindowsFormsApplication1
{
    partial class frm_nhanvien
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
            this.groupBox_bangnhanvien = new System.Windows.Forms.GroupBox();
            this.l = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_tongsonhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox_bangnhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tongsonhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_bangnhanvien
            // 
            this.groupBox_bangnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox_bangnhanvien.Controls.Add(this.l);
            this.groupBox_bangnhanvien.Controls.Add(this.label8);
            this.groupBox_bangnhanvien.Controls.Add(this.ComboBox_gioitinh);
            this.groupBox_bangnhanvien.Controls.Add(this.label7);
            this.groupBox_bangnhanvien.Controls.Add(this.btn_luu);
            this.groupBox_bangnhanvien.Controls.Add(this.btn_thoat);
            this.groupBox_bangnhanvien.Controls.Add(this.btn_xoa);
            this.groupBox_bangnhanvien.Controls.Add(this.btn_sua);
            this.groupBox_bangnhanvien.Controls.Add(this.btn_them);
            this.groupBox_bangnhanvien.Controls.Add(this.txt_dienthoai);
            this.groupBox_bangnhanvien.Controls.Add(this.label6);
            this.groupBox_bangnhanvien.Controls.Add(this.dt_ngaysinh);
            this.groupBox_bangnhanvien.Controls.Add(this.txt_diachi);
            this.groupBox_bangnhanvien.Controls.Add(this.label5);
            this.groupBox_bangnhanvien.Controls.Add(this.label4);
            this.groupBox_bangnhanvien.Controls.Add(this.txt_tennhanvien);
            this.groupBox_bangnhanvien.Controls.Add(this.label3);
            this.groupBox_bangnhanvien.Controls.Add(this.txt_manhanvien);
            this.groupBox_bangnhanvien.Controls.Add(this.label2);
            this.groupBox_bangnhanvien.Location = new System.Drawing.Point(46, 91);
            this.groupBox_bangnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_bangnhanvien.Name = "groupBox_bangnhanvien";
            this.groupBox_bangnhanvien.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_bangnhanvien.Size = new System.Drawing.Size(799, 385);
            this.groupBox_bangnhanvien.TabIndex = 0;
            this.groupBox_bangnhanvien.TabStop = false;
            this.groupBox_bangnhanvien.Text = "Cập nhật thông tin";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(236, 362);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 16);
            this.l.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Tổng số nhân viên";
            // 
            // ComboBox_gioitinh
            // 
            this.ComboBox_gioitinh.FormattingEnabled = true;
            this.ComboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.ComboBox_gioitinh.Location = new System.Drawing.Point(240, 195);
            this.ComboBox_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_gioitinh.Name = "ComboBox_gioitinh";
            this.ComboBox_gioitinh.Size = new System.Drawing.Size(103, 24);
            this.ComboBox_gioitinh.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(71, 192);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Giới tính";
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(579, 241);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 38);
            this.btn_luu.TabIndex = 41;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(579, 312);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 38);
            this.btn_thoat.TabIndex = 40;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(579, 160);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 38);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(579, 96);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 36);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(579, 24);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 36);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(240, 299);
            this.txt_dienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(231, 22);
            this.txt_dienthoai.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(71, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại";
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(240, 145);
            this.dt_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(231, 22);
            this.dt_ngaysinh.TabIndex = 7;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(240, 248);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(231, 22);
            this.txt_diachi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(71, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(71, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Location = new System.Drawing.Point(240, 96);
            this.txt_tennhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(231, 22);
            this.txt_tennhanvien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(240, 40);
            this.txt_manhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(231, 22);
            this.txt_manhanvien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(64, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cập Nhật Thông Tin Nhân Viên";
            // 
            // dt_tongsonhanvien
            // 
            this.dt_tongsonhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_tongsonhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_tongsonhanvien.Location = new System.Drawing.Point(41, 484);
            this.dt_tongsonhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dt_tongsonhanvien.Name = "dt_tongsonhanvien";
            this.dt_tongsonhanvien.RowHeadersWidth = 51;
            this.dt_tongsonhanvien.Size = new System.Drawing.Size(804, 189);
            this.dt_tongsonhanvien.TabIndex = 24;
            this.dt_tongsonhanvien.SelectionChanged += new System.EventHandler(this.dt_tongsonhanvien_SelectionChanged);
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(890, 675);
            this.Controls.Add(this.dt_tongsonhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_bangnhanvien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_nhanvien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Formnhanvien_Load);
            this.groupBox_bangnhanvien.ResumeLayout(false);
            this.groupBox_bangnhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tongsonhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_bangnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dt_tongsonhanvien;
        private System.Windows.Forms.ComboBox ComboBox_gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label8;
    }
}