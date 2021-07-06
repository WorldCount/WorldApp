using System;
using ARM.Core.Types;

namespace ARM.Core.Models.Postgres.Bills
{
    /// <summary>Транзакции по основному счету</summary>
    public class MainTransaction
    {
        public int Id { get; set; }

        /// <summary>Дата транзакции</summary>
        public DateTime Date { get; set; }

        /// <summary>Сумма транзакции</summary>
        public double Ammount { get; set; }
        /// <summary>Тип транзакции - приход/расход</summary>
        public TransactionType Type { get; set; }
        /// <summary>Описание транзации</summary>
        public string Description { get; set; }
        /// <summary>Транзакция закрыта</summary>
        public bool IsClose { get; set; }

        /// <summary>Счет транзакции</summary>
        public int BillId { get; set; }
        public MainBill Bill { get; set; }
    }
}
