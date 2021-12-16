﻿using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVP.Views
{
    public partial class UCSach : UserControl, ISachView
    {
        private IEnumerable<SachDTO> _listSach;
        //private IEnumerable<SachDTO> _listSachByName;
        private IEnumerable<SachTacGiaDTO> _listSachTG;
        private IEnumerable<TacGiaDTO> _listTG;
        private SachPresenter _sachPresenter;
        public UCSach()
        {
            InitializeComponent();
            _sachPresenter = new SachPresenter(this);
        }

        private void UCSach_Load(object sender, EventArgs e)
        {
            _sachPresenter.GetsAll();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCThemSach ucThemSach = new UCThemSach();
            ucThemSach.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(ucThemSach);
            pnlContainer.Controls.SetChildIndex(ucThemSach, 0);
        }


        public void GetsAll(IEnumerable<SachDTO> listSach, IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG)
        {
            flp.Controls.Clear();
            _listSach = listSach;
            _listTG = listTG;
            _listSachTG = listSTG;
            var results = _listSachTG.Join(_listTG,
                      wo => wo.TacGiaId,
                      p => p.Id,
                      (stg, tg) => new { stg, tg }
                    );
            List<string> listtg;
            for (int i = 0; i < listSach.Count(); i++)
            {
                listtg = new List<string>();
                for (int j=0; j<results.Count(); j++)
                {
                    if(results.ElementAt(j).stg.SachId == listSach.ElementAt(i).Id)
                    {
                        listtg.Add(results.ElementAt(j).tg.ButDanh);
                    }
                }
                flp.Controls.Add(new UCItemSach(_listSach.ElementAt(i), listtg, getPanelContainer));
                
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            _sachPresenter.GetsAll();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flp.Controls.Clear();
            var listS = _listSach.Where(p => p.TenSach.StartsWith(txtTimKiem.Text)).ToList();
            /*var results = _listSachTG.Join(_listTG,
                      wo => wo.TacGiaId,
                      p => p.Id,
                      (stg, tg) => new { stg, tg }
                    );*/
            List<string> listtg = new List<string>();
            for (int i = 0; i < listS.Count(); i++)
            {
                var results = (
                        from tg in _listTG
                        join stg in _listSachTG on tg.Id equals stg.TacGiaId
                        where (stg.SachId == listS.ElementAt(i).Id)
                        select new {tg.ButDanh}
                    ).ToList();
                for(int j = 0; j< results.Count; j++)
                {
                    listtg.Add(results.ElementAt(j).ButDanh);
                }
                /*for (int j = 0; j < results.Count(); j++)
                {
                    if (results.ElementAt(j).stg.SachId == listS.ElementAt(i).Id)
                    {
                        listtg.Add(results.ElementAt(j).tg.ButDanh);
                    }
                }*/
                flp.Controls.Add(new UCItemSach(listS.ElementAt(i), listtg, getPanelContainer));
                listtg = new List<string>();
            }
        }

        public void GetsByName(IEnumerable<SachDTO> listSach)
        {
            //_listSachByName = listSach;
        }
    }
}
