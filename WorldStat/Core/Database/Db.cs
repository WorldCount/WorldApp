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

                foreach (ReportPos reportPose in data)
                {
                    reportPose.Date = end;
                    reportPose.TransType = TransType.ВСЕ;
                }

                return data;
            }
        }

        public static async Task<List<ReportPos>> LoadGroupReportPosesAsync(DateTime start, DateTime end,
            int firmId = 0, long mailType = 9999,
            long mailCategory = 9999, TransCategory transCategory = TransCategory.ВСЕ)
        {
            return await Task.Run(() => LoadGroupReportPoses(start, end, firmId, mailType, mailCategory, transCategory));
        }

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

        public static async Task<List<ReportPos>> LoadReportPosesAsync(DateTime start, DateTime end, int firmId = 0, long mailType = 9999, 
            long mailCategory = 9999, TransType transType = TransType.ВСЕ, TransCategory transCategory = TransCategory.ВСЕ)
        {
            return await Task.Run(() => LoadReportPoses(start, end, firmId, mailType, mailCategory, transType, transCategory));
        }

        #endregion
    }
}
