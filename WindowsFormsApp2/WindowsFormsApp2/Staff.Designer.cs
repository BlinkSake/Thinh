namespace WindowsFormsApp2
{
    partial class Staff
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_TenNV = new System.Windows.Forms.TextBox();
            this.Txt_MaNv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_DienThoai = new System.Windows.Forms.TextBox();
            this.Txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_GioiTinh = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            this.Bnt_Luu = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Bnt_Sua = new System.Windows.Forms.Button();
            this.Bnt_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(403, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh mục nhân viên";
            // 
            // Txt_TenNV
            // 
            this.Txt_TenNV.Location = new System.Drawing.Point(152, 129);
            this.Txt_TenNV.Name = "Txt_TenNV";
            this.Txt_TenNV.Size = new System.Drawing.Size(281, 22);
            this.Txt_TenNV.TabIndex = 8;
            // 
            // Txt_MaNv
            // 
            this.Txt_MaNv.Location = new System.Drawing.Point(152, 90);
            this.Txt_MaNv.Name = "Txt_MaNv";
            this.Txt_MaNv.Size = new System.Drawing.Size(281, 22);
            this.Txt_MaNv.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // Txt_DienThoai
            // 
            this.Txt_DienThoai.Location = new System.Drawing.Point(781, 130);
            this.Txt_DienThoai.Name = "Txt_DienThoai";
            this.Txt_DienThoai.Size = new System.Drawing.Size(281, 22);
            this.Txt_DienThoai.TabIndex = 12;
            // 
            // Txt_DiaChi
            // 
            this.Txt_DiaChi.Location = new System.Drawing.Point(781, 91);
            this.Txt_DiaChi.Name = "Txt_DiaChi";
            this.Txt_DiaChi.Size = new System.Drawing.Size(281, 22);
            this.Txt_DiaChi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(634, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(634, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(634, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày sinh";
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgaySinh.Location = new System.Drawing.Point(781, 169);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(281, 22);
            this.dt_NgaySinh.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(5, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính";
            // 
            // Cb_GioiTinh
            // 
            this.Cb_GioiTinh.AutoSize = true;
            this.Cb_GioiTinh.Location = new System.Drawing.Point(152, 169);
            this.Cb_GioiTinh.Name = "Cb_GioiTinh";
            this.Cb_GioiTinh.Size = new System.Drawing.Size(59, 21);
            this.Cb_GioiTinh.TabIndex = 18;
            this.Cb_GioiTinh.Text = "Nam";
            this.Cb_GioiTinh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 280);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Thoat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Thoat.Location = new System.Drawing.Point(935, 545);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(127, 35);
            this.Btn_Thoat.TabIndex = 24;
            this.Btn_Thoat.Text = "Đóng";
            this.Btn_Thoat.UseVisualStyleBackColor = false;
            // 
            // Bnt_Luu
            // 
            this.Bnt_Luu.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Luu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Luu.Location = new System.Drawing.Point(688, 545);
            this.Bnt_Luu.Name = "Bnt_Luu";
            this.Bnt_Luu.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Luu.TabIndex = 23;
            this.Bnt_Luu.Text = "Lưu";
            this.Bnt_Luu.UseVisualStyleBackColor = false;
            this.Bnt_Luu.Click += new System.EventHandler(this.Bnt_Luu_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Xoa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Xoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Xoa.Location = new System.Drawing.Point(467, 545);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(127, 35);
            this.Btn_Xoa.TabIndex = 22;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Bnt_Sua
            // 
            this.Bnt_Sua.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Sua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Sua.Location = new System.Drawing.Point(223, 545);
            this.Bnt_Sua.Name = "Bnt_Sua";
            this.Bnt_Sua.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Sua.TabIndex = 21;
            this.Bnt_Sua.Text = "Sửa";
            this.Bnt_Sua.UseVisualStyleBackColor = false;
            // 
            // Bnt_Them
            // 
            this.Bnt_Them.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Them.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Them.Location = new System.Drawing.Point(9, 545);
            this.Bnt_Them.Name = "Bnt_Them";
            this.Bnt_Them.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Them.TabIndex = 20;
            this.Bnt_Them.Text = "Thêm";
            this.Bnt_Them.UseVisualStyleBackColor = false;
            this.Bnt_Them.Click += new System.EventHandler(this.Bnt_Them_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 656);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Bnt_Luu);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Bnt_Sua);
            this.Controls.Add(this.Bnt_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cb_GioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_DienThoai);
            this.Controls.Add(this.Txt_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_TenNV);
            this.Controls.Add(this.Txt_MaNv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Staff";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_TenNV;
        private System.Windows.Forms.TextBox Txt_MaNv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_DienThoai;
        private System.Windows.Forms.TextBox Txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_NgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Cb_GioiTinh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.Button Bnt_Luu;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Bnt_Sua;
        private System.Windows.Forms.Button Bnt_Them;
    }
}