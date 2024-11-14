namespace doandbms.Design
{
    partial class QuanLiSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_dsghan = new Button();
            btn_dsduyet = new Button();
            btn_xemtk = new Button();
            btn_sua = new Button();
            btn_delete = new Button();
            label9 = new Label();
            txt_matoa = new TextBox();
            label10 = new Label();
            txt_maphong = new TextBox();
            txt_masv = new TextBox();
            label6 = new Label();
            label1 = new Label();
            txt_sdt = new TextBox();
            label2 = new Label();
            txt_diachi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            txt_sex = new TextBox();
            label8 = new Label();
            txt_name = new TextBox();
            txt_cccd = new TextBox();
            mdf_date = new DateTimePicker();
            label5 = new Label();
            dtg_student = new DataGridView();
            txt_search_sv = new TextBox();
            lb_search = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_student).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_dsghan);
            panel1.Controls.Add(btn_dsduyet);
            panel1.Controls.Add(btn_xemtk);
            panel1.Controls.Add(btn_sua);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_matoa);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txt_maphong);
            panel1.Controls.Add(txt_masv);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_sdt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_diachi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_sex);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_cccd);
            panel1.Controls.Add(mdf_date);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 589);
            panel1.TabIndex = 0;
            // 
            // btn_dsghan
            // 
            btn_dsghan.Location = new Point(246, 508);
            btn_dsghan.Name = "btn_dsghan";
            btn_dsghan.Size = new Size(75, 43);
            btn_dsghan.TabIndex = 84;
            btn_dsghan.Text = "Danh sách gia hạn";
            btn_dsghan.UseVisualStyleBackColor = true;
            btn_dsghan.Click += btn_dsghan_Click;
            // 
            // btn_dsduyet
            // 
            btn_dsduyet.Location = new Point(139, 508);
            btn_dsduyet.Name = "btn_dsduyet";
            btn_dsduyet.Size = new Size(75, 43);
            btn_dsduyet.TabIndex = 82;
            btn_dsduyet.Text = "Danh sách duyệt";
            btn_dsduyet.UseVisualStyleBackColor = true;
            btn_dsduyet.Click += btn_dsduyet_Click;
            // 
            // btn_xemtk
            // 
            btn_xemtk.Location = new Point(298, 459);
            btn_xemtk.Name = "btn_xemtk";
            btn_xemtk.Size = new Size(75, 43);
            btn_xemtk.TabIndex = 81;
            btn_xemtk.Text = "Xem tài khoản";
            btn_xemtk.UseVisualStyleBackColor = true;
            btn_xemtk.Click += btn_xemtk_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(192, 459);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(75, 43);
            btn_sua.TabIndex = 80;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(84, 459);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 43);
            btn_delete.TabIndex = 79;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(68, 373);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 78;
            label9.Text = "Mã Tòa:";
            // 
            // txt_matoa
            // 
            txt_matoa.Location = new Point(172, 370);
            txt_matoa.Name = "txt_matoa";
            txt_matoa.Size = new Size(219, 23);
            txt_matoa.TabIndex = 77;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(68, 412);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 75;
            label10.Text = "Mã phòng:";
            // 
            // txt_maphong
            // 
            txt_maphong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_maphong.Location = new Point(172, 409);
            txt_maphong.Margin = new Padding(3, 2, 3, 2);
            txt_maphong.Name = "txt_maphong";
            txt_maphong.Size = new Size(219, 23);
            txt_maphong.TabIndex = 76;
            // 
            // txt_masv
            // 
            txt_masv.Location = new Point(171, 97);
            txt_masv.Name = "txt_masv";
            txt_masv.Size = new Size(220, 23);
            txt_masv.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(65, 292);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 73;
            label6.Text = " Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(65, 100);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 61;
            label1.Text = "Mã sinh viên:";
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(171, 289);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(219, 23);
            txt_sdt.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(65, 177);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 62;
            label2.Text = "Ngày sinh:";
            label2.Click += label2_Click;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(171, 247);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(220, 23);
            txt_diachi.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(64, 137);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 63;
            label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(65, 250);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 70;
            label4.Text = "Địa chỉ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(68, 331);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 64;
            label7.Text = "CCCD:";
            // 
            // txt_sex
            // 
            txt_sex.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sex.Location = new Point(171, 208);
            txt_sex.Margin = new Padding(3, 2, 3, 2);
            txt_sex.Name = "txt_sex";
            txt_sex.Size = new Size(72, 23);
            txt_sex.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(65, 206);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 68;
            label8.Text = "Giới tính:";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(172, 134);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(219, 23);
            txt_name.TabIndex = 65;
            // 
            // txt_cccd
            // 
            txt_cccd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_cccd.Location = new Point(171, 328);
            txt_cccd.Margin = new Padding(3, 2, 3, 2);
            txt_cccd.Name = "txt_cccd";
            txt_cccd.Size = new Size(219, 23);
            txt_cccd.TabIndex = 67;
            // 
            // mdf_date
            // 
            mdf_date.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mdf_date.Location = new Point(171, 172);
            mdf_date.Margin = new Padding(3, 2, 3, 2);
            mdf_date.Name = "mdf_date";
            mdf_date.Size = new Size(219, 23);
            mdf_date.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 12);
            label5.Name = "label5";
            label5.Size = new Size(177, 24);
            label5.TabIndex = 28;
            label5.Text = "Thông tin sinh viên";
            // 
            // dtg_student
            // 
            dtg_student.AllowDrop = true;
            dtg_student.BackgroundColor = SystemColors.ControlLightLight;
            dtg_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_student.Location = new Point(478, 80);
            dtg_student.Margin = new Padding(3, 2, 3, 2);
            dtg_student.Name = "dtg_student";
            dtg_student.RowHeadersWidth = 51;
            dtg_student.RowTemplate.Height = 29;
            dtg_student.Size = new Size(591, 499);
            dtg_student.TabIndex = 1;
            dtg_student.CellContentClick += dt_Student_CellContentClick;
            dtg_student.CellDoubleClick += dtg_student_CellDoubleClick;
            // 
            // txt_search_sv
            // 
            txt_search_sv.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search_sv.Location = new Point(662, 22);
            txt_search_sv.Margin = new Padding(3, 2, 3, 2);
            txt_search_sv.Name = "txt_search_sv";
            txt_search_sv.Size = new Size(265, 32);
            txt_search_sv.TabIndex = 2;
            txt_search_sv.KeyDown += txt_search_sv_KeyDown;
            // 
            // lb_search
            // 
            lb_search.AutoSize = true;
            lb_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_search.Location = new Point(524, 28);
            lb_search.Name = "lb_search";
            lb_search.Size = new Size(90, 25);
            lb_search.TabIndex = 3;
            lb_search.Text = "Tìm Kiếm";
            // 
            // QuanLiSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_search);
            Controls.Add(txt_search_sv);
            Controls.Add(dtg_student);
            Controls.Add(panel1);
            Name = "QuanLiSinhVien";
            Size = new Size(1071, 613);
            Load += QuanLiSinhVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Button btn_dsghan;
        private Button btn_dsduyet;
        private Button btn_xemtk;
        private Button btn_sua;
        private Button btn_delete;
        private Label label9;
        private TextBox txt_matoa;
        private Label label10;
        private TextBox txt_maphong;
        private TextBox txt_masv;
        private Label label6;
        private Label label1;
        private TextBox txt_sdt;
        private Label label2;
        private TextBox txt_diachi;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox txt_sex;
        private Label label8;
        private TextBox txt_name;
        private TextBox txt_cccd;
        private DateTimePicker mdf_date;
        private DataGridView dtg_student;
        private TextBox txt_search_sv;
        private Label lb_search;
    }
}
