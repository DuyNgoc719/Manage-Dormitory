namespace doandbms.Design
{
    partial class KyLuat
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
            btn_canhCao = new Button();
            panel2 = new Panel();
            txt_timKiem = new TextBox();
            label6 = new Label();
            btn_xoa = new Button();
            btn_add = new Button();
            dtp_ngay = new DateTimePicker();
            label5 = new Label();
            txt_loi = new TextBox();
            txt_maToa = new TextBox();
            txt_maSV = new TextBox();
            txt_maKL = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtg_kyLuat = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_kyLuat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_canhCao);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(dtp_ngay);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_loi);
            panel1.Controls.Add(txt_maToa);
            panel1.Controls.Add(txt_maSV);
            panel1.Controls.Add(txt_maKL);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 805);
            panel1.TabIndex = 0;
            // 
            // btn_canhCao
            // 
            btn_canhCao.Location = new Point(153, 487);
            btn_canhCao.Name = "btn_canhCao";
            btn_canhCao.Size = new Size(226, 47);
            btn_canhCao.TabIndex = 39;
            btn_canhCao.Text = "Cảnh Báo Vi Phạm";
            btn_canhCao.UseVisualStyleBackColor = true;
            btn_canhCao.Click += btn_canhCao_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_timKiem);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(3, 559);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 239);
            panel2.TabIndex = 38;
            // 
            // txt_timKiem
            // 
            txt_timKiem.Location = new Point(271, 89);
            txt_timKiem.Margin = new Padding(3, 4, 3, 4);
            txt_timKiem.Name = "txt_timKiem";
            txt_timKiem.Size = new Size(241, 27);
            txt_timKiem.TabIndex = 39;
            txt_timKiem.TextChanged += txt_timKiem_TextChanged;
            txt_timKiem.KeyDown += txt_timKiem_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(102, 93);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 38;
            label6.Text = "Tìm kiếm:";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(293, 420);
            btn_xoa.Margin = new Padding(3, 4, 3, 4);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(86, 47);
            btn_xoa.TabIndex = 37;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(153, 420);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(86, 47);
            btn_add.TabIndex = 36;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // dtp_ngay
            // 
            dtp_ngay.Location = new Point(197, 344);
            dtp_ngay.Margin = new Padding(3, 4, 3, 4);
            dtp_ngay.Name = "dtp_ngay";
            dtp_ngay.Size = new Size(241, 27);
            dtp_ngay.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 344);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 34;
            label5.Text = "Ngày vi phạm:";
            // 
            // txt_loi
            // 
            txt_loi.Location = new Point(197, 273);
            txt_loi.Margin = new Padding(3, 4, 3, 4);
            txt_loi.Name = "txt_loi";
            txt_loi.Size = new Size(241, 27);
            txt_loi.TabIndex = 33;
            // 
            // txt_maToa
            // 
            txt_maToa.Location = new Point(197, 204);
            txt_maToa.Margin = new Padding(3, 4, 3, 4);
            txt_maToa.Name = "txt_maToa";
            txt_maToa.Size = new Size(241, 27);
            txt_maToa.TabIndex = 32;
            // 
            // txt_maSV
            // 
            txt_maSV.Location = new Point(197, 135);
            txt_maSV.Margin = new Padding(3, 4, 3, 4);
            txt_maSV.Name = "txt_maSV";
            txt_maSV.Size = new Size(241, 27);
            txt_maSV.TabIndex = 31;
            // 
            // txt_maKL
            // 
            txt_maKL.Location = new Point(197, 61);
            txt_maKL.Margin = new Padding(3, 4, 3, 4);
            txt_maKL.Name = "txt_maKL";
            txt_maKL.Size = new Size(241, 27);
            txt_maKL.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 271);
            label4.Name = "label4";
            label4.Size = new Size(127, 28);
            label4.TabIndex = 29;
            label4.Text = "Lỗi vi phạm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 201);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 28;
            label3.Text = "Mã Tòa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 135);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 27;
            label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 26;
            label1.Text = "Mã kỹ luật:";
            // 
            // dtg_kyLuat
            // 
            dtg_kyLuat.BackgroundColor = SystemColors.ControlLightLight;
            dtg_kyLuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kyLuat.Location = new Point(633, 4);
            dtg_kyLuat.Name = "dtg_kyLuat";
            dtg_kyLuat.RowHeadersWidth = 51;
            dtg_kyLuat.RowTemplate.Height = 29;
            dtg_kyLuat.Size = new Size(588, 805);
            dtg_kyLuat.TabIndex = 1;
            dtg_kyLuat.CellClick += dtg_kyLuat_CellClick;
            dtg_kyLuat.CellContentClick += dtg_kyLuat_CellContentClick;
            dtg_kyLuat.CellDoubleClick += dtg_kyLuat_CellDoubleClick;
            // 
            // KyLuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtg_kyLuat);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KyLuat";
            Size = new Size(1224, 817);
            Load += KyLuat_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_kyLuat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private Panel panel2;
        private Button btn_xoa;
        private Button btn_add;
        private DateTimePicker dtp_ngay;
        private Label label5;
        private TextBox txt_loi;
        private TextBox txt_maToa;
        private TextBox txt_maSV;
        private TextBox txt_maKL;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox txt_timKiem;
        private Label label6;
        private DataGridView dtg_kyLuat;
        private Button btn_canhCao;
    }
}
