using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class ctpm : DevExpress.XtraEditors.XtraForm
    {
        public ctpm()
        {
            InitializeComponent();
        }

        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthemsuapmt_Click(object sender, EventArgs e)
        {

        }

        private void ctpm_Load(object sender, EventArgs e)
        {
            dgvpmt.DataSource = db.PHIEUMUONTRAs;
        }
    }
}