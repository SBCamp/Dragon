using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
   public class UserProfile
    {
        private string _Username;
        private string _HashedPassword;
        private string _UserId;
        private bool _LoggedIn;
        public bool LoggedIn
        {
            get { return _LoggedIn;  }
            set { _LoggedIn = value; }
        }
    }
}
