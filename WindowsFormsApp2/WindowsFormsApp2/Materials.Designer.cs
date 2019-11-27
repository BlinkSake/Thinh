namespace WindowsFormsApp2
{
    partial class Materials
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bnt_Them = new System.Windows.Forms.Button();
            this.Btn_Sua = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.Bnt_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục vật liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã vật liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(37, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên vật liệu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(281, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 299);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bnt_Them
            // 
            this.Bnt_Them.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Them.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Them.Location = new System.Drawing.Point(41, 529);
            this.Bnt_Them.Name = "Bnt_Them";
            this.Bnt_Them.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Them.TabIndex = 6;
            this.Bnt_Them.Text = "Thêm";
            this.Bnt_Them.UseVisualStyleBackColor = false;
            this.Bnt_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Sua
            // 
            this.Btn_Sua.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Sua.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Sua.Location = new System.Drawing.Point(221, 529);
            this.Btn_Sua.Name = "Btn_Sua";
            this.Btn_Sua.Size = new System.Drawing.Size(127, 35);
            this.Btn_Sua.TabIndex = 7;
            this.Btn_Sua.Text = "Sửa";
            this.Btn_Sua.UseVisualStyleBackColor = false;
            this.Btn_Sua.Click += new System.EventHandler(this.Btn_Sua_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Xoa.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Xoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Xoa.Location = new System.Drawing.Point(409, 529);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(127, 35);
            this.Btn_Xoa.TabIndex = 8;
            this.Btn_Xoa.Text = "Xóa";
            this.Btn_Xoa.UseVisualStyleBackColor = false;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Luu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Luu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_Luu.Location = new System.Drawing.Point(601, 529);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(127, 35);
            this.Btn_Luu.TabIndex = 9;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = false;
            this.Btn_Luu.Click += new System.EventHandler(this.button4_Click);
            // 
            // Bnt_Thoat
            // 
            this.Bnt_Thoat.BackColor = System.Drawing.SystemColors.Window;
            this.Bnt_Thoat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bnt_Thoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bnt_Thoat.Location = new System.Drawing.Point(795, 529);
            this.Bnt_Thoat.Name = "Bnt_Thoat";
            this.Bnt_Thoat.Size = new System.Drawing.Size(127, 35);
            this.Bnt_Thoat.TabIndex = 10;
            this.Bnt_Thoat.Text = "Đóng";
            this.Bnt_Thoat.UseVisualStyleBackColor = false;
            this.Bnt_Thoat.Click += new System.EventHandler(this.Bnt_Thoat_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 656);
            this.Controls.Add(this.Bnt_Thoat);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_Sua);
            this.Controls.Add(this.Bnt_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Category";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bnt_Them;
        private System.Windows.Forms.Button Btn_Sua;
        private System.Windows.Forms.Button Btn_Xoa;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Button Bnt_Thoat;
    }
}