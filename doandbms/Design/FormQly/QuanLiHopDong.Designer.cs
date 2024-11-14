namespace doandbms.Design
{
    partial class QuanLiHopDong
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
            dtg_hopDong = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            txt_searchHopDong = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hopDong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dtg_hopDong);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_searchHopDong);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 607);
            panel1.TabIndex = 0;
            // 
            // dtg_hopDong
            // 
            dtg_hopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hopDong.Location = new Point(65, 114);
            dtg_hopDong.Name = "dtg_hopDong";
            dtg_hopDong.RowTemplate.Height = 25;
            dtg_hopDong.Size = new Size(615, 461);
            dtg_hopDong.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 6;
            label1.Text = "Quản lí hợp đồng";
            // 
            // button1
            // 
            button1.Location = new Point(813, 326);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_searchHopDong
            // 
            txt_searchHopDong.Location = new Point(740, 276);
            txt_searchHopDong.Name = "txt_searchHopDong";
            txt_searchHopDong.Size = new Size(218, 23);
            txt_searchHopDong.TabIndex = 3;
            txt_searchHopDong.TextChanged += textBox1_TextChanged;
            // 
            // QuanLiHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "QuanLiHopDong";
            Size = new Size(1071, 613);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hopDong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox txt_searchHopDong;
        private Label label1;
        private DataGridView dtg_hopDong;
    }
}
