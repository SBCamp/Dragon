using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Library.Objects
{
    class Progress
    {

        private Module[] _CurrentList;
        public Module Current
        {
            get { return (Module)from Module mod in _CurrentList where mod.ModuleCompleted == false select mod; }
        }

        public ModuleParts CurrentPart
        {
            get { return (ModuleParts)from ModuleParts modpart in Current.Parts
                                      where modpart.Order == Current.Parts.Where(a => a.Completetion == false).OrderBy(a => a.Order).Min(a => a.Order)
                                       select modpart; }
        }
    }
}
