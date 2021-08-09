using System.Collections.Generic;
using System.IO;
using System.Text;
using WcPostApi.Types;
using WorldStat.Core.Database.Models;

namespace WorldStat.Core.Reports.Models
{
    public class DispathReportRepository
    {

        #region Stat

        #region Простая

        /// <summary>Статистика по простым мжд</summary>
        private readonly DispathReportStat _interSimple;
        /// <summary>Статистика по простой почте</summary>
        private readonly DispathReportStat _simple;

        #endregion

        #region Заказная

        /// <summary>Статистика по 1 классу</summary>
        private readonly DispathReportStat _firstClass;
        /// <summary>Статистика по заказным мжд</summary>
        private readonly DispathReportStat _interCustom;
        /// <summary>Статистика по заказной почте</summary>
        private readonly DispathReportStat _custom;

        #endregion


        #endregion

        #region Public Properties

        #region Общая

        /// <summary>Стикеры</summary>
        public int Stickers => _interSimple.Stickers + _simple.Stickers + _firstClass.Stickers + _interCustom.Stickers + _custom.Stickers;
        /// <summary>Франкировка</summary>
        public int Frank => _interSimple.Frank + _simple.Frank + _firstClass.Frank + _interCustom.Frank + _custom.Frank;

        /// <summary>Количество отправлений, всего</summary>
        public int AllCount => _interSimple.AllCount + _simple.AllCount + _firstClass.AllCount + _interCustom.AllCount + _custom.AllCount;
        /// <summary>Плата за отправления, всего</summary>
        public double AllPay => _interSimple.AllPay + _simple.AllPay + _firstClass.AllPay + _interCustom.AllPay + _custom.AllPay;

        /// <summary>Количество писем, всего</summary>
        public int AllMailCount => _interSimple.MailCount + _simple.MailCount + _firstClass.MailCount + _interCustom.MailCount + _custom.MailCount;
        /// <summary>Плата за письма, всего</summary>
        public double AllMailPay => _interSimple.MailPay + _simple.MailPay + _firstClass.MailPay + _interCustom.MailPay + _custom.MailPay;

        /// <summary>Количество бандеролей, всего</summary>
        public int AllParcelCount => _interSimple.ParcelCount + _simple.ParcelCount + _firstClass.ParcelCount + _interCustom.ParcelCount + _custom.ParcelCount;
        /// <summary>Плата за бандероли, всего</summary>
        public double AllParcelPay => _interSimple.ParcelPay + _simple.ParcelPay + _firstClass.ParcelPay + _interCustom.ParcelPay + _custom.ParcelPay;

        #endregion

        #region Простая

        /// <summary>Количество простой почты</summary>
        public int SimpleCount => _simple.AllCount + _interSimple.AllCount;
        /// <summary>Плата за простую почту</summary>
        public double SimplePay => _simple.AllPay + _interSimple.AllPay;

        /// <summary>Количество простых писем</summary>
        public int SimpleMailCount => _simple.MailCount + _interSimple.MailCount;
        /// <summary>Плата за простые письма</summary>
        public double SimpleMailPay => _simple.MailPay + _interSimple.MailPay;

        /// <summary>Количество простых бандеролей</summary>
        public int SimpleParcelCount => _simple.ParcelCount + _interSimple.ParcelCount;
        /// <summary>Плата за простые бандероли</summary>
        public double SimpleParcelPay => _simple.ParcelPay + _interSimple.ParcelPay;

        #endregion

        #region Заказная

        /// <summary>Количество заказной почты</summary>
        public int CustomCount => _custom.AllCount + _interCustom.AllCount + _firstClass.AllCount;
        /// <summary>Плата за заказную почту</summary>
        public double CustomPay => _custom.AllPay + _interCustom.AllPay + _firstClass.AllPay;

        /// <summary>Количество заказных писем</summary>
        public int CustomMailCount => _custom.MailCount + _interCustom.MailCount + _firstClass.MailCount;
        /// <summary>Плата за заказные письма</summary>
        public double CustomMailPay => _custom.MailPay + _interCustom.MailPay + _firstClass.MailPay;

        /// <summary>Количество заказных бандеролей</summary>
        public int CustomParcelCount => _custom.ParcelCount + _interCustom.ParcelCount + _firstClass.ParcelCount;
        /// <summary>Плата за заказные бандероли</summary>
        public double CustomParcelPay => _custom.ParcelPay + _interCustom.ParcelPay + _firstClass.ParcelPay;

        #endregion

        #region Международная

