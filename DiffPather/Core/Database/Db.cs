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
            using (DatabaseContext db = new DatabaseContext())
                return db.Database.EnsureDeleted();
        }

        /// <summary>Удаление БД</summary>
        public static async Task<bool> DeleteDbAsync()
        {
            using (DatabaseContext db = new DatabaseContext())
                return await db.Database.EnsureDeletedAsync();
        }

        /// <summary>Создание БД</summary>
        public static bool CreateDb()
        {
            using (DatabaseContext db = new DatabaseContext())
                return db.Database.EnsureCreated();
        }

        /// <summary>Создание БД</summary>
        public static async Task<bool> CreateDbAsync()
        {
            using (DatabaseContext db = new DatabaseContext())
                return await db.Database.EnsureCreatedAsync();
        }

        #endregion

        #region Apps

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Список всех приложений</summary>
        public static List<AppInfo> GetAppInfos()
        {
            using (DatabaseContext db = new DatabaseContext())
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
                using (DatabaseContext db = new DatabaseContext())
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

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Удаление приложения</summary>
        public static void DeleteAppInfo(AppInfo appInfo)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                db.Remove(appInfo);
                db.SaveChanges();
            }
        }

        /// <summary>Удаление приложения</summary>
        public static async Task DeleteAppInfoAsync(AppInfo appInfo)
        {
            await Task.Run(() => DeleteAppInfo(appInfo));
        }
        #endregion

    }
}
