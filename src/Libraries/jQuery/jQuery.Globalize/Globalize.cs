using System;
using System.Collections;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace jQueryApi.Globalize
{

    /// <summary>
    /// Provides access to jQuery history and back button management APIs.
    /// </summary>
    [IgnoreNamespace]
    [Imported]
    public static class Globalize
    {
        public static void Culture(string selector)
        { 
        }

        public static void Culture(string[] selector)
        { 
        }

        public static string FindClosestCulture(string selector)
        {
            return null;
        }

        public static string FindClosestCulture(string[] selector)
        {
            return null;
        }

        public static string Format(Number value)
        {
            return null;
        }

        public static string Format(Number value, string format){
            return null;
        }

        public static string Format(Number value, string format, string culture)
        {
            return null;
        }

        public static string Format(Date value)
        {
            return null;
        }

        public static string Format(Date value, string format)
        {
            return null;
        }

        public static string Format(Date value, string format, string culture)
        {
            return null;
        }

        public static int ParseInt(string value)
        {
            return 0;
        }

        public static int ParseInt(string value, int radix){
            return 0;
        }

        public static int ParseInt(string value, int radix, string culture)
        {
            return 0;
        }

        public static float ParseFloat(string value)
        {
            return 0;
        }

        public static float ParseFloat(string value, int radix)
        {
            return 0;
        }

        public static float ParseFloat(string value, int radix, string culture)
        {
            return 0;
        }

        public static Date ParseDate(string value)
        {
            return Date.Now;
        }

        public static Date ParseDate(string value, string[] formats)
        {
            return Date.Now;
        }

        public static Date ParseDate(string value, string[] formats, string culture)
        {
            return Date.Now;
        }

        public static void AddCultureInfo(Dictionary info)
        { }

        public static void AddCultureInfo(string culture, Dictionary info)
        { }

        public static void AddCultureInfo(string cutulre, string extendedCultureName, Dictionary info)
        { }
    }
}
