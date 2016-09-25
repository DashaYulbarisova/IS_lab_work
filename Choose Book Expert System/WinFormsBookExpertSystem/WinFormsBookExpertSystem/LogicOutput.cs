using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class LogicOutput : ILogicOutput
    {
        private KnowledgeBase myKnowledgeBase;
        public LogicOutput(KnowledgeBase knowledgeBase)
        {
            myKnowledgeBase = knowledgeBase;
        }
    }
}
