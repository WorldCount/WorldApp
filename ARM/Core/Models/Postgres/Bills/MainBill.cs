using System.Collections.Generic;

namespace ARM.Core.Models.Postgres.Bills
{
    /// <summary>Основной счет</summary>
    public class MainBill
    {
        public int Id { get; set; }
        /// <summary>Баланс</summary>
        public double Balance { get; set; }

        /// <summary>Привязка к организации</summary>
        public int FirmId { get; set; }
        public Firm Firm { get; set; }

        /// <summary>Список транзакций</summary>
        public List<MainTransaction> Transactions { get; set; }
    }
}
