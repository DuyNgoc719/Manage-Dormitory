namespace doandbms.Design.FormQly
{
    partial class DSachGiaHan
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
            label1 = new Label();
            dtg_giahan = new DataGridView();
            btn_accpet = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_giahan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(402, 59);
            label1.Name = "label1";
            label1.Size = new Size(258, 37);
            label1.TabIndex = 0;
            label1.Text = "Danh Sách Gia Hạn";
            // 
            // dtg_giahan
            // 
            dtg_giahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_giahan.Location = new Point(122, 143);
            dtg_giahan.Name = "dtg_giahan";
            dtg_giahan.RowTemplate.Height = 25;
            dtg_giahan.Size = new Size(830, 342);
            dtg_giahan.TabIndex = 1;
            dtg_giahan.CellContentClick += dtg_giahan_CellContentClick;
            // 
            // btn_accpet
            // 
            btn_accpet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_accpet.Location = new Point(805, 520);
            btn_accpet.Name = "btn_accpet";
            btn_accpet.Size = new Size(147, 70);
            btn_accpet.TabIndex = 2;
            btn_accpet.Text = "Duyệt";
            btn_accpet.UseVisualStyleBackColor = true;
            btn_accpet.Click += btn_accpet_Click;
            // 
            // DSachGiaHan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_accpet);
            Controls.Add(dtg_giahan);
            Controls.Add(label1);
            Name = "DSachGiaHan";
            Size = new Size(1071, 613);
            Load += DSachGiaHan_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_giahan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtg_giahan;
        private Button btn_accpet;
    }
}
