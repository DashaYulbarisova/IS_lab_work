using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class WorkMemory : IWorkMemory
    {
        private IChangeRules myChangeRules;
        public WorkMemory (IChangeRules changeRules)
            {
                myChangeRules = changeRules;
            }

    }
}
