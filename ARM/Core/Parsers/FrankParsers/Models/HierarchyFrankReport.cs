using System;
using System.Collections.Generic;
using System.Linq;

namespace ARM.Core.Parsers.FrankParsers.Models
{
    public class HierarchyFrankReport
    {
        #region Public Properties

        // Код организации
        public string FirmCode { get; set; }
        // Договор
        public string Doc { get; set; }
        // Название организации
        public string Name { get; set; }
        // Дата отчета
        public DateTime Date { get; set; }

        // Общая
        public int Count { get; set; }
        public double PaySum { get; set; }

        // Простая
        public int SimpleCount { get; set; }
        public double SimplePaySum { get; set; }

        // Заказная
        public int CustomCount { get; set; }
        public double CustomPaySum { get; set; }

        #endregion

        private readonly Dictionary<int, FrankMail> _positions = new Dictionary<int, FrankMail>();

        public bool SetName(string name)
        {
            string firm = name.Replace("\"   \"", " ").Replace("   ", "|");
            List<string> d = firm.Split('|').ToList();

            if (d.Count == 2)
            {
                Doc = d[0];
                Name = d[1];
                return true;
            }

            return false;
        }

        public void AddPosition(FrankRow frankRow)
        {
            if (!_positions.ContainsKey(frankRow.MailCode))
                _positions.Add(frankRow.MailCode, new FrankMail
                {
                    Count = frankRow.Count,
                    PaySum = frankRow.PaySum,
                    Code = frankRow.MailCode,
                    Name = frankRow.MailName
                });
            else
            {

                _positions[frankRow.MailCode].Count += frankRow.Count;
                _positions[frankRow.MailCode].PaySum += frankRow.PaySum;
            }

            Count += frankRow.Count;
            PaySum += frankRow.PaySum;

            if (frankRow.MailName.Contains("Пр"))
            {
                SimpleCount += frankRow.Count;
                SimplePaySum += frankRow.PaySum;
            }
            else
            {
                CustomCount += frankRow.Count;
                CustomPaySum += frankRow.PaySum;
            }
        }

        public void RemovePosition(FrankRow frankRow)
        {
            if (!_positions.ContainsKey(frankRow.MailCode))
                return;

            _positions[frankRow.MailCode].Count -= frankRow.Count;
            _positions[frankRow.MailCode].PaySum -= frankRow.PaySum;

            Count -= frankRow.Count;
            PaySum -= frankRow.PaySum;

            if (frankRow.MailName.Contains("Пр"))
            {
                SimpleCount -= frankRow.Count;
                SimplePaySum -= frankRow.PaySum;
            }
            else
            {
                CustomCount -= frankRow.Count;
                CustomPaySum -= frankRow.PaySum;
            }
        }

        public int GetPositionCount(int frankMailCode)
        {
            if (!_positions.ContainsKey(frankMailCode))
                return 0;
            return _positions[frankMailCode].Count;
        }

        public double GetPositionPaySum(int frankMailCode)
        {
            if (!_positions.ContainsKey(frankMailCode))
                return 0;
            return _positions[frankMailCode].PaySum;
        }

        public Dictionary<int, FrankMail> GetAllPositions()
        {
            return _positions;
        }
    }
}
