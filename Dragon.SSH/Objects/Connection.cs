using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.SSH.Objects
{
    class ConnectionCollection
    {
        List<Connection> ListConnection = new List<Connection>();
       void Connection()
        {
           //Load other connections
        }
    }

    class Connection
    {
        string Alias;
        string Address;
        int port;
        string username;
        string Password;

    }
}
