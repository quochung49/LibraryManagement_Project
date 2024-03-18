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
    public partial class Formtacgia : Form
    {
        public Formtacgia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tacgia");

            if (dt != null)
            {
                dt_tacgia.DataSource = dt;
            }
            dt_tacgia.Columns[0].HeaderText = "Mã tác giả";
            dt_tacgia.Columns[1].HeaderText = "Tên tác giả";
            dt_tacgia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells); 
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            dt_tacgia.Enabled = true;

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();

        }
        private void dt_tacgia_SelectionChanged(object sender, EventArgs e)
        {
            txt_matacgia.Text = dt_tacgia.CurrentRow.Cells[0].Value.ToString();
            txt_tentacgia.Text = dt_tacgia.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_matacgia.Text = "";
            txt_tentacgia.Text = "";
            btn_luu.Enabled = true;
            //sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            dt_tacgia.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "hủy")
            {
                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoa.Text = "Xóa";
                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                loaddata();
                dt_tacgia.Enabled = true;


            }
            else
            {
               

                if (txt_matacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã tác giả");
                    txt_matacgia.Focus();

                }
                else if (txt_tentacgia.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    txt_tentacgia.Focus();


                }
                else if (t.thucthidulieu("update  tacgia set tentacgia=N'" + txt_tentacgia.Text + "'where matacgia=N'" + txt_matacgia.Text + "'") == true)
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
                dt_tacgia.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txt_matacgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                       if ( t.thucthidulieu("delete from tacgia where matacgia='" + txt_matacgia.Text + "'")==true)
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                       else MessageBox.Show("Không thể xóa", "Thông báo");
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

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_matacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã tác giả");
                txt_matacgia.Focus();

            }
            else if (txt_tentacgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tác giả");
                txt_tentacgia.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO tacgia VALUES (N'" + txt_matacgia.Text + "', '" + txt_tentacgia.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_matacgia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
