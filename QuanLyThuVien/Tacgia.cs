﻿using DevExpress.XtraEditors;
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
    public partial class frmTacgia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacgia()
        {
            InitializeComponent();
        }
        QuanLyThuVienDataContext db = new QuanLyThuVienDataContext();
        TACGIA tg = new TACGIA();


        void loadtacgia()
        {
            dgvtacgia.DataSource = db.TACGIAs.ToList();
        }



        private void btnthemsuatg_Click(object sender, EventArgs e)
        {
            TACGIA tg = new TACGIA();

            tg.MATACGIA = txtmatg.Text;
            tg.TENTACGIA = txttentg.Text;
            try
            {
                var tacgia = db.TACGIAs.FirstOrDefault(p => p.MATACGIA == tg.MATACGIA);
                if (tacgia == null)
                {
                    db.TACGIAs.InsertOnSubmit(tg);

                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK);
                    txtmatg.Clear();
                    txttentg.Clear();
                }
                else
                {
                    tg = db.TACGIAs.Where(p => p.MATACGIA == txtmatg.Text).Single();
                    tg.MATACGIA = txtmatg.Text;
                    tg.TENTACGIA = txttentg.Text;
                    MessageBox.Show("Sửa thanh cong", "Thong bao", MessageBoxButtons.OK);
                    txtmatg.Clear();
                    txttentg.Clear();
                }
                db.SubmitChanges();
                loadtacgia();
            }
            catch
            {
                MessageBox.Show("Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void frmTacgia_Load(object sender, EventArgs e)
        {
            loadtacgia();
        }

        private void btnxoatg_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xoá?", "Thông Báo",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                foreach (DataGridViewRow row in dgvtacgia.SelectedRows)
                {
                    var numrow = row.Cells[0].Value;
                    tg = db.TACGIAs.FirstOrDefault(s => s.MATACGIA == numrow.ToString());
                    if (tg != null)
                    {
                        db.TACGIAs.DeleteOnSubmit(tg);
                    }
                    db.SubmitChanges();
                    loadtacgia();
                    MessageBox.Show("Xoá Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtmatg.Clear();
                    txttentg.Clear();
                }
        }

        private void dgvtacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatg.Text = dgvtacgia.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttentg.Text = dgvtacgia.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txtTimkiemtg_KeyUp(object sender, KeyEventArgs e)
        {
            var findtg = (from s in db.TACGIAs
                              where s.TENTACGIA.Contains(txtTimkiemtg.Text) || s.MATACGIA.Contains(txtTimkiemtg.Text)
                              select s).ToList();
            dgvtacgia.DataSource = findtg;
        }
    }
}