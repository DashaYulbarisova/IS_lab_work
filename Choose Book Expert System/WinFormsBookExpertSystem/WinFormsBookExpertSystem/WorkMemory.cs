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
        public WorkMemory (IStudyComponent studyComponent) // конструктор
        {
            myStudyComponent = studyComponent;
            factArray = new Fact[1000]; // создаем пустой массив для фактов (допустим, 1000 элементов)
        }
        public void addFacts(Fact newFact) // функция добавления фактов в рабочую память
        {
            //реализация интерфейса
            
        }

    }
}
