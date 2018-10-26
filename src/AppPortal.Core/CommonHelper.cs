using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace AppPortal.Core
{
    public static partial class CommonHelper
    {
        public static class UltilityHelper
        {
            public static string[] Chars = new string[] { "-", "%", ",", ":", "”", "“", "\"",
            "[", "]",
            "(", ")",
            "?", ".", "`",
            "!", "\\", "'","+",
            "‘", "’",";", "…", "–" };

            public static int GenerateRandomInteger(int min = 0, int max = int.MaxValue)
            {
                var randomNumberBuffer = new byte[10];
                var rdn = RandomNumberGenerator.Create();
                rdn.GetBytes(randomNumberBuffer);
                return new Random(BitConverter.ToInt32(randomNumberBuffer, 0)).Next(min, max);
            }

            public static string unicodeToNoMark(string input)
            {
                input = input.ToLowerInvariant().Trim();
                if (input == null) return "";
                string noMark = "a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,a,e,e,e,e,e,e,e,e,e,e,e,e,u,u,u,u,u,u,u,u,u,u,u,u,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,o,i,i,i,i,i,i,y,y,y,y,y,y,d,A,A,E,U,O,O,D";
                string unicode = "a,á,à,ả,ã,ạ,â,ấ,ầ,ẩ,ẫ,ậ,ă,ắ,ằ,ẳ,ẵ,ặ,e,é,è,ẻ,ẽ,ẹ,ê,ế,ề,ể,ễ,ệ,u,ú,ù,ủ,ũ,ụ,ư,ứ,ừ,ử,ữ,ự,o,ó,ò,ỏ,õ,ọ,ơ,ớ,ờ,ở,ỡ,ợ,ô,ố,ồ,ổ,ỗ,ộ,i,í,ì,ỉ,ĩ,ị,y,ý,ỳ,ỷ,ỹ,ỵ,đ,Â,Ă,Ê,Ư,Ơ,Ô,Đ";
                string[] a_n = noMark.Split(',');
                string[] a_u = unicode.Split(',');
                for (int i = 0; i < a_n.Length; i++)
                {
                    input = input.Replace(a_u[i], a_n[i]);
                }
                input = input.Replace("  ", " ");
                input = Regex.Replace(input, "[^a-zA-Z0-9% ._]", string.Empty);
                input = removeSpecialChar(input);
                input = input.Replace(" ", "-");
                input = input.Replace("--", "-");
                return input;
            }

            private static string removeSpecialChar(string input)
            {
                input = input.Replace("-", "").Replace(":", "").Replace(",", "").Replace("_", "").Replace("'", "").Replace("\"", "").Replace(";", "").Replace("”", "").Replace(".", "").Replace("%", "");
                return input;
            }

            public static string FillterChar(string str)
            {
                str = ConvertToUnUnicode(str);
                str = Regex.Replace(str, @"[^0-9a-zA-Z]+", "-");
                str = str.Replace(" ", "-");
                str = str.Replace("--", "-");
                str = str.Replace("?", "-");
                str = str.Replace("&", "-");
                str = str.Replace(",", "-");
                str = str.Replace(":", "-");
                str = str.Replace("!", "-");
                str = str.Replace("'", "-");
                str = str.Replace("\"", "-");
                str = str.Replace("%", "-");
                str = str.Replace("#", "-");
                str = str.Replace("$", "-");
                str = str.Replace("*", "-");
                str = str.Replace("`", "-");
                str = str.Replace("~", "-");
                str = str.Replace("@", "-");
                str = str.Replace("^", "-");
                str = str.Replace(".", "-");
                str = str.Replace("/", "-");
                str = str.Replace(">", "-");
                str = str.Replace("<", "-");
                str = str.Replace("[", "-");
                str = str.Replace("]", "-");
                str = str.Replace(";", "-");
                str = str.Replace("+", "-");
                str = str.Replace("(", "-");
                str = str.Replace(")", "-");
                str = str.Replace("\"", "-");
                while (str.Contains("--"))
                    str = str.Replace("--", "-");
                while (str.Contains("__"))
                    str = str.Replace("__", "_");
                return str.ToLower();
            }

            public static string ConvertToUnUnicode(string str)
            {
                if (string.IsNullOrEmpty(str)) return string.Empty;
                str = str.Trim();
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = str.Normalize(NormalizationForm.FormD);
                return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            }

            public static bool StrContentToFile(string content, string pathPhisycal, string fileName)
            {
                try
                {
                    pathPhisycal = Path.Combine(pathPhisycal, fileName);
                    File.WriteAllText(pathPhisycal, content);
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }
    }
}
