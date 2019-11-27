namespace WindowsFormsApp2
{
    partial class Customer
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
            this.Txt_Dienthoai = new System.Windows.Forms.TextBox();
            this.Txt_Diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Tenkhach = new System.Windows.Forms.TextBox();
            this.Txt_Makhach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bnt_Dong = new System.Windows.Forms.Button();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Bnt_Sua = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh mục khách hàng";
            // 
            // Txt_Dienthoai
            // 
            this.Txt_Dienthoai.Location = new System.Drawing.Point(797, 141);
            this.Txt_Dienthoai.Name = "Txt_Dienthoai";
            this.Txt_Dienthoai.Size = new System.Drawing.Size(281, 22);
            this.Txt_Dienthoai.TabIndex = 20;
            // 
            // Txt_Diachi
            // 
            this.Txt_Diachi.Location = new System.Drawing.Point(797, 102);
            this.Txt_Diachi.Name = "Txt_Diachi";
            this.Txt_Diachi.Size = new System.Drawing.Size(281, 22);
            this.Txt_Diachi.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(650, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(650, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Địa chỉ";
            // 
            // Txt_Tenkhach
            // 
            this.Txt_Tenkhach.Location = new System.Drawing.Point(168, 140);
            this.Txt_Tenkhach.Name = "Txt_Tenkhach";
            this.Txt_Tenkhach.Size = new System.Drawing.Size(281, 22);
            this.Txt_Tenkhach.TabIndex = 16;
            // 
            // Txt_Makhach
            // 
            this.Txt_Makhach.Location = new System.Drawing.Point(168, 101);
            this.Txt_Makhach.Name = "Txt_Makhach";
            this.Txt_Makhach.Size = new System.Drawing.Size(281, 22);
            this.Txt_Makhach.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã khách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 280);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Bnt_Dong
            // 
            this.Bnt_Dong.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Dong.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Dong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Dong.Location = new System.Drawing.Point(947, 522);
            this.Bnt_Dong.Name = "Bnt_Dong";
            this.Bnt_Dong.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Dong.TabIndex = 29;
            this.Bnt_Dong.Text = "Đóng";
            this.Bnt_Dong.UseVisualStyleBackColor = false;
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Luu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Luu.Location = new System.Drawing.Point(700, 522);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(127, 35);
            this.Btn_Luu.TabIndex = 28;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = false;
            this.Btn_Luu.Click += new System.EventHandler(this.Btn_Luu_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Xoa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Xoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Xoa.Location = new System.Drawing.Point(479, 522);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(127, 35);
            this.Btn_Xoa.TabIndex = 27;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // Bnt_Sua
            // 
            this.Bnt_Sua.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Sua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Sua.Location = new System.Drawing.Point(235, 522);
            this.Bnt_Sua.Name = "Bnt_Sua";
            this.Bnt_Sua.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Sua.TabIndex = 26;
            this.Bnt_Sua.Text = "Sửa";
            this.Bnt_Sua.UseVisualStyleBackColor = false;
            // 
            // Btn_Them
            // 
            this.Btn_Them.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Them.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Them.Location = new System.Drawing.Point(21, 522);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(127, 35);
            this.Btn_Them.TabIndex = 25;
            this.Btn_Them.Text = "Thêm";
            this.Btn_Them.UseVisualStyleBackColor = false;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 656);
            this.Controls.Add(this.Bnt_Dong);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Bnt_Sua);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_Dienthoai);
            this.Controls.Add(this.Txt_Diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Tenkhach);
            this.Controls.Add(this.Txt_Makhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Dienthoai;
        private System.Windows.Forms.TextBox Txt_Diachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Tenkhach;
        private System.Windows.Forms.TextBox Txt_Makhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bnt_Dong;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Bnt_Sua;
        private System.Windows.Forms.Button Btn_Them;
    }
}