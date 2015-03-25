using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace Utilities
{
    public static class Formatting
    {
        /// <summary>
        /// Takes a string input and converts it to TitleCase. Extension method of string class
        /// </summary>
        /// <param name="input">String parameter</param>
        /// <returns>Formatted string</returns>
        public static string ConvertToTitleCase(this string input) //
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            String output = input.ToLower(); //String cannot be converted if all uppercase, therefore ToLower is used
            return textInfo.ToTitleCase(output);
        }
    }
}