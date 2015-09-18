using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Dragon.Library.Methods
{
   public static class Sanitization
    {
       public static bool cleanEmail(string s)
        {   //Could also use the Mailing Class system
            return Regex.IsMatch(s, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

       public static bool cleanPassword(string s)
        {   //Check for UTF-8, But all strings in .NET should be UTF-16
            return Regex.IsMatch(s, @"^(\w[6])+{\w[16]$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

       public static bool cleanUsername(string s)
       {
           return Regex.IsMatch(s, @"^(\w[24])$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
       }

    }
}
