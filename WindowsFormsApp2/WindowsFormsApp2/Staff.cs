using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Class;
namespace WindowsFormsApp2
{
    public partial class Staff : Form
    {
        DataTable tblNhanVien;
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Txt_MaNv.Enabled = false;
            Bnt_Luu.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            string sql;
            sql = "SELECT Manhanvien,Tennhanvien,Gioitinh,Diachi,Dienthoai,Ngaysinh FROM tblNhanvien";
            tblNhanVien = Function.GetDataToTable(sql);
            dataGridView1.DataSource = tblNhanVien;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].HeaderText = "Điện thoại";
            dataGridView1.Columns[5].HeaderText = "Ngày sinh";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(Bnt_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_MaNv.Focus();
                return;
            }
            if(tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Txt_MaNv.Text = dataGridView1.CurrentRow.Cells["Manhanvien"].Value.ToString();
            Txt_TenNV.Text = dataGridView1.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
            {
                Cb_GioiTinh.Checked = true;

            }
            else
                Cb_GioiTinh.Checked = false;
            Txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["Diachi"].Value.ToString();
            Txt_DienThoai.Text = dataGridView1.CurrentRow.Cells["Dienthoai"].Value.ToString();
            dt_NgaySinh.Text = dataGridView1.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            Bnt_Sua.Enabled = true;
            Btn_Xoa.Enabled = true;
        }

        private void Bnt_Them_Click(object sender, EventArgs e)
        {
            Bnt_Sua.Enabled = false;
            Btn_Xoa.Enabled = false;
            Bnt_Luu.Enabled = true;
            Bnt_Them.Enabled = false;
            ResetValue();
            Txt_MaNv.Enabled = true;
            Txt_MaNv.Focus();
        }
        public void ResetValue()
        {
            Txt_MaNv.Text = "";
            Txt_TenNV.Text = "";
            Cb_GioiTinh.Checked = false;
            Txt_DiaChi.Text = "";
            dt_NgaySinh.Text = "";
            Txt_DienThoai.Text = "";
        }

        private void Bnt_Luu_Click(object sender, EventArgs e)
        {
            string sql, sql1 , gt;

            if(Txt_MaNv.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_MaNv.Focus();
                return;

            }

            if (Txt_TenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_MaNv.Focus();
                return;

            }

            if (Txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_MaNv.Focus();
                return;

            }

            if (Txt_DienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_MaNv.Focus();
                return;

            }

            if (dt_NgaySinh.Text=="  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_MaNv.Focus();
                return;

            }

            if (Cb_GioiTinh.Checked == true)
            {
                gt = "Nam";
            }
            else
                gt = "Nữ";
            sql = "SELECT Manhanvien FROM tblNhanvien WHERE Manhanvien = N'" + Txt_MaNv.Text.Trim() + "'  ";

            if (Function.Checkey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Txt_MaNv.Focus();
                Txt_MaNv.Text = "";
                return;
            }
            sql1 = "INSERT INTO tblNhanvien(Manhanvien,Tennhanvien,Gioitinh, Diachi,Dienthoai, Ngaysinh) VALUES (N'" + Txt_MaNv.Text.Trim() + "',N'" + Txt_TenNV.Text.Trim() + "',N'" + gt + "',N'" + Txt_DiaChi.Text.Trim() + "','" + Txt_DienThoai.Text + "','" + Function.ConvertDateTime(dt_NgaySinh.Text) + "')";
            Function.RunSQL(sql1);
 
            LoadData();
            ResetValue();
            Btn_Xoa.Enabled = true;
            Bnt_Them.Enabled = true;
            Bnt_Sua.Enabled = true;
            Bnt_Luu.Enabled = false;
            Txt_MaNv.Enabled = false;

            if (!Function.IsDate(dt_NgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // mskNgaysinh.Text = "";
                dt_NgaySinh.Focus();
                return;
            }
        }

        private void Bnt_Sua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if(tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Txt_MaNv.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Txt_TenNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_TenNV.Focus();
                return;
            }
            if(Txt_DiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_DiaChi.Focus();
                return;
            }
            if(Txt_DienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_DienThoai.Focus();
                return;
            }
            if(dt_NgaySinh.Text.Trim() == "/ /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_NgaySinh.Focus();
                return;
            }
            if(!Function.IsDate(dt_NgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dt_NgaySinh.Text = "";
                dt_NgaySinh.Focus();
                return;
            }
            if (Cb_GioiTinh.Checked == true)
            {
                gt = "Nam";
            }
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanvien SET Tennhanvien =N'" + Txt_TenNV.Text.Trim().ToString() +
            "' ,Diachi =N'" + Txt_DiaChi.Text.Trim().ToString() +
                "' ,Dienthoai=N'" + Txt_DienThoai.Text.Trim().ToString() +
                "' ,Gioitinh =N'" + gt + 
                "' ,Ngaysinh =N'" + Function.ConvertDateTime(dt_NgaySinh.Text) +
                "' WHERE Manhanvien=N'" + Txt_MaNv.Text + "'";

            Function.RunSQL(sql);
            MessageBox.Show("Sửa Mã nhân viên '"+Txt_MaNv.Text+"'thành công  ");
            LoadData();
            ResetValue();
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Txt_MaNv.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa mã nhân viên '"+Txt_MaNv.Text+ "' không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK ) 
            {
                sql = "DELETE tblNhanvien WHERE Manhanvien=N'" + Txt_MaNv.Text + "'";
               


                Function.RunSQL(sql);
                
               
                MessageBox.Show("Xóa mã nhân viên '"+Txt_MaNv.Text+"'thành công");
                LoadData();
                ResetValue();
            }

           
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
