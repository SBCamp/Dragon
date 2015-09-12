using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
   public class Address
    {
        private string _Prefix;
        private string _StreetAddress1;
        private string _StreetAddress2;
        private string _PostalCode;
        private string _City;
        private string _Providence;
        private string _Country;
        private string _County;

        public string[] SendMail()
        {
            return new string[2] { string.Format("{0} {1} {2}", _Prefix, _StreetAddress1, _StreetAddress2) , string.Format("{0} {1} {2} {3}", _City, _Providence, _Country, _PostalCode) };
        }
    }
}
