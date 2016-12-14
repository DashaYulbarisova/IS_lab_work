using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExplainComponent : IExplainComponent // компонент объяснения
    {
        private ILogicOutput _myLogicOutput;
        private IWorkMemory _myWorkMemory;
        private List<ExplainElement> myExplanationList;
        public ExplainComponent(ILogicOutput logicOutput,IWorkMemory workMemory) // конструктор
        {
            _myLogicOutput = logicOutput;
            _myWorkMemory = workMemory;
        }
        public void ExplainResults() // функция объяснения результатов
        {
            // реализация
            string ruleText;
            string factValueText;
            int countFact = _myWorkMemory.getCountFact();
            for (int i = 0; i < countFact; i++)
            {
                ruleText  = _myLogicOutput.FindTheRule(_myWorkMemory.getFact(i)).Print();
                factValueText = _myWorkMemory.getFact(i).propNameFact;
                myExplanationList.Add(new ExplainElement(ruleText, factValueText));
            }
            
        }
        public string Print() // функция отображения объяснения
        {
            string fullStr = "";
            foreach (ExplainElement element in myExplanationList)
            {
                fullStr = fullStr + element.Print() + Environment.NewLine;
            }
            return fullStr;


        }
    }
}
