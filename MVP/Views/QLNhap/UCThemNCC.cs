using MVP.IViews;
using MVP.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCThemNCC : UserControl, IThemNCCView
    {
        private ThemNCCPresenter _themnccPresenter;
        public UCThemNCC()
        {
            InitializeComponent();
            _themnccPresenter = new ThemNCCPresenter(this);
        }

        private void UCThemNCC_Load(object sender, EventArgs e)
        {
            dtpNgayHopTac.Format = DateTimePickerFormat.Custom;
            dtpNgayHopTac.CustomFormat = "MM/dd/yyyy";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _themnccPresenter.Add(txtNcc.Text, txtDiaChi.Text, txtSdt.Text, dtpNgayHopTac.Value, cbxStatus.GetItemText(cbxStatus.SelectedItem));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            txtNcc.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel2.Width - ucNotifi.Width) / 2,
                (panel2.Height - ucNotifi.Height) / 2);
            panel2.Controls.Add(ucNotifi);
            panel2.Controls.SetChildIndex(ucNotifi, 0);
            if (flag)
                refresh();
        }
    }
}
