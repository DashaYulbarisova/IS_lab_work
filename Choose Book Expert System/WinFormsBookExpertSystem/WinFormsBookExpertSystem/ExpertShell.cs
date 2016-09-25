using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExpertShell
    {

        private WorkMemory myWorkMemory;
        private ChangeRules myChangeRules;
        private LogicOutput myLogicOutput;
        private ExplainComponent myExplainComponent;
        private KnowledgeBase myKnowledgeBase;
        public ExpertShell()
        {
            
            myChangeRules = new ChangeRules();
            myWorkMemory = new WorkMemory(myChangeRules);
            myKnowledgeBase = new KnowledgeBase();
            myLogicOutput = new LogicOutput(myKnowledgeBase);
            myExplainComponent = new ExplainComponent(myLogicOutput);
        }
    }
}
