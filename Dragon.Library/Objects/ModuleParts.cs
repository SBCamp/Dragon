using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
    class ModuleParts
    {
        public int Order;
        public string PartName;
        public DateTime PartCompletionDate;
        public bool Completetion
        {
            get { return PartCompletionDate < DateTime.Now; }
        }
    }
}
