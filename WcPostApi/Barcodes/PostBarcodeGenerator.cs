using System;
using System.Collections.Generic;
using System.Text;

namespace WcPostApi.Barcodes
{
    public static class PostBarcodeGenerator
    {
        
        /// <summary>Генерирует ШПИ с верным контрольным разрядом для внутреннего отправления</summary>
        /// <param name="barcode">Объект ШПИ</param>
        /// <returns>Валидный ШПИ: string</returns>
        internal static string GetInternalBarcode(PostBarcode barcode)
        {
            return GetInternalBarcode(barcode.Ops, barcode.Month, barcode.Num);
        }

        /// <summary>Генерирует ШПИ с верным контрольным разрядом для внутреннего отправления</summary>
        /// <param name="ops">Номер ОПС</param>
        /// <param name="month">Номер месяца</param>
        /// <param name="num">Номер отправления</param>
        /// <returns>Валидный ШПИ: string</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        internal static string GetInternalBarcode(int ops, int month, int num)
        {

            if (ops > 999999 || ops < 100000) throw new ArgumentException($"Номер ОПС должен быть в диапазоне от 100000 до 999999", nameof(ops));
            if (month > 99 || month <= 0) throw new ArgumentException($"Номер месяца должен быть в диапазоне от 1 до 99", nameof(month));
            if (num > 99999 || num <= 0) throw new ArgumentException($"Номер ШПИ должен быть в диапазоне от 1 до 99999", nameof(num));

            string b = $"{ops}{month.ToString().PadLeft(2, '0')}{num.ToString().PadLeft(5, '0')}";

            // Сумма четных
            int even = 0;
            // Сумма нечетных
            int odd = 0;

            for (int i = 0; i < 13; i++)
            {
                try
                {
                    if (i % 2 == 0)
                        even += int.Parse(b[i].ToString());
                    else
                        odd += int.Parse(b[i].ToString());
                }
                catch { throw; }
            }

            int sum = (even * 3) + odd;
            int numControlRank = 10 - (sum % 10);
            string controlRank = numControlRank == 10 ? "0" : numControlRank.ToString();

            return $"{b.Substring(0, 13)}{controlRank}";
        }

        /// <summary>Генерирует ШПИ с верным контрольным разрядом для внешнего отправления</summary>
        /// <param name="barcode">Объект ШПИ</param>
        /// <returns>Валидный ШПИ: string</returns>
        internal static string GetExternalBarcode(PostBarcode barcode)
        {
            return GetExternalBarcode(barcode.Code, barcode.Land, barcode.Num);
        }

        /// <summary>Генерирует ШПИ с верным контрольным разрядом для внешнего отправления</summary>
        /// <param name="code">Код отправления</param>
        /// <param name="land">Код страны отправления</param>
        /// <param name="num">Номер отправления</param>
        /// <returns>Валидный ШПИ: string</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        internal static string GetExternalBarcode(string code, string land, int num)
        {
            if (string.IsNullOrEmpty(code)) throw new ArgumentNullException(nameof(code), "Код отправления не должен быть пустым");
            if (string.IsNullOrEmpty(land)) throw new ArgumentNullException(nameof(land), "Страна отправления не должена быть пустой");
            if (num > 99999999 || num <= 0) throw new ArgumentException($"Номер ШПИ должен быть в диапазоне от 1 до 99999999", nameof(num));

            // Сумма элементов
            int sum = 0;

            string b = $"{num.ToString().PadLeft(8, '0')}";

            for (int i = 0; i < 8; i++)
            {
                try
                {
                    sum += (int.Parse(b[i].ToString()) * Const.Multipliers[i]);
                }
                catch { throw; }
            }

            int numControlRank = 11 - (sum % 11);
            string controlRank;

            if (numControlRank == 10)
                controlRank = "0";
            else if (numControlRank == 11)
                controlRank = "5";
            else
                controlRank = numControlRank.ToString();

            return $"{code}{b}{controlRank}{land}".ToUpper();
        }

        /// <summary>Создает объект ШПИ из строки</summary>
        /// <param name="barcodeString">Строка со ШПИ</param>
        /// <returns>Объект ШПИ: PostBarcode</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static PostBarcode GenBarcode(string barcodeString)
        {
            return new PostBarcode(barcodeString);
        }

        /// <summary>Создает объект ШПИ для внутреннего отправления</summary>
        /// <param name="ops">Номер отделения</param>
        /// <param name="month">Номер месяца</param>
        /// <param name="num">Номер отправления</param>
        /// <returns>Объект ШПИ: PostBarcode</returns>
        public static PostBarcode GenInternalBarcode(int ops, int month, int num)
        {
            return new PostBarcode(GetInternalBarcode(ops, month, num));
        }

        /// <summary>Создает объект ШПИ для внешнего отправления</summary>
        /// <param name="code">Код отправления</param>
        /// <param name="land">Код страны отправления</param>
        /// <param name="num">Номер отправления</param>
        /// <returns>Объект ШПИ: PostBarcode</returns>
        public static PostBarcode GenExternalBarcode(string code, string land, int num)
        {
            return new PostBarcode(GetExternalBarcode(code, land, num));
        }

        /// <summary>Возвращает контрольный разряд отправления</summary>
        /// <param name="barcodeString">Строка со ШПИ</param>
        /// <returns>Контрольный разряд: char?</returns>
        public static char? GenControlRank(string barcodeString)
        {
            return GenControlRank(new PostBarcode(barcodeString));
        }

        /// <summary>Возвращает контрольный разряд отправления</summary>
        /// <param name="barcode">Объект ШПИ</param>
        /// <returns>Контрольный разряд: char?</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static char? GenControlRank(PostBarcode barcode)
        {
            if (barcode.IsExternal())
                return barcode.ToString()[10];

            if (barcode.IsInteral())
                return barcode.ToString()[13];

            return null;
        }

        /// <summary>Проверяет строку со ШПИ на валидность</summary>
        /// <param name="barcodeString">Строка со ШПИ</param>
        /// <returns>Валидный ШПИ: bool</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static bool IsValid(string barcodeString)
        {
            PostBarcode b = GenBarcode(barcodeString);
            if (b.ToString() == barcodeString)
                return true;
            return false;
        }

        /// <summary>Генерирует опредленное количество объектов ШПИ начиная с определенного</summary>
        /// <param name="barcode">Объект ШПИ</param>
        /// <param name="count">Количество отправлений для генерации</param>
        /// <returns>Список объектов ШПИ: "List&lt;PostBarcode&gt;</returns>
        public static List<PostBarcode> GenBarcodes(PostBarcode barcode, int count)
        {
            return GenBarcodes(barcode.Ops, barcode.Month, barcode.Num, count);
        }

        /// <summary>Генерирует опредленное количество объектов ШПИ</summary>
        /// <param name="ops">Номер отделения</param>
        /// <param name="month">Номер месяца</param>
        /// <param name="num">Номер отправления</param>
        /// <param name="count">Количество отправлений для генерации</param>
        /// <returns>Список объектов ШПИ: "List&lt;PostBarcode&gt;</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static List<PostBarcode> GenBarcodes(int ops, int month, int num, int count)
        {
            List<PostBarcode> barcodes = new List<PostBarcode>();
            foreach (string b in GenBarcodesString(ops, month, num, count))
                barcodes.Add(new PostBarcode(b));

            return barcodes;
        }

        /// <summary>Генерирует опредленное количество объектов ШПИ начиная с определенного</summary>
        /// <param name="barcode">Объект ШПИ</param>
        /// <param name="count">Количество отправлений для генерации</param>
        /// <returns>Список объектов ШПИ: "List&lt;string&gt;</returns>
        public static List<string> GenBarcodesString(PostBarcode barcode, int count)
        {
            return GenBarcodesString(barcode.Ops, barcode.Month, barcode.Num, count);
        }

