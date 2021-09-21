using System;

namespace DwUtils.Core.Database.Models
{
    public class AllStatRpo
    {
        /// <summary>Дата</summary>
        public DateTime Date { get; set; }
        /// <summary>Всего прибыло</summary>
        public int AllCount { get; set; }
        /// <summary>Дослано</summary>
        public int SentCount { get; set; }
        /// <summary>На вручение</summary>
        public int AllReceivedCount { get; set; }
        /// <summary>На вручение без ценных</summary>
        public int ReceivedNoValueCount { get; set; }
        /// <summary>Ценные</summary>
        public int ValueCount { get; set; }
        /// <summary>1 класс</summary>
        public int FirstClassCount { get; set; }
        /// <summary>Получателю</summary>
        public int ReceivedCount { get; set; }
        /// <summary>Возврат</summary>
        public int ReturnCount { get; set; }
        /// <summary>Плата за возврат</summary>
        public double ReturnPay { get; set; }
        /// <summary>Уведомления</summary>
        public int NotifyCount { get; set; }
        /// <summary>Вручено</summary>
        public int HandedCount { get; set; }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Hour { get; set; }


        public string AllCountName => AllCount == 0 ? "-" : AllCount.ToString();
        public string SentCountName => SentCount == 0 ? "-" : SentCount.ToString();
        public string AllReceivedCountName => AllReceivedCount == 0 ? "-" : AllReceivedCount.ToString();
        public string ReceivedNoValueCountName => ReceivedNoValueCount == 0 ? "-" : ReceivedNoValueCount.ToString();
        public string ValueCountName => ValueCount == 0 ? "-" : ValueCount.ToString();
        public string FirstClassCountName => FirstClassCount == 0 ? "-" : FirstClassCount.ToString();
        public string ReceivedCountName => ReceivedCount == 0 ? "-" : ReceivedCount.ToString();
        public string ReturnCountName => ReturnCount == 0 ? "-" : ReturnCount.ToString();
        // ReSharper disable once CompareOfFloatsByEqualityOperator
        public string ReturnPayName => ReturnPay == 0 ? "-" : ReturnPay.ToString("F");
        public string NotifyCountName => NotifyCount == 0 ? "-" : NotifyCount.ToString();
        public string HandedCountName => HandedCount == 0 ? "-" : HandedCount.ToString();


        public override string ToString()
        {
            return $"{Date} [{AllCount}]";
        }
    }
}
