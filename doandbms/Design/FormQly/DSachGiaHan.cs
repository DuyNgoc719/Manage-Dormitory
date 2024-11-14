using doandbms.Dbs;
using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.Design.FormQly
{
    public partial class DSachGiaHan : UserControl
    {
        QlyRepository qlyRepository = new QlyRepository();
        QuanLy quanLy = new QuanLy();
        public DSachGiaHan(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }

        private void dtg_giahan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_accpet_Click(object sender, EventArgs e)
        {

        }

        private void DSachGiaHan_Load(object sender, EventArgs e)
        {
            dtg_giahan.DataSource = qlyRepository.LoadSkDatPhong(quanLy.MaQl);
        }
    }
}
