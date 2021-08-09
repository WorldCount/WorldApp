
namespace WorldStat.Core.Reports.Models
{
    public class DispathReportStat
    {

        /// <summary>Общее количество</summary>
        public int AllCount => MailCount + ParcelCount;

        /// <summary>Общая плата</summary>
        public double AllPay => MailPay + ParcelPay;

        /// <summary>Количество писем, всего</summary>
        public int MailCount { get; private set; }
        /// <summary>Плата за письма, всего</summary>
        public double MailPay { get; private set; }

        /// <summary>Количество бандеролей, всего</summary>
        public int ParcelCount { get; private set; }
        /// <summary>Плата за бандероли, всего</summary>
        public double ParcelPay { get; private set; }

        /// <summary>Количество стикеров</summary>
        public int Stickers { get; private set; }
        /// <summary>Количество франкировки</summary>
        public int Frank { get; private set; }

        /// <summary>Статистика по категории отправления</summary>
        public DispathReportStat() { }

        public void Add(int count, double pay, long mailType)
        {
            if (mailType == 2 || mailType == 15)
            {
                Frank += count;
                MailCount += count;
                MailPay += pay;
            }
            else if (mailType == 3 || mailType == 16)
            {
                Stickers += count;
                ParcelCount += count;
                ParcelPay += pay;
            }
        }

        public void Remove(int count, double pay, long mailType)
        {
            if (mailType == 2 || mailType == 15)
            {
                Frank -= count;
                MailCount -= count;
                MailPay -= pay;
            }
            else if (mailType == 3 || mailType == 16)
            {
                Stickers -= count;
                ParcelCount -= count;
                ParcelPay -= pay;
            }
        }

        public void Clear()
        {
            MailCount = 0;
            MailPay = 0;
            ParcelCount = 0;
            ParcelPay = 0;
            Stickers = 0;
            Frank = 0;
        }
    }
}
