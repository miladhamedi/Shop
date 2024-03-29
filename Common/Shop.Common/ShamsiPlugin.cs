﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Shop.Common
{
    public static class ShamsiPlugin
    {

        private static CultureInfo culture;
        public static CultureInfo GetPersianCulture()
        {
            if (culture == null)
            {
                culture = new CultureInfo("fa-IR");
                DateTimeFormatInfo formatInfo = culture.DateTimeFormat;
                formatInfo.AbbreviatedDayNames = new[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
                formatInfo.DayNames = new[] { "یکشنبه", "دوشنبه", "سه شنبه", "چهار شنبه", "پنجشنبه", "جمعه", "شنبه" };
                var monthNames = new[]
                {
                    "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن",
                    "اسفند",
                    ""
             };
                formatInfo.AbbreviatedMonthNames =
                    formatInfo.MonthNames =
                    formatInfo.MonthGenitiveNames = formatInfo.AbbreviatedMonthGenitiveNames = monthNames;
                formatInfo.AMDesignator = "ق.ظ";
                formatInfo.PMDesignator = "ب.ظ";
                formatInfo.ShortDatePattern = "yyyy/MM/dd";
                formatInfo.LongDatePattern = "dddd, dd MMMM,yyyy";
                formatInfo.FirstDayOfWeek = DayOfWeek.Saturday;
                System.Globalization.Calendar cal = new PersianCalendar();

                FieldInfo fieldInfo = culture.GetType().GetField("calendar", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                    fieldInfo.SetValue(culture, cal);

                FieldInfo info = formatInfo.GetType().GetField("calendar", BindingFlags.NonPublic | BindingFlags.Instance);
                if (info != null)
                    info.SetValue(formatInfo, cal);

                culture.NumberFormat.NumberDecimalSeparator = "/";
                //_Culture.NumberFormat.CurrencyDecimalDigits = DigitShapes.NativeNational;
                culture.NumberFormat.NumberNegativePattern = 0;
            }
            return culture;


        }


        public static string ToPeString(this DateTime date, string format = "yyyy/MM/dd")
        {
            return date.ToString(format, GetPersianCulture());
        }

    }

}

