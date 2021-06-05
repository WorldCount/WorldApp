
namespace EagleEye.Core.Parsers.FrankParsers.Models
{

    // Тип строки
    public enum FrankRowType
    {
        FirmName,
        AppendFirmName,
        Pay,
        Skip,
        Unknow
    }

    public class FrankRow
    {
        #region Public Properties

        // Код организации
        public string FirmCode { get; set; }
        // Название организации
        public string FirmName { get; set; }

        // Код вида отправления
        public int MailCode { get; set; }
        // Название вида отправления
        public string MailName { get; set; }

        // Сумма платы за франкировку
        public double PaySum { get; set; }
        // Количество отправлений
        public int Count { get; set; }

        // Тип строки
        public FrankRowType Type { get; set; }

        #endregion
    }
}
