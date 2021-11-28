using System;
using System.Drawing;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class SuaNhanVien : Form
    {
        public SuaNhanVien()
        {
            InitializeComponent();            
        }
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SencondaryColor;
                }
            }
        }
        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            loadTheme();
            dateTimePickerNBD.Format = DateTimePickerFormat.Custom;
            dateTimePickerNBD.CustomFormat = "dd/MM/yyyy";
            dateTimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
        }
    }
}
