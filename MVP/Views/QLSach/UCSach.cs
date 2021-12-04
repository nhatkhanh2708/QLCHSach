﻿using System;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCSach : UserControl
    {
        public UCSach()
        {
            InitializeComponent();
        }

        private void UCSach_Load(object sender, EventArgs e)
        {
            loadflp();
            hideScrollBar();
        }

        public Panel getPanelContainer
        {
            get { return pnlContainer; }
            set { pnlContainer = value; }
        }

        private void hideScrollBar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
        }

        private void loadflp()
        {
            for (int i = 0; i < 20; i++)
            {
                flp.Controls.Add(new UCItemSach(getPanelContainer));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCThemSach ucThemSach = new UCThemSach();
            ucThemSach.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemSach);
            pnlContainer.Controls.SetChildIndex(ucThemSach, 0);
        }
    }
}
