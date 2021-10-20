using System;
using System.Text.RegularExpressions;

namespace Skyline.BeerViet.App
{
    public class CodeHelper
    {
        public static string ConvertToUnsign(string signString)
        {
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = signString.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static int ConvertToInt(object value, int defaultValue = 0)
        {
            if (value == null)
            {
                return defaultValue;
            }
            try
            {
                return int.Parse(value.ToString());
            }
            catch
            {
                return defaultValue;
            }
        }

        public static string ConvertToString(object value)
        {
            try
            {
                return value.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        public static bool ConvertToBool(object value, bool defaultValue = false)
        {
            if (value == null)
                return defaultValue;

            string strValue = value.ToString();
            if (strValue == "1" || strValue.ToUpper() == "TRUE")
            {
                return true;
            }
            return false;
        }
    }
}
