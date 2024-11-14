namespace doandbms.Design.FormSv
{
    partial class GiaHanHopDong
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
            panel3 = new Panel();
            btn_doitoa = new Button();
            textBox2 = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pn_giahan = new Panel();
            btn_giahan = new Button();
            mdf_startday = new DateTimePicker();
            label15 = new Label();
            label1 = new Label();
            txt_ttrang = new Label();
            label2 = new Label();
            txt_soky = new TextBox();
            label3 = new Label();
            lbl_masv = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pn_giahan.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pn_giahan);
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 591);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_doitoa);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(3, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 573);
            panel3.TabIndex = 8;
            // 
            // btn_doitoa
            // 
            btn_doitoa.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_doitoa.Location = new Point(300, 417);
            btn_doitoa.Name = "btn_doitoa";
            btn_doitoa.Size = new Size(96, 39);
            btn_doitoa.TabIndex = 65;
            btn_doitoa.Text = "Yêu cầu";
            btn_doitoa.UseVisualStyleBackColor = true;
            btn_doitoa.Click += btn_doitoa_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(296, 264);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(309, 213);
            label14.Name = "label14";
            label14.Size = new Size(50, 19);
            label14.TabIndex = 10;
            label14.Text = "ToaCu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(296, 312);
            label12.Name = "label12";
            label12.Size = new Size(45, 19);
            label12.TabIndex = 9;
            label12.Text = "None";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(181, 312);
            label13.Name = "label13";
            label13.Size = new Size(83, 19);
            label13.TabIndex = 8;
            label13.Text = "Tình trạng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(205, 213);
            label10.Name = "label10";
            label10.Size = new Size(59, 19);
            label10.TabIndex = 6;
            label10.Text = "Tòa cũ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(105, 264);
            label11.Name = "label11";
            label11.Size = new Size(159, 19);
            label11.TabIndex = 7;
            label11.Text = "Tòa muốn chuyển đến:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(309, 169);
            label9.Name = "label9";
            label9.Size = new Size(50, 19);
            label9.TabIndex = 5;
            label9.Text = "MaSV";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(74, 169);
            label8.Name = "label8";
            label8.Size = new Size(190, 19);
            label8.TabIndex = 2;
            label8.Text = "Mã sinh viên muốn đổi tòa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(189, 44);
            label7.Name = "label7";
            label7.Size = new Size(117, 24);
            label7.TabIndex = 1;
            label7.Text = "Xin Đổi Tòa";
            // 
            // pn_giahan
            // 
            pn_giahan.BorderStyle = BorderStyle.FixedSingle;
            pn_giahan.Controls.Add(btn_giahan);
            pn_giahan.Controls.Add(mdf_startday);
            pn_giahan.Controls.Add(label15);
            pn_giahan.Controls.Add(label1);
            pn_giahan.Controls.Add(txt_ttrang);
            pn_giahan.Controls.Add(label2);
            pn_giahan.Controls.Add(txt_soky);
            pn_giahan.Controls.Add(label3);
            pn_giahan.Controls.Add(lbl_masv);
            pn_giahan.Controls.Add(label4);
            pn_giahan.Location = new Point(537, 29);
            pn_giahan.Name = "pn_giahan";
            pn_giahan.Size = new Size(523, 573);
            pn_giahan.TabIndex = 7;
            // 
            // btn_giahan
            // 
            btn_giahan.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_giahan.Location = new Point(343, 417);
            btn_giahan.Name = "btn_giahan";
            btn_giahan.Size = new Size(96, 39);
            btn_giahan.TabIndex = 64;
            btn_giahan.Text = "Yêu cầu";
            btn_giahan.UseVisualStyleBackColor = true;
            btn_giahan.Click += btn_giahan_Click;
            // 
            // mdf_startday
            // 
            mdf_startday.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mdf_startday.Location = new Point(220, 209);
            mdf_startday.Margin = new Padding(3, 2, 3, 2);
            mdf_startday.Name = "mdf_startday";
            mdf_startday.Size = new Size(219, 23);
            mdf_startday.TabIndex = 63;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(81, 213);
            label15.Name = "label15";
            label15.Size = new Size(103, 19);
            label15.TabIndex = 7;
            label15.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 44);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 0;
            label1.Text = "Gia Hạn Hợp Đồng";
            // 
            // txt_ttrang
            // 
            txt_ttrang.AutoSize = true;
            txt_ttrang.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ttrang.Location = new Point(211, 312);
            txt_ttrang.Name = "txt_ttrang";
            txt_ttrang.Size = new Size(45, 19);
            txt_ttrang.TabIndex = 6;
            txt_ttrang.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(126, 169);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 1;
            label2.Text = "MSSV:";
            // 
            // txt_soky
            // 
            txt_soky.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_soky.Location = new Point(220, 264);
            txt_soky.Name = "txt_soky";
            txt_soky.Size = new Size(100, 26);
            txt_soky.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(127, 267);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 2;
            label3.Text = "Số kỳ:";
            // 
            // lbl_masv
            // 
            lbl_masv.AutoSize = true;
            lbl_masv.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_masv.Location = new Point(220, 169);
            lbl_masv.Name = "lbl_masv";
            lbl_masv.Size = new Size(53, 19);
            lbl_masv.TabIndex = 4;
            lbl_masv.Text = "MaSV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(92, 312);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 3;
            label4.Text = "Tình trạng:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.ForeColor = SystemColors.AppWorkspace;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1077, 43);
            panel4.TabIndex = 50;
            // 
            // GiaHanHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "GiaHanHopDong";
            Size = new Size(1071, 613);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pn_giahan.ResumeLayout(false);
            pn_giahan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label7;
        private Panel pn_giahan;
        private Label txt_ttrang;
        private Label label2;
        private TextBox txt_soky;
        private Label label3;
        private Label lbl_masv;
        private Label label4;
        private TextBox textBox2;
        private Label label14;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label15;
        private DateTimePicker mdf_startday;
        private Button btn_doitoa;
        private Button btn_giahan;
        private Panel panel4;
    }
}
