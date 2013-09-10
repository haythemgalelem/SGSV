using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SGSV.Utils
{
    public static class ExtensionMethods
    {
        #region string

        public static bool EsEmail(this string texto)
        {
            const string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            return Regex.IsMatch(texto, pattern);
        }

        #endregion string

        #region TextBox

        public static void Limpiar(this TextBox txtBox)
        {
            txtBox.Text = string.Empty;
        }

        #endregion TextBox
    }
}
