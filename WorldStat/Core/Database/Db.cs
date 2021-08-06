using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public static List<ReportPos> LoadReportPoses(DateTime start, DateTime end, int firmId = 0, long mailType = 9999, long mailCategory = 9999)
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

                return q.Include(r => r.Firm).Where(r => r.Date >= start && r.Date <= end).OrderBy(p => p.Date).ToList();
            }
        }

        public static async Task<List<ReportPos>> LoadReportPosesAsync(DateTime start, DateTime end, int firmId = 0, long mailType = 9999, long mailCategory = 9999)
        {
            return await Task.Run(() => LoadReportPoses(start, end, firmId, mailType, mailCategory));
        }

        #endregion
    }
}
