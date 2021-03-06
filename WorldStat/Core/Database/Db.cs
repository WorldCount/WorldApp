using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WcPostApi.Types;
using WorldStat.Core.Database.Contexts;
using WorldStat.Core.Database.Models;

namespace WorldStat.Core.Database
{
    public static class Db
    {

        #region MailType

        public static List<MailType> LoadActiveMailTypes()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                List<MailType> mailTypes = db.MailTypes.Where(t => t.Enable).OrderBy(t => t.ShortName).ToList();
                mailTypes.Insert(0, new MailType
                {
                    Name = "ВСЕ",
                    ShortName = "ВСЕ",
                    Id = 0,
                    Code = 9999
                });

                return mailTypes;
            }
        }

        public static async Task<List<MailType>> LoadActiveMailTypesAsync()
        {
            return await Task.Run(LoadActiveMailTypes);
        }

        public static List<MailType> LoadAllMailTypes()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                List<MailType> mailTypes = db.MailTypes.OrderBy(t => t.ShortName).ToList();
                return mailTypes;
            }
        }

        public static async Task<List<MailType>> LoadAllMailTypesAsync()
        {
            return await Task.Run(LoadAllMailTypes);
        }

        #endregion

        #region MailCategory

        public static List<MailCategory> LoadActiveMailCategories()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                List<MailCategory> mailCategories = db.MailCategories.Where(c => c.Enable).OrderBy(t => t.ShortName).ToList();
                mailCategories.Insert(0, new MailCategory
                {
                    Name = "ВСЕ",
                    ShortName = "ВСЕ",
                    Id = 0,
                    Code = 9999
                });

                return mailCategories;
            }
        }

        public static async Task<List<MailCategory>> LoadActiveMailCategoriesAsync()
        {
            return await Task.Run(LoadActiveMailCategories);
        }

        public static List<MailCategory> LoadAllMailCategories()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                List<MailCategory> mailCategories = db.MailCategories.OrderBy(t => t.ShortName).ToList();
                return mailCategories;
            }
        }

        public static async Task<List<MailCategory>> LoadAllMailCategoriesAsync()
        {
            return await Task.Run(LoadAllMailCategories);
        }

        #endregion

        #region Firms

        public static List<Firm> LoadAllFirms()
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                List<Firm> firms = db.Firms.OrderBy(f => f.ShortName).ToList();
                firms.Insert(0, new Firm
                {
                    Name = "ВСЕ",
                    ShortName = "ВСЕ",
                    Id = 0
                });

                return firms;
            }
        }

        public static async Task<List<Firm>> LoadAllFirmsAsync()
        {
            return await Task.Run(LoadAllFirms);
        }

        #endregion

        #region Report Poses

        /// <summary>
        /// Группированный отчет по доходам
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="firmId">Id организации</param>
        /// <param name="mailType">Тип отправления</param>
        /// <param name="mailCategory">Категория отправления</param>
        /// <param name="transCategory">Класс отправления</param>
        /// <param name="transType">Пересылка</param>
        /// <param name="group">Групировать данные</param>
        /// <returns>Список позиций</returns>
        public static List<ReportPos> LoadGroupIncomeReportPoses(DateTime start, DateTime end, int firmId = 0,
            long mailType = 9999, long mailCategory = 9999, TransCategory transCategory = TransCategory.ВСЕ, TransType transType = TransType.ВСЕ, bool group = false)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select r.Id, r.Date, r.FirmId, r.MailCategory, r.MailType, r.TransCategory, r.TransType, Sum(Count) as Count, Sum(Pay) as Pay, r.ReportId");
            sb.Append(" from ReportPoses r");
            sb.Append(" inner join Firms f on r.FirmId = f.Id");
            sb.Append($" where r.date >= '{start:yyyy-MM-dd}' and r.date <= '{end.AddDays(1):yyyy-MM-dd}'");

            if (firmId > 0)
                sb.Append($" and r.FirmId = {firmId} ");

            if (mailType != 9999)
                sb.Append($" and r.MailType = {mailType}");

            if (mailCategory != 9999)
                sb.Append($" and r.MailCategory = {mailCategory}");

            if (transCategory != TransCategory.ВСЕ)
                sb.Append($" and r.TransCategory = {(int)transCategory}");

            if (transType != TransType.ВСЕ)
                sb.Append($" and r.TransType = {(int) transType}");

            sb.Append(@group ? " group by r.FirmId" : " group by r.Date, r.FirmId");

            using (WorldStatContext db = new WorldStatContext())
            {
                var q = db.ReportPoses.FromSql(sb.ToString());

                q = q.Include(r => r.Firm);
                q = @group ? q.OrderBy(p => p.Firm.ShortName) : q.OrderBy(p => p.Date).ThenBy(p => p.Firm.ShortName);

                var data = q.ToList();

                if (group)
                {
                    DateTime date = new DateTime(1986, 9, 2);
                    foreach (ReportPos reportPose in data)
                        reportPose.Date = date;
                }

                return data;
            }
        }

        /// <summary>
        /// Группированный отчет по доходам
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="firmId">Id организации</param>
        /// <param name="mailType">Тип отправления</param>
        /// <param name="mailCategory">Категория отправления</param>
        /// <param name="transCategory">Класс отправления</param>
        /// <param name="transType">Пересылка</param>
        /// <param name="group">Групировать данные</param>
        /// <returns>Список позиций</returns>
        public static async Task<List<ReportPos>> LoadGroupIncomeReportPosesAsync(DateTime start, DateTime end,
            int firmId = 0, long mailType = 9999, long mailCategory = 9999, TransCategory transCategory = TransCategory.ВСЕ, 
            TransType transType = TransType.ВСЕ, bool group = false)
        {
            return await Task.Run(() => LoadGroupIncomeReportPoses(start, end, firmId, mailType, mailCategory, transCategory, transType, group));
        }

        /// <summary>
        /// Группированный отчет по позициям
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="firmId">Id организации</param>
        /// <param name="mailType">Тип отправления</param>
        /// <param name="mailCategory">Категория отправления</param>
        /// <param name="transCategory">Класс отправления</param>
        /// <returns>Список позиций</returns>
        public static List<ReportPos> LoadGroupReportPoses(DateTime start, DateTime end, int firmId = 0, long mailType = 9999,
            long mailCategory = 9999, TransCategory transCategory = TransCategory.ВСЕ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select r.Id, r.Date, r.FirmId, r.MailCategory, r.MailType, r.TransCategory, r.TransType, Sum(Count) as Count, Sum(Pay) as Pay, r.ReportId");
            sb.Append(" from ReportPoses r");
            sb.Append($" where r.date >= '{start:yyyy-MM-dd}' and r.date <= '{end.AddDays(1):yyyy-MM-dd}'");

            if (firmId > 0)
                sb.Append($" and r.FirmId = {firmId} ");

            if (mailType != 9999)
                sb.Append($" and r.MailType = {mailType}");

            if(mailCategory != 9999)
                sb.Append($" and r.MailCategory = {mailCategory}");

            if (transCategory != TransCategory.ВСЕ)
                sb.Append($" and r.TransCategory = {(int)transCategory}");

            sb.Append(" group by r.FirmId, r.MailCategory, r.MailType, r.TransCategory");

            using (WorldStatContext db = new WorldStatContext())
            {
                var q = db.ReportPoses.FromSql(sb.ToString());
                
                q = q.Include(r => r.Firm);
                q = q.OrderBy(p => p.Firm.ShortName).ThenBy(p => p.TransCategory).ThenByDescending(p => p.MailCategory).ThenBy(p => p.MailType);

                var data = q.ToList();

                DateTime date = new DateTime(1986, 9, 2);
                foreach (ReportPos reportPose in data)
                {
                    reportPose.Date = date;
                    reportPose.TransType = TransType.ВСЕ;
                }

                return data;
            }
        }

        /// <summary>
        /// Группированный отчет по позициям
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="firmId">Id организации</param>
        /// <param name="mailType">Тип отправления</param>
        /// <param name="mailCategory">Категория отправления</param>
        /// <param name="transCategory">Класс отправления</param>
        /// <returns>Список позиций</returns>
        public static async Task<List<ReportPos>> LoadGroupReportPosesAsync(DateTime start, DateTime end,
            int firmId = 0, long mailType = 9999,
            long mailCategory = 9999, TransCategory transCategory = TransCategory.ВСЕ)
        {
            return await Task.Run(() => LoadGroupReportPoses(start, end, firmId, mailType, mailCategory, transCategory));
        }

        /// <summary>
        /// Отчет по позициям
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="firmId">Id организации</param>
        /// <param name="mailType">Тип отправления</param>
        /// <param name="mailCategory">Категория отправления</param>
        /// <param name="transType">Тип пересылки</param>
        /// <param name="transCategory">Класс отправления</param>
        /// <returns>Список позиций</returns>
        public static List<ReportPos> LoadReportPoses(DateTime start, DateTime end, int firmId = 0, long mailType = 9999, 
            long mailCategory = 9999, TransType transType = TransType.ВСЕ, TransCategory transCategory = TransCategory.ВСЕ)
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                var q = db.ReportPoses.AsQueryable();

                if (firmId > 0)
                    q = q.Where(r => r.FirmId == firmId);

                if (mailType != 9999)
                    q = q.Where(r => r.MailType == mailType);

                if (mailCategory != 9999)
                    q = q.Where(r => r.MailCategory == mailCategory);

                if (transType != TransType.ВСЕ)
                    q = q.Where(r => r.TransType == transType);

                if (transCategory != TransCategory.ВСЕ)
                    q = q.Where(r => r.TransCategory == transCategory);


                q = q.Include(r => r.Firm).Where(r => r.Date >= start && r.Date <= end).OrderBy(p => p.Date).ThenBy(p => p.Firm.ShortName).ThenBy(p => p.TransCategory).ThenByDescending(p => p.MailCategory).ThenBy(p => p.MailType); ;

                return q.ToList();
            }
        }

        /// <summary>
        /// Отчет по позициям
        /// </summary>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        /// <param name="firmId">Id организации</param>
        /// <param name="mailType">Тип отправления</param>
        /// <param name="mailCategory">Категория отправления</param>
        /// <param name="transType">Тип пересылки</param>
        /// <param name="transCategory">Класс отправления</param>
        /// <returns>Список позиций</returns>
        public static async Task<List<ReportPos>> LoadReportPosesAsync(DateTime start, DateTime end, int firmId = 0, long mailType = 9999, 
            long mailCategory = 9999, TransType transType = TransType.ВСЕ, TransCategory transCategory = TransCategory.ВСЕ)
        {
            return await Task.Run(() => LoadReportPoses(start, end, firmId, mailType, mailCategory, transType, transCategory));
        }


        public static List<ReportPos> LoadDispathReportPoses(DateTime start, DateTime end, int firmId = 0)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("select Id, Date, FirmId, MailCategory, MailType, TransCategory, TransType, Sum(Count) as Count, Sum(Pay) as Pay, ReportId");
            sb.Append(" from ReportPoses");
            sb.Append($" where date >= '{start:yyyy-MM-dd}' and date <= '{end.AddDays(1):yyyy-MM-dd}'");

            if (firmId > 0)
                sb.Append($" and FirmId = {firmId} ");

            sb.Append(" group by MailCategory, MailType, TransCategory");

            using (WorldStatContext db = new WorldStatContext())
            {
                var q = db.ReportPoses.FromSql(sb.ToString());

                q = q.Include(r => r.Firm).OrderBy(p => p.Date);

                var data = q.ToList();

                return data;
            }
        }

        public static async Task<List<ReportPos>> LoadDispathReportPosesAsync(DateTime start, DateTime end, int firmId = 0)
        {
            return await Task.Run(() => LoadDispathReportPoses(start, end, firmId));
        }

        public static List<ReportPos> GetReportPosesByReportId(int reportId)
        {
            using (WorldStatContext db = new WorldStatContext())
            {
                return db.ReportPoses.Where(p => p.ReportId == reportId).ToList();
            }
        }

        public static async Task<List<ReportPos>> GetReportPosesByReportIdAsync(int reportId)
        {
            return await Task.Run(() => GetReportPosesByReportId(reportId));
        }
        #endregion
    }
}
