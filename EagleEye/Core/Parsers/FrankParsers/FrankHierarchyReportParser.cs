using System;
using System.Collections.Generic;
using System.IO;
using EagleEye.Core.Parsers.FrankParsers.Models;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace EagleEye.Core.Parsers.FrankParsers
{
    public class FrankHierarchyReportParser
    {
        private readonly string _path;
        private readonly List<HierarchyFrankReport> _frankReports;

        public DateTime ReportDate { get; set; }

        FrankHierarchyReportParser(string path)
        {
            _path = path;
            _frankReports = new List<HierarchyFrankReport>();
        }

        #region Public Methods

        public void Parse()
        {
            IWorkbook workbook = GetWorkbook();

            if(workbook == null)
                return;

            ISheet sheet = workbook.GetSheetAt(0);

            // Парсим дату отчета
            ReportDate = ParseReportDate(sheet);

            HierarchyFrankReport report = new HierarchyFrankReport { Date = ReportDate };

            for (int i = 9; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);

                int cellNum = row.LastCellNum;
                int cellCount = row.Cells.Count;


                if (cellNum == 6)
                    break;

                if (cellNum == 13 || cellNum == 8 || cellNum == 14)
                    continue;

                if (cellNum == 1 && cellCount == 1)
                    continue;

                if (cellNum == 12 && cellCount == 12)
                    continue;

                if (cellNum == 12 && cellCount == 10)
                    continue;

                FrankRow frankRow = ParseRow(row);

                if(frankRow.Type == FrankRowType.Skip)
                    continue;

                if (frankRow.Type == FrankRowType.FirmName)
                {
                    // Если i вышло за начальную точку -  это уже новая отчет,
                    // добавляем старый ко всем отчетам и делаем новый
                    if (i > 9)
                        _frankReports.Add(report);

                    report = new HierarchyFrankReport {Date = ReportDate, FirmCode = frankRow.FirmCode};
                    report.SetName(frankRow.FirmName);
                    continue;
                }

                if (frankRow.Type == FrankRowType.AppendFirmName)
                    report.Name = $"{report.Name} {frankRow.FirmName}";

                if(frankRow.Type == FrankRowType.Pay)
                    report.AddPosition(frankRow);
            }

            // Добавляем последний отчет
            _frankReports.Add(report);
        }

        public SortedDictionary<int, string> GetKeys()
        {
            SortedDictionary<int, string> keys = new SortedDictionary<int, string>();

            foreach (HierarchyFrankReport report in _frankReports)
            {
                foreach (KeyValuePair<int, FrankMail> pos in report.GetAllPositions())
                {
                    if(!keys.ContainsKey(pos.Key))
                        keys.Add(pos.Key, pos.Value.Name);
                }
            }

            return keys;
        }

        public string GetPath()
        {
            return _path;
        }

        public List<HierarchyFrankReport> GetReports()
        {
            return _frankReports;
        }

        public int Count()
        {
            return _frankReports.Count;
        }

        #endregion



        #region Private Methods

        private DateTime ParseReportDate(ISheet sheet)
        {
            try
            {
                IRow rowDate = sheet.GetRow(2);
                string rawDate = rowDate.Cells[0].StringCellValue;

                string[] data = rawDate.Split(' ');

                if (data.Length == 5)
                {
                    DateTime parse = DateTime.Parse(data[1]);
                    return parse;
                }

                return DateTime.Today;
            }
            catch
            {
                return DateTime.Today;
            }
        }

        private IWorkbook GetWorkbook()
        {
            IWorkbook workbook;

            if (string.IsNullOrEmpty(_path))
                return null;

            FileInfo fileInfo = new FileInfo(_path);
            string ext = fileInfo.Extension;

            if ((ext != ".xls") && (ext != ".xlsx"))
                return null;

            using (FileStream fileStream = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                if (ext == ".xlsx")
                    workbook = new XSSFWorkbook(fileStream);
                else
                    workbook = new HSSFWorkbook(fileStream);
            }

            return workbook;
        }

        private Tuple<int, string> ParseMailName(string mailName)
        {
            string[] data = mailName.Split(' ');

            string rawKey = data[data.Length - 1];

            int key;

            try
            {
                key = int.Parse(rawKey);
            }
            catch
            {
                return null;
            }

            string value = mailName.Replace(rawKey, "").Replace("Почта Рос - ", "").Trim();

            return Tuple.Create(key, value);
        }

        private FrankRow ParseRow(IRow row)
        {
            int cellCount = row.Cells.Count;

            if (cellCount == 2)
                return ParseFirmNameRow(row);

            if (cellCount == 1)
                return ParseAppendFirmNameRow(row);

            if (cellCount == 5)
                return ParsePayRow(row);

            return new FrankRow { Type = FrankRowType.Unknow };
        }

        private FrankRow ParseFirmNameRow(IRow row)
        {
            FrankRow frankRow = new FrankRow();

            try
            {
                int firmId = (int)row.Cells[0].NumericCellValue;
                string name = row.Cells[1].StringCellValue;

                frankRow.FirmCode = firmId.ToString().Trim();
                frankRow.FirmName = name.Trim();
                frankRow.Type = FrankRowType.FirmName;

                return frankRow;
            }
            catch
            {
                return new FrankRow { Type = FrankRowType.Unknow };
            }
        }

        private FrankRow ParseAppendFirmNameRow(IRow row)
        {
            FrankRow frankRow = new FrankRow();

            try
            {
                string name = row.Cells[0].StringCellValue;

                frankRow.FirmName = name.Trim();
                frankRow.Type = FrankRowType.AppendFirmName;

                return frankRow;
            }
            catch
            {
                return new FrankRow { Type = FrankRowType.Unknow };
            }
        }

        private FrankRow ParsePayRow(IRow row)
        {
            try
            {
                string mail = row.Cells[0].StringCellValue.Trim();
                if (string.IsNullOrEmpty(mail) || !mail.Contains("Почта Рос"))
                    return new FrankRow { Type = FrankRowType.Skip };

                Tuple<int, string> payTuple = ParseMailName(mail);
                if(payTuple == null)
                    return new FrankRow { Type = FrankRowType.Skip };


                int count = (int)row.Cells[1].NumericCellValue;
                double pay = row.Cells[4].NumericCellValue;

                return new FrankRow
                {
                    MailName = payTuple.Item2,
                    MailCode = payTuple.Item1,
                    Count = count,
                    PaySum = pay,
                    Type = FrankRowType.Pay
                };
            }
            catch
            {
                return new FrankRow { Type = FrankRowType.Unknow };
            }
        }

        #endregion


    }
}
