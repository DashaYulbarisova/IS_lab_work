using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExpertShell //класс фасад
    {

        private WorkMemory myWorkMemory;


        //private List<IWorkMemory> myWorkMemories;



        private StudyComponent myStudyComponent;
        private LogicOutput myLogicOutput;
        private ExplainComponent myExplainComponent;
        private KnowledgeBase myKnowledgeBase;
        public ExpertShell() // конструктор
        {

            myStudyComponent = new StudyComponent();
            myWorkMemory = new WorkMemory(myStudyComponent);
            myKnowledgeBase = new KnowledgeBase();
            myLogicOutput = new LogicOutput(myKnowledgeBase);
            myExplainComponent = new ExplainComponent(myLogicOutput);
        }
    }
}
