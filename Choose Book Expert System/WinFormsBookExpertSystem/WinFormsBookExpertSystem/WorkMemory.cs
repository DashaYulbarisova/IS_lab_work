using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class WorkMemory : IWorkMemory // класс рабочая память
    {
        private IStudyComponent myStudyComponent;
        public WorkMemory (IStudyComponent studyComponent) // конструктор
        {
            myStudyComponent = studyComponent;
        }
        public void addFacts() // функция добавления фактов в рабочую память
        {
            //реализация интерфейса
        }

    }
}
