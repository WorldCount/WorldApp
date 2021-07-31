
namespace WorldStat.Core.Parsers.Models
{
    public class FrankMail
    {
        #region Public Properties

        // Код вида отправления
        public int Code { get; set; }
        // Название вида отправления
        public string Name { get; set; }
        // Количество отправлений
        public int Count { get; set; }
        // Сумма платы отправлений
        public double PaySum { get; set; }

        #endregion
    }
}
