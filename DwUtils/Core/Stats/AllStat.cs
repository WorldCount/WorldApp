using System.Collections.Generic;
using DwUtils.Core.Database.Models;

namespace DwUtils.Core.Stats
{
    public class AllStat
    {
        #region Private Fields

        private readonly int _posCount;
        private readonly int _allCount;
        private readonly int _sentCount;
        private readonly int _allReceiveCount;
        private readonly int _receiveNoValueCount;
        private readonly int _valueCount;
        private readonly int _firstClassCount;
        private readonly int _receiveCount;
        private readonly int _returnCount;
        private readonly double _returnPay;
        private readonly int _notifyCount;
        private readonly int _handedCount;

        #endregion

        #region Public Properties

        public bool ReplaceNull { get; set; } = false;
        public string ReplaceChar { get; set; } = "0";

        public string PosCount => FormatInt(_posCount);
        public string AllCount => FormatInt(_allCount);
        public string SentCount => FormatInt(_sentCount);
        public string AllReceiveCount => FormatInt(_allReceiveCount);
        public string ReceiveNoValueCount => FormatInt(_receiveNoValueCount);
        public string ValueCount => FormatInt(_valueCount);
        public string FirstClassCount => FormatInt(_firstClassCount);
        public string ReceiveCount => FormatInt(_receiveCount);
        public string ReturnCount => FormatInt(_returnCount);
        public string ReturnPay => FormatDouble(_returnPay);
        public string NotifyCount => FormatInt(_notifyCount);
        public string HandedCount => FormatInt(_handedCount);

        #endregion

        public AllStat(List<AllStatRpo> rpos)
        {
            if (rpos != null)
            {
                _posCount = rpos.Count;

                foreach (AllStatRpo allRpo in rpos)
                {
                    _allCount += allRpo.AllCount;
                    _sentCount += allRpo.SentCount;
                    _allReceiveCount += allRpo.AllReceivedCount;
                    _receiveNoValueCount += allRpo.ReceivedNoValueCount;
                    _valueCount += allRpo.ValueCount;
                    _firstClassCount += allRpo.FirstClassCount;
                    _receiveCount += allRpo.ReceivedCount;
                    _returnCount += allRpo.ReturnCount;
                    _returnPay += allRpo.ReturnPay;
                    _notifyCount += allRpo.NotifyCount;
                    _handedCount += allRpo.HandedCount;
                }
            }
        }

        #region Private Methods

        private string FormatInt(int value)
        {
            if (ReplaceNull && value == 0)
                return ReplaceChar;

            return value.ToString();
        }

        private string FormatDouble(double value)
        {

            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (ReplaceNull && value == 0)
                return ReplaceChar;

            return value.ToString("F");
        }

        #endregion

        #region Public Methods

        public string GetReturnPayToFormat(string format = "C")
        {
            return _returnPay.ToString(format);
        }

        #endregion
    }
}
