﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCChiTietNCC : UserControl
    {
        public UCChiTietNCC()
        {
            InitializeComponent();
        }

        private void UCChiTietNCC_Load(object sender, EventArgs e)
        {
            dtpNgayHopTac.Format = DateTimePickerFormat.Custom;
            dtpNgayHopTac.CustomFormat = "MM/dd/yyyy";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}