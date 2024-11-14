namespace doandbms.Design
{
    partial class QuanLiPhong
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
            panel2 = new Panel();
            txt_timKiem1 = new TextBox();
            label5 = new Label();
            btn_them = new Button();
            btn_xoa = new Button();
            txt_soNguoiDaO = new TextBox();
            txt_maToa = new TextBox();
            txt_loaiPhong = new TextBox();
            txt_maPhong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtg_phong = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_phong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_them);
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(txt_soNguoiDaO);
            panel1.Controls.Add(txt_maToa);
            panel1.Controls.Add(txt_loaiPhong);
            panel1.Controls.Add(txt_maPhong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 809);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_timKiem1);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(3, 559);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 234);
            panel2.TabIndex = 22;
            // 
            // txt_timKiem1
            // 
            txt_timKiem1.Location = new Point(274, 73);
            txt_timKiem1.Margin = new Padding(3, 4, 3, 4);
            txt_timKiem1.Name = "txt_timKiem1";
            txt_timKiem1.Size = new Size(197, 27);
            txt_timKiem1.TabIndex = 18;
            txt_timKiem1.TextChanged += txt_timKiem_TextChanged;
            txt_timKiem1.KeyDown += txt_timKiem1_KeyDown_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 73);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 17;
            label5.Text = "Mã phòng:";
            // 
            // btn_them
            // 
            btn_them.Location = new Point(317, 432);
            btn_them.Margin = new Padding(3, 4, 3, 4);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(86, 48);
            btn_them.TabIndex = 21;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(139, 432);
            btn_xoa.Margin = new Padding(3, 4, 3, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(86, 48);
            btn_xoa.TabIndex = 20;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_soNguoiDaO
            // 
            txt_soNguoiDaO.Location = new Point(227, 321);
            txt_soNguoiDaO.Margin = new Padding(3, 4, 3, 4);
            txt_soNguoiDaO.Name = "txt_soNguoiDaO";
            txt_soNguoiDaO.Size = new Size(197, 27);
            txt_soNguoiDaO.TabIndex = 19;
            // 
            // txt_maToa
            // 
            txt_maToa.Location = new Point(227, 241);
            txt_maToa.Margin = new Padding(3, 4, 3, 4);
            txt_maToa.Name = "txt_maToa";
            txt_maToa.Size = new Size(197, 27);
            txt_maToa.TabIndex = 18;
            // 
            // txt_loaiPhong
            // 
            txt_loaiPhong.Location = new Point(227, 165);
            txt_loaiPhong.Margin = new Padding(3, 4, 3, 4);
            txt_loaiPhong.Name = "txt_loaiPhong";
            txt_loaiPhong.Size = new Size(197, 27);
            txt_loaiPhong.TabIndex = 17;
            // 
            // txt_maPhong
            // 
            txt_maPhong.Location = new Point(227, 96);
            txt_maPhong.Margin = new Padding(3, 4, 3, 4);
            txt_maPhong.Name = "txt_maPhong";
            txt_maPhong.Size = new Size(197, 27);
            txt_maPhong.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 319);
            label4.Name = "label4";
            label4.Size = new Size(175, 28);
            label4.TabIndex = 15;
            label4.Text = "Số người đang ở:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 239);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 14;
            label3.Text = "Mã tòa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 168);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 13;
            label2.Text = "Loại phòng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 96);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 12;
            label1.Text = "Mã phòng:";
            // 
            // dtg_phong
            // 
            dtg_phong.BackgroundColor = SystemColors.ControlLightLight;
            dtg_phong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_phong.Location = new Point(614, 4);
            dtg_phong.Name = "dtg_phong";
            dtg_phong.RowHeadersWidth = 51;
            dtg_phong.RowTemplate.Height = 29;
            dtg_phong.Size = new Size(607, 794);
            dtg_phong.TabIndex = 13;
            dtg_phong.CellClick += dtg_phong_CellClick;
            dtg_phong.CellContentClick += dtg_phong_CellContentClick;
            dtg_phong.CellDoubleClick += dtg_phong_CellDoubleClick;
            dtg_phong.KeyDown += txt_timKiem1_KeyDown;
            // 
            // QuanLiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtg_phong);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLiPhong";
            Size = new Size(1224, 817);
            Load += QuanLiPhong_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_phong).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private TextBox txt_timKiem1;
        private Label label5;
        private Button btn_them;
        private Button btn_xoa;
        private TextBox txt_soNguoiDaO;
        private TextBox txt_maToa;
        private TextBox txt_loaiPhong;
        private TextBox txt_maPhong;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtg_phong;
    }
}
