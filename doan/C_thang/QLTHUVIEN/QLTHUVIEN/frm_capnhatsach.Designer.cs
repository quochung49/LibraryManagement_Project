namespace WindowsFormsApplication1
{
    partial class frm_capnhatsach
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.ComboBox_matacgia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_theloai = new System.Windows.Forms.ComboBox();
            this.ComboBox_nhaxb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_namxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tensach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_masach = new System.Windows.Forms.TextBox();
            this.label1_masach = new System.Windows.Forms.Label();
            this.dt_capnhatsach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_capnhatsach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_thoat);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.ComboBox_matacgia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ComboBox_theloai);
            this.groupBox2.Controls.Add(this.ComboBox_nhaxb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_namxb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_tensach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_masach);
            this.groupBox2.Controls.Add(this.label1_masach);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(10, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1145, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sách";
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(613, 156);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 38);
            this.btn_luu.TabIndex = 36;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(774, 156);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 38);
            this.btn_thoat.TabIndex = 35;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(451, 156);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 38);
            this.btn_xoa.TabIndex = 34;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(279, 156);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 36);
            this.btn_sua.TabIndex = 33;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(135, 156);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 36);
            this.btn_them.TabIndex = 32;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // ComboBox_matacgia
            // 
            this.ComboBox_matacgia.FormattingEnabled = true;
            this.ComboBox_matacgia.Location = new System.Drawing.Point(868, 98);
            this.ComboBox_matacgia.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_matacgia.Name = "ComboBox_matacgia";
            this.ComboBox_matacgia.Size = new System.Drawing.Size(134, 33);
            this.ComboBox_matacgia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(721, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tác giả";
            // 
            // ComboBox_theloai
            // 
            this.ComboBox_theloai.FormattingEnabled = true;
            this.ComboBox_theloai.Location = new System.Drawing.Point(868, 41);
            this.ComboBox_theloai.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_theloai.Name = "ComboBox_theloai";
            this.ComboBox_theloai.Size = new System.Drawing.Size(134, 33);
            this.ComboBox_theloai.TabIndex = 9;
            this.ComboBox_theloai.SelectedIndexChanged += new System.EventHandler(this.comtheloai_SelectedIndexChanged);
            // 
            // ComboBox_nhaxb
            // 
            this.ComboBox_nhaxb.FormattingEnabled = true;
            this.ComboBox_nhaxb.Location = new System.Drawing.Point(519, 102);
            this.ComboBox_nhaxb.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox_nhaxb.Name = "ComboBox_nhaxb";
            this.ComboBox_nhaxb.Size = new System.Drawing.Size(160, 33);
            this.ComboBox_nhaxb.TabIndex = 7;
            this.ComboBox_nhaxb.SelectedIndexChanged += new System.EventHandler(this.ComboBox_nhaxb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(355, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(713, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thể loại";
            // 
            // txt_namxb
            // 
            this.txt_namxb.Location = new System.Drawing.Point(519, 46);
            this.txt_namxb.Margin = new System.Windows.Forms.Padding(4);
            this.txt_namxb.Name = "txt_namxb";
            this.txt_namxb.Size = new System.Drawing.Size(160, 30);
            this.txt_namxb.TabIndex = 5;
            this.txt_namxb.TextChanged += new System.EventHandler(this.txt_namxb_TextChanged);
            this.txt_namxb.Enter += new System.EventHandler(this.txtnamxb_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(343, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm xuất bản";
            // 
            // txt_tensach
            // 
            this.txt_tensach.Location = new System.Drawing.Point(147, 101);
            this.txt_tensach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tensach.Name = "txt_tensach";
            this.txt_tensach.Size = new System.Drawing.Size(163, 30);
            this.txt_tensach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách";
            // 
            // txt_masach
            // 
            this.txt_masach.Location = new System.Drawing.Point(147, 44);
            this.txt_masach.Margin = new System.Windows.Forms.Padding(4);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(163, 30);
            this.txt_masach.TabIndex = 1;
            this.txt_masach.TextChanged += new System.EventHandler(this.txt_masach_TextChanged);
            // 
            // label1_masach
            // 
            this.label1_masach.AutoSize = true;
            this.label1_masach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1_masach.Location = new System.Drawing.Point(20, 44);
            this.label1_masach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_masach.Name = "label1_masach";
            this.label1_masach.Size = new System.Drawing.Size(102, 29);
            this.label1_masach.TabIndex = 0;
            this.label1_masach.Text = "Mã sách";
            // 
            // dt_capnhatsach
            // 
            this.dt_capnhatsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_capnhatsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_capnhatsach.Location = new System.Drawing.Point(29, 387);
            this.dt_capnhatsach.Margin = new System.Windows.Forms.Padding(4);
            this.dt_capnhatsach.Name = "dt_capnhatsach";
            this.dt_capnhatsach.RowHeadersWidth = 51;
            this.dt_capnhatsach.Size = new System.Drawing.Size(1126, 214);
            this.dt_capnhatsach.TabIndex = 23;
            this.dt_capnhatsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_luoi_CellContentClick);
            this.dt_capnhatsach.SelectionChanged += new System.EventHandler(this.dt_capnhatsach_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cập Nhật Sách";
            // 
            // frm_capnhatsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1184, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_capnhatsach);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_capnhatsach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Formcapnhatsach_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_capnhatsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboBox_nhaxb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_namxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_masach;
        private System.Windows.Forms.Label label1_masach;
        private System.Windows.Forms.ComboBox ComboBox_theloai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_matacgia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dt_capnhatsach;
        private System.Windows.Forms.Label label1;
    }
}