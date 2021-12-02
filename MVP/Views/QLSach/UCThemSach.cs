using MVP.IViews.Sach;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemSach : UserControl, IThemSachView
    {
        private IEnumerable<TheLoaiDTO> _listTheLoai;
        private IEnumerable<TacGiaDTO> _listTacGia;
        private IEnumerable<NhaXuatBanDTO> _listNxb;
        private ThemSachPresenter _themSachPresenter;
        
        private BindingSource bsTheLoai;

        public UCThemSach()
        {
            InitializeComponent();
            _themSachPresenter = new ThemSachPresenter(this);
            bsTheLoai = new BindingSource();
        }

        private void UCThemSach_Load(object sender, EventArgs e)
        {
            _themSachPresenter.GetsAllCbx();
            loadCbx();
        }

        private void loadCbx()
        {
            bsTheLoai.DataSource = _listTheLoai.ToList();
            cbxTheLoai.DataSource = bsTheLoai.DataSource;
            cbxTheLoai.DisplayMember = "TenTheLoai";
            cbxTheLoai.ValueMember = "Id";
            
            //cbx tg
            // cbx nxb
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            _themSachPresenter.GetImg();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            //làm mới txtbx, flp, picturebx
            flpTacGia.Controls.Clear();
            flpTheLoai.Controls.Clear();
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel1.Width - ucNotifi.Width) / 2,
                (panel1.Height - ucNotifi.Height) / 2);
            panel1.Controls.Add(ucNotifi);
            panel1.Controls.SetChildIndex(ucNotifi, 0);
            if (flag)
                refresh();
        }

        public void GetsAllCbx(IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL, IEnumerable<NhaXuatBanDTO> listNXB)
        {
            _listNxb = listNXB;
            _listTacGia = listTG;
            _listTheLoai = listTL;
        }

        public void GetImg(Image img)
        {
            picBox.BackgroundImage = img;
            picBox.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void cbxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpTheLoai.Controls.Add(new UCItemCbx(flpTheLoai, cbxTheLoai.SelectedValue.ToString()));
        }
    }
}
