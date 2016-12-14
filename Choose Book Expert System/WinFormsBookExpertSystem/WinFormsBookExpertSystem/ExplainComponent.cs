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
        private List<ExplainElement> myExplanationList = new List<ExplainElement>();
        public ExplainComponent(ILogicOutput logicOutput,IWorkMemory workMemory) // конструктор
        {
            _myLogicOutput = logicOutput;
            _myWorkMemory = workMemory;
        }
        public void ExplainResults() // функция объяснения результатов
        {
            // реализация
            string ruleText = "";
            string factValueText = "";
            Rule serviceRule;// = new Rule(null,null,null);
            Fact serviceFact;
            int countFact = _myWorkMemory.getCountFact();
            for (int i = 1; i < countFact; i++)
            {
                serviceFact = _myWorkMemory.getFact(i);
                serviceRule = _myLogicOutput.FindRuleByName(serviceFact.propNameFact);
                ruleText  = serviceRule.Print();
                factValueText = serviceFact.propValueFact;
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
