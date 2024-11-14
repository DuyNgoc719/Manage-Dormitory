namespace doandbms.Design
{
    partial class QuanLiDienNuoc
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
            txt_thangD = new TextBox();
            dtg_tienDien = new DataGridView();
            label16 = new Label();
            btn_xoaTienDien = new Button();
            btn_addTienDien = new Button();
            txt_tienDien = new TextBox();
            txt_soDienCuoiThang = new TextBox();
            txt_soDienDauThang = new TextBox();
            txt_maPhongD = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txt_thangN = new TextBox();
            dtg_tienNuoc = new DataGridView();
            btn_xoaTienNuoc = new Button();
            label10 = new Label();
            btn_addTienNuoc = new Button();
            label9 = new Label();
            label8 = new Label();
            txt_tienNuoc = new TextBox();
            label7 = new Label();
            txt_soNuocCuoiThang = new TextBox();
            label6 = new Label();
            txt_soNuocDauThang = new TextBox();
            txt_maPhongN = new TextBox();
            label17 = new Label();
            panel3 = new Panel();
            cbx_trangThai = new ComboBox();
            label24 = new Label();
            txt_thang = new TextBox();
            dtg_hoaDon = new DataGridView();
            label23 = new Label();
            label18 = new Label();
            txtSearch = new TextBox();
            panel4 = new Panel();
            textBox16 = new TextBox();
            textBox1 = new TextBox();
            label22 = new Label();
            textBox15 = new TextBox();
            label21 = new Label();
            textBox14 = new TextBox();
            label20 = new Label();
            label19 = new Label();
            btn_xoaHD = new Button();
            btn_addHD = new Button();
            txt_tongTien = new TextBox();
            txt_maPhong = new TextBox();
            txt_maHD = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_tienDien).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_tienNuoc).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoaDon).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_thangD);
            panel1.Controls.Add(dtg_tienDien);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(btn_xoaTienDien);
            panel1.Controls.Add(btn_addTienDien);
            panel1.Controls.Add(txt_tienDien);
            panel1.Controls.Add(txt_soDienCuoiThang);
            panel1.Controls.Add(txt_soDienDauThang);
            panel1.Controls.Add(txt_maPhongD);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 388);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txt_thangD
            // 
            txt_thangD.Location = new Point(413, 75);
            txt_thangD.Name = "txt_thangD";
            txt_thangD.Size = new Size(114, 27);
            txt_thangD.TabIndex = 17;
            txt_thangD.TextChanged += txt_thangD_TextChanged;
            // 
            // dtg_tienDien
            // 
            dtg_tienDien.BackgroundColor = SystemColors.ControlLightLight;
            dtg_tienDien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_tienDien.Location = new Point(0, 28);
            dtg_tienDien.Name = "dtg_tienDien";
            dtg_tienDien.RowHeadersWidth = 51;
            dtg_tienDien.RowTemplate.Height = 29;
            dtg_tienDien.Size = new Size(260, 340);
            dtg_tienDien.TabIndex = 16;
            dtg_tienDien.CellClick += dtg_tienDien_CellClick;
            dtg_tienDien.CellContentClick += dtg_tienDien_CellContentClick;
            dtg_tienDien.CellDoubleClick += dtg_tienDien_CellDoubleClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(70, 20);
            label16.TabIndex = 15;
            label16.Text = "Tiền điện";
            // 
            // btn_xoaTienDien
            // 
            btn_xoaTienDien.Location = new Point(419, 292);
            btn_xoaTienDien.Margin = new Padding(3, 4, 3, 4);
            btn_xoaTienDien.Name = "btn_xoaTienDien";
            btn_xoaTienDien.Size = new Size(86, 31);
            btn_xoaTienDien.TabIndex = 13;
            btn_xoaTienDien.Text = "Xóa";
            btn_xoaTienDien.UseVisualStyleBackColor = true;
            // 
            // btn_addTienDien
            // 
            btn_addTienDien.Location = new Point(299, 292);
            btn_addTienDien.Margin = new Padding(3, 4, 3, 4);
            btn_addTienDien.Name = "btn_addTienDien";
            btn_addTienDien.Size = new Size(86, 31);
            btn_addTienDien.TabIndex = 12;
            btn_addTienDien.Text = "Thêm";
            btn_addTienDien.UseVisualStyleBackColor = true;
            btn_addTienDien.Click += btn_addTienDien_Click;
            // 
            // txt_tienDien
            // 
            txt_tienDien.Location = new Point(413, 198);
            txt_tienDien.Margin = new Padding(3, 4, 3, 4);
            txt_tienDien.Name = "txt_tienDien";
            txt_tienDien.Size = new Size(114, 27);
            txt_tienDien.TabIndex = 10;
            // 
            // txt_soDienCuoiThang
            // 
            txt_soDienCuoiThang.Location = new Point(413, 160);
            txt_soDienCuoiThang.Margin = new Padding(3, 4, 3, 4);
            txt_soDienCuoiThang.Name = "txt_soDienCuoiThang";
            txt_soDienCuoiThang.Size = new Size(114, 27);
            txt_soDienCuoiThang.TabIndex = 9;
            // 
            // txt_soDienDauThang
            // 
            txt_soDienDauThang.Location = new Point(413, 117);
            txt_soDienDauThang.Margin = new Padding(3, 4, 3, 4);
            txt_soDienDauThang.Name = "txt_soDienDauThang";
            txt_soDienDauThang.Size = new Size(114, 27);
            txt_soDienDauThang.TabIndex = 8;
            txt_soDienDauThang.TextChanged += textBox3_TextChanged;
            // 
            // txt_maPhongD
            // 
            txt_maPhongD.Location = new Point(413, 33);
            txt_maPhongD.Margin = new Padding(3, 4, 3, 4);
            txt_maPhongD.Name = "txt_maPhongD";
            txt_maPhongD.Size = new Size(114, 27);
            txt_maPhongD.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 201);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 5;
            label5.Text = "Tiền điện:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 163);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 4;
            label4.Text = "Số điện cuối tháng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 120);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 3;
            label3.Text = "Số điện đầu tháng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 79);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Tháng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã phòng:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_thangN);
            panel2.Controls.Add(dtg_tienNuoc);
            panel2.Controls.Add(btn_xoaTienNuoc);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btn_addTienNuoc);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_tienNuoc);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_soNuocCuoiThang);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_soNuocDauThang);
            panel2.Controls.Add(txt_maPhongN);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(589, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 388);
            panel2.TabIndex = 1;
            // 
            // txt_thangN
            // 
            txt_thangN.Location = new Point(486, 101);
            txt_thangN.Name = "txt_thangN";
            txt_thangN.Size = new Size(114, 27);
            txt_thangN.TabIndex = 42;
            // 
            // dtg_tienNuoc
            // 
            dtg_tienNuoc.BackgroundColor = SystemColors.ControlLightLight;
            dtg_tienNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_tienNuoc.Location = new Point(3, 29);
            dtg_tienNuoc.Name = "dtg_tienNuoc";
            dtg_tienNuoc.RowHeadersWidth = 51;
            dtg_tienNuoc.RowTemplate.Height = 29;
            dtg_tienNuoc.Size = new Size(304, 340);
            dtg_tienNuoc.TabIndex = 17;
            dtg_tienNuoc.CellClick += dtg_tienNuoc_CellClick;
            dtg_tienNuoc.CellContentClick += dtg_tienNuoc_CellContentClick;
            dtg_tienNuoc.CellDoubleClick += dtg_tienNuoc_CellDoubleClick;
            // 
            // btn_xoaTienNuoc
            // 
            btn_xoaTienNuoc.Location = new Point(482, 292);
            btn_xoaTienNuoc.Margin = new Padding(3, 4, 3, 4);
            btn_xoaTienNuoc.Name = "btn_xoaTienNuoc";
            btn_xoaTienNuoc.Size = new Size(86, 31);
            btn_xoaTienNuoc.TabIndex = 41;
            btn_xoaTienNuoc.Text = "Xóa";
            btn_xoaTienNuoc.UseVisualStyleBackColor = true;
            btn_xoaTienNuoc.Click += btn_xoaTienNuoc_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 63);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 30;
            label10.Text = "Mã phòng:";
            // 
            // btn_addTienNuoc
            // 
            btn_addTienNuoc.Location = new Point(353, 292);
            btn_addTienNuoc.Margin = new Padding(3, 4, 3, 4);
            btn_addTienNuoc.Name = "btn_addTienNuoc";
            btn_addTienNuoc.Size = new Size(86, 31);
            btn_addTienNuoc.TabIndex = 40;
            btn_addTienNuoc.Text = "Thêm";
            btn_addTienNuoc.UseVisualStyleBackColor = true;
            btn_addTienNuoc.Click += btn_addTienNuoc_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(343, 108);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 31;
            label9.Text = "Tháng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 149);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 32;
            label8.Text = "Số nước đầu tháng:";
            // 
            // txt_tienNuoc
            // 
            txt_tienNuoc.Location = new Point(486, 228);
            txt_tienNuoc.Margin = new Padding(3, 4, 3, 4);
            txt_tienNuoc.Name = "txt_tienNuoc";
            txt_tienNuoc.Size = new Size(114, 27);
            txt_tienNuoc.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(343, 192);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 33;
            label7.Text = "Số nước cuối tháng:";
            // 
            // txt_soNuocCuoiThang
            // 
            txt_soNuocCuoiThang.Location = new Point(486, 185);
            txt_soNuocCuoiThang.Margin = new Padding(3, 4, 3, 4);
            txt_soNuocCuoiThang.Name = "txt_soNuocCuoiThang";
            txt_soNuocCuoiThang.Size = new Size(114, 27);
            txt_soNuocCuoiThang.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(343, 231);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 34;
            label6.Text = "Tiền nước:";
            // 
            // txt_soNuocDauThang
            // 
            txt_soNuocDauThang.Location = new Point(486, 146);
            txt_soNuocDauThang.Margin = new Padding(3, 4, 3, 4);
            txt_soNuocDauThang.Name = "txt_soNuocDauThang";
            txt_soNuocDauThang.Size = new Size(114, 27);
            txt_soNuocDauThang.TabIndex = 36;
            // 
            // txt_maPhongN
            // 
            txt_maPhongN.Location = new Point(486, 60);
            txt_maPhongN.Margin = new Padding(3, 4, 3, 4);
            txt_maPhongN.Name = "txt_maPhongN";
            txt_maPhongN.Size = new Size(114, 27);
            txt_maPhongN.TabIndex = 35;
            // 
            // label17
            // 
            label17.AccessibleRole = AccessibleRole.MenuBar;
            label17.AutoSize = true;
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(74, 20);
            label17.TabIndex = 29;
            label17.Text = "Tiền nước";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cbx_trangThai);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(txt_thang);
            panel3.Controls.Add(dtg_hoaDon);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btn_xoaHD);
            panel3.Controls.Add(btn_addHD);
            panel3.Controls.Add(txt_tongTien);
            panel3.Controls.Add(txt_maPhong);
            panel3.Controls.Add(txt_maHD);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Location = new Point(3, 400);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1217, 417);
            panel3.TabIndex = 2;
            // 
            // cbx_trangThai
            // 
            cbx_trangThai.FormattingEnabled = true;
            cbx_trangThai.Items.AddRange(new object[] { "True", "False" });
            cbx_trangThai.Location = new Point(589, 260);
            cbx_trangThai.Name = "cbx_trangThai";
            cbx_trangThai.Size = new Size(114, 28);
            cbx_trangThai.TabIndex = 47;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label24.Location = new Point(650, 331);
            label24.Name = "label24";
            label24.Size = new Size(105, 28);
            label24.TabIndex = 46;
            label24.Text = "Tìm kiếm:";
            // 
            // txt_thang
            // 
            txt_thang.Location = new Point(589, 176);
            txt_thang.Name = "txt_thang";
            txt_thang.Size = new Size(114, 27);
            txt_thang.TabIndex = 45;
            // 
            // dtg_hoaDon
            // 
            dtg_hoaDon.BackgroundColor = SystemColors.ControlLightLight;
            dtg_hoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoaDon.GridColor = Color.DarkCyan;
            dtg_hoaDon.Location = new Point(-1, 28);
            dtg_hoaDon.Name = "dtg_hoaDon";
            dtg_hoaDon.RowHeadersWidth = 51;
            dtg_hoaDon.RowTemplate.Height = 29;
            dtg_hoaDon.Size = new Size(386, 384);
            dtg_hoaDon.TabIndex = 43;
            dtg_hoaDon.CellClick += dtg_hoaDon_CellClick;
            dtg_hoaDon.CellDoubleClick += dtg_hoaDon_CellDoubleClick;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(793, 40);
            label23.Name = "label23";
            label23.Size = new Size(72, 20);
            label23.TabIndex = 33;
            label23.Text = "Tổng tiền";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 5);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 32;
            label18.Text = "Hóa đơn";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(770, 331);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 27);
            txtSearch.TabIndex = 31;
            txtSearch.TextChanged += textBox13_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox16);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label22);
            panel4.Controls.Add(textBox15);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(textBox14);
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label19);
            panel4.Location = new Point(793, 75);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(351, 227);
            panel4.TabIndex = 30;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(174, 172);
            textBox16.Margin = new Padding(3, 4, 3, 4);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(114, 27);
            textBox16.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 44;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(46, 176);
            label22.Name = "label22";
            label22.Size = new Size(58, 20);
            label22.TabIndex = 32;
            label22.Text = "Còn lại:";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(174, 123);
            textBox15.Margin = new Padding(3, 4, 3, 4);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(114, 27);
            textBox15.TabIndex = 31;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(46, 127);
            label21.Name = "label21";
            label21.Size = new Size(100, 20);
            label21.TabIndex = 30;
            label21.Text = "Tiền đã đóng:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(174, 72);
            textBox14.Margin = new Padding(3, 4, 3, 4);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(114, 27);
            textBox14.TabIndex = 29;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(46, 76);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 28;
            label20.Text = "Tổng tiền";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(46, 25);
            label19.Name = "label19";
            label19.Size = new Size(53, 20);
            label19.TabIndex = 26;
            label19.Text = "Tháng:";
            // 
            // btn_xoaHD
            // 
            btn_xoaHD.Location = new Point(516, 311);
            btn_xoaHD.Margin = new Padding(3, 4, 3, 4);
            btn_xoaHD.Name = "btn_xoaHD";
            btn_xoaHD.Size = new Size(86, 48);
            btn_xoaHD.TabIndex = 27;
            btn_xoaHD.Text = "Xóa";
            btn_xoaHD.UseVisualStyleBackColor = true;
            btn_xoaHD.Click += btn_xoaHD_Click;
            // 
            // btn_addHD
            // 
            btn_addHD.Location = new Point(409, 311);
            btn_addHD.Margin = new Padding(3, 4, 3, 4);
            btn_addHD.Name = "btn_addHD";
            btn_addHD.Size = new Size(86, 48);
            btn_addHD.TabIndex = 26;
            btn_addHD.Text = "Thêm";
            btn_addHD.UseVisualStyleBackColor = true;
            btn_addHD.Click += button9_Click;
            // 
            // txt_tongTien
            // 
            txt_tongTien.Location = new Point(589, 220);
            txt_tongTien.Margin = new Padding(3, 4, 3, 4);
            txt_tongTien.Name = "txt_tongTien";
            txt_tongTien.Size = new Size(114, 27);
            txt_tongTien.TabIndex = 23;
            // 
            // txt_maPhong
            // 
            txt_maPhong.Location = new Point(589, 132);
            txt_maPhong.Margin = new Padding(3, 4, 3, 4);
            txt_maPhong.Name = "txt_maPhong";
            txt_maPhong.Size = new Size(114, 27);
            txt_maPhong.TabIndex = 22;
            // 
            // txt_maHD
            // 
            txt_maHD.Location = new Point(589, 91);
            txt_maHD.Margin = new Padding(3, 4, 3, 4);
            txt_maHD.Name = "txt_maHD";
            txt_maHD.Size = new Size(114, 27);
            txt_maHD.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(461, 263);
            label11.Name = "label11";
            label11.Size = new Size(75, 20);
            label11.TabIndex = 20;
            label11.Text = "Trạng thái";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(461, 224);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 19;
            label12.Text = "Tổng tiền";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(461, 140);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 18;
            label13.Text = "Mã phòng:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(461, 179);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 17;
            label14.Text = "Tháng:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(461, 95);
            label15.Name = "label15";
            label15.Size = new Size(92, 20);
            label15.TabIndex = 16;
            label15.Text = "Mã hóa đơn:";
            // 
            // QuanLiDienNuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLiDienNuoc";
            Size = new Size(1224, 817);
            Load += QuanLiDienNuoc_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_tienDien).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_tienNuoc).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoaDon).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_tienDien;
        private TextBox txt_soDienCuoiThang;
        private TextBox txt_soDienDauThang;
        private TextBox txt_maPhongD;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label16;
        private Button btn_xoaTienDien;
        private Button btn_addTienDien;
        private Label label17;
        private Label label18;
        private TextBox txtSearch;
        private Panel panel4;
        private TextBox textBox16;
        private Label label22;
        private TextBox textBox15;
        private Label label21;
        private TextBox textBox14;
        private Label label20;
        private Label label19;
        private Button btn_xoaHD;
        private Button btn_addHD;
        private TextBox txt_tongTien;
        private TextBox txt_maPhong;
        private TextBox txt_maHD;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btn_xoaTienNuoc;
        private Label label10;
        private Button btn_addTienNuoc;
        private Label label9;
        private Label label8;
        private TextBox txt_tienNuoc;
        private Label label7;
        private TextBox txt_soNuocCuoiThang;
        private Label label6;
        private TextBox txt_soNuocDauThang;
        private TextBox txt_maPhongN;
        private Label label23;
        private DataGridView dtg_tienDien;
        private DataGridView dtg_tienNuoc;
        private DataGridView dtg_hoaDon;
        private TextBox txt_thangD;
        private TextBox txt_thangN;
        private TextBox txt_thang;
        private TextBox textBox1;
        private Label label24;
        private ComboBox cbx_trangThai;
    }
}
