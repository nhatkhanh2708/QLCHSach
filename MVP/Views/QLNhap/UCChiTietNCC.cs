using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietNCC : UserControl, ICtNccView
    {
        private NccDTO _nccDTO;
        private CtNccPresenter _ctNccPresenter;
        public UCChiTietNCC(NccDTO nccDTO)
        {
            InitializeComponent();
            _nccDTO = nccDTO;
            _ctNccPresenter = new CtNccPresenter(this);
        }

        private void UCChiTietNCC_Load(object sender, EventArgs e)
        {
            dtpNgayHopTac.Format = DateTimePickerFormat.Custom;
            dtpNgayHopTac.CustomFormat = "MM/dd/yyyy";
            load();
        }

        public void load()
        {
            txtDiaChi.ReadOnly = true;
            txtNcc.ReadOnly = true;
            txtSdt.ReadOnly = true;
            dtpNgayHopTac.Enabled = false;
            cbxStatus.Enabled = false;
            btnUpdate.Visible = false;
            btnHuy.Visible = false;

            txtDiaChi.Text = _nccDTO.DiaChi;
            txtNcc.Text = _nccDTO.TenNCC;
            txtSdt.Text = _nccDTO.SDT;
            cbxStatus.SelectedIndex = _nccDTO.Status == true ? 0 : 1;
            dtpNgayHopTac.Value = _nccDTO.NgayHopTac;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDiaChi.ReadOnly = false;
            txtNcc.ReadOnly = false;
            txtSdt.ReadOnly = false;
            dtpNgayHopTac.Enabled = true;
            cbxStatus.Enabled = true;
            btnUpdate.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _ctNccPresenter.DeleteNcc(_nccDTO.Id);
            Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _nccDTO.TenNCC = txtNcc.Text;
            _nccDTO.Status = cbxStatus.SelectedIndex == 0 ? true : false;
            _nccDTO.NgayHopTac = dtpNgayHopTac.Value;
            _nccDTO.SDT = txtSdt.Text;
            _nccDTO.DiaChi = txtDiaChi.Text;
            _ctNccPresenter.UpdateNcc(_nccDTO);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            load();
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
                txtDiaChi.ReadOnly = true;
                txtNcc.ReadOnly = true;
                txtSdt.ReadOnly = true;
                dtpNgayHopTac.Enabled = false;
                cbxStatus.Enabled = false;
                btnUpdate.Visible = false;
                btnHuy.Visible = false;
            }
        }
    }
}
