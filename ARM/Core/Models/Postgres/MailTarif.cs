using ARM.Core.Types;

namespace ARM.Core.Models.Postgres
{
    /// <summary>Тариф на отправление</summary>
    public class MailTarif
    {
        public int Id { get; set; }
        /// <summary>Имя</summary>
        public string Name { get; set; }
        /// <summary>Стоимость</summary>
        public double Cost { get; set; }
        /// <summary>Начальный вес</summary>
        public int StartMass { get; set; }
        /// <summary>Конечный вес</summary>
        public int EndMass { get; set; }
        /// <summary>Тип отправления</summary>
        public int Type { get; set; }
        /// <summary>Категория</summary>
        public int Category { get; set; }
        /// <summary>Тип пересылки</summary>
        public TransType TransType { get; set; }
        /// <summary>Код категории по франку</summary>
        public int FrankCode { get; set; }
    }
}
