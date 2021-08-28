using System.Threading.Tasks;
using DiffPather.Core.Database.Contexts;

namespace DiffPather.Core.Database
{
    public static class Db
    {

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
    }
}
