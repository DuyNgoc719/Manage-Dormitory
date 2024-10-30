namespace doandbms.User
{
    partial class InforQly
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
            txt_MaToaQl = new TextBox();
            txt_Name = new TextBox();
            txt_MaQl = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Update = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Update);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 607);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_MaToaQl);
            panel2.Controls.Add(txt_Name);
            panel2.Controls.Add(txt_MaQl);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(84, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 374);
            panel2.TabIndex = 20;
            // 
            // txt_MaToaQl
            // 
            txt_MaToaQl.Location = new Point(215, 257);
            txt_MaToaQl.Name = "txt_MaToaQl";
            txt_MaToaQl.Size = new Size(211, 23);
            txt_MaToaQl.TabIndex = 24;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(215, 185);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(211, 23);
            txt_Name.TabIndex = 23;
            // 
            // txt_MaQl
            // 
            txt_MaQl.Location = new Point(215, 114);
            txt_MaQl.Name = "txt_MaQl";
            txt_MaQl.Size = new Size(211, 23);
            txt_MaQl.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 255);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 20;
            label3.Text = "Tòa Quản Lí:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 185);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 19;
            label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 117);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 18;
            label1.Text = "Mã Quản Lí:";
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.Black;
            btn_Update.Location = new Point(652, 210);
            btn_Update.Margin = new Padding(3, 2, 3, 2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(134, 36);
            btn_Update.TabIndex = 18;
            btn_Update.Text = "Cập nhật";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // InforQly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 574);
            Controls.Add(panel1);
            Name = "InforQly";
            Load += InforQly_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_MaToaQl;
        private TextBox txt_Name;
        private TextBox txt_MaQl;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Update;
    }
}