        /// <summary>Количество мжд почты</summary>
        public int InterCount => _interCustom.AllCount + _interSimple.AllCount;
        /// <summary>Плата за мжд почту</summary>
        public double InterPay => _interCustom.AllPay + _interSimple.AllPay;

        /// <summary>Количество мжд писем</summary>
        public int InterMailCount => _interCustom.MailCount + _interSimple.MailCount;
        /// <summary>Плата за мжд письма</summary>
        public double InterMailPay => _interCustom.MailPay + _interSimple.MailPay;

        /// <summary>Количество мжд бандеролей</summary>
        public int InterParcelCount => _interCustom.ParcelCount + _interSimple.ParcelCount;
        /// <summary>Плата за мжд бандероли</summary>
        public double InterParcelPay => _interCustom.ParcelPay + _interSimple.ParcelPay;

        /// <summary>Количество мжд простых</summary>
        public int InterSimpleCount => _interSimple.AllCount;
        /// <summary>Плата за мжд простые</summary>
        public double InterSimplePay => _interSimple.AllPay;

        /// <summary>Количество простых мжд писем</summary>
        public int InterSimpleMailCount => _interSimple.MailCount;
        /// <summary>Плата за простые мжд письма</summary>
        public double InterSimpleMailPay => _interSimple.MailPay;

        /// <summary>Количество простых мжд бандеролей</summary>
        public int InterSimpleParcelCount => _interSimple.ParcelCount;
        /// <summary>Плата за простые мжд бандероли</summary>
        public double InterSimpleParcelPay => _interSimple.ParcelPay;

        /// <summary>Количество заказных мжд писем</summary>
        public int InterCustomMailCount => _interCustom.MailCount;
        /// <summary>Плата за заказные мжд письма</summary>
        public double InterCustomMailPay => _interCustom.MailPay;

        /// <summary>Количество заказных мжд бандеролей</summary>
        public int InterCustomParcelCount => _interCustom.ParcelCount;
        /// <summary>Плата за заказные мжд бандероли</summary>
        public double InterCustomParcelPay => _interCustom.ParcelPay;

        /// <summary>Количество мжд заказных</summary>
        public int InterCustomCount => _interCustom.AllCount;
        /// <summary>Плата за мжд заказные</summary>
        public double InterCustomPay => _interCustom.AllPay;

        #endregion

        #region Внутренняя

        /// <summary>Количество мжд почты</summary>
        public int InsideCount => _custom.AllCount + _simple.AllCount;
        /// <summary>Плата за мжд почту</summary>
        public double InsidePay => _custom.AllPay + _simple.AllPay;

        /// <summary>Количество мжд писем</summary>
        public int InsideMailCount => _custom.MailCount + _simple.MailCount;
        /// <summary>Плата за мжд письма</summary>
        public double InsideMailPay => _custom.MailPay + _simple.MailPay;

        /// <summary>Количество мжд бандеролей</summary>
        public int InsideParcelCount => _custom.ParcelCount + _simple.ParcelCount;
        /// <summary>Плата за мжд бандероли</summary>
        public double InsideParcelPay => _custom.ParcelPay + _simple.ParcelPay;

        /// <summary>Количество мжд простых</summary>
        public int InsideSimpleCount => _simple.AllCount;
        /// <summary>Плата за мжд простые</summary>
        public double InsideSimplePay => _simple.AllPay;

        /// <summary>Количество простых мжд писем</summary>
        public int InsideSimpleMailCount => _simple.MailCount;
        /// <summary>Плата за простые мжд письма</summary>
        public double InsideSimpleMailPay => _simple.MailPay;

        /// <summary>Количество простых мжд бандеролей</summary>
        public int InsideSimpleParcelCount => _simple.ParcelCount;
        /// <summary>Плата за простые мжд бандероли</summary>
        public double InsideSimpleParcelPay => _simple.ParcelPay;

        /// <summary>Количество заказных мжд писем</summary>
        public int InsideCustomMailCount => _custom.MailCount;
        /// <summary>Плата за заказные мжд письма</summary>
        public double InsideCustomMailPay => _custom.MailPay;

        /// <summary>Количество заказных мжд бандеролей</summary>
        public int InsideCustomParcelCount => _custom.ParcelCount;
        /// <summary>Плата за заказные мжд бандероли</summary>
        public double InsideCustomParcelPay => _custom.ParcelPay;

        /// <summary>Количество мжд заказных</summary>
        public int InsideCustomCount => _custom.AllCount;
        /// <summary>Плата за мжд заказные</summary>
        public double InsideCustomPay => _custom.AllPay;

        #endregion

        #region 1 класс

        /// <summary>Количество 1 класса</summary>
        public int FirstCount => _firstClass.AllCount;
        /// <summary>Плата за 1 класс</summary>
        public double FirstPay => _firstClass.AllPay;

        /// <summary>Количество заказных писем 1 класс</summary>
        public int FirstMailCount => _firstClass.MailCount;
        /// <summary>Плата за заказные письма 1 класс</summary>
        public double FirstMailPay => _firstClass.MailPay;

        /// <summary>Количество заказных бандеролей 1 класс</summary>
        public int FirstParcelCount => _firstClass.ParcelCount;
        /// <summary>Плата за заказные бандероли 1 класс</summary>
        public double FirstParcelPay => _firstClass.ParcelPay;

        #endregion

        #endregion

        public DispathReportRepository()
        {
            _firstClass = new DispathReportStat();
            _interSimple = new DispathReportStat();
            _interCustom = new DispathReportStat();
            _simple = new DispathReportStat();
            _custom = new DispathReportStat();
        }

        public DispathReportRepository(List<ReportPos> reports) : this()
        {
            foreach (ReportPos report in reports)
            {
                Add(report);
            }
        }

        public void Add(ReportPos report)
        {
            if (report != null)
            {
                if (report.MailCategory == 0)
                {
                    if (report.TransCategory == TransCategory.Внутренняя)
                    {
                        if (report.MailType == 2 || report.MailType == 3)
                            _simple.Add(report.Count, report.Pay, report.MailType);
                    }
                    else if (report.TransCategory == TransCategory.Международная)
                        _interSimple.Add(report.Count, report.Pay, report.MailType);
                }
                else if (report.MailCategory == 1)
                {
                    if (report.TransCategory == TransCategory.Внутренняя)
                    {
                        if (report.MailType == 2 || report.MailType == 3)
                            _custom.Add(report.Count, report.Pay, report.MailType);
                        else if(report.MailType == 15 || report.MailType == 16)
                            _firstClass.Add(report.Count, report.Pay, report.MailType);
                    }
                    else if (report.TransCategory == TransCategory.Международная)
                        _interCustom.Add(report.Count, report.Pay, report.MailType);
                }
            }
        }

        public List<DispathReport> ToDispathReports()
        {
            List<DispathReport> dispathReports = new List<DispathReport>();

            DispathReport clear = new DispathReport{ IsVoid = true };

            
            if (AllCount > 0)
            {

                #region Услуги

                dispathReports.Add(new DispathReport { Name = "УСЛУГИ:", IsVoid = true, IsHeader = true });

                if (Frank > 0)
                    dispathReports.Add(new DispathReport { Description = "Франкировка", Count = Frank, IsVoid = true });

                if (Stickers > 0)
                    dispathReports.Add(new DispathReport { Description = "Стикеры", Count = Stickers, IsVoid = true });
                dispathReports.Add(clear);

                dispathReports.Add(clear);

                #endregion

                #region Общие данные

                dispathReports.Add(new DispathReport { Name = "ОБЩИЕ ДАННЫЕ:", IsVoid = true, IsHeader = true });
                dispathReports.Add(new DispathReport { Name = "Отправлений", Description = "Всего", Count = AllCount, Pay = AllPay, IsSubheader = true });

                if(AllParcelCount > 0)
                    dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = AllParcelCount, Pay = AllParcelPay });
                
                if(AllMailCount > 0)
                    dispathReports.Add(new DispathReport { Description = "Писем", Count = AllMailCount, Pay = AllMailPay });
                dispathReports.Add(clear);

                if (SimpleCount > 0)
                {
                    dispathReports.Add(new DispathReport { Name = "Простой", Description = "Всего", Count = SimpleCount, Pay = SimplePay });

                    if(SimpleParcelCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = SimpleParcelCount, Pay = SimpleParcelPay });

                    if(SimpleMailCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Писем", Count = SimpleMailCount, Pay = SimpleMailPay });
                    dispathReports.Add(clear);
                }


                if (CustomCount > 0)
                {
                    dispathReports.Add(new DispathReport { Name = "Заказной", Description = "Всего", Count = CustomCount, Pay = CustomPay });

                    if(CustomParcelCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = CustomParcelCount, Pay = CustomParcelPay });
                    if(CustomMailCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Писем", Count = CustomMailCount, Pay = CustomMailPay });
                    dispathReports.Add(clear);
                }
                
                dispathReports.Add(clear);

                #endregion

                dispathReports.Add(new DispathReport { Name = "ПО ВИДАМ ОТПРАВЛЕНИЙ:", IsVoid = true, IsHeader = true });

                #region 1 класс

                if (FirstCount > 0)
                {
                    dispathReports.Add(new DispathReport { Name = "1 класс", Description = "Всего", Count = FirstCount, Pay = FirstPay, IsSubheader = true });

                    if (FirstParcelCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = FirstParcelCount, Pay = FirstParcelPay });

                    if (FirstMailCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Писем", Count = FirstMailCount, Pay = FirstMailPay });
                    dispathReports.Add(clear);
                }

                dispathReports.Add(clear);

                #endregion

                #region Международные

                if (InterCount > 0)
                {
                    dispathReports.Add(new DispathReport { Name = "Международные", Description = "Всего", Count = InterCount, Pay = InterPay, IsSubheader = true });

                    if (InterParcelCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = InterParcelCount, Pay = InterParcelPay });

                    if (InterMailCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Писем", Count = InterMailCount, Pay = InterMailPay });

                    dispathReports.Add(clear);

                    if (InterSimpleCount > 0)
                    {
                        dispathReports.Add(new DispathReport { Name = "Простой", Description = "Всего", Count = InterSimpleCount, Pay = InterSimplePay });

                        if (InterSimpleParcelCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = InterSimpleParcelCount, Pay = InterSimpleParcelPay });
                        if (InterSimpleMailCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Писем", Count = InterSimpleMailCount, Pay = InterSimpleMailPay });

                        dispathReports.Add(clear);
                    }

                    if (InterCustomCount > 0)
                    {
                        dispathReports.Add(new DispathReport { Name = "Заказной", Description = "Всего", Count = InterCustomCount, Pay = InterCustomPay });
                        if (InterCustomParcelCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = InterCustomParcelCount, Pay = InterCustomParcelPay });
                        if (InterCustomMailCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Писем", Count = InterCustomMailCount, Pay = InterCustomMailPay });
                        dispathReports.Add(clear);
                    }


                    dispathReports.Add(clear);
                }

                #endregion

                #region Внутренняя

                if (InsideCount > 0)
                {
                    dispathReports.Add(new DispathReport { Name = "Внутренние", Description = "Всего", Count = InsideCount, Pay = InsidePay, IsSubheader = true });

                    if (InsideParcelCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = InsideParcelCount, Pay = InsideParcelPay });

                    if (InsideMailCount > 0)
                        dispathReports.Add(new DispathReport { Description = "Писем", Count = InsideMailCount, Pay = InsideMailPay });

                    dispathReports.Add(clear);

                    if (InsideSimpleCount > 0)
                    {
                        dispathReports.Add(new DispathReport { Name = "Простой", Description = "Всего", Count = InsideSimpleCount, Pay = InsideSimplePay });

                        if (InsideSimpleParcelCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = InsideSimpleParcelCount, Pay = InsideSimpleParcelPay });
                        if (InsideSimpleMailCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Писем", Count = InsideSimpleMailCount, Pay = InsideSimpleMailPay });

                        dispathReports.Add(clear);
                    }

                    if (InsideCustomCount > 0)
                    {
                        dispathReports.Add(new DispathReport { Name = "Заказной", Description = "Всего", Count = InsideCustomCount, Pay = InsideCustomPay });
                        if (InsideCustomParcelCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Бандеролей", Count = InsideCustomParcelCount, Pay = InsideCustomParcelPay });
                        if (InsideCustomMailCount > 0)
                            dispathReports.Add(new DispathReport { Description = "Писем", Count = InsideCustomMailCount, Pay = InsideCustomMailPay });
                        dispathReports.Add(clear);
                    }


                    dispathReports.Add(clear);
                }

                #endregion
            }

