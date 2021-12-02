using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemCbx : UserControl
    {
        private FlowLayoutPanel _flp;
        public UCItemCbx(FlowLayoutPanel flowLayoutPanel, string title)
        {
            InitializeComponent();
            _flp = flowLayoutPanel;
            lblitem.Text = title;
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            _flp.Controls.Remove(this);
        }
    }
}
