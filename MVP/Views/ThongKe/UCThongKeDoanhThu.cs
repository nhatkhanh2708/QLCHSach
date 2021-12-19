using Model.Entities;
using MVP.Properties;
using Service.DTOs;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MVP.Views
{
    public partial class UCThongKeDoanhThu : UserControl
    {
        private readonly IHdNhapService _hdNhapService;
        private readonly IHdXuatService _hdXuatService;
        private IEnumerable<HdNhapDTO> _listNhap;
        private IEnumerable<HdXuatDTO> _listXuat;
        private bool isPie = false;
        CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public UCThongKeDoanhThu()
        {
            InitializeComponent();
            _hdNhapService = (IHdNhapService)Startup.ServiceProvider.GetService(typeof(IHdNhapService));
            _hdXuatService = (IHdXuatService)Startup.ServiceProvider.GetService(typeof(IHdXuatService));
        }

        private void UCThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            _listNhap = _hdNhapService.GetsAll();
            _listXuat = _hdXuatService.GetsAll();
            dateFrom.Format = DateTimePickerFormat.Custom;
            dateFrom.CustomFormat = "dd-MM-yyyy";
            dateFrom.Value = DateTime.Today.AddMonths(-3);
            dateTo.Format = DateTimePickerFormat.Custom;
            dateTo.CustomFormat = "dd-MM-yyyy";
            dateTo.Value = DateTime.Today;
            LoadChart();
        }
        
        private void LoadChart()
        {
            pnlChart.Controls.Clear();
            Chart chart1;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new System.Drawing.Point(0, 0);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Nhập";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Xuất";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new System.Drawing.Size(pnlChart.Width, pnlChart.Height);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            pnlChart.Controls.Add(chart1);

            var yearfrom = dateFrom.Value.Year;
            var yearto = dateTo.Value.Year;

            if (yearfrom == yearto)
            {
                var monthfrom = dateFrom.Value.Month;
                var monthto = dateTo.Value.Month;

                if(monthfrom == monthto)
                {
                    var dayfrom = dateFrom.Value.Day;
                    var dayto = dateTo.Value.Day;

                    for(int day = dayfrom; day <= dayto; day++)
                    {
                        var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == monthfrom && p.NgayTao.Day == day)
                                        .Sum(x => x.TongTien);

                        var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == yearfrom &&
                                    p.NgayTao.Month == monthfrom && p.NgayTao.Day == day)
                                    .Sum(x => x.TongTien);

                        chart1.Series["Nhập"].Points.AddXY(day+"/"+monthfrom, listMonthfromNhap);
                        chart1.Series["Xuất"].Points.AddXY(day + "/" + monthfrom, listMonthfromXuat);
                    }
                }
                else
                {
                    for (int month = monthfrom; month <= monthto; month++)
                    {
                        if (month == monthfrom)
                        {
                            var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == month && p.NgayTao.Day >= dateFrom.Value.Day)
                                        .Sum(x => x.TongTien);

                            var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == month && p.NgayTao.Day >= dateFrom.Value.Day)
                                        .Sum(x => x.TongTien);

                            chart1.Series["Nhập"].Points.AddXY(month+"/"+yearfrom, listMonthfromNhap);
                            chart1.Series["Xuất"].Points.AddXY(month + "/" + yearfrom, listMonthfromXuat);
                        }
                        else if (month == monthto)
                        {
                            var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == month && p.NgayTao.Day <= dateTo.Value.Day)
                                        .Sum(x => x.TongTien);
                            
                            var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == month && p.NgayTao.Day <= dateTo.Value.Day)
                                        .Sum(x => x.TongTien);
                            chart1.Series["Nhập"].Points.AddXY(month + "/" + yearfrom, listMonthfromNhap);
                            chart1.Series["Xuất"].Points.AddXY(month + "/" + yearfrom, listMonthfromXuat);
                        }
                        else
                        {
                            var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == month)
                                        .Sum(x => x.TongTien);

                            var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == yearfrom &&
                                        p.NgayTao.Month == month)
                                        .Sum(x => x.TongTien);
                            chart1.Series["Nhập"].Points.AddXY(month + "/" + yearfrom, listMonthfromNhap);
                            chart1.Series["Xuất"].Points.AddXY(month + "/" + yearfrom, listMonthfromXuat);
                        }
                    }
                }
            }
            else
            {
                var monthfrom = dateFrom.Value.Month;
                var monthto = dateTo.Value.Month;
                var month = monthfrom;
                var year = yearfrom;
                bool flag = true;

                while(flag)
                {
                    if (month == monthfrom && year == yearfrom)
                    {
                        var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == year &&
                                    p.NgayTao.Month == month && p.NgayTao.Day >= dateFrom.Value.Day)
                                    .Sum(x => x.TongTien);

                        var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == year &&
                                    p.NgayTao.Month == month && p.NgayTao.Day >= dateFrom.Value.Day)
                                    .Sum(x => x.TongTien);
                        
                        chart1.Series["Nhập"].Points.AddXY(month+"/"+year, listMonthfromNhap);
                        chart1.Series["Xuất"].Points.AddXY(month + "/" + year, listMonthfromXuat);
                    }
                    else if (month == monthto && year == yearto)
                    {
                        var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == year &&
                                    p.NgayTao.Month == month && p.NgayTao.Day <= dateTo.Value.Day)
                                    .Sum(x => x.TongTien);

                        var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == year &&
                                    p.NgayTao.Month == month && p.NgayTao.Day <= dateTo.Value.Day)
                                    .Sum(x => x.TongTien);
                        chart1.Series["Nhập"].Points.AddXY(month + "/" + year, listMonthfromNhap);
                        chart1.Series["Xuất"].Points.AddXY(month + "/" + year, listMonthfromXuat);
                    }
                    else
                    {
                        var listMonthfromNhap = _listNhap.Where(p => p.NgayTao.Year == year &&
                                    p.NgayTao.Month == month)
                                    .Sum(x => x.TongTien);

                        var listMonthfromXuat = _listXuat.Where(p => p.NgayTao.Year == year &&
                                    p.NgayTao.Month == month)
                                    .Sum(x => x.TongTien);
                        chart1.Series["Nhập"].Points.AddXY(month + "/" + year, listMonthfromNhap);
                        chart1.Series["Xuất"].Points.AddXY(month + "/" + year, listMonthfromXuat);
                    }

                    if(month == monthto && year == yearto)
                    {
                        flag = false;
                        break;
                    }

                    if(month == 12)
                    {
                        month = 1;
                        year += 1;
                    }
                    else
                        month++;
                }
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!isPie)
                LoadChart();
            else
                LoadPie();
        }

        private void LoadPie()
        {
            pnlChart.Controls.Clear();
            var PriceNhap = _listNhap.Where(p => p.NgayTao >= dateFrom.Value && p.NgayTao < dateTo.Value.AddDays(1))
                                        .Sum(x => x.TongTien);

            var PriceXuat = _listXuat.Where(p => p.NgayTao >= dateFrom.Value && p.NgayTao < dateTo.Value.AddDays(1))
                        .Sum(x => x.TongTien);

            var tileNhap = Math.Round(Decimal.ToDouble(PriceNhap / (PriceNhap + PriceXuat)) * 100, 2, MidpointRounding.AwayFromZero);
            var tileXuat = Math.Round(100 - tileNhap, 2, MidpointRounding.AwayFromZero);

            Chart chartcircle;
            ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, tileNhap);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, tileXuat);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();

            chartcircle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartArea1.Name = "ChartArea1";
            chartcircle.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartcircle.Legends.Add(legend1);
            chartcircle.Location = new System.Drawing.Point(0, 0);
            chartcircle.Name = "chartcircle";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "circle";
            dataPoint1.AxisLabel = "Nhập ("+ double.Parse(PriceNhap.ToString()).ToString("#,###", cul.NumberFormat) + " VND)";
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.Label = "";
            dataPoint2.AxisLabel = "Xuất (" + double.Parse(PriceXuat.ToString()).ToString("#,###", cul.NumberFormat) + " VND)";
            dataPoint2.IsValueShownAsLabel = true;
            dataPoint2.Label = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartcircle.Series.Add(series1);
            chartcircle.Size = new System.Drawing.Size(pnlChart.Width, pnlChart.Height);
            chartcircle.TabIndex = 0;
            title1.Name = "Titlecircle";
            title1.Text = "Biểu đồ tiền nhập và xuất (%)";
            chartcircle.Titles.Add(title1);
            pnlChart.Controls.Add(chartcircle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isPie)
            {
                LoadPie();
                isPie = true;
                button1.Image = Resources.icons8_bar_chart_24;
            }
            else
            {
                LoadChart();
                isPie = false;
                button1.Image = Resources.icons8_pie_chart_24;
            }
        }
    }

}