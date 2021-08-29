using DiffPather.Core.Database.Models.Repository;
using DiffPather.Core.Storage;
using Microsoft.EntityFrameworkCore;

namespace DiffPather.Core.Database.Contexts
{
    public class RepositoryContext : DbContext
    {
        public string DbPath { get; } = PathManager.RepoDatabasePath;

        public DbSet<RepoAppInfo> AppInfos { get; set; }
        public DbSet<RepoAppVersion> AppVersions { get; set; }
        public DbSet<RepoAppFile> Files { get; set; }
        public DbSet<RepoAppDescription> Descriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RepoAppInfo>().HasIndex(i => i.CurrentVersion);
            modelBuilder.Entity<RepoAppInfo>().HasIndex(i => i.Name);
            modelBuilder.Entity<RepoAppVersion>().HasIndex(v => v.Version);
            modelBuilder.Entity<RepoAppFile>().HasIndex(f => f.Name);
        }
    }
}