            return dispathReports;
        }

        public void SaveToFile(string path, string reportName)
        {
            if (AllCount > 0)
            {
                string report = GetFileReportData(reportName);
                if(string.IsNullOrEmpty(report))
                    return;

                try
                {
                    using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                        sw.Write(report);
                }
                catch
                {
                    //
                }
            }
        }

        private string FormatPay(double pay)
        {
            return $"{pay:F} р".Replace(',', '.');
        }

        private string GetFileReportData(string reportName)
        {
            string headerLine = "================================================";
            string footerLine = "------------------------------------------------";

            if (AllCount > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("");
                sb.AppendLine($"[ОТЧЕТ: {reportName}]");
                sb.AppendLine("");

                sb.AppendLine("Общие данные:");
                sb.AppendLine(headerLine);
                sb.AppendLine($"Всего отправлений: {AllCount} шт = {FormatPay(AllPay)}");
                sb.AppendLine(headerLine);
                sb.AppendLine($"\tБандеролей: {AllParcelCount} шт = {FormatPay(AllParcelPay)}");
                sb.AppendLine($"\tПисем: {AllMailCount} шт = {FormatPay(AllMailPay)}");
                sb.AppendLine(footerLine);
                sb.AppendLine($"\tФранкировка: {Frank} шт");
                sb.AppendLine($"\tСтикеры: {Stickers} шт");
                sb.AppendLine(footerLine);
                sb.AppendLine("");

                sb.AppendLine("Из них простой:");
                sb.AppendLine(headerLine);
                sb.AppendLine($"Всего отправлений: {SimpleCount} шт = {FormatPay(SimplePay)}");
                sb.AppendLine(headerLine);
                sb.AppendLine($"\tБандеролей: {SimpleParcelCount} шт = {FormatPay(SimpleParcelPay)}");
                sb.AppendLine($"\tПисем: {SimpleMailCount} шт = {FormatPay(SimpleMailPay)}");
                sb.AppendLine(footerLine);
                sb.AppendLine("");

                sb.AppendLine("Из них заказной:");
                sb.AppendLine(headerLine);
                sb.AppendLine($"Всего отправлений: {CustomCount} шт = {FormatPay(CustomPay)}");
                sb.AppendLine(headerLine);
                sb.AppendLine($"\tБандеролей: {CustomParcelCount} шт = {FormatPay(CustomParcelPay)}");
                sb.AppendLine($"\tПисем: {CustomMailCount} шт = {FormatPay(CustomMailPay)}");
                sb.AppendLine(footerLine);
                sb.AppendLine("");

                sb.AppendLine("");
                sb.AppendLine("*** ПО ВИДАМ ОТПРАВЛЕНИЙ ***");
                sb.AppendLine("");

                sb.AppendLine("1 класс:");
                sb.AppendLine(headerLine);
                sb.AppendLine($"Всего отправлений: {FirstCount} шт = {FormatPay(FirstPay)}");
                sb.AppendLine(headerLine);
                sb.AppendLine($"\tБандеролей: {FirstParcelCount} шт = {FormatPay(FirstParcelPay)}");
                sb.AppendLine($"\tПисем: {FirstMailCount} шт = {FormatPay(FirstMailPay)}");
                sb.AppendLine(footerLine);
                sb.AppendLine("");

                sb.AppendLine("Международные:");
                sb.AppendLine(headerLine);
                sb.AppendLine($"Всего отправлений: {InterCount} шт = {FormatPay(InterPay)}");
                sb.AppendLine(headerLine);
                sb.AppendLine($"\tБандеролей: {InterParcelCount} шт = {FormatPay(InterParcelPay)}");
                sb.AppendLine($"\t\t- простых: {InterSimpleParcelCount} шт = {FormatPay(InterSimpleParcelPay)}");
                sb.AppendLine($"\t\t- заказных: {InterCustomParcelCount} шт = {FormatPay(InterCustomParcelPay)}");
                sb.AppendLine($"\tПисем: {InterMailCount} шт = {FormatPay(InterMailPay)}");
                sb.AppendLine($"\t\t- простых: {InterSimpleMailCount} шт = {FormatPay(InterSimpleMailPay)}");
                sb.AppendLine($"\t\t- заказных: {InterCustomMailCount} шт = {FormatPay(InterCustomMailPay)}");
                sb.AppendLine(footerLine);
                sb.AppendLine("");

                sb.AppendLine("Внутренние:");
                sb.AppendLine(headerLine);
                sb.AppendLine($"Всего отправлений: {InsideCount} шт = {FormatPay(InsidePay)}");
                sb.AppendLine(headerLine);
                sb.AppendLine($"\tБандеролей: {InsideParcelCount} шт = {FormatPay(InsideParcelPay)}");
                sb.AppendLine($"\t\t- простых: {InsideSimpleParcelCount} шт = {FormatPay(InsideSimpleParcelPay)}");
                sb.AppendLine($"\t\t- заказных: {InsideCustomParcelCount} шт = {FormatPay(InsideCustomParcelPay)}");
                sb.AppendLine($"\tПисем: {InsideMailCount} шт = {FormatPay(InsideMailPay)}");
                sb.AppendLine($"\t\t- простых: {InsideSimpleMailCount} шт = {FormatPay(InsideSimpleMailPay)}");
                sb.AppendLine($"\t\t- заказных: {InsideCustomMailCount} шт = {FormatPay(InsideCustomMailPay)}");
                sb.AppendLine(footerLine);
                sb.AppendLine("");

                return sb.ToString();
            }

            return null;
        }
    }
}
