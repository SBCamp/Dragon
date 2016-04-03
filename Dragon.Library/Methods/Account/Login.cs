using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Methods.Account
{
    public class Login
    {
        public static void CheckLogin(string Username, string Password)
        {
            new Entities.CustomerCollection();
            if(Username.ToSafeString() == "steve" && Password == "") {
                Entities.CustomerCollection.CUS[0].User.LoggedIn = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
