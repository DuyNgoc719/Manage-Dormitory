namespace doandbms
{
    partial class GiaoDienSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienSinhVien));
            menuButton = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_qlSv = new Button();
            panel3 = new Panel();
            button1 = new Button();
            btn_qlDn = new Button();
            btn_inforQl = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            mainForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.ImeMode = ImeMode.NoControl;
            menuButton.Location = new Point(8, 17);
            menuButton.Margin = new Padding(3, 2, 3, 2);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(46, 37);
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
            sidebar.Controls.Add(btn_inforQl);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.MaximumSize = new Size(216, 620);
            sidebar.MinimumSize = new Size(72, 620);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(216, 620);
            sidebar.TabIndex = 5;
            sidebar.Paint += sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuButton);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(74, 24);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_qlSv);
            panel2.Location = new Point(3, 80);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 46);
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
            btn_qlSv.Location = new Point(-13, -13);
            btn_qlSv.Margin = new Padding(3, 2, 3, 2);
            btn_qlSv.Name = "btn_qlSv";
            btn_qlSv.Padding = new Padding(18, 6, 0, 0);
            btn_qlSv.Size = new Size(264, 66);
            btn_qlSv.TabIndex = 1;
            btn_qlSv.Text = "              Thông tin sinh viên";
            btn_qlSv.TextAlign = ContentAlignment.MiddleLeft;
            btn_qlSv.UseVisualStyleBackColor = false;
            btn_qlSv.Click += btn_qlSv_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btn_qlDn);
            panel3.Location = new Point(3, 130);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 46);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(3, 180);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(18, 6, 0, 0);
            button1.Size = new Size(264, 66);
            button1.TabIndex = 2;
            button1.Text = "              Hợp đồng / đổi tòa";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
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
            btn_qlDn.Location = new Point(-13, -13);
            btn_qlDn.Margin = new Padding(3, 2, 3, 2);
            btn_qlDn.Name = "btn_qlDn";
            btn_qlDn.Padding = new Padding(18, 6, 0, 0);
            btn_qlDn.Size = new Size(264, 66);
            btn_qlDn.TabIndex = 1;
            btn_qlDn.Text = "              Hợp đồng / đổi tòa";
            btn_qlDn.TextAlign = ContentAlignment.MiddleLeft;
            btn_qlDn.UseVisualStyleBackColor = false;
            btn_qlDn.Click += btn_qlDn_Click;
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
            btn_inforQl.Location = new Point(3, 180);
            btn_inforQl.Margin = new Padding(3, 2, 3, 2);
            btn_inforQl.Name = "btn_inforQl";
            btn_inforQl.Padding = new Padding(5, 6, 0, 0);
            btn_inforQl.RightToLeft = RightToLeft.No;
            btn_inforQl.Size = new Size(264, 66);
            btn_inforQl.TabIndex = 3;
            btn_inforQl.Text = "              Kỷ luật";
            btn_inforQl.TextAlign = ContentAlignment.MiddleLeft;
            btn_inforQl.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // mainForm
            // 
            mainForm.Location = new Point(213, -4);
            mainForm.Margin = new Padding(3, 2, 3, 2);
            mainForm.Name = "mainForm";
            mainForm.Size = new Size(1071, 613);
            mainForm.TabIndex = 6;
            // 
            // GiaoDienSinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 612);
            Controls.Add(sidebar);
            Controls.Add(mainForm);
            Name = "GiaoDienSinhVien";
            Text = "GiaoDienHocSinh";
            Load += GiaoDienSinhVien_Load;
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Timer sidebarTimer;
        public Panel mainForm;
        private Button button1;
        private Button btn_inforQl;
    }
}