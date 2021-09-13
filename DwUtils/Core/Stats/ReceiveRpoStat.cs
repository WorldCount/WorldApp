using System.Collections.Generic;
using DwUtils.Core.Database.Models;

namespace DwUtils.Core.Stats
{
    public class ReceiveRpoStat
    {
        #region Private Fields

        private readonly int _posCount;
        private readonly int _allCount;
        private readonly int _receiveCount;
        private readonly int _returnCount;
        private readonly double _returnPay;

        #endregion

        #region Public Properties

        public bool ReplaceNull { get; set; } = false;
        public string ReplaceChar { get; set; } = "0";

        public string PosCount => FormatInt(_posCount);
        public string AllCount => FormatInt(_allCount);
        public string ReceiveCount => FormatInt(_receiveCount);
        public string ReturnCount => FormatInt(_returnCount);
        public string ReturnPay => FormatDouble(_returnPay);

        #endregion

        public ReceiveRpoStat(List<ReceivedRpo> rpos)
        {
            if (rpos != null)
            {
                _posCount = rpos.Count;

                foreach (ReceivedRpo receivedRpo in rpos)
                {
                    _allCount += receivedRpo.AllCount;
                    _receiveCount += receivedRpo.ReceivedCount;
                    _returnCount += receivedRpo.ReturnCount;
                    _returnPay += receivedRpo.ReturnPay;
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
