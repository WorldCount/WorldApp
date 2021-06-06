namespace EagleEye.Core.Models.Postgres
{
    /// <summary>Услуги</summary>
    public class Service
    {
        public int Id { get; set; }
        /// <summary>Код номенклатуры</summary>
        public int Code { get; set; }
        /// <summary>Название услуги</summary>
        public string Name { get; set; }
        /// <summary>Описание услуги</summary>
        public string Description { get; set; }
        /// <summary>Стоимость услуги</summary>
        public double Cost { get; set; }
        /// <summary>Стоимость услуги с НДС</summary>
        public double CostNds { get; set; }
        /// <summary>Ручной рассчет</summary>
        public bool Manual { get; set; }
    }
}
