using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietQuyen : UserControl, ICtQuyenView
    {
        private QuyenDTO _quyenDTO;
        private CtQuyenPresenter ctQuyenPresenter;
        private QuyenDTO q;
        public UCChiTietQuyen(QuyenDTO quyenDTO)
        {
            InitializeComponent();
            _quyenDTO = quyenDTO;
            ctQuyenPresenter = new CtQuyenPresenter(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
        private void UCChiTietQuyen_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            btnHuy.Visible = false;
            btnUpdate.Visible = false;
            txtTenQuyen.ReadOnly = true;
            chkQLBan.Enabled = false;
            chkQLNhap.Enabled = false;
            chkQLNV.Enabled = false;
            chkQLSach.Enabled = false;
            chkQLTaiKhoan.Enabled = false;
            chkThongKe.Enabled = false;
            txtTenQuyen.Text = _quyenDTO.TenQuyen;
            string[] list = _quyenDTO.MoTa.Split(",");
            foreach(string t in list)
            {
                if (t.Equals("QL sách"))
                    chkQLSach.Checked = true;
                if (t.Equals("QL bán"))
                    chkQLBan.Checked = true;
                if (t.Equals("QL nhập"))
                    chkQLNhap.Checked = true;
                if (t.Equals("QL nhân viên"))
                    chkQLNV.Checked = true;
                if (t.Equals("QL tài khoản"))
                    chkQLTaiKhoan.Checked = true;
                if (t.Equals("Thống kê"))
                    chkThongKe.Checked = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = true;
            btnUpdate.Visible = true;
            txtTenQuyen.ReadOnly = false;
            chkQLBan.Enabled = true;
            chkQLNhap.Enabled = true;
            chkQLNV.Enabled = true;
            chkQLSach.Enabled = true;
            chkQLTaiKhoan.Enabled = true;
            chkThongKe.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ctQuyenPresenter.Delete(_quyenDTO.Id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            q = (QuyenDTO)_quyenDTO.Clone();
            string mota = "";
            mota += chkQLSach.Checked ? "QL sách," : "";
            mota += chkQLBan.Checked ? "QL bán," : "";
            mota += chkQLNhap.Checked ? "QL nhập," : "";
            mota += chkQLNV.Checked ? "QL nhân viên," : "";
            mota += chkQLTaiKhoan.Checked ? "QL tài khoản," : "";
            mota += chkThongKe.Checked ? "Thống kê," : "";
            mota = mota.Substring(0, mota.Length - 1);
            q.TenQuyen = txtTenQuyen.Text;
            q.MoTa = mota;
            ctQuyenPresenter.Update(q);
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
                btnHuy.Visible = false;
                btnUpdate.Visible = false;
                txtTenQuyen.ReadOnly = true;
                chkQLBan.Enabled = false;
                chkQLNhap.Enabled = false;
                chkQLNV.Enabled = false;
                chkQLSach.Enabled = false;
                chkQLTaiKhoan.Enabled = false;
                chkThongKe.Enabled = false;
                txtTenQuyen.Text = _quyenDTO.TenQuyen;
                _quyenDTO = (QuyenDTO)q.Clone();
            }
        }
    }
}
