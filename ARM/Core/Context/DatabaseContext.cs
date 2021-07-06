using ARM.Core.Models.Postgres;
using ARM.Core.Models.Postgres.Bills;
using ARM.Core.Storage.FileStorage;
using Microsoft.EntityFrameworkCore;

namespace ARM.Core.Context
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
