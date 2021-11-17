﻿using MVP.IViews;
using MVP.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class Form1 : Form, INxbView
    {
        private NxbPresenter _nxbPresenter;
        public Form1()
        {
            InitializeComponent();
            _nxbPresenter = new NxbPresenter(this);
        }

        public void ThemThanhCong()
        {
            MessageBox.Show("Thanh cong");
        }

        public void ThemThatBai()
        {
            MessageBox.Show("That bai");
        }

        public void XoaThanhCong()
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _nxbPresenter.checkThem(tenNxb.Text, vietTat.Text);
        }

    }
}