namespace WcPostApi.Barcodes.Interfaces
{
    public interface IPostBarcode
    {
        /// <summary>Тип ШПИ</summary>
        PostBarcodeType Type { get; set; }

        // Внутренний ШПИ
        /// <summary>Номер отделения связи</summary>
        int Ops { get; set; }
        /// <summary>Месяц ШПИ</summary>
        int Month { get; set; }
        /// <summary>Номер ШПИ</summary>
        int Num { get; set; }

        // Внешний ШПИ
        /// <summary>Код отправления для МЖД ШПИ</summary>
        string Code { get; set; }
        /// <summary>Страна отправления для МЖД ШПИ</summary>
        string Land { get; set; }

        /// <summary>
        /// Проверка типа отправления Внутреннее\Внешнее
        /// </summary>
        /// <param name="barcodeString">Строка с номером ШПИ</param>
        PostBarcodeType CheckType(string barcodeString);

        /// <summary>
        /// Парсинг строки со ШПИ
        /// </summary>
        /// <param name="barcodeString">Строка с номером ШПИ</param>
        /// <returns>Парсинг выполнен: bool</returns>
        bool Parse(string barcodeString);

        /// <summary>
        /// Уменьшает номер отправления на указанное число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Уменьшение выполнено: bool</returns>
        bool DecrementNum(int num);

        /// <summary>
        /// Увеличивает номер отправления на указанное число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Увеличение выполнено: bool</returns>
        bool IncrementNum(int num);

        /// <summary>
        /// Уменьшает номер месяца на указанное число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Уменьшение выполнено: bool</returns>
        bool DecrementMonth(int num);

        /// <summary>
        /// Увеличивает номер месяца на указанное число
        /// </summary>
        /// <param name="num">Число</param>
        /// <returns>Увеличение выполнено: bool</returns>
        bool IncrementMonth(int num);

        /// <summary>
        /// Это внешнее отправление
        /// </summary>
        /// <returns>bool</returns>
        bool IsExternal();

        /// <summary>
        /// Это внутреннее отправление
        /// </summary>
        /// <returns>bool</returns>
        bool IsInteral();

        /// <summary>
        /// Это неопределенное отправление
        /// </summary>
        /// <returns>bool</returns>
        bool IsUnknown();

        /// <summary>
        /// Возвращает ШПИ с контрольным разрядом
        /// </summary>
        /// <returns>ШПИ полностью: string</returns>
        string ToString();
    }
}
