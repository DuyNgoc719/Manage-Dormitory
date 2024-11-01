namespace doandbms.Design
{
    partial class GiaoDienQuanLi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienQuanLi));
            menuButton = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_qlSv = new Button();
            panel3 = new Panel();
            btn_qlDn = new Button();
            panel4 = new Panel();
            btn_qlPhong = new Button();
            panel5 = new Panel();
            btn_qlHd = new Button();
            btn_inforQl = new Button();
            btn_Kl = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            mainForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.ImeMode = ImeMode.NoControl;
            menuButton.Location = new Point(9, 23);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(53, 49);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.DimGray;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(btn_inforQl);
            sidebar.Controls.Add(btn_Kl);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(247, 827);
            sidebar.MinimumSize = new Size(82, 827);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(82, 827);
            sidebar.TabIndex = 3;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 99);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(85, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_qlSv);
            panel2.Location = new Point(3, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 61);
            panel2.TabIndex = 1;
            // 
            // btn_qlSv
            // 
            btn_qlSv.BackColor = Color.DimGray;
            btn_qlSv.Cursor = Cursors.Hand;
            btn_qlSv.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_qlSv.ForeColor = SystemColors.ButtonHighlight;
            btn_qlSv.Image = (Image)resources.GetObject("btn_qlSv.Image");
            btn_qlSv.ImageAlign = ContentAlignment.MiddleLeft;
            btn_qlSv.ImeMode = ImeMode.NoControl;
            btn_qlSv.Location = new Point(-15, -17);
            btn_qlSv.Name = "btn_qlSv";
            btn_qlSv.Padding = new Padding(21, 8, 0, 0);
            btn_qlSv.Size = new Size(302, 88);
            btn_qlSv.TabIndex = 1;
            btn_qlSv.Text = "              Quản lí sinh viên";
            btn_qlSv.TextAlign = ContentAlignment.MiddleLeft;
            btn_qlSv.UseVisualStyleBackColor = false;
            btn_qlSv.Click += btn_qlSv_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_qlDn);
            panel3.Location = new Point(3, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 61);
            panel3.TabIndex = 2;
            // 
            // btn_qlDn
            // 
            btn_qlDn.BackColor = Color.DimGray;
            btn_qlDn.Cursor = Cursors.Hand;
            btn_qlDn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_qlDn.ForeColor = SystemColors.ButtonHighlight;
            btn_qlDn.Image = (Image)resources.GetObject("btn_qlDn.Image");
            btn_qlDn.ImageAlign = ContentAlignment.MiddleLeft;
            btn_qlDn.ImeMode = ImeMode.NoControl;
            btn_qlDn.Location = new Point(-15, -17);
            btn_qlDn.Name = "btn_qlDn";
            btn_qlDn.Padding = new Padding(21, 8, 0, 0);
            btn_qlDn.Size = new Size(302, 88);
            btn_qlDn.TabIndex = 1;
            btn_qlDn.Text = "              Quản lý điện nước";
            btn_qlDn.TextAlign = ContentAlignment.MiddleLeft;
            btn_qlDn.UseVisualStyleBackColor = false;
            btn_qlDn.Click += btn_qlDn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_qlPhong);
            panel4.Location = new Point(3, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 61);
            panel4.TabIndex = 3;
            // 
            // btn_qlPhong
            // 
            btn_qlPhong.BackColor = Color.DimGray;
            btn_qlPhong.Cursor = Cursors.Hand;
            btn_qlPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_qlPhong.ForeColor = SystemColors.ButtonHighlight;
            btn_qlPhong.Image = (Image)resources.GetObject("btn_qlPhong.Image");
            btn_qlPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btn_qlPhong.ImeMode = ImeMode.NoControl;
            btn_qlPhong.Location = new Point(-15, -17);
            btn_qlPhong.Name = "btn_qlPhong";
            btn_qlPhong.Padding = new Padding(21, 8, 0, 0);
            btn_qlPhong.Size = new Size(302, 88);
            btn_qlPhong.TabIndex = 1;
            btn_qlPhong.Text = "              Quản lý phòng";
            btn_qlPhong.TextAlign = ContentAlignment.MiddleLeft;
            btn_qlPhong.UseVisualStyleBackColor = false;
            btn_qlPhong.Click += btn_qlPhong_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_qlHd);
            panel5.Location = new Point(3, 309);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 61);
            panel5.TabIndex = 4;
            // 
            // btn_qlHd
            // 
            btn_qlHd.BackColor = Color.DimGray;
            btn_qlHd.Cursor = Cursors.Hand;
            btn_qlHd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_qlHd.ForeColor = SystemColors.ButtonHighlight;
            btn_qlHd.Image = (Image)resources.GetObject("btn_qlHd.Image");
            btn_qlHd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_qlHd.ImeMode = ImeMode.NoControl;
            btn_qlHd.Location = new Point(-15, -17);
            btn_qlHd.Name = "btn_qlHd";
            btn_qlHd.Padding = new Padding(21, 8, 0, 0);
            btn_qlHd.Size = new Size(302, 88);
            btn_qlHd.TabIndex = 1;
            btn_qlHd.Text = "              Quản lý hợp đồng";
            btn_qlHd.TextAlign = ContentAlignment.MiddleLeft;
            btn_qlHd.UseVisualStyleBackColor = false;
            btn_qlHd.Click += btn_qlHd_Click;
            // 
            // btn_inforQl
            // 
            btn_inforQl.BackColor = Color.DimGray;
            btn_inforQl.Cursor = Cursors.Hand;
            btn_inforQl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_inforQl.ForeColor = Color.Transparent;
            btn_inforQl.Image = (Image)resources.GetObject("btn_inforQl.Image");
            btn_inforQl.ImageAlign = ContentAlignment.TopLeft;
            btn_inforQl.ImeMode = ImeMode.NoControl;
            btn_inforQl.Location = new Point(3, 376);
            btn_inforQl.Name = "btn_inforQl";
            btn_inforQl.Padding = new Padding(6, 8, 0, 0);
            btn_inforQl.RightToLeft = RightToLeft.No;
            btn_inforQl.Size = new Size(302, 88);
            btn_inforQl.TabIndex = 2;
            btn_inforQl.Text = "              Thông tin quản lí";
            btn_inforQl.TextAlign = ContentAlignment.MiddleLeft;
            btn_inforQl.UseVisualStyleBackColor = false;
            btn_inforQl.Click += btn_inforQl_Click;
            // 
            // btn_Kl
            // 
            btn_Kl.BackColor = Color.DimGray;
            btn_Kl.Cursor = Cursors.Hand;
            btn_Kl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Kl.ForeColor = Color.Transparent;
            btn_Kl.Image = (Image)resources.GetObject("btn_Kl.Image");
            btn_Kl.ImageAlign = ContentAlignment.TopLeft;
            btn_Kl.ImeMode = ImeMode.NoControl;
            btn_Kl.Location = new Point(3, 470);
            btn_Kl.Name = "btn_Kl";
            btn_Kl.Padding = new Padding(6, 8, 0, 0);
            btn_Kl.RightToLeft = RightToLeft.No;
            btn_Kl.Size = new Size(302, 88);
            btn_Kl.TabIndex = 5;
            btn_Kl.Text = "              Kỷ luật";
            btn_Kl.TextAlign = ContentAlignment.MiddleLeft;
            btn_Kl.UseVisualStyleBackColor = false;
            btn_Kl.Click += btn_Kl_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick_1;
            // 
            // mainForm
            // 
            mainForm.Location = new Point(242, 0);
            mainForm.Name = "mainForm";
            mainForm.Size = new Size(1224, 817);
            mainForm.TabIndex = 4;
            // 
            // GiaoDienQuanLi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 816);
            Controls.Add(sidebar);
            Controls.Add(mainForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GiaoDienQuanLi";
            Text = "GiaoDien";
            Load += GiaoDienQuanLi_Load;
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox menuButton;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_qlSv;
        private Panel panel3;
        private Button btn_qlDn;
        private Panel panel4;
        private Button btn_qlPhong;
        private Panel panel5;
        private Button btn_qlHd;
        private Button btn_inforQl;
        private Button btn_Kl;
        private System.Windows.Forms.Timer sidebarTimer;
        public Panel mainForm;
    }
}