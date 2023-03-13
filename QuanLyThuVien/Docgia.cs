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
    public partial class frmDocgia : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();       
        public frmDocgia()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        void DataGridView()
        {
            dgvdg.DataSource = db.DOCGIAs.ToList();
        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            dgvdg.DataSource = db.DOCGIAs;
            cbotimdg.SelectedIndex = 0;        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }



     

        private void btnthemsuadg_Click(object sender, EventArgs e)
        {
            try
            {
                DOCGIA docgia = new DOCGIA();
                docgia.MADOCGIA = txtmadg.Text;
                docgia.TENDOCGIA = txttendg.Text;
                docgia.DIACHI = txtdiachidg.Text;
                docgia.SDTDOCGIA = txtsdtdg.Text;
                var test = db.DOCGIAs.FirstOrDefault(p => p.MADOCGIA == docgia.MADOCGIA);
                if (test == null)
                {
                    db.DOCGIAs.InsertOnSubmit(docgia);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    db.SubmitChanges();
                    DataGridView();
                    txtmadg.Clear();
                    txttendg.Clear();
                    txtdiachidg.Clear();
                    txtsdtdg.Clear();

                }
                else
                {
                    test.TENDOCGIA = docgia.TENDOCGIA;
                    test.DIACHI = docgia.DIACHI;
                    test.SDTDOCGIA = docgia.SDTDOCGIA;
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    db.SubmitChanges();
                    DataGridView();
                    txtmadg.Clear();
                    txttendg.Clear();
                    txtdiachidg.Clear();
                    txtsdtdg.Clear();
                }
                
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnxoadg_Click(object sender, EventArgs e)
        {
            DOCGIA dg = new DOCGIA();
            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvdg.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    dg = db.DOCGIAs.FirstOrDefault(s => s.MADOCGIA == numrow.ToString());
                    if (dg != null)
                    {
                        db.DOCGIAs.DeleteOnSubmit(dg);
                    }
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtmadg.Clear();
                    txttendg.Clear();
                    txtdiachidg.Clear();
                    txtsdtdg.Clear();
                }
        }

        private void txttimdg_KeyUp(object sender, KeyEventArgs e)
        {
            if (cbotimdg.Text == "Độc Giả")
            {
            var findtendg = (from s in db.DOCGIAs
                              where s.TENDOCGIA.Contains(txttimdg.Text)
                              select s).ToList();
            dgvdg.DataSource = findtendg;

            }else if (cbotimdg.Text == "Địa Chỉ")
            {
                var finddiachidg = (from s in db.DOCGIAs
                                  where s.DIACHI.Contains(txttimdg.Text)
                                  select s).ToList();
                dgvdg.DataSource = finddiachidg;
            }
            else
            {
                var findsdtdg = (from s in db.DOCGIAs
                                  where s.SDTDOCGIA.Contains(txttimdg.Text)
                                  select s).ToList();
                dgvdg.DataSource = findsdtdg;
            }
        }

        private void dgvdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtmadg.Text = dgvdg.Rows[numrow].Cells[0].Value.ToString();
            txttendg.Text = dgvdg.Rows[numrow].Cells[1].Value.ToString();
            txtdiachidg.Text = dgvdg.Rows[numrow].Cells[2].Value.ToString();
            txtsdtdg.Text = dgvdg.Rows[numrow].Cells[3].Value.ToString();
        }
    }
}