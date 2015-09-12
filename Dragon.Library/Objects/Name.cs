using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
    public class Name
    {
        string First;
        string Surname;
        string Middle;

        public string FullName()
        {
            return string.Format("{0} {1} {2}", First, Middle, Surname);
        }
    }
}
