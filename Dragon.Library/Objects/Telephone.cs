using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
    class Telephone
    {
        private int _MobileNumber;
        private int _BusinessNumber;
        private int _fax;

        public string _FormatedNumber(int f)
        {
            return string.Format("({0}) {1}-{2}", f.ToSafeString().Substring(0, 3), f.ToSafeString().Substring(3, 3), f.ToSafeString().Substring(6, 4));
        }
    }
}
