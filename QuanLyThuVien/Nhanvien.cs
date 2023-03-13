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
    public partial class frmNhanvien : DevExpress.XtraEditors.XtraForm
    {
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        public frmNhanvien()
        {
            InitializeComponent();
        }
        void DataGridView()
        {
            dgvNhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = txtIDNV.Text;
            nv.HOTENNV = txtName.Text;
            nv.DIACHINV = txtDiachi.Text;
            nv.NGAYSINHNV = Convert.ToDateTime(dtmNgaysinh.Value);
            nv.GIOITINHNV = cbogioitinh.Text;
            nv.DIENTHOAINV = txtSDT.Text;
            nv.EMAILNV = txtEmail.Text;
            try
            {
                var test = db.NHANVIENs.FirstOrDefault(p => p.MANV == nv.MANV);
                if (test == null)
                {
                    db.NHANVIENs.InsertOnSubmit(nv);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    txtIDNV.Clear();
                    txtName.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();

                }
                else
                {
                    test.HOTENNV = txtName.Text;
                    test.DIACHINV = txtDiachi.Text;
                    test.NGAYSINHNV = Convert.ToDateTime(dtmNgaysinh.Value);
                    test.GIOITINHNV = cbogioitinh.Text;
                    test.DIENTHOAINV = txtSDT.Text;
                    test.EMAILNV = txtEmail.Text;
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    txtIDNV.Clear();
                    txtName.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();
                }
                db.SubmitChanges();
                DataGridView();
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            cbotimnv.SelectedIndex = 1;
            cbogioitinh.SelectedIndex = 0;
            dgvNhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                var delete = db.NHANVIENs.FirstOrDefault(p => p.MANV == txtIDNV.Text);
                if( delete != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    DataGridView();
                    MessageBox.Show("Xóa Thành Công !!!");
                    txtIDNV.Clear();
                    txtName.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();

                }
                else
                {
                    MessageBox.Show("lỗi rồi!!!");
                }
            }
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtIDNV.Text = dgvNhanvien.Rows[numrow].Cells[0].Value.ToString();
            txtName.Text = dgvNhanvien.Rows[numrow].Cells[1].Value.ToString();
            cbogioitinh.Text = dgvNhanvien.Rows[numrow].Cells[2].Value.ToString();
            dtmNgaysinh.Text = dgvNhanvien.Rows[numrow].Cells[3].Value.ToString();
            txtDiachi.Text = dgvNhanvien.Rows[numrow].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanvien.Rows[numrow].Cells[5].Value.ToString();
            txtEmail.Text = dgvNhanvien.Rows[numrow].Cells[6].Value.ToString();


        }

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbotimnv.Text == "Mã Nhân Viên")
            {
            var findmanv = (from s in db.NHANVIENs
                              where  s.MANV.Contains(txtTimkiem.Text)
                              select s).ToList();
            dgvNhanvien.DataSource = findmanv;
            }else if (cbotimnv.Text == "Tên Nhân Viên")
            {
            var findtennv = (from s in db.NHANVIENs
                                   where s.HOTENNV.Contains(txtTimkiem.Text)
                                   select s).ToList();
            dgvNhanvien.DataSource = findtennv;
            }
            else if (cbotimnv.Text == "Giới Tính")
            {
                var findgioitinhnv = (from s in db.NHANVIENs
                                 where s.GIOITINHNV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findgioitinhnv;
            }
            else if (cbotimnv.Text == "Địa Chỉ")
            {
                var finddiachinv = (from s in db.NHANVIENs
                                 where s.DIACHINV.Contains(txtTimkiem.Text)
                                 select s).ToList();
            dgvNhanvien.DataSource = finddiachinv;

            }
            else if (cbotimnv.Text == "SĐT")
            {
                var findsdtnv = (from s in db.NHANVIENs
                                 where s.DIENTHOAINV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findsdtnv;
            }
            else
            {
                var findemailnv = (from s in db.NHANVIENs
                                 where s.EMAILNV.Contains(txtTimkiem.Text)
                                 select s).ToList();
                dgvNhanvien.DataSource = findemailnv;
            }
        }
    }
}