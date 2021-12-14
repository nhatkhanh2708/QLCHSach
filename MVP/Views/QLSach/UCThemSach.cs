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
        private bool isLoad = true;
        private IEnumerable<TheLoaiDTO> _listTheLoai;
        private IEnumerable<TacGiaDTO> _listTacGia;
        private IEnumerable<NhaXuatBanDTO> _listNxb;
        private IEnumerable<NccDTO> _listNcc;
        private ThemSachPresenter _themSachPresenter;
        
        public UCThemSach()
        {
            InitializeComponent();
            _themSachPresenter = new ThemSachPresenter(this);
        }

        private void UCThemSach_Load(object sender, EventArgs e)
        {
            //hideScrollBar();
            _themSachPresenter.GetsAllCbx();
            loadCbx();
            isLoad = false;
        }

        private void hideScrollBar()
        {
            flpTacGia.AutoScroll = false;
            flpTacGia.HorizontalScroll.Maximum = 0;
            flpTacGia.HorizontalScroll.Visible = false;
            flpTacGia.VerticalScroll.Maximum = 0;
            flpTacGia.VerticalScroll.Visible = false;
            flpTacGia.AutoScroll = true;

            flpTheLoai.AutoScroll = false;
            flpTheLoai.HorizontalScroll.Maximum = 0;
            flpTheLoai.HorizontalScroll.Visible = false;
            flpTheLoai.VerticalScroll.Maximum = 0;
            flpTheLoai.VerticalScroll.Visible = false;
            flpTheLoai.AutoScroll = true;
        }

        private void loadCbx()
        {
            cbxTheLoai.DataSource = _listTheLoai.ToList();
            cbxTheLoai.DisplayMember = "TenTheLoai";
            cbxTheLoai.ValueMember = "Id";

            cbxNXB.DataSource = _listNxb.ToList();
            cbxNXB.DisplayMember = "TenNxb";
            cbxNXB.ValueMember = "Id";

            cbxTacGia.DataSource = _listTacGia.ToList();
            cbxTacGia.DisplayMember = "ButDanh";
            cbxTacGia.ValueMember = "Id";

            cbxNcc.DataSource = _listNcc.ToList();
            cbxNcc.DisplayMember = "TenNCC";
            cbxNcc.ValueMember = "Id";
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
            List<int> listTgId = new List<int>();
            foreach(UCItemCbx ctl in flpTacGia.Controls)
            {
                listTgId.Add(ctl.getId());
            }

            List<int> listTLId = new List<int>();
            foreach (UCItemCbx ctl in flpTheLoai.Controls)
            {
                listTLId.Add(ctl.getId());
            }

            _themSachPresenter.Add(txtTenSach.Text, listTgId, listTLId, (int)cbxNXB.SelectedValue,
                numerGiaBan.Text, numerGiaNhap.Text, numerSL.Text, (int) cbxNcc.SelectedValue, picBox.BackgroundImage);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {   
            cbxNXB.SelectedIndex = 0;
            cbxTacGia.SelectedIndex = 0;
            cbxTheLoai.SelectedIndex = 0;
            cbxNcc.SelectedIndex = 0;
            picBox.Controls.Clear();
            txtTenSach.Text = "";
            numerGiaBan.Text = "";
            numerGiaNhap.Text = "";
            numerSL.Text = "";
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

        public void GetImg(Image img)
        {
            if(img != null)
            {
                picBox.BackgroundImage = img;
                picBox.BackgroundImageLayout = ImageLayout.Stretch;
                panel4.BackColor = Color.DarkSlateBlue;
                picBox.BorderStyle = BorderStyle.FixedSingle;
                btnRmImg.Visible = true;
            }            
        }

        public void GetsAllCbx(IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL, IEnumerable<NhaXuatBanDTO> listNXB, IEnumerable<NccDTO> listNcc)
        {
            _listNxb = listNXB;
            _listTacGia = listTG;
            _listTheLoai = listTL;
            _listNcc = listNcc;
        }

        private void cbxTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isLoad)
                flpTacGia.Controls.Add(new UCItemCbx(flpTacGia, cbxTacGia.Text, int.Parse(cbxTacGia.SelectedValue.ToString())));
        }

        private void cbxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isLoad)
            {
                flpTheLoai.Controls.Add(new UCItemCbx(flpTheLoai, cbxTheLoai.Text, int.Parse(cbxTheLoai.SelectedValue.ToString())));
            }
        }

        private void btnRmImg_Click(object sender, EventArgs e)
        {
            picBox.BackgroundImage = null;
            panel4.BackColor = Color.WhiteSmoke;
            picBox.BorderStyle = BorderStyle.None;
            btnRmImg.Visible = false;
        }
    }
}
