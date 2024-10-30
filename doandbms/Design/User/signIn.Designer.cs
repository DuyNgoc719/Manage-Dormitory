namespace doandbms.User
{
    partial class signIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            btn_Login = new Button();
            lbl_Register = new LinkLabel();
            lbl_ForgotPass = new LinkLabel();
            label1 = new Label();
            btn_SelectSv = new RadioButton();
            btn_SelectQl = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(58, 314);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 28);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(58, 270);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(335, 11);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 51);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(98, 322);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(197, 23);
            txt_Password.TabIndex = 15;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(98, 273);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(197, 23);
            txt_Username.TabIndex = 14;
            // 
            // btn_Login
            // 
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Login.Location = new Point(138, 388);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(105, 38);
            btn_Login.TabIndex = 13;
            btn_Login.Text = "Đăng Nhập";
            btn_Login.TextImageRelation = TextImageRelation.TextAboveImage;
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // lbl_Register
            // 
            lbl_Register.AutoSize = true;
            lbl_Register.BackColor = Color.Transparent;
            lbl_Register.Cursor = Cursors.Hand;
            lbl_Register.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Register.LinkColor = Color.LightSkyBlue;
            lbl_Register.Location = new Point(246, 354);
            lbl_Register.Name = "lbl_Register";
            lbl_Register.Size = new Size(53, 15);
            lbl_Register.TabIndex = 12;
            lbl_Register.TabStop = true;
            lbl_Register.Text = "Đăng Ký";
            lbl_Register.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lbl_ForgotPass
            // 
            lbl_ForgotPass.AutoSize = true;
            lbl_ForgotPass.BackColor = Color.Transparent;
            lbl_ForgotPass.Cursor = Cursors.Hand;
            lbl_ForgotPass.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ForgotPass.LinkColor = Color.LightSkyBlue;
            lbl_ForgotPass.Location = new Point(23, 354);
            lbl_ForgotPass.Name = "lbl_ForgotPass";
            lbl_ForgotPass.Size = new Size(100, 15);
            lbl_ForgotPass.TabIndex = 11;
            lbl_ForgotPass.TabStop = true;
            lbl_ForgotPass.Text = "Quên Mật Khẩu?";
            lbl_ForgotPass.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 224);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 20;
            label1.Text = "Bạn là:";
            label1.Click += label1_Click;
            // 
            // btn_SelectSv
            // 
            btn_SelectSv.AutoSize = true;
            btn_SelectSv.Location = new Point(122, 226);
            btn_SelectSv.Name = "btn_SelectSv";
            btn_SelectSv.Size = new Size(73, 19);
            btn_SelectSv.TabIndex = 21;
            btn_SelectSv.TabStop = true;
            btn_SelectSv.Text = "Sinh viên";
            btn_SelectSv.UseVisualStyleBackColor = true;
            // 
            // btn_SelectQl
            // 
            btn_SelectQl.AutoSize = true;
            btn_SelectQl.Location = new Point(209, 226);
            btn_SelectQl.Name = "btn_SelectQl";
            btn_SelectQl.Size = new Size(63, 19);
            btn_SelectQl.TabIndex = 22;
            btn_SelectQl.TabStop = true;
            btn_SelectQl.Text = "Quản lí";
            btn_SelectQl.UseVisualStyleBackColor = true;
            // 
            // signIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(btn_SelectQl);
            Controls.Add(btn_SelectSv);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Register);
            Controls.Add(lbl_ForgotPass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "signIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Login;
        private LinkLabel lbl_Register;
        private LinkLabel lbl_ForgotPass;
        private Label label1;
        private RadioButton btn_SelectSv;
        private RadioButton btn_SelectQl;
    }
}