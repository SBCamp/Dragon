using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
    class Module
    {
        public string ModuleName;
        public DateTime CompletetionDate;
        public bool ModuleCompleted
        {
            get { return CompletetionDate < DateTime.Now; }
        }

        public ModuleParts[] Parts;
    }
}
