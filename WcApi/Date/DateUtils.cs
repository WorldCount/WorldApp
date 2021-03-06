using System;

namespace WcApi.Date
{
    public static class DateUtils
    {
        public static DateTime CropTime(DateTime date, int hour = 0, int minute = 0, int second = 0)
        {
            return new DateTime(date.Year, date.Month, date.Day, hour, minute, second);
        }

        public static DateTime CropDate(DateTime date, int year = 0, int month = 0, int day = 0, int hour = 0, int minute = 0, int second = 0)
        {
            int newYear = year == 0 ? date.Year : year;
            int newMonth = month == 0 ? date.Month : month;
            int newDay = day == 0 ? date.Day : day;

            return new DateTime(newYear, newMonth, newDay, hour, minute, second);
        }

        public static string GetMonthName(DateTime date, bool toUpper = true)
        {
            string[] months = { "ЯНВАРЬ", "ФЕВРАЛЬ", "МАРТ", "АПРЕЛЬ", "МАЙ", "ИЮНЬ", "ИЮЛЬ", "АВГУСТ", "СЕНТЯБРЬ", "ОКТЯБРЬ", "НОЯБРЬ", "ДЕКАБРЬ" };
            return toUpper ? months[date.Month - 1] : months[date.Month - 1].ToLower();
        }

        public static string GetDayName(DateTime date, bool toUpper = false)
        {
            string name = date.ToString("ddd");
            return toUpper ? name.ToUpper() : name;
        }
    }
}
