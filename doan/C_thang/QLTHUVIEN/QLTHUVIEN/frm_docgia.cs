using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_docgia : Form
    {
        public frm_docgia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void Formdocgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            lb_tongdocgia.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dt_docgia.DataSource = dt;
            }
            dt_docgia.Columns[0].HeaderText = "Mã độc giả";
            dt_docgia.Columns[1].HeaderText = "Họ và tên";
            dt_docgia.Columns[2].HeaderText = "Ngày sinh";
            dt_docgia.Columns[3].HeaderText = "Giới tính";
            dt_docgia.Columns[4].HeaderText = "Lớp";
            


            dt_docgia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            dt_docgia.Enabled = true;

        }

        private void dt_luoi_SelectionChanged(object sender, EventArgs e)
        {
            txt_madocgia.Text = dt_docgia.CurrentRow.Cells[0].Value.ToString();
            txt_tendocgia.Text = dt_docgia.CurrentRow.Cells[1].Value.ToString();
            dt_ngaysinh.Text = dt_docgia.CurrentRow.Cells[2].Value.ToString();
            ComboBox_gioitinh.Text = dt_docgia.CurrentRow.Cells[3].Value.ToString();
            txt_lop.Text = dt_docgia.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_madocgia.Text = "";
            txt_tendocgia.Text = "";
           
            btn_luu.Enabled = true;
            //sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            dt_docgia.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ngayhh = dt_ngaysinh.Value.ToString("yyyy/MM/dd");
            if (txt_madocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                txt_madocgia.Focus();

            }
            else if (txt_tendocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên độc giả");
                txt_tendocgia.Focus();


            }
            else if (txt_lop.Text == "")
            {
                MessageBox.Show("Chưa nhập lớp");
                txt_lop.Focus();


            }

            else if (t.thucthidulieu("INSERT INTO docgia VALUES (N'" + txt_madocgia.Text + "',N'" + txt_tendocgia.Text + "','" + ngayhh + "',N'" + ComboBox_gioitinh.Text + "',N'" + txt_lop.Text +"')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");



                txt_madocgia.Focus();

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string ngayhh = dt_ngaysinh.Value.ToString("yyyy/MM/dd");

            if (btn_sua.Text == "hủy")
            {
                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoa.Text = "Xóa";
                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                loaddata();
                dt_docgia.Enabled = true;
            }
            else
            {

                if (txt_tendocgia.Text == "")
                {
                    txt_tendocgia.Focus();

                }
                else if (txt_lop.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txt_lop.Focus();


                }
                else if (t.thucthidulieu("update docgia set hoten=N'" + txt_tendocgia.Text + "', ngaysinh=N'" + ngayhh + "', gioitinh=N'" + ComboBox_gioitinh.Text + "', thongtin='" + txt_lop.Text + "'where madg =N'" + txt_madocgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (btn_xoa.Text == "hủy")
            {

                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoa.Text = "Xóa";
                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                loaddata();
                dt_docgia.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txt_madocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from docgia where madg ='" + txt_madocgia.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");


                
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void label_capnhatthongtintacgia_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
