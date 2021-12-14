using MVP.IViews;
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
            _listSach = listSach;
            _listTG = listTG;
            _listSachTG = listSTG;
            var results = _listSachTG.Join(_listTG,
                      wo => wo.TacGiaId,
                      p => p.Id,
                      (stg, tg) => new { stg, tg }
                    );
            List<string> listtg = new List<string>();
            for (int i = 0; i < listSach.Count(); i++)
            {
                for(int j=0; j<results.Count(); j++)
                {
                    if(results.ElementAt(j).stg.SachId == listSach.ElementAt(i).Id)
                    {
                        listtg.Add(results.ElementAt(j).tg.ButDanh);
                    }
                }
                flp.Controls.Add(new UCItemSach(_listSach.ElementAt(i), listtg, getPanelContainer));
            }
        }
    }
}
