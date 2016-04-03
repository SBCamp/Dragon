using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
   public class Employee
    {
        Employee()
        {

        }

        private Guid _ID;
        public Guid ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private Name _Name;
        public Name Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private Progress Status;

        private Module[] DesignatedModule;
    }
}
