using Service.DTOs;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietQuyen : UserControl
    {
        private QuyenDTO _quyenDTO;
        public UCChiTietQuyen(QuyenDTO quyenDTO)
        {
            InitializeComponent();
            _quyenDTO = quyenDTO;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //QL sách,QL bán,QL nhập,QL nhân viên,QL tài khoản,Thống kê
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

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
