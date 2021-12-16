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
    public partial class UCChiTietNV : UserControl, IChiTietNVView
    {
        private bool isComplete = false;
        private NhanVienDTO _nvDTO;
        private NhanVienDTO temp;
        private ChiTietNVPresenter _chiTietNVPresenter;
        private UCNhanVien _ucNv;
        public UCChiTietNV(UCNhanVien ucNv, NhanVienDTO nhanVienDTO)
        {
            InitializeComponent();
            _nvDTO = nhanVienDTO;
            temp = (NhanVienDTO)_nvDTO.Clone();
            _chiTietNVPresenter = new ChiTietNVPresenter(this);
            _ucNv = ucNv;
        }

        private void UCChiTietNV_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "MM/dd/yyyy";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.CustomFormat = "MM/dd/yyyy";
            _chiTietNVPresenter.isExistTaiKhoanNV(_nvDTO.Id);
            load();
        }

        public void load()
        {
            btnUpdate.Visible = false;
            btnHuy.Visible = false;

            txtDiaChi.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtTennv.ReadOnly = true;

            cbxChucVu.Enabled = false;
            cbxGender.Enabled = false;
            dtpNgayBatDau.Enabled = false;
            dtpNgaySinh.Enabled = false;

            txtTennv.Text = _nvDTO.HoTen;
            txtSdt.Text = _nvDTO.SDT;
            txtDiaChi.Text = _nvDTO.DiaChi;
            cbxGender.SelectedIndex = _nvDTO.GioiTinh ? 0 : 1;
            foreach(QuyenDTO q in cbxChucVu.Items)
            {
                if (q.TenQuyen.Equals(_nvDTO.ChucVu))
                {
                    cbxChucVu.SelectedItem = q;
                    break;
                }
            }
            dtpNgayBatDau.Value = _nvDTO.NgayBatDau;
            dtpNgaySinh.Value = _nvDTO.NgaySinh;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isComplete)
            {
                _ucNv.LoadNv(isComplete);
                Dispose();
            }
            else
                Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDiaChi.ReadOnly = false;
            txtSdt.ReadOnly = false;
            txtTennv.ReadOnly = false;

            if(cbxChucVu.DataSource != null)
                cbxChucVu.Enabled = true;
            cbxGender.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgaySinh.Enabled = true;

            btnUpdate.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            _chiTietNVPresenter.DeleteNV(_nvDTO.Id);
            Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            temp.HoTen = txtTennv.Text;
            temp.GioiTinh = cbxGender.SelectedIndex == 0 ? true : false;
            temp.NgayBatDau = dtpNgayBatDau.Value;
            temp.NgaySinh = dtpNgaySinh.Value;
            temp.DiaChi = txtDiaChi.Text;
            temp.SDT = txtSdt.Text;
            temp.ChucVu = null;
            int Quyenid = -1;
            if (cbxChucVu.DataSource != null)
            {
                Quyenid = int.Parse(cbxChucVu.SelectedValue.ToString());
            }
            _chiTietNVPresenter.UpdateNV(temp, Quyenid);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            load();
        }

        public void GetAllChucVu(IEnumerable<QuyenDTO> listQuyen)
        {
            cbxChucVu.DataSource = listQuyen.ToList();
            cbxChucVu.DisplayMember = "TenQuyen";
            cbxChucVu.ValueMember = "Id";
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
                btnUpdate.Visible = false;
                btnHuy.Visible = false;

                txtDiaChi.ReadOnly = true;
                txtSdt.ReadOnly = true;
                txtTennv.ReadOnly = true;

                cbxChucVu.Enabled = false;
                cbxGender.Enabled = false;
                dtpNgayBatDau.Enabled = false;
                dtpNgaySinh.Enabled = false;
                _nvDTO = (NhanVienDTO)temp.Clone();
                isComplete = true;
            }            
        }

        public void isExistTaiKhoanNV(bool isExist)
        {
            if (isExist)
                _chiTietNVPresenter.GetAllChucVu();
            else
            {
                cbxChucVu.DataSource = null;
            }
        }
    }
}
