﻿using Microsoft.EntityFrameworkCore;
using WorldStat.Core.Database.Models;
using WorldStat.Core.Storage;

namespace WorldStat.Core.Database.Contexts
{
    public class WorldStatContext : DbContext
    {
        public string DbPath { get;} = PathManager.DatabasePath;

        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportPos> ReportPoses { get; set; }
        public DbSet<MailCode> MailCodes { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Calendar> Calendars { get; set; }


        public DbSet<MailType> MailTypes { get; set; }
        public DbSet<MailCategory> MailCategories { get; set; }
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MailCode>().HasIndex(m => m.Code);
            modelBuilder.Entity<Firm>().HasIndex(f => f.Code);
            modelBuilder.Entity<Report>().HasIndex(r => r.Date);
            modelBuilder.Entity<Calendar>().HasIndex(c => c.Date);
            modelBuilder.Entity<MailType>().HasIndex(t => t.Code);
            modelBuilder.Entity<MailCategory>().HasIndex(c => c.Code);
            modelBuilder.Entity<Notice>().HasIndex(n => n.Code);
        }
    }
}
