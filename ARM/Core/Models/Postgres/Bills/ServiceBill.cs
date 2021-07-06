using System.Collections.Generic;

namespace ARM.Core.Models.Postgres.Bills
{
    /// <summary>Счет по доп.услугам</summary>
    public class ServiceBill
    {
        public int Id { get; set; }

        /// <summary>Баланс</summary>
        public double Balance { get; set; }

        /// <summary>Привязка к организации</summary>
        public int FirmId { get; set; }
        public Firm Firm { get; set; }

        /// <summary>Список транзакций</summary>
        public List<ServiceTransaction> Transactions { get; set; }
    }
}
