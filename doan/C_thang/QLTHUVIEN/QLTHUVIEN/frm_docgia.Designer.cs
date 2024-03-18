namespace WindowsFormsApplication1
{
    partial class frm_docgia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.label_gioitinh = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txt_lop = new System.Windows.Forms.TextBox();
            this.label_lop = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.txt_tendocgia = new System.Windows.Forms.TextBox();
            this.label_hovaten = new System.Windows.Forms.Label();
            this.txt_madocgia = new System.Windows.Forms.TextBox();
            this.label_madocgia = new System.Windows.Forms.Label();
            this.label_capnhatthongtintacgia = new System.Windows.Forms.Label();
            this.dt_docgia = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_tongdocgia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_docgia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBox_gioitinh);
            this.groupBox1.Controls.Add(this.label_gioitinh);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.dt_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_lop);
            this.groupBox1.Controls.Add(this.label_lop);
            this.groupBox1.Controls.Add(this.label_ngaysinh);
            this.groupBox1.Controls.Add(this.txt_tendocgia);
            this.groupBox1.Controls.Add(this.label_hovaten);
            this.groupBox1.Controls.Add(this.txt_madocgia);
            this.groupBox1.Controls.Add(this.label_madocgia);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật thông tin";
            // 
            // ComboBox_gioitinh
            // 
            this.ComboBox_gioitinh.FormattingEnabled = true;
            this.ComboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.ComboBox_gioitinh.Location = new System.Drawing.Point(180, 158);
            this.ComboBox_gioitinh.Name = "ComboBox_gioitinh";
            this.ComboBox_gioitinh.Size = new System.Drawing.Size(78, 21);
            this.ComboBox_gioitinh.TabIndex = 43;
            // 
            // label_gioitinh
            // 
            this.label_gioitinh.AutoSize = true;
            this.label_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_gioitinh.Location = new System.Drawing.Point(53, 156);
            this.label_gioitinh.Name = "label_gioitinh";
            this.label_gioitinh.Size = new System.Drawing.Size(76, 20);
            this.label_gioitinh.TabIndex = 42;
            this.label_gioitinh.Text = "Giới tính";
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(434, 158);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 31);
            this.btn_luu.TabIndex = 41;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(434, 202);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 31);
            this.btn_thoat.TabIndex = 40;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(434, 111);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 31);
            this.btn_xoa.TabIndex = 39;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(434, 65);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 29);
            this.btn_sua.TabIndex = 38;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(434, 20);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(73, 29);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaysinh.Location = new System.Drawing.Point(180, 118);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(174, 20);
            this.dt_ngaysinh.TabIndex = 7;
            // 
            // txt_lop
            // 
            this.txt_lop.Location = new System.Drawing.Point(180, 202);
            this.txt_lop.Name = "txt_lop";
            this.txt_lop.Size = new System.Drawing.Size(174, 20);
            this.txt_lop.TabIndex = 6;
            // 
            // label_lop
            // 
            this.label_lop.AutoSize = true;
            this.label_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_lop.Location = new System.Drawing.Point(53, 200);
            this.label_lop.Name = "label_lop";
            this.label_lop.Size = new System.Drawing.Size(39, 20);
            this.label_lop.TabIndex = 5;
            this.label_lop.Text = "Lớp";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_ngaysinh.Location = new System.Drawing.Point(53, 118);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(87, 20);
            this.label_ngaysinh.TabIndex = 4;
            this.label_ngaysinh.Text = "Ngày sinh";
            // 
            // txt_tendocgia
            // 
            this.txt_tendocgia.Location = new System.Drawing.Point(180, 78);
            this.txt_tendocgia.Name = "txt_tendocgia";
            this.txt_tendocgia.Size = new System.Drawing.Size(174, 20);
            this.txt_tendocgia.TabIndex = 3;
            // 
            // label_hovaten
            // 
            this.label_hovaten.AutoSize = true;
            this.label_hovaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_hovaten.Location = new System.Drawing.Point(53, 78);
            this.label_hovaten.Name = "label_hovaten";
            this.label_hovaten.Size = new System.Drawing.Size(86, 20);
            this.label_hovaten.TabIndex = 2;
            this.label_hovaten.Text = "Họ và tên";
            // 
            // txt_madocgia
            // 
            this.txt_madocgia.Location = new System.Drawing.Point(180, 32);
            this.txt_madocgia.Name = "txt_madocgia";
            this.txt_madocgia.Size = new System.Drawing.Size(174, 20);
            this.txt_madocgia.TabIndex = 1;
            // 
            // label_madocgia
            // 
            this.label_madocgia.AutoSize = true;
            this.label_madocgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_madocgia.Location = new System.Drawing.Point(48, 32);
            this.label_madocgia.Name = "label_madocgia";
            this.label_madocgia.Size = new System.Drawing.Size(96, 20);
            this.label_madocgia.TabIndex = 0;
            this.label_madocgia.Text = "Mã độc giả";
            // 
            // label_capnhatthongtintacgia
            // 
            this.label_capnhatthongtintacgia.AutoSize = true;
            this.label_capnhatthongtintacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_capnhatthongtintacgia.ForeColor = System.Drawing.Color.Red;
            this.label_capnhatthongtintacgia.Location = new System.Drawing.Point(75, 22);
            this.label_capnhatthongtintacgia.Name = "label_capnhatthongtintacgia";
            this.label_capnhatthongtintacgia.Size = new System.Drawing.Size(458, 31);
            this.label_capnhatthongtintacgia.TabIndex = 2;
            this.label_capnhatthongtintacgia.Text = "CẬP NHẬT THÔNG TIN ĐỘC GIẢ";
            this.label_capnhatthongtintacgia.Click += new System.EventHandler(this.label_capnhatthongtintacgia_Click);
            // 
            // dt_docgia
            // 
            this.dt_docgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_docgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_docgia.Location = new System.Drawing.Point(12, 325);
            this.dt_docgia.Name = "dt_docgia";
            this.dt_docgia.RowHeadersWidth = 51;
            this.dt_docgia.Size = new System.Drawing.Size(565, 199);
            this.dt_docgia.TabIndex = 25;
            this.dt_docgia.SelectionChanged += new System.EventHandler(this.dt_luoi_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tổng số độc giả";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_tongdocgia
            // 
            this.lb_tongdocgia.AutoSize = true;
            this.lb_tongdocgia.Location = new System.Drawing.Point(108, 309);
            this.lb_tongdocgia.Name = "lb_tongdocgia";
            this.lb_tongdocgia.Size = new System.Drawing.Size(0, 13);
            this.lb_tongdocgia.TabIndex = 27;
            // 
            // frm_docgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(605, 548);
            this.Controls.Add(this.lb_tongdocgia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_docgia);
            this.Controls.Add(this.label_capnhatthongtintacgia);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_docgia";
            this.Text = "docgia";
            this.Load += new System.EventHandler(this.Formdocgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_docgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBox_gioitinh;
        private System.Windows.Forms.Label label_gioitinh;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.TextBox txt_lop;
        private System.Windows.Forms.Label label_lop;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.TextBox txt_tendocgia;
        private System.Windows.Forms.Label label_hovaten;
        private System.Windows.Forms.TextBox txt_madocgia;
        private System.Windows.Forms.Label label_madocgia;
        private System.Windows.Forms.Label label_capnhatthongtintacgia;
        private System.Windows.Forms.DataGridView dt_docgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_tongdocgia;
    }
}