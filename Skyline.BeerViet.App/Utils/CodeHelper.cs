namespace Skyline.BeerViet.App
{
    public class CodeHelper
    {
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
