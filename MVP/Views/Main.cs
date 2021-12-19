using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class Main : Form, IMainView
    {
        private TaiKhoanDTO _taiKhoanDTO;
        private Form _fLogin;
        private MainPresenter _mainPresenter;
        public Main(TaiKhoanDTO taiKhoanDTO, Form flogin)
        {
            InitializeComponent();
            _taiKhoanDTO = taiKhoanDTO;
            _fLogin = flogin;
            _mainPresenter = new MainPresenter(this);
        }

        private void hideSubMenu()
        {
            pnlSubQLSach.Visible = false;
            pnlSubQLNhap.Visible = false;
            pnlSubQLXuat.Visible = false;
            pnlSubQLNS.Visible = false;
            pnlSubQLTK.Visible = false;
            pnlSubTK.Visible = false;   
        }

        private void hideScrollBar()
        {
            pnlFunct.AutoScroll = false;
            pnlFunct.HorizontalScroll.Maximum = 0;
            pnlFunct.HorizontalScroll.Visible = false;
            pnlFunct.VerticalScroll.Maximum = 0;
            pnlFunct.VerticalScroll.Visible = false;
            pnlFunct.AutoScroll = true;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {            
            showSubMenu(pnlSubQLSach);
        }

        private void btnQLXuat_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubQLXuat);
        }
        
        private void btnQLNhap_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubQLNhap);
        }

        private void btnQLNS_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubQLNS);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubQLTK);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubTK);
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideBorder()
        {
            btnInfo.FlatAppearance.BorderSize = 0;
            btnSach.FlatAppearance.BorderSize = 0;
            btnTG.FlatAppearance.BorderSize = 0;
            btnTL.FlatAppearance.BorderSize = 0;
            btnNXB.FlatAppearance.BorderSize = 0;
            btnBanSach.FlatAppearance.BorderSize = 0;
            btnNhapSach.FlatAppearance.BorderSize = 0;
            btnNCC.FlatAppearance.BorderSize = 0;
            btnNV.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnQuyen.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnThongKeSach.FlatAppearance.BorderSize = 0;
        }

        private void AddUCMain(Control ucMain)
        {
            bool flag = false;
            foreach(Control ctl in pnlMain.Controls)
            {
                if (ctl.Name.Equals(ucMain.Name))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                ucMain.Dock = DockStyle.Fill;
                ucMain.BringToFront();
                pnlMain.Controls.Add(ucMain);
                foreach (Control ctl in pnlMain.Controls)
                {
                    if (!ctl.Name.Equals(ucMain.Name))
                    {
                        pnlMain.Controls.Remove(ctl);
                    }
                }
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            hideBorder();
            btnInfo.FlatAppearance.BorderSize = 1;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCSach());
            btnSach.FlatAppearance.BorderSize = 1;

        }

        private void btnTG_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCTacGia());
            btnTG.FlatAppearance.BorderSize = 1;
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCTheLoai());
            btnTL.FlatAppearance.BorderSize = 1;
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCNhaXuatBan());
            btnNXB.FlatAppearance.BorderSize = 1;
        }

        private void btnBanSach_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCBan(_taiKhoanDTO));
            btnBanSach.FlatAppearance.BorderSize = 1;
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCNhap(_taiKhoanDTO));
            btnNhapSach.FlatAppearance.BorderSize = 1;
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCNhaCungCap());
            btnNCC.FlatAppearance.BorderSize = 1;
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCNhanVien());
            btnNV.FlatAppearance.BorderSize = 1;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCTaiKhoan());
            btnTaiKhoan.FlatAppearance.BorderSize = 1;
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCQuyen());
            btnQuyen.FlatAppearance.BorderSize = 1;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCThongKeDoanhThu());
            btnDoanhThu.FlatAppearance.BorderSize = 1;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(new UCThongKeSach());
            btnThongKeSach.FlatAppearance.BorderSize = 1;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            _fLogin.Show();
        }

        private void pnlImgLogo_Click(object sender, EventArgs e)
        {
            hideBorder();
            AddUCMain(pnlImgHome);
            hideSubMenu();
        }

        public void GetTenNV(string tenNV)
        {
            btnInfo.Text = tenNV;
        }

        public void GetTenQuyen(string quyen, string[] funct)
        {
            lblChucVu.Text = quyen;
            foreach(string c in funct)
            {
                if (c.Equals(QLSACH))
                    btnQLSach.Visible = true;
                if (c.Equals(QLBAN))
                    btnQLXuat.Visible = true;
                if (c.Equals(QLNHAP))
                    btnQLNhap.Visible = true;
                if (c.Equals(QLNV))
                    btnQLNS.Visible = true;
                if (c.Equals(QLTK))
                    btnQLTK.Visible = true;
                if (c.Equals(THONGKE))
                    btnTK.Visible = true;
            }
        }

        private readonly string QLSACH = "QL sách";
        private readonly string QLBAN = "QL bán";
        private readonly string QLNHAP = "QL nhập";
        private readonly string QLNV = "QL nhân viên";
        private readonly string QLTK = "QL tài khoản";
        private readonly string THONGKE = "Thống kê";

        private void Main_Load(object sender, EventArgs e)
        {
            _mainPresenter.ShowName(_taiKhoanDTO.NhanVienId);
            _mainPresenter.ShowRole(_taiKhoanDTO.QuyenId);
            hideSubMenu();
            hideScrollBar();
        }
    }
}
