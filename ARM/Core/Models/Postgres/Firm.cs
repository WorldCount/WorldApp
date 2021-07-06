using System;
using ARM.Core.Models.Postgres.Bills;

namespace ARM.Core.Models.Postgres
{
    /// <summary>Основная организация</summary>
    public class Firm
    {
        public int Id { get; set; }
        /// <summary>ID организации по франку</summary>
        public string FrankId { get; set; }
        /// <summary>Название организации</summary>
        public string Name { get; set; }
        /// <summary>ИНН</summary>
        public string Inn { get; set; }
        /// <summary>КПП</summary>
        public string Kpp { get; set; }
        /// <summary>Номер договора</summary>
        public string DocNum { get; set; }
        /// <summary>Дата договора</summary>
        public DateTime DocDate { get; set; }
        /// <summary>Способ оплаты</summary>
        public int PayType { get; set; }
        /// <summary>Это новая организация</summary>
        public bool IsNew { get; set; }
        /// <summary>Выгружать данные</summary>
        public bool Unload { get; set; } = true;

        // Связи с балансами
        /// <summary>Основные услуги</summary>
        public MainBill BillMain { get; set; }
        /// <summary>Дополнительные услуги</summary>
        public ServiceBill BillService { get; set; }
    }
}
