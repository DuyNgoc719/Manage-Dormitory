namespace doandbms.Design
{
    partial class UserQuanLi
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
            txt_chucVu = new TextBox();
            txt_maToaQl = new TextBox();
            txt_name = new TextBox();
            txt_maQl = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            btn_updateQli = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_updateQli);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 607);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_chucVu);
            panel2.Controls.Add(txt_maToaQl);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(txt_maQl);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(84, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 374);
            panel2.TabIndex = 20;
            // 
            // txt_chucVu
            // 
            txt_chucVu.Location = new Point(214, 282);
            txt_chucVu.Name = "txt_chucVu";
            txt_chucVu.ReadOnly = true;
            txt_chucVu.Size = new Size(211, 23);
            txt_chucVu.TabIndex = 25;
            // 
            // txt_maToaQl
            // 
            txt_maToaQl.Location = new Point(214, 213);
            txt_maToaQl.Name = "txt_maToaQl";
            txt_maToaQl.Size = new Size(211, 23);
            txt_maToaQl.TabIndex = 24;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(214, 141);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(211, 23);
            txt_name.TabIndex = 23;
            // 
            // txt_maQl
            // 
            txt_maQl.Location = new Point(214, 70);
            txt_maQl.Name = "txt_maQl";
            txt_maQl.ReadOnly = true;
            txt_maQl.Size = new Size(211, 23);
            txt_maQl.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(66, 280);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 21;
            label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(66, 211);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 20;
            label3.Text = "Tòa Quản Lí:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(66, 141);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 19;
            label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 73);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 18;
            label1.Text = "Mã Quản Lí:";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(652, 290);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 19;
            button2.Text = "Đổi mật khẩu";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_updateQli
            // 
            btn_updateQli.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btn_updateQli.ForeColor = Color.Black;
            btn_updateQli.Location = new Point(652, 210);
            btn_updateQli.Margin = new Padding(3, 2, 3, 2);
            btn_updateQli.Name = "btn_updateQli";
            btn_updateQli.Size = new Size(134, 36);
            btn_updateQli.TabIndex = 18;
            btn_updateQli.Text = "Cập nhật";
            btn_updateQli.UseVisualStyleBackColor = true;
            btn_updateQli.Click += btn_updateQli_Click;
            // 
            // UserQuanLi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserQuanLi";
            Size = new Size(1071, 613);
            Load += UserQuanLi_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_chucVu;
        private TextBox txt_maToaQl;
        private TextBox txt_name;
        private TextBox txt_maQl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button btn_updateQli;
    }
}
