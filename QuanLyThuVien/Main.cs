using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraEditors ;
using DevExpress.XtraBars.Helpers;


namespace QuanLyThuVien

{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

        }



        public void TabCreating(XtraTabControl TabControl, string Text, Form Form)
        {
            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTabPage = TabControl.TabPages[Index];
                TabControl.SelectedTabPage.Text = Text;

            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTabPage = TabPage;

                Form.TopLevel = false;
                Form.Parent = TabPage;
                //  Form.MdiParent = this;
                Form.Show();
                Form.Dock = DockStyle.Fill;
            }
        }

        static int KiemTraTonTai(XtraTabControl TabControlName, string TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }
        private void tileControl1_Click(object sender, EventArgs e)
        {

        }



        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            XtraTabControl TabControl = (XtraTabControl)sender;
            int a = TabControl.TabPages.Count;
            int i = TabControl.SelectedTabPageIndex;
            TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
            TabControl.SelectedTabPageIndex = i - 1;
        }




        private void btndangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {


            frmDangnhap dangnhap = new frmDangnhap();
            this.Hide();
            dangnhap.ShowDialog();
        }


     

        //private void btnmuontra_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmMuontra muontra = new frmMuontra();
        //    TabCreating(this.xtraTabControl1, "Mượn Trả", muontra);
        //}

        //private void btntimkiem_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmTimkiem timkiem = new frmTimkiem();
        //    TabCreating(this.xtraTabControl1, "Tìm Kiếm", timkiem);
        //}

        //private void btnthongke_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmThongke thongke = new frmThongke();
        //    TabCreating(this.xtraTabControl1, "Thống Kê", thongke);
        //}

        //private void btntrogiup_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    frmTrogiup trogiup = new frmTrogiup();
        //    TabCreating(this.xtraTabControl1, "Trợ Giúp", trogiup);
        //}

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Summer 2008";
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(skinlink);
            skin();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }



        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult tl =
        //     MessageBox.Show("Bạn có muốn thoát ?",
        //     "Thông báo",
        //     MessageBoxButtons.YesNo,
        //     MessageBoxIcon.Question);
        //    if (tl == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //    }

        //}
        private void btntacgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTacgia tacgia = new frmTacgia();
            TabCreating(this.xtraTabControl1, "Tác Giả", tacgia);

        }

        private void btndocgia_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDocgia docgia = new frmDocgia();
            TabCreating(this.xtraTabControl1, "Đọc Giả", docgia);
        }

        private void btndoipass_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoipass doipass = new frmDoipass();
            TabCreating(this.xtraTabControl1, "Đổi Mật Khẩu", doipass);
        }

        private void btnnxb_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNxb nxb = new frmNxb();
            TabCreating(this.xtraTabControl1, "Nhà Xuất Bản", nxb);
        }

        private void btntheloai_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTheloai theloai = new frmTheloai();
            TabCreating(this.xtraTabControl1, "Thể Loại", theloai);
        }

        private void btndausach_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDausach dausach = new frmDausach();
            TabCreating(this.xtraTabControl1, "Đầu Sách", dausach);
        }

        private void btnlienhe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLienhe lienhe = new frmLienhe();
            TabCreating(this.xtraTabControl1, "Liên Hệ", lienhe);
        }

        private void btnnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanvien nhanvien = new frmNhanvien();
            TabCreating(this.xtraTabControl1, "Nhân Viên", nhanvien);
        }
    }
}