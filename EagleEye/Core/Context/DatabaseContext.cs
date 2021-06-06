using EagleEye.Core.Models.Postgres;
using EagleEye.Core.Models.Postgres.Bills;
using EagleEye.Core.Storage.FileStorage;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.UDF;

namespace EagleEye.Core.Context
{
    public class DatabaseContext : DbContext
    {
        /// <summary>Организации</summary>
        public DbSet<Firm> Firms { get; set; }
        /// <summary>Услуги</summary>
        public DbSet<Service> Services { get; set; }
        /// <summary>Основные счета</summary>
        public DbSet<MainBill> MainBills { get; set; }
        /// <summary>Счета на доп.услуги</summary>
        public DbSet<ServiceBill> ServiceBills { get; set; }
        /// <summary>Транзакции по основным счетам</summary>
        public DbSet<MainTransaction> MainTransactions { get; set; }
        /// <summary>Транзакции по доп.услугам</summary>
        public DbSet<ServiceTransaction> ServiceTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            PostgresConnect connect = PostgresConnect.Load();
            if(connect != null)
                optionsBuilder.UseNpgsql(connect.ToString());
        }
    }
}
