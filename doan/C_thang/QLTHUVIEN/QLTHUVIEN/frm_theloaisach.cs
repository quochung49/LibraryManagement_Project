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
    public partial class theloaisach : Form
    {
        public theloaisach()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from theloai");
           
            if (dt != null)
            {
                dt_theloaisach.DataSource = dt;
            }
            dt_theloaisach.Columns[0].HeaderText = "Mã thể loại";
            dt_theloaisach.Columns[1].HeaderText = "Tên thể loại";
            dt_theloaisach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells); 
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            dt_theloaisach.Enabled = true;

        }
        private void nhaxuatban_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dt_theloaisach_SelectionChanged(object sender, EventArgs e)
        {
            txt_matheloai.Text = dt_theloaisach.CurrentRow.Cells[0].Value.ToString();
            txt_tentheloai.Text = dt_theloaisach.CurrentRow.Cells[1].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_matheloai.Text = "";
            txt_tentheloai.Text = "";
            btn_luu.Enabled = true;
            //sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            dt_theloaisach.Enabled = false;

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
               dt_theloaisach.Enabled = true;


            }
            else
            {
                ///them.Enabled = false;
               /// sua.Text = "Cập nhật";
                ///xoa.Text = "hủy";

                if (txt_matheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại");
                    txt_matheloai.Focus();

                }
                else if (txt_tentheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên thể loại");
                    txt_tentheloai.Focus();


                }
                else if (t.thucthidulieu("update  theloai set tentheloai=N'" + txt_tentheloai.Text + "'where matheloai=N'" + txt_matheloai.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            
            
            }

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_matheloai.Text=="")
            {
                MessageBox.Show("Chưa nhập mã thể loại");
                txt_matheloai.Focus();

            }else if (txt_tentheloai.Text=="")
            {
                MessageBox.Show("Chưa nhập tên thể loại");
                txt_tentheloai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO theloai VALUES (N'" + txt_matheloai.Text + "', '" + txt_tentheloai.Text+ "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (btn_xoa.Text == "hủy") {

                btn_luu.Enabled = false;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_xoa.Text = "Xóa";
                btn_sua.Text = "Sửa";
                btn_them.Enabled = true;
                loaddata();
                dt_theloaisach.Enabled = true;




            }
            else {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txt_matheloai.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes) {
                    try
                    {

                        t.thucthidulieu("delete from theloai where matheloai='" + txt_matheloai.Text+"'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else  loaddata(); 
            
            
            
            
            
            }
            
            
            
            }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void txt_matheloai_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

