using DiffPather.Core.Database.Models;
using DiffPather.Core.Storage;
using Microsoft.EntityFrameworkCore;

namespace DiffPather.Core.Database.Contexts
{
    public class DiffPatherContext : DbContext
    {
        public string DbPath { get; } = PathManager.DatabasePath;

        public DbSet<AppInfo> AppInfos { get; set; }
        public DbSet<AppVersion> AppVersions { get; set; }
        public DbSet<AppFile> Files { get; set; }
        public DbSet<AppDescription> Descriptions { get; set; }

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
        }
    }
}
