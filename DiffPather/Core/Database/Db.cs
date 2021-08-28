using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiffPather.Core.Database.Contexts;
using DiffPather.Core.Database.Models;

namespace DiffPather.Core.Database
{
    public static class Db
    {

        #region Database

        /// <summary>Удаление БД</summary>
        public static bool DeleteDb()
        {
            using (DiffPatherContext db = new DiffPatherContext())
                return db.Database.EnsureDeleted();
        }

        /// <summary>Удаление БД</summary>
        public static async Task<bool> DeleteDbAsync()
        {
            using (DiffPatherContext db = new DiffPatherContext())
                return await db.Database.EnsureDeletedAsync();
        }

        /// <summary>Создание БД</summary>
        public static bool CreateDb()
        {
            using (DiffPatherContext db = new DiffPatherContext())
                return db.Database.EnsureCreated();
        }

        /// <summary>Создание БД</summary>
        public static async Task<bool> CreateDbAsync()
        {
            using (DiffPatherContext db = new DiffPatherContext())
                return await db.Database.EnsureCreatedAsync();
        }

        #endregion

        #region Apps

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Список всех приложений</summary>
        public static List<AppInfo> GetAppInfos()
        {
            using (DiffPatherContext db = new DiffPatherContext())
                return db.AppInfos.ToList();
        }

        /// <summary>Список всех приложений</summary>
        public static async Task<List<AppInfo>> GetAppInfosAsync()
        {
            return await Task.Run(GetAppInfos);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Обновляет данные о приложениях</summary>
        public static bool UpdateAppInfos(List<AppInfo> appInfos)
        {
            try
            {
                using (DiffPatherContext db = new DiffPatherContext())
                {
                    db.UpdateRange(appInfos);
                    db.SaveChanges();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>Обновляет данные о приложениях</summary>
        public static async Task<bool> UpdateAppInfosAsync(List<AppInfo> appInfos)
        {
            return await Task.Run(() => UpdateAppInfos(appInfos));
        }

        #endregion

    }
}
