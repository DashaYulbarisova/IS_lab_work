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



        public StudyComponent MyStudyComponent;
        public LogicOutput MyLogicOutput;
        public ExplainComponent MyExplainComponent;
        public KnowledgeBase MyKnowledgeBase;

        public ExpertShell() // конструктор
        {
            MyKnowledgeBase = new KnowledgeBase();
         //   MyKnowledgeBase.ReadFromFile();
            MyStudyComponent = new StudyComponent(MyKnowledgeBase);
            myWorkMemory = new WorkMemory(MyStudyComponent);
            MyLogicOutput = new LogicOutput(MyKnowledgeBase);
            MyExplainComponent = new ExplainComponent(MyLogicOutput);
        }
    }
}
