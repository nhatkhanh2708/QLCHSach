using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietSach : UserControl, ICtSachView
    {
        private SachDTO _sachDTO;
        private SachDTO temp;
        private CtSachPresenter _CtSachPresenter;
        private IEnumerable<TheLoaiDTO> _listTheLoai;
        private IEnumerable<TacGiaDTO> _listTacGia;
        private IEnumerable<NhaXuatBanDTO> _listNxb;
        private bool isLoad = true;
        public UCChiTietSach(SachDTO sachDTO)
        {
            InitializeComponent();
            _sachDTO = sachDTO;
            temp = (SachDTO)_sachDTO.Clone();
            _CtSachPresenter = new CtSachPresenter(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UCChiTietSach_Load(object sender, EventArgs e)
        {
            load();
            _CtSachPresenter.GetAllCbx();
            loadCbx();
            isLoad = true;
        }

        public void load()
        {
            txtTenSach.ReadOnly = true;
            cbxTacGia.Visible = false;
            cbxTheLoai.Visible = false;
            cbxNXB.Enabled = false;
            numerGiaBan.ReadOnly = true;
            numerGiaNhap.ReadOnly = true;
            numerSL.ReadOnly = true;
            txtNcc.ReadOnly = true;
            btnChonAnh.Visible = false;
            btnRmImg.Visible = false;
            btnUpdate.Visible = false;
            btnHuy.Visible = false;

            txtTenSach.Text = _sachDTO.TenSach;
            numerSL.Text = _sachDTO.SoLuong.ToString();
            numerGiaNhap.Text = Convert.ToInt32(_sachDTO.GiaNhap).ToString();
            numerGiaBan.Text = Convert.ToInt32(_sachDTO.GiaBan).ToString();

            if(_sachDTO.Img.Length != 0)
            {
                lblImg.BackgroundImage = (Image)(new ImageConverter()).ConvertFrom(_sachDTO.Img);
                lblImg.BackgroundImageLayout = ImageLayout.Stretch;
                panel4.BackColor = Color.DarkSlateBlue;
                lblImg.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                lblImg.BackgroundImage = Properties.Resources.icons8_book_100__1_;
                lblImg.BackgroundImageLayout = ImageLayout.Center;
                panel4.BackColor = Color.WhiteSmoke;
                lblImg.BorderStyle = BorderStyle.None;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isLoad = true;
            
            txtTenSach.ReadOnly = false;
            cbxTacGia.Visible = true;            
            cbxTheLoai.Visible = true;
            cbxNXB.Enabled = true;
            numerGiaBan.ReadOnly = false;
            numerGiaNhap.ReadOnly = false;
            numerSL.ReadOnly = false;
            btnChonAnh.Visible = true;
            btnUpdate.Visible = true;
            btnHuy.Visible = true;

            if (_sachDTO.Img.Length != 0)
            {
                btnRmImg.Visible = true;
            }
            else
            {
                btnRmImg.Visible = false;
            }

            foreach (UCItemCbx ctl in flpTacGia.Controls)
            {
                ctl.visiblebtnRm(true);
            }

            foreach (UCItemCbx ctl in flpTheLoai.Controls)
            {
                ctl.visiblebtnRm(true);
            }

            isLoad = false;
        }

        public void loadCbx()
        {
            cbxTheLoai.DataSource = _listTheLoai.ToList();
            cbxTheLoai.DisplayMember = "TenTheLoai";
            cbxTheLoai.ValueMember = "Id";

            cbxTacGia.DataSource = _listTacGia.ToList();
            cbxTacGia.DisplayMember = "ButDanh";
            cbxTacGia.ValueMember = "Id";

            cbxNXB.DataSource = _listNxb.ToList();
            cbxNXB.DisplayMember = "TenNxb";
            cbxNXB.ValueMember = "Id";
            _CtSachPresenter.LoadData(_sachDTO);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _CtSachPresenter.Delete(_sachDTO.Id);
            Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            List<int> listTgId = new List<int>();
            foreach (UCItemCbx ctl in flpTacGia.Controls)
            {
                listTgId.Add(ctl.getId());
            }

            List<int> listTLId = new List<int>();
            foreach (UCItemCbx ctl in flpTheLoai.Controls)
            {
                listTLId.Add(ctl.getId());
            }

            _CtSachPresenter.Update(temp, txtTenSach.Text, listTgId, listTLId, (int)cbxNXB.SelectedValue,
                numerGiaBan.Text, numerGiaNhap.Text, numerSL.Text, lblImg.BackgroundImage);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            isLoad = true;
            load();
            _CtSachPresenter.GetAllCbx();
            loadCbx();
            isLoad = false;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Open image",
                Filter = "(*.jpg;*.jpeg,*.png)|*.JPG;*.JPEG;*.PNG",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblImg.Controls.Clear();
                    lblImg.BackgroundImage = Image.FromFile(ofd.FileName);                    
                    lblImg.BackgroundImageLayout = ImageLayout.Stretch;
                    panel4.BackColor = Color.DarkSlateBlue;
                    lblImg.BorderStyle = BorderStyle.FixedSingle;
                    btnRmImg.Visible = true;
                }
            }
        }

        private void btnRmImg_Click(object sender, EventArgs e)
        {
            lblImg.Controls.Clear();
            lblImg.BackgroundImage = Properties.Resources.icons8_book_100__1_;
            lblImg.BackgroundImageLayout = ImageLayout.Center;
            panel4.BackColor = Color.WhiteSmoke;
            lblImg.BorderStyle = BorderStyle.None;
            btnRmImg.Visible = false;
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
            {
                isLoad = true;
                txtTenSach.ReadOnly = true;
                cbxTacGia.Visible = false;
                flpTacGia.Enabled = false;
                cbxTheLoai.Visible = false;
                flpTheLoai.Enabled = false;
                cbxNXB.Enabled = false;
                numerGiaBan.ReadOnly = true;
                numerGiaNhap.ReadOnly = true;
                numerSL.ReadOnly = true;
                btnChonAnh.Visible = false;
                btnRmImg.Visible = false;
                btnUpdate.Visible = false;
                btnHuy.Visible = false;
                _sachDTO = (SachDTO)temp.Clone();
                foreach (UCItemCbx ctl in flpTacGia.Controls)
                {
                    ctl.visiblebtnRm(false);
                }

                foreach (UCItemCbx ctl in flpTheLoai.Controls)
                {
                    ctl.visiblebtnRm(false);
                }
                isLoad = false;
            }
        }

        public void GetAllCbx(IEnumerable<NhaXuatBanDTO> listNXB, IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL)
        {
            _listNxb = listNXB;
            _listTacGia = listTG;
            _listTheLoai = listTL;
        }

        private void cbxTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad && cbxTacGia.Visible)
            {
                bool flag = false;
                string temp = cbxTacGia.Text;
                int idtemp = int.Parse(cbxTacGia.SelectedValue.ToString());
                foreach (UCItemCbx ctl in flpTacGia.Controls)
                {
                    if(ctl._id == idtemp)
                    {
                        flag = true;
                    }
                }
                if(!flag)
                    flpTacGia.Controls.Add(new UCItemCbx(flpTacGia, temp, idtemp));
            }
        }

        private void cbxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoad && cbxTheLoai.Visible)
            {
                bool flag = false;
                string temp = cbxTheLoai.Text;
                int idtemp = int.Parse(cbxTheLoai.SelectedValue.ToString());
                foreach (UCItemCbx ctl in flpTheLoai.Controls)
                {
                    if (ctl._id == idtemp)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                    flpTheLoai.Controls.Add(new UCItemCbx(flpTheLoai, temp, idtemp));
            }
        }

        public void LoadData(IEnumerable<TacGiaDTO> listTG, IEnumerable<TheLoaiDTO> listTL, NhaXuatBanDTO nxb, NccDTO ncc)
        {
            txtNcc.Text = ncc.TenNCC;
            cbxNXB.SelectedIndex = cbxNXB.FindStringExact(nxb.TenNxb);

            flpTacGia.Controls.Clear();
            foreach(TacGiaDTO tg in listTG)
            {
                var t = new UCItemCbx(flpTacGia, tg.ButDanh, tg.Id);
                t.visiblebtnRm(false);
                flpTacGia.Controls.Add(t);
            }

            flpTheLoai.Controls.Clear();
            foreach (TheLoaiDTO tl in listTL)
            {
                var t = new UCItemCbx(flpTheLoai, tl.TenTheLoai, tl.Id);
                t.visiblebtnRm(false);
                flpTheLoai.Controls.Add(t);
            }
        }

        private void cbxNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
