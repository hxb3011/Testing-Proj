namespace HotelManagement.GUI
{
    using HotelManagement.Data.Access;

    using System;
    using System.Windows.Forms.DataVisualization.Charting;

    public partial class StatisticsUI2 : Form
    {
        private int start, end;
        public StatisticsUI2()
        {
            InitializeComponent();
            chart1.AxisViewChanged += Chart1_AxisViewChanged;
            LoadRevenueByMonth();
            UpdateTotals();
            LoadRoomRevenueByType();
            LoadServiceRevenueByName();
        }

        private void LoadServiceRevenueByName()
        {
            var bo = StatisticsBO2.Instance;
            bo.LoadServiceRevenueByNameStatistic(start, end);
            var seService = chart1.Series["seService"];
            var points = seService.Points;
            points.Clear();
            var serviceRevenue = bo.ServiceRevenueByType;
            if (serviceRevenue == null || serviceRevenue.Count == 0)
            {
                var i = points.AddXY("Tất cả", 1);
                points[i].IsValueShownAsLabel = false;
                points[i].Label = "0";
                return;
            }
            foreach (var p in bo.ServiceRevenueByType)
                points.AddXY(p.Item1, p.Item2);
        }

        private void UpdateTotals()
        {
            var bo = StatisticsBO2.Instance;
            double sum = 0;
            for (int i = start, end = this.end; i <= end; ++i)
                sum += bo.RevenueByMonth[i].Item2;
            var seMonth = chart1.Series["seMonth"];
            seMonth.LegendText = string.Format("Tổng cộng: {0:F2}", sum);
        }

        private void LoadRoomRevenueByType()
        {
            var bo = StatisticsBO2.Instance;
            bo.LoadRoomRevenueByTypeStatistic(start, end);
            var seRoom = chart1.Series["seRoom"];
            var points = seRoom.Points;
            points.Clear();
            var roomRevenue = bo.RoomRevenueByType;
            if (roomRevenue == null || roomRevenue.Count == 0)
            {
                var i = points.AddXY("Tất cả", 1);
                points[i].IsValueShownAsLabel = false;
                points[i].Label = "0";
                return;
            }
            foreach (var p in roomRevenue)
                points.AddXY(p.Item1, p.Item2);
        }

        private void LoadRevenueByMonth()
        {
            var bo = StatisticsBO2.Instance;
            bo.LoadRevenueByMonthStatistic();
            var seMonth = chart1.Series["seMonth"];
            var points = seMonth.Points;
            points.Clear();
            var revenue = bo.RevenueByMonth;
            foreach (var (x, y) in revenue)
                points.AddXY(string.Format("{0}/{1}", x % 12 + 1, x / 12), y);
            start = 0;
            end = revenue.Count - 1;
        }

        private void Chart1_AxisViewChanged(object? sender, ViewEventArgs e)
        {
            double start = e.NewPosition, end = e.NewSize;
            //if (!double.IsNaN(end) && !double.IsNaN(start)) end += start - 1;
            var bo = StatisticsBO2.Instance;
            int istart = 0, iend = bo.RevenueByMonth.Count - 1;
            if (!double.IsNaN(start))
            {
                if (start >= 0)
                    istart = start > iend ? iend : (int)start;
                if (!double.IsNaN(end))
                    end += start - 1;
            }

            if (!double.IsNaN(end))
            {
                if (end < istart) iend = istart;
                else if (end <= iend) iend = (int)end;
            }

            this.start = istart;
            this.end = iend;

            UpdateTotals();
            LoadRoomRevenueByType();
            LoadServiceRevenueByName();
        }

    }
}
