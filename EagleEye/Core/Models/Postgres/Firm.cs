using System;

namespace EagleEye.Core.Models.Postgres
{
    /// <summary>Основная организация</summary>
    public class Firm
    {
        public int Id { get; set; }
        /// <summary>ID организации по франку</summary>
        public string FrankId { get; set; }
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
    }
}
