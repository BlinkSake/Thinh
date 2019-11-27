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
    public partial class Customer : Form
    {
        DataTable tblKhach;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Txt_Makhach.Enabled = false;
            Btn_Luu.Enabled = false;
            LoadData();
        }
        private void LoadData()
        {
            string sql;
            sql = "SELECT * from tblKhach";
            tblKhach = Function.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dataGridView1.DataSource = tblKhach; //Hiển thị vào dataGridView
            dataGridView1.Columns[0].HeaderText = "Mã khách";
            dataGridView1.Columns[1].HeaderText = "Tên khách";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Điện thoại";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Btn_Them.Enabled==false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Makhach.Focus();
                return;
            }
            if(tblKhach.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Txt_Makhach.Text = dataGridView1.CurrentRow.Cells["Makhach"].Value.ToString();
            Txt_Tenkhach.Text = dataGridView1.CurrentRow.Cells["Tenkhach"].Value.ToString();
            Txt_Diachi.Text = dataGridView1.CurrentRow.Cells["Diachi"].Value.ToString();
            Txt_Dienthoai.Text = dataGridView1.CurrentRow.Cells["Dienthoai"].Value.ToString();
            Bnt_Sua.Enabled = true;
            Btn_Xoa.Enabled = true;


        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            Bnt_Sua.Enabled = false;
            Btn_Xoa.Enabled = false;
            Btn_Luu.Enabled = true;
            Btn_Them.Enabled = true;
            ResetValue();
            Txt_Makhach.Enabled = true;
            Txt_Makhach.Focus();
        }

        private void ResetValue()
        {
            Txt_Makhach.Text = "";
            Txt_Tenkhach.Text = "";
            Txt_Diachi.Text = "";
            Txt_Dienthoai.Text = "";
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            string sql;
            if(Txt_Makhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Makhach.Focus();
                return;
            }
            if (Txt_Tenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Tenkhach.Focus();
                return;
            }
            if (Txt_Diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Diachi.Focus();
                return;
            }
            if (Txt_Dienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Dienthoai.Focus();
                return;
            }
            sql = "SELECT Makhach FROM tblKhach WHERE Makhach = N'"+Txt_Makhach.Text.Trim()+"'";
            if(Function.Checkey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Makhach.Focus();
                return;
            }
            sql = "INSERT INTO tblKhach VALUES (N'"+Txt_Makhach.Text.Trim()+"',N'"+Txt_Tenkhach.Text.Trim()+"',N'"+Txt_Diachi.Text.Trim()+"',N'"+Txt_Dienthoai.Text+"')";
            Function.RunSQL(sql);
            MessageBox.Show("Thành công");
            LoadData();
            ResetValue();

            Btn_Xoa.Enabled = true;
            Bnt_Sua.Enabled = true;
            Btn_Luu.Enabled = false;
            Txt_Makhach.Enabled = false;
            


        }
    }
}
