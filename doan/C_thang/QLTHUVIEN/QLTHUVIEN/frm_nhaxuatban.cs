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
    public partial class Formnhaxb : Form
    {
        public Formnhaxb()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from nhaxb");

            if (dt != null)
            {
                dt_nhaxuatban.DataSource = dt;
            }
            dt_nhaxuatban.Columns[0].HeaderText = "Mã nhà XB";
            dt_nhaxuatban.Columns[1].HeaderText = "Tên nhà XB";
            dt_nhaxuatban.Columns[2].HeaderText = "Địa chỉ";
            dt_nhaxuatban.Columns[3].HeaderText = "Điện thoại";
            dt_nhaxuatban.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            dt_nhaxuatban.Enabled = true;

        }
        private void Formnhaxb_Load(object sender, EventArgs e)
        {
            loaddata();

        }

        private void dt_nhaxuatban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_nhaxuatban_SelectionChanged(object sender, EventArgs e)
        {
            txt_manhaxb.Text = dt_nhaxuatban.CurrentRow.Cells[0].Value.ToString();
            txt_tennhaxb.Text = dt_nhaxuatban.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = dt_nhaxuatban.CurrentRow.Cells[2].Value.ToString();
            txt_phone.Text = dt_nhaxuatban.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_manhaxb.Text = "";
            txt_tennhaxb.Text = "";
            txt_diachi.Text = "";
            txt_phone.Text = "";
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            dt_nhaxuatban.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_manhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà xuất bản");
                txt_manhaxb.Focus();

            }else if (txt_tennhaxb.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà xuất bản");
                txt_tennhaxb.Focus();


            }else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txt_diachi.Focus();


            }
            else if (txt_phone.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txt_phone.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO nhaxb VALUES (N'" + txt_manhaxb.Text + "','" + txt_tennhaxb.Text + "','" + txt_diachi.Text + "','" + txt_phone.Text +  "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
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
                dt_nhaxuatban.Enabled = true;


            }
            else
            {


                if (txt_tennhaxb.Text == "")
                {
                    MessageBox.Show("Nhà xuất bản chưa có thông tin");
                    txt_tennhaxb.Focus();

                }
                else if (txt_diachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txt_diachi.Focus();


                }
                else if (t.thucthidulieu("update  nhaxb set tennxb=N'" + txt_tennhaxb.Text + "', diachi=N'" + txt_diachi.Text + "', dienthoai='" + txt_phone.Text + "'where manxb=N'" + txt_manhaxb.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void xoa_Click(object sender, EventArgs e)
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
                dt_nhaxuatban.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txt_manhaxb.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from nhaxb where manxb='" + txt_manhaxb.Text + "'")==true)
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

        private void txt_manhaxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
