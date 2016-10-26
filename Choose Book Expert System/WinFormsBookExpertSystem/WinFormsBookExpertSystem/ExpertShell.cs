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



        public StudyComponent myStudyComponent;
        public LogicOutput myLogicOutput;
        public ExplainComponent myExplainComponent;
        public KnowledgeBase myKnowledgeBase;
        public ExpertShell() // конструктор
        {

            
            myWorkMemory = new WorkMemory(myStudyComponent);
            myKnowledgeBase = new KnowledgeBase();
            myKnowledgeBase.readFromFile();
            myStudyComponent = new StudyComponent(myKnowledgeBase);
            myLogicOutput = new LogicOutput(myKnowledgeBase);
            myExplainComponent = new ExplainComponent(myLogicOutput);
        }
    }
}
