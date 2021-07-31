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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}