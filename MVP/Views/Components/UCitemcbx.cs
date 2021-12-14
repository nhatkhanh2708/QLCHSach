﻿using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCItemCbx : UserControl
    {
        private FlowLayoutPanel _flp;
        private int _id;
        public UCItemCbx(FlowLayoutPanel flowLayoutPanel, string title, int id)
        {
            InitializeComponent();
            _flp = flowLayoutPanel;
            lblitem.Text = title;
            _id = id;
        }

        public int getId() =>  _id;

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            _flp.Controls.Remove(this);
        }
    }
}
