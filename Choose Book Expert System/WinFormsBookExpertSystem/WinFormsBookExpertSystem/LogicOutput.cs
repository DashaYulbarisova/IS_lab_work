using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class LogicOutput : ILogicOutput // класс механизм логического вывода
    {
        private KnowledgeBase _myKnowledgeBase;
        public LogicOutput(KnowledgeBase knowledgeBase) // конструктор
        {
            _myKnowledgeBase = knowledgeBase;
        }

        public Rule FindTheRule(Fact fact) // функция нахождения правила (добавить возвращаемый тип значения)
        {
            Rule returnRule = null;
            foreach (Rule rule in _myKnowledgeBase.PropRulesPool)
            {
                foreach (MyCondition condition in rule.Condition)
                {
                    if ((condition.NameFact == fact.propNameFact) && (condition.ValueFact == fact.propValueFact))
                    {
                        returnRule = rule;
                        break;                     
                    }
                }
            }
            return returnRule;            
            
        }
        public void AskTheQuestion() // функция, задающая вопрос (добавить возвращаемый тип значения) 
        {
            // реализация
        }
        public void GetTheAnswer() // функция, которая принимает ответ
        {
            // реализация
        }
    }
}
