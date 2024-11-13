namespace doandbms.User
{
    partial class signUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_RePassword = new TextBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            btn_Reg = new Button();
            label5 = new Label();
            btnSelect_Qly = new RadioButton();
            btnSelect_Sv = new RadioButton();
            txt_Email = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(371, 26);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 26);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 397);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 19;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 336);
            label3.Name = "label3";
            label3.Size = new Size(144, 18);
            label3.TabIndex = 18;
            label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 272);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 17;
            label2.Text = "Mật Khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 217);
            label1.Name = "label1";
            label1.Size = new Size(115, 18);
            label1.TabIndex = 16;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // txt_RePassword
            // 
            txt_RePassword.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_RePassword.Location = new Point(175, 329);
            txt_RePassword.Name = "txt_RePassword";
            txt_RePassword.PasswordChar = '*';
            txt_RePassword.Size = new Size(204, 25);
            txt_RePassword.TabIndex = 14;
            txt_RePassword.TextChanged += txt_RePassword_TextChanged;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(175, 265);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(204, 25);
            txt_Password.TabIndex = 13;
            txt_Password.TextChanged += txt_Password_TextChanged;
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Username.Location = new Point(175, 210);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(204, 25);
            txt_Username.TabIndex = 12;
            // 
            // btn_Reg
            // 
            btn_Reg.Cursor = Cursors.Hand;
            btn_Reg.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Reg.Location = new Point(300, 498);
            btn_Reg.Name = "btn_Reg";
            btn_Reg.Size = new Size(88, 37);
            btn_Reg.TabIndex = 11;
            btn_Reg.Text = "Đăng Ký";
            btn_Reg.UseVisualStyleBackColor = true;
            btn_Reg.Click += btn_Reg_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(9, 450);
            label5.Name = "label5";
            label5.Size = new Size(52, 17);
            label5.TabIndex = 22;
            label5.Text = "Bạn là:";
            // 
            // btnSelect_Qly
            // 
            btnSelect_Qly.AutoSize = true;
            btnSelect_Qly.Location = new Point(175, 445);
            btnSelect_Qly.Name = "btnSelect_Qly";
            btnSelect_Qly.Size = new Size(79, 22);
            btnSelect_Qly.TabIndex = 23;
            btnSelect_Qly.TabStop = true;
            btnSelect_Qly.Text = "Quản lý";
            btnSelect_Qly.UseVisualStyleBackColor = true;
            // 
            // btnSelect_Sv
            // 
            btnSelect_Sv.AutoSize = true;
            btnSelect_Sv.Location = new Point(291, 445);
            btnSelect_Sv.Name = "btnSelect_Sv";
            btnSelect_Sv.Size = new Size(88, 22);
            btnSelect_Sv.TabIndex = 24;
            btnSelect_Sv.TabStop = true;
            btnSelect_Sv.Text = "Sinh viên";
            btnSelect_Sv.UseVisualStyleBackColor = true;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Email.Location = new Point(175, 390);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(204, 25);
            txt_Email.TabIndex = 15;
            txt_Email.TabStop = false;
            // 
            // signUp
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 561);
            Controls.Add(btnSelect_Sv);
            Controls.Add(btnSelect_Qly);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Email);
            Controls.Add(txt_RePassword);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(btn_Reg);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUp";
            Load += signUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_RePassword;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Reg;
        private Label label5;
        private RadioButton btnSelect_Qly;
        private RadioButton btnSelect_Sv;
        private TextBox txt_Email;
    }
}