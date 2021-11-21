using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Main()
        {
            InitializeComponent();
            buttonCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

      //  [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
      //  private extern static void ReleaseCapture();

      //  [DllImport("user32.DLL", EntryPoint = "SendMessage")]
     //   private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(12,108,218);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    panelTitle.BackColor = color;
                    buttonCloseChildForm.Visible = true;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SencondaryColor = ThemeColor.ChangeColorBrightness(color, 0);
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font= new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                }
            }
        }
        private void openChildForm(Form childForm , object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskTop.Controls.Add(childForm);
            this.panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        //    labelTitle.Text = childForm.Text;

        }
        private void buttonBanSach_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new BanSach(), sender);
            labelTitle.Text = "Bán sách";
        }

        private void buttonNhapSach_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new NhapSach(), sender);
            labelTitle.Text = "Nhập sách";
        }

        private void buttonSach_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new Sach(), sender);
            labelTitle.Text = "Sách";
        }

        private void buttonTheLoai_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new TheLoai(), sender);
            labelTitle.Text = "Thể loại";
        }

        private void buttonTacGia_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new TacGia(), sender);
            labelTitle.Text = "Tác giả";
        }

        private void buttonNXB_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new NhaXuatBan(), sender);
            labelTitle.Text = "Nhà xuất bản";
        }

        private void buttonNCC_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new NhaCungCap(), sender);
            labelTitle.Text = "Nhà cung cấp";
        }

        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new TaiKhoan(), sender);
            labelTitle.Text = "Tài khoản";
        }

        private void buttonNhanVien_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            openChildForm(new NhanVien(), sender);
            labelTitle.Text = "Nhân viên";
        }

        private void buttonDoanhThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitle.Text = "Doanh thu";
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitle.Text = "Thống kê";
        }
        private void buttonQuyen_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitle.Text = "Quyền";
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();

            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(41, 128, 185);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonCloseChildForm.Visible = false;

        }
        private void buttonExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }
    }
}
