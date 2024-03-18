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
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_manhanvien.Text = "";
            txt_tennhanvien.Text = "";
            txt_diachi.Text = "";
            txt_dienthoai.Text = "";
            btn_luu.Enabled = true;
            //sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            dt_tongsonhanvien.Enabled = false;
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select manv,hoten,ngaysinh,gioitinh,diachi,dienthoai from nhanvien");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dt_tongsonhanvien.DataSource = dt;
            }
            dt_tongsonhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dt_tongsonhanvien.Columns[1].HeaderText = "Họ và tên";
            dt_tongsonhanvien.Columns[2].HeaderText = "Ngày sinh";
            dt_tongsonhanvien.Columns[3].HeaderText = "Giới tính";
            dt_tongsonhanvien.Columns[4].HeaderText = "Địa chỉ";
            dt_tongsonhanvien.Columns[5].HeaderText = "Điện thoại";
            
        
            dt_tongsonhanvien.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            dt_tongsonhanvien.Enabled = true;

        }
        private void Formnhanvien_Load(object sender, EventArgs e)
        {
            loaddata();
            ///tongso.Text = luoi.CurrentRow.Cells[0].Value.ToString();

        }

        private void dt_tongsonhanvien_SelectionChanged(object sender, EventArgs e)
        {
            txt_manhanvien.Text = dt_tongsonhanvien.CurrentRow.Cells[0].Value.ToString();
            txt_tennhanvien.Text = dt_tongsonhanvien.CurrentRow.Cells[1].Value.ToString();
            dt_ngaysinh.Text = dt_tongsonhanvien.CurrentRow.Cells[2].Value.ToString();
            ComboBox_gioitinh.Text = dt_tongsonhanvien.CurrentRow.Cells[3].Value.ToString();
            txt_diachi.Text = dt_tongsonhanvien.CurrentRow.Cells[4].Value.ToString();
            txt_dienthoai.Text = dt_tongsonhanvien.CurrentRow.Cells[5].Value.ToString();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string ngayhh = dt_ngaysinh.Value.ToString("yyyy/MM/dd");
            if (txt_manhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txt_manhanvien.Focus();

            }
            else if (txt_tennhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txt_tennhanvien.Focus();


            }
            else if (txt_diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txt_diachi.Focus();


            }
            else if (txt_dienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoại");
                txt_dienthoai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO nhanvien(manv,hoten,ngaysinh,diachi,dienthoai,gioitinh) VALUES (N'" + txt_manhanvien.Text + "','" + txt_tennhanvien.Text + "','" + ngayhh + "','" + txt_diachi.Text + "','" + txt_dienthoai.Text + "','" + ComboBox_gioitinh.Text+ "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");



            txt_manhanvien.Focus();

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
                dt_tongsonhanvien.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txt_manhanvien.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from nhanvien where manv='" + txt_manhanvien.Text + "'") == true)
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
                dt_tongsonhanvien.Enabled = true;
            }
            else
            {

                if (txt_tennhanvien.Text == "")
                {
                    txt_tennhanvien.Focus();

                }
                else if (txt_diachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txt_diachi.Focus();


                }
                else if (txt_dienthoai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    txt_dienthoai.Focus();

                    
                }
                else if (t.thucthidulieu("update  nhanvien set hoten=N'" + txt_tennhanvien.Text + "', ngaysinh=N'" + ngayhh + "', diachi=N'" + txt_diachi.Text + "', dienthoai='" + txt_dienthoai.Text +  "'where manv=N'" + txt_manhanvien.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                  

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }
    }
}
