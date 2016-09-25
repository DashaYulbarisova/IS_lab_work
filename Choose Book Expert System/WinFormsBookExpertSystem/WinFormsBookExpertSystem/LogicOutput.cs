using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class LogicOutput : ILogicOutput // класс механизм логического вывода
    {
        private KnowledgeBase myKnowledgeBase;
        public LogicOutput(KnowledgeBase knowledgeBase) // конструктор
        {
            myKnowledgeBase = knowledgeBase;
        }

        public void findTheRule() // функция нахождения правила (добавить возвращаемый тип значения)
        {
            // реализация
        }
        public void askTheQuestion() // функция, задающая вопрос (добавить возвращаемый тип значения) 
        {
            // реализация
        }
        public void getTheAnswer() // функция, которая принимает ответ
        {
            // реализация
        }
    }
}
