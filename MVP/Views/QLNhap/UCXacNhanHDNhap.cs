using MVP.IViews;
using MVP.Presenters;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Windows.Forms;
using MVP.Properties;

namespace MVP.Views
{
    public partial class UCXacNhanHDNhap : UserControl, IXacNhanHDNhapView
    {
        private bool isComplete = false;
        private Dictionary<int, int> _listSelected;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private decimal _totalPrice = 0;
        private IEnumerable<SachTacGiaDTO> _listSTG;
        private IEnumerable<TacGiaDTO> _listTG;
        private int _NccId;
        private NhanVienDTO _nv;
        private NccDTO _ncc;
        private HdNhapDTO _hdNhap;
        private TaiKhoanDTO _taikhoan;        
        private XacNhanHDNhapPresenter _xacNhanHDNhapPresenter;
        private SachDTO _sach;
        private UCThemHDNhap _ucThemHdNhap;
        private DataTable dataTable;
        public UCXacNhanHDNhap(UCThemHDNhap ucThemHDNhap, TaiKhoanDTO taiKhoanDTO, Dictionary<int, int> listSelected, int nccId, IEnumerable<TacGiaDTO> listTG, IEnumerable<SachTacGiaDTO> listSTG, decimal totalPrice)
        {
            InitializeComponent();
            _taikhoan = taiKhoanDTO;
            _listSelected = listSelected;
            _NccId = nccId;
            _listTG = listTG;
            _listSTG = listSTG;
            _totalPrice = totalPrice;
            _xacNhanHDNhapPresenter = new XacNhanHDNhapPresenter(this);
            _ucThemHdNhap = ucThemHDNhap;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isComplete)
            {
                _ucThemHdNhap.CompleteCreatedBill(isComplete);
                Dispose();
            }
            else
                Dispose();
        }

        private void UCXacNhanHDNhap_Load(object sender, EventArgs e)
        {
            hideScrollbar();
            load();
        }

        private void load()
        {
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            _xacNhanHDNhapPresenter.GetTenNV_Ncc(_taikhoan.NhanVienId, _NccId);
            lblTongTien.Text = double.Parse(_totalPrice.ToString()).ToString("#,###", cul.NumberFormat) + " VND";

            dataTable = new DataTable();
            dataTable.Columns.Add("Sách");
            dataTable.Columns.Add("Số lượng");
            dataTable.Columns.Add("Giá");
            dataTable.Columns.Add("Thành tiền");

            var _listTemp = _listTG.Join(_listSTG,
                p => p.Id,
                q => q.TacGiaId,
                (tg, stg) => new { tg.ButDanh, stg.SachId }
                );
            int sum = 0;
            for (int i = 0; i < _listSelected.Count(); i++)
            {
                string tg = "";
                _xacNhanHDNhapPresenter.GetSachById(_listSelected.ElementAt(i).Key);
                for (int j = 0; j < _listTemp.Count(); j++)
                {
                    if (_listSelected.ElementAt(i).Key == _listTemp.ElementAt(j).SachId)
                    {
                        tg += _listTemp.ElementAt(j).ButDanh + ", ";
                    }
                }
                tg = tg.Substring(0, tg.Length - 2);
                sum += _listSelected.ElementAt(i).Value;
                flp.Controls.Add(new UCItemSachChon(null, null, _sach, tg, _listSelected.ElementAt(i).Value));

                dataTable.Rows.Add(new object[] { _sach.TenSach, _listSelected.ElementAt(i).Value,
                                    double.Parse(_sach.GiaNhap.ToString()).ToString("#,###", cul.NumberFormat) + " VND",
                                    double.Parse((_listSelected.ElementAt(i).Value * _sach.GiaNhap).ToString()).ToString("#,###", cul.NumberFormat) + " VND"
                            });
            }
            lblTongSoSach.Text = sum.ToString();
        }

        private void hideScrollbar()
        {
            flp.AutoScroll = false;
            flp.HorizontalScroll.Maximum = 0;
            flp.HorizontalScroll.Visible = false;
            flp.VerticalScroll.Maximum = 0;
            flp.VerticalScroll.Visible = false;
            flp.AutoScroll = true;
        }

