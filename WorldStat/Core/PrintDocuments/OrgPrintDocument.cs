using System.Collections.Generic;
using System.Linq;
using WcPostApi.Types;
using WorldStat.Core.Database.Models;

namespace WorldStat.Core.PrintDocuments
{
    public class OrgPrintDocument : IncomePrintDocument
    {
        #region Private Fields

        private readonly List<MailCategory> _mailCategories;
        private readonly List<MailType> _mailTypes;

        #endregion

        public OrgPrintDocument(List<ReportPos> reports, string count, string sum, string posCount, bool grouping,
            List<MailCategory> mailCategories, List<MailType> mailTypes) 
            : base(reports, count, sum, posCount, grouping)
        {
            _mailTypes = mailTypes;
            _mailCategories = mailCategories;

            DefaultPageSettings.Landscape = !grouping;
        }

        #region Public Ovverrides Methods

        public override int[] GetColumnWidths()
        {
            if(Grouping)
                return new[] { 200, 140, 140, 80, 90, 120 };
            return new[] { 100, 320, 150, 150, 80, 90, 120, 100 };
        }

        public override string[] GetValuesByType(ReportPos report)
        {
            string category = "ВСЕ";
            if (report.TransCategory == TransCategory.Международная)
                category = "МЖД";
            else if (report.TransCategory == TransCategory.Внутренняя)
                category = "-";

            MailCategory mailCategory = _mailCategories.FirstOrDefault(c => c.Code == report.MailCategory);
            string mailCategoryName = report.MailCategory.ToString();
            if (mailCategory != null)
                mailCategoryName = mailCategory.ShortName;

            MailType mailType = _mailTypes.FirstOrDefault(t => t.Code == report.MailType);
            string mailTypeName = report.MailType.ToString();
            if (mailType != null)
                mailTypeName = mailType.ShortName;

            string type = report.TransType == TransType.Нет ? "-" : report.TransType.ToString();

            if(Grouping)
                return new[] { report.FirmName, mailTypeName, 
                    mailCategoryName, category, 
                    report.Count.ToString(), report.Pay.ToString("N2")};

            return new[] { report.DateText, report.FirmName, mailTypeName, 
                mailCategoryName, category,
                report.Count.ToString(), report.Pay.ToString("N2"), type };
        }

        public override string[] GetHeaderTitle()
        {
            if(Grouping)
                return new[] { "Организация", "Тип", "Категория", "Класс", "Кол-во", "Плата" };
            return new[] { "Дата", "Организация", "Тип", "Категория", "Класс", "Кол-во", "Плата", "Пересылка" };
        }

        public override string[] GetStatByType()
        {
            if(Grouping)
                return new[] { PosCount, "", "", "", Count, Sum, "" };
            return new[] { "", PosCount, "", "", "", Count, Sum, "" };
        }

        #endregion
    }
}
