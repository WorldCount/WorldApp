using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiffPather.Core.Database.Contexts;
using DiffPather.Core.Database.Models.Repository;

namespace DiffPather.Core.Database
{
    public static class DbRepository
    {
        #region Database

        /// <summary>Удаление БД</summary>
        public static bool DeleteDb()
        {
            using (RepositoryContext db = new RepositoryContext())
                return db.Database.EnsureDeleted();
        }

        /// <summary>Удаление БД</summary>
        public static async Task<bool> DeleteDbAsync()
        {
            using (RepositoryContext db = new RepositoryContext())
                return await db.Database.EnsureDeletedAsync();
        }

        /// <summary>Создание БД</summary>
        public static bool CreateDb()
        {
            using (RepositoryContext db = new RepositoryContext())
                return db.Database.EnsureCreated();
        }

        /// <summary>Создание БД</summary>
        public static async Task<bool> CreateDbAsync()
        {
            using (RepositoryContext db = new RepositoryContext())
                return await db.Database.EnsureCreatedAsync();
        }

        #endregion

        #region Apps

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Список всех приложений</summary>
        public static List<RepoAppInfo> GetAppInfos()
        {
            using (RepositoryContext db = new RepositoryContext())
                return db.AppInfos.ToList();
        }

        /// <summary>Список всех приложений</summary>
        public static async Task<List<RepoAppInfo>> GetAppInfosAsync()
        {
            return await Task.Run(GetAppInfos);
        }

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Обновляет данные о приложениях</summary>
        public static bool UpdateAppInfos(List<RepoAppInfo> appInfos)
        {
            try
            {
                using (RepositoryContext db = new RepositoryContext())
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
        public static async Task<bool> UpdateAppInfosAsync(List<RepoAppInfo> appInfos)
        {
            return await Task.Run(() => UpdateAppInfos(appInfos));
        }

        // ReSharper disable once MemberCanBePrivate.Global
        /// <summary>Удаление приложения</summary>
        public static void DeleteAppInfo(RepoAppInfo appInfo)
        {
            using (RepositoryContext db = new RepositoryContext())
            {
                db.Remove(appInfo);
                db.SaveChanges();
            }
        }

        /// <summary>Удаление приложения</summary>
        public static async Task DeleteAppInfoAsync(RepoAppInfo appInfo)
        {
            await Task.Run(() => DeleteAppInfo(appInfo));
        }
        #endregion
    }
}
