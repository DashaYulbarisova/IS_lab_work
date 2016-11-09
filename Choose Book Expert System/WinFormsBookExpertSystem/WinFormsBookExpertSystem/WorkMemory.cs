using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class WorkMemory : IWorkMemory // класс рабочая память
    {
        private Fact[] factArray; // массив фактов 
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
            factArray = new Fact[1000]; // создаем пустой массив для фактов (допустим, 1000 элементов)
        }

        private bool isFactInWorkMemory(Fact fact)
        {

            bool answer = true;
            for (int i = 0; i < countFact - 1; i++)
            {
                if (factArray[i] == fact)
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
                factArray[countFact] = newFact;
                countFact = countFact + 1;
            }

        }

    }
}
