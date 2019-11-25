using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp2.Class;

namespace WindowsFormsApp2
{
    public partial class Category : Form
    {
        DataTable tblVL;

        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            Btn_Luu.Enabled = false;
            //btnBoqua.Enabled = false;
            LoadDataGridView(); //Hiển thị bảng tblChatlieu
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaVatLieu, TenVatLieu FROM tblVatlieu";
            tblVL = Class.Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng

           

            dataGridView1.DataSource = tblVL; //Nguồn dữ liệu      

            dataGridView1.DataSource = tblVL; //Nguồn dữ liệu            
            dataGridView1.Columns[0].HeaderText = "Mã vật liệu";
            dataGridView1.Columns[1].HeaderText = "Tên vật liệu";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 300;
            //dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            //dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btn_Sua.Enabled = false;
            Btn_Xoa.Enabled = false;
            Btn_Luu.Enabled = true;
            Bnt_Them.Enabled = true;
            Bnt_Them.Enabled = false;
            ResetValue();
            textBox1.Enabled = true;
            textBox1.Focus();
        }
        private void ResetValue()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Bnt_Them.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }
            if (tblVL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox1.Text = dataGridView1.CurrentRow.Cells["MaVatlieu"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["TenVatlieu"].Value.ToString();
            Btn_Sua.Enabled = true;
            Btn_Xoa.Enabled = true;
            Btn_Luu.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String sql, sql1;

            if(textBox1.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập mã vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return;
            }

            if(textBox2.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn phải nhập tên vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return;
            }
            sql = "SELECT MaVatLieu FROM tblVatlieu WHERE MaVatLieu = N'" + textBox1.Text.Trim() + "'";

            if(Class.Function.Checkey(sql))
            {
                MessageBox.Show("Mã vật liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            sql1 = "INSERT INTO tblVatLieu VALUES (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";

            Class.Function.RunSQL(sql1);
            MessageBox.Show("Thêm thành công");
            LoadDataGridView();
            ResetValue();
            Btn_Xoa.Enabled = true;
            Bnt_Them.Enabled = true;
            Btn_Sua.Enabled = true;
            Btn_Luu.Enabled = false;
            textBox1.Enabled = false;
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblVL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(textBox2.Text.Trim().Length==0)
            {
                MessageBox.Show("Bạn chưa nhập tên vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblVatLieu SET TenVatlieu=N'" +
                textBox2.Text.ToString() +
                "' WHERE MaVatlieu=N'" + textBox1.Text + "'";
            Class.Function.RunSQL(sql);
            MessageBox.Show("Sửa Mã vật liệu '" +textBox1.Text + "' thành công  ");
            LoadDataGridView();
            ResetValue();

        }

        private void Bnt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(tblVL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblVatlieu WHERE MaVatlieu=N'" + textBox1.Text + "'";
                Class.Function.RunSQL(sql);
                MessageBox.Show("Xóa vật liệu '" + textBox1.Text + "' thành công  ");
                LoadDataGridView();
                ResetValue();
            }
        }
    }
}
