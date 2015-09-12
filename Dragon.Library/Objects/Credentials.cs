using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
    class Credentials
    {
        public static string userName;
        public static string passWord;
        public static bool signedIn()
        {
            if (userName.IsNullOrWhiteSpace())
                return false;
            if (passWord.IsNullOrWhiteSpace())
                return false;

            //Need Logic here for the Login from Mongo
            return true;
        }
    }
}
