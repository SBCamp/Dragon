using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library
{
    public static class StringExtensions
    {
        public static string ToSafeString(this string s)
        {
            return String.IsNullOrWhiteSpace(s) ? string.Empty : s;
        }

        public static string ToSafeString(this int s)
        {
            var str = Convert.ToString(s);
            return String.IsNullOrWhiteSpace(str) ? string.Empty : str;
        }
    }
}