        public void Notification(string title, string description, Image img, bool flag)
        {
            UCNotification ucNotifi = new UCNotification(title, description, img);
            ucNotifi.Anchor = AnchorStyles.None;
            ucNotifi.Location = new Point((panel1.Width - ucNotifi.Width) / 2,
                (panel1.Height - ucNotifi.Height) / 2);
            panel1.Controls.Add(ucNotifi);
            panel1.Controls.SetChildIndex(ucNotifi, 0);
            if (flag)
            {
                btnInHD.Visible = true;
                btnThanhtoan.Visible = false;
                isComplete = true;
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            ExportPdf();
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            _xacNhanHDNhapPresenter.AddHDNhap(_listSelected, _taikhoan.Id, _NccId, _totalPrice);
        }

        public void GetSachById(SachDTO sach)
        {
            _sach = sach;
        }


        private void ExportPdf()
        {
            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;
            document.PageSettings.Margins.All = 50;
            PdfPage page = document.Pages.Add();
            PdfGraphics graphics = page.Graphics;


            PdfImage image = PdfImage.FromImage(Resources.logoBook);
            RectangleF bounds = new RectangleF(230, 0, 300, 130);
            page.Graphics.DrawImage(image, bounds);


            PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            bounds = new RectangleF(0, bounds.Bottom + 10, graphics.ClientSize.Width, 30);
            graphics.DrawRectangle(solidBrush, bounds);
            PdfTrueTypeFont subHeadingFont = new PdfTrueTypeFont(new Font("Microsoft Sans Serif", 14), true);
            PdfTextElement element = new PdfTextElement("Hóa đơn #" + _hdNhap.Id + "             Nhà cung cấp: " + _ncc.TenNCC, subHeadingFont);
            element.Brush = PdfBrushes.White;
            PdfLayoutResult result = element.Draw(page, new PointF(10, bounds.Top + 8));
            string currentDate = "Ngày " + _hdNhap.NgayTao.ToString("dd-MM-yyyy HH:mm:ss");
            SizeF textSize = subHeadingFont.MeasureString(currentDate);
            PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);
            graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);


            DataTable invoiceDetails = dataTable;
            PdfGrid grid = new PdfGrid();
            grid.DataSource = invoiceDetails;

            PdfGridRow header = grid.Headers[0];
            PdfGridCellStyle headerStyle = new PdfGridCellStyle();
            headerStyle.Borders.All = new PdfPen(new PdfColor(126, 151, 173));
            headerStyle.BackgroundBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            headerStyle.TextBrush = PdfBrushes.White;
            headerStyle.Font = new PdfTrueTypeFont(new Font("Microsoft Sans Serif", 14), true);
            for (int i = 0; i < header.Cells.Count; i++)
            {
                header.Cells[i].StringFormat = new PdfStringFormat(PdfTextAlignment.Justify, PdfVerticalAlignment.Middle);
            }
            header.ApplyStyle(headerStyle);

            for (int i = 0; i < grid.Rows.Count; i++)
            {
                PdfGridRow r = grid.Rows[i];
                PdfGridCellStyle rStyle = new PdfGridCellStyle();
                rStyle.Borders.All = PdfPens.WhiteSmoke;
                rStyle.Font = new PdfTrueTypeFont(new Font("Microsoft Sans Serif", 14), true);
                rStyle.TextBrush = new PdfSolidBrush(new PdfColor(131, 130, 136));
                rStyle.Borders.All = new PdfPen(new PdfColor(217, 217, 217), 0.10f);
                r.ApplyStyle(rStyle);
            }

            PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
            layoutFormat.Layout = PdfLayoutType.Paginate;
            PdfGridLayoutResult gridResult = grid.Draw(page, new RectangleF(new PointF(0, result.Bounds.Bottom + 20), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);


            PdfBrush solidBrush1 = new PdfSolidBrush(new PdfColor(126, 151, 173));
            bounds = new RectangleF(0, gridResult.Bounds.Bottom + 10, graphics.ClientSize.Width, 30);
            graphics.DrawRectangle(solidBrush1, bounds);
            PdfTextElement element1 = new PdfTextElement("", subHeadingFont);
            element1.Brush = PdfBrushes.White;
            PdfLayoutResult result1 = element1.Draw(page, new PointF(10, bounds.Top + 8));
            string tongtien = "Tổng tiền: " + double.Parse(_hdNhap.TongTien.ToString()).ToString("#,###", cul.NumberFormat) + " VND";
            SizeF textSize1 = subHeadingFont.MeasureString(tongtien);
            PointF textPosition1 = new PointF(graphics.ClientSize.Width - textSize1.Width - 10, result1.Bounds.Y);
            graphics.DrawString(tongtien, subHeadingFont, element1.Brush, textPosition1);

            //document.Save("C:\\Users\\khanh\\Downloads\\HD"+_hdXuat.Id+"_"+_hdXuat.NgayTao.ToString("dd-MM-yyyy HH:mm:ss")+".pdf");
            document.Save("D:\\HDNhap" + _hdNhap.Id + "_" +
                _hdNhap.NgayTao.ToString("ddMMyyyyHHmmss") + ".pdf");
            document.Close(true);


            Notification("In hóa đơn thành công", null, Resources.success, true);
        }

        public void GetHDNhapNew(HdNhapDTO hdNhapDTO)
        {
            _hdNhap = hdNhapDTO;
        }

        public void GetTenNV_Ncc(NhanVienDTO nv, NccDTO ncc)
        {
            _nv = nv;
            _ncc = ncc;
            lblNcc.Text = _ncc.TenNCC;
            lblNguoitao.Text = _nv.HoTen;
        }
    }
}