        /// <summary>Генерирует опредленное количество объектов ШПИ</summary>
        /// <param name="ops">Номер отделения</param>
        /// <param name="month">Номер месяца</param>
        /// <param name="num">Номер отправления</param>
        /// <param name="count">Количество отправлений для генерации</param>
        /// <returns>Список объектов ШПИ: "List&lt;string&gt;</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static List<string> GenBarcodesString(int ops, int month, int num, int count)
        {
            if (ops > 999999 || ops < 100000) throw new ArgumentException($"Номер ОПС должен быть в диапазоне от 100000 до 999999", nameof(ops));
            if (month > 99 || month <= 0) throw new ArgumentException($"Номер месяца должен быть в диапазоне от 1 до 99", nameof(month));
            if (num > 99999 || num <= 0) throw new ArgumentException($"Номер ШПИ должен быть в диапазоне от 1 до 99999", nameof(num));

            List<string> barcodes = new List<string>();

            for (int i = 0; i < count; i++)
            {

                if (num > 99999)
                {
                    num = 1;
                    month += 1;
                }

                if (month > 99)
                    month = 1;

                string b = GetInternalBarcode(ops, month, num);

                if (!string.IsNullOrEmpty(b))
                    barcodes.Add(b);

                num++;
            }

            return barcodes;
        }

        /// <summary>Генерирует объекты валидных ШПИ по маске</summary>
        /// <param name="rawBarcode">Строка с маской ШПИ</param>
        /// <param name="unknownChar">Неизвестный символ в ШПИ</param>
        /// <returns>Список вылидных объектов ШПИ: "List&lt;PostBarcode&gt;</returns>
        public static List<PostBarcode> GenValidBarcodes(object rawBarcode, char unknownChar = '*')
        {
            List<PostBarcode> barcodes = new List<PostBarcode>();

            foreach (string b in GenValidBarcodesString(rawBarcode, unknownChar))
                barcodes.Add(new PostBarcode(b));

            return barcodes;
        }

        /// <summary>Генерирует объекты валидных ШПИ по маске</summary>
        /// <param name="rawBarcode">Строка с маской ШПИ</param>
        /// <param name="unknownChar">Неизвестный символ в ШПИ</param>
        /// <returns>Список вылидных ШПИ: "List&lt;string&gt;</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static List<string> GenValidBarcodesString(object rawBarcode, char unknownChar = '*')
        {
            List<string> r = new List<string>();
            List<string> barcodes = new List<string>();
            int num = 0;

            if (rawBarcode is string s)
                barcodes.Add(s);
            else
                barcodes = (List<string>)rawBarcode;

            for (var i = barcodes.Count - 1; i >= 0; i--)
            {
                int index = barcodes[i].IndexOf(unknownChar);
                if (index == -1)
                    r.Add(barcodes[i]);
                else
                {
                    num++;

                    StringBuilder sb = new StringBuilder(barcodes[i]);
                    for (var n = 0; n <= 9; n++)
                    {
                        sb[index] = Char.Parse(n.ToString());
                        r.Add(sb.ToString());
                    }
                }
            }

            if (num == 0)
                return CheckBarcodesString(r);
            return GenValidBarcodesString(r);
        }

        /// <summary>Возвращает список валидных объектов ШПИ</summary>
        /// <param name="barcodes">Список ШПИ</param>
        /// <returns>Список вылидных объектов ШПИ: "List&lt;Barcode&gt;</returns>
        public static List<PostBarcode> CheckBarcodes(List<string> barcodes)
        {
            List<PostBarcode> barcodeList = new List<PostBarcode>();

            foreach (string b in CheckBarcodesString(barcodes))
                barcodeList.Add(new PostBarcode(b));

            return barcodeList;
        }

        /// <summary>Возвращает список валидных ШПИ</summary>
        /// <param name="barcodes">Список ШПИ</param>
        /// <returns>Список вылидных ШПИ: "List&lt;string&gt;</returns>
        // ReSharper disable once MemberCanBePrivate.Global
        public static List<string> CheckBarcodesString(List<string> barcodes)
        {
            List<string> r = new List<string>();
            for (var i = barcodes.Count - 1; i >= 0; i--)
            {
                if (barcodes[i][0] != '0' && IsValid(barcodes[i]))
                    r.Add(barcodes[i]);
            }

            return r;
        }
    }
}
