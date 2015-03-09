using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace Utilities
{
    public class ConvertToTitleCase
    {
        public static string ConvertToTitleCase(this string input)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            String output = input.ToLower();
            return textInfo.ToTitleCase(output);
        }
    }
}