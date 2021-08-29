using DiffPather.Core.Database.Models;
using DiffPather.Core.Database.Models.Repository;
using DiffPather.Core.Storage;
using Microsoft.EntityFrameworkCore;

namespace DiffPather.Core.Database.Contexts
{
    public class DatabaseContext : DbContext
    {
        public string DbPath { get; } = PathManager.DatabasePath;

        #region Base Models

        public DbSet<AppInfo> AppInfos { get; set; }
        public DbSet<AppVersion> AppVersions { get; set; }
        public DbSet<AppFile> Files { get; set; }
        public DbSet<AppDescription> Descriptions { get; set; }

        #endregion


        #region Repository Models

        public DbSet<RepoAppInfo> RepoAppInfos { get; set; }
        public DbSet<RepoAppVersion> RepoAppVersions { get; set; }
        public DbSet<RepoAppFile> RepoFiles { get; set; }
        public DbSet<RepoAppDescription> RepoDescriptions { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppInfo>().HasIndex(i => i.CurrentVersion);
            modelBuilder.Entity<AppInfo>().HasIndex(i => i.Name);
            modelBuilder.Entity<AppVersion>().HasIndex(v => v.Version);
            modelBuilder.Entity<AppFile>().HasIndex(f => f.Name);

            modelBuilder.Entity<RepoAppInfo>().HasIndex(i => i.CurrentVersion);
            modelBuilder.Entity<RepoAppInfo>().HasIndex(i => i.Name);
            modelBuilder.Entity<RepoAppVersion>().HasIndex(v => v.Version);
            modelBuilder.Entity<RepoAppFile>().HasIndex(f => f.Name);
        }
    }
}
