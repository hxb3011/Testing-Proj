namespace HotelManagement.Data.Access
{
    using System;
    using System.Collections.Generic;

    public class StatisticsBO2
    {
        private static readonly object syncKey = new();
        private static StatisticsBO2 bo;

        public IList<(int, double)> RevenueByMonth => revenueByMonth;
        public IList<(string, double)> RoomRevenueByType => roomRevenueByType;
        public IList<(string, double)> ServiceRevenueByType => serviceRevenueByType;
        public static StatisticsBO2 Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new StatisticsBO2();
                    }
                return bo;
            }
        }

        private readonly List<(int, double)> revenueByMonth = new();
        private readonly List<(string, double)> roomRevenueByType = new();
        private readonly List<(string, double)> serviceRevenueByType = new();
        private readonly StatisticsDAO2 dao = new();

        public void LoadRevenueByMonthStatistic()
        {
            var values = dao.RevenueByMonthStatistic();
            int ld = -1;
            RevenueByMonth.Clear();
            foreach (var (d, t) in values)
            {
                if (ld >= 0)
                {
                    for (; ld < d; ++ld)
                        RevenueByMonth.Add((ld, 0));
                }
                RevenueByMonth.Add((d, t));
                ld = d + 1;
            }
            if (RevenueByMonth.Count == 0)
            {
                var dt = DateTime.Now;
                RevenueByMonth.Add((dt.Month - 1 + dt.Year * 12, 0));
            }
            while (RevenueByMonth.Count < 12)
                RevenueByMonth.Insert(0, (RevenueByMonth[0].Item1 - 1, 0));
        }

        public void LoadServiceRevenueByNameStatistic(int start, int end)
        {
            start = RevenueByMonth[start].Item1;
            end = RevenueByMonth[end].Item1;

            var values = dao.ServiceRevenueByNameStatistic(start, end);
            serviceRevenueByType.Clear();
            serviceRevenueByType.AddRange(values);
        }

        public void LoadRoomRevenueByTypeStatistic(int start, int end)
        {
            start = RevenueByMonth[start].Item1;
            end = RevenueByMonth[end].Item1;

            var values = dao.RoomRevenueByTypeStatistic(start, end);
            roomRevenueByType.Clear();
            roomRevenueByType.AddRange(values);
        }

        private StatisticsBO2() { }
    }
}
