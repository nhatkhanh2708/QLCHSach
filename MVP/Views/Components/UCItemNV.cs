using MVP.Properties;
using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemNV : UserControl
    {
        private bool _male;
        public UCItemNV(bool isMale)
        {
            InitializeComponent();
            _male = isMale;
        }

        private void UCItemNV_Load(object sender, EventArgs e)
        {
            lblGender.Image = _male ? Resources.icons8_male_24 : Resources.icons8_female_24;
            lblStatus.Image = true ? Resources.icons8_filled_circle_green : Resources.icons8_filled_circle_red;
        }
    }
}
