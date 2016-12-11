using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class WorkMemory : IWorkMemory // класс рабочая память
    {
        private List<Fact> factArray; // массив фактов 
        private IStudyComponent myStudyComponent;
        private int countFact;

        public int propCountFact
        {
            get { return countFact; }
            set { countFact = value; }
        }

        public WorkMemory (IStudyComponent studyComponent) // конструктор
        {
            countFact = 0;
            myStudyComponent = studyComponent;
            factArray = new List<Fact>(); // создаем пустой массив для фактов (допустим, 1000 элементов)
        }

        private bool isFactInWorkMemory(Fact fact)
        {

            bool answer = true;
            for (int i = 0; i < countFact - 1; i++)
            {
                if ((factArray[i].propNameFact == fact.propNameFact) &&(factArray[i].propValueFact == fact.propValueFact))
                {
                    answer = true;
                    break;

                }
                else answer = false;

            }
            return answer;

        }

        public void AddFacts(Fact newFact) // функция добавления фактов в рабочую память
        {
            //реализация интерфейса
            if (isFactInWorkMemory(newFact) == false)
            {
                factArray.Add(newFact);
                countFact = countFact + 1;
            }
           

        }
        public void clearMemory()
        {
            factArray.Clear();
            countFact = 0;
        }

    }
}
