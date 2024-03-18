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
    public partial class frm_capnhatsach : Form
    {
        public frm_capnhatsach()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from sach");

            if (dt != null)
            {
                dt_capnhatsach.DataSource = dt;
            }
            dt_capnhatsach.Columns[0].HeaderText = "Mã sách ";
            dt_capnhatsach.Columns[0].Width = 80;
            dt_capnhatsach.Columns[3].Width = 180;


            dt_capnhatsach.Columns[1].HeaderText = "Tên sách";
            dt_capnhatsach.Columns[2].HeaderText =  "Mã thể loại";
            dt_capnhatsach.Columns[3].HeaderText =  "Mã tác giả";
            dt_capnhatsach.Columns[4].HeaderText = "Mã nhà xuất bản";
            dt_capnhatsach.Columns[5].HeaderText = "Năm xuất bản";
            //luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            btn_xoa.Enabled = true;
            btn_sua.Text = "Sửa";
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_luu.Enabled = false;
            dt_capnhatsach.Enabled = true;

        }
        private void loadcombo() {
            DataTable dt = t.docdulieu("select * from nhaxb");
            DataTable dt1 = t.docdulieu("select * from theloai");
            DataTable dt2 = t.docdulieu("select * from tacgia");

           
                ComboBox_nhaxb.DataSource = dt;
                ComboBox_nhaxb.DisplayMember = "tennxb";
                ComboBox_nhaxb.ValueMember = "manxb";
                //comnhaxb.DisplayMember = "tennxb";
                //comnhaxb.ValueMember = "manxb";
                ComboBox_theloai.DataSource = dt1;
                ComboBox_theloai.DisplayMember = "tentheloai";
                ComboBox_theloai.ValueMember = "matheloai";
                ComboBox_matacgia.DataSource = dt2;
                ComboBox_matacgia.DisplayMember = "tentacgia";
                ComboBox_matacgia.ValueMember = "matg";
        
        }
       

        private void Formcapnhatsach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dt_luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dt_capnhatsach_SelectionChanged(object sender, EventArgs e)
        {
            txt_masach.Text = dt_capnhatsach.CurrentRow.Cells[0].Value.ToString();
            txt_tensach.Text = dt_capnhatsach.CurrentRow.Cells[1].Value.ToString();
            ComboBox_theloai.Text = dt_capnhatsach.CurrentRow.Cells[2].Value.ToString();
            ComboBox_matacgia.Text = dt_capnhatsach.CurrentRow.Cells[3].Value.ToString();
            ComboBox_nhaxb.Text = dt_capnhatsach.CurrentRow.Cells[4].Value.ToString();
            txt_namxb.Text = dt_capnhatsach.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_masach.Text = "";
            txt_tensach.Text = "";
         
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Text = "hủy";
            btn_them.Enabled = false;
            dt_capnhatsach.Enabled = false;
            loadcombo();

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
           
            if (txt_masach.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                txt_masach.Focus();

            }
            else if (txt_tensach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txt_tensach.Focus();


            }
            else if (txt_namxb.Text == "")
            {
                MessageBox.Show("Chưa nhập năm xuất bản");
                txt_namxb.Focus();


            }

            else if (t.thucthidulieu("INSERT INTO SACH VALUES (N'" + txt_masach.Text + "','" + txt_tensach.Text + "','" + txt_namxb.Text + "','" + ComboBox_nhaxb.SelectedValue.ToString() + "','" + ComboBox_theloai.SelectedValue.ToString() + "','" + ComboBox_matacgia.SelectedValue.ToString() + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void txt_namxb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnamxb_Enter(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(txt_namxb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");

            }
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
                dt_capnhatsach.Enabled = true;


            }
            else
            {
                txt_masach.Enabled = false;


                if (txt_tensach.Text == "")
                {
                    txt_tensach.Focus();

                }
                else if (txt_namxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txt_namxb.Focus();

                    // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                }
                else if (t.thucthidulieu("update  SACH set tensach=N'" + txt_tensach.Text + "', namxb=N'" + txt_namxb.Text + "', manxb='" + ComboBox_nhaxb.Text + "', matheloai='" + ComboBox_theloai.Text + "', matg='" + ComboBox_matacgia.Text + "'where masach=N'" + txt_masach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                    txt_masach.Enabled = true;

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
                dt_capnhatsach.Enabled = true;




            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txt_masach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from sach where masach='" + txt_masach.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        

        private void comtheloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_masach_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_nhaxb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
