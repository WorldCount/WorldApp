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
    }
}
