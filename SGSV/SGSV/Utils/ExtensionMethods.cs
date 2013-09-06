using System.Text.RegularExpressions;

namespace SGSV.Utils
{
    public static class ExtensionMethods
    {
        public static bool EsEmail(this string texto)
        {
            const string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            return Regex.IsMatch(texto, pattern);
        }
    }
}
