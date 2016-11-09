using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public interface IWorkMemory // класс интерфейс для рабочей памяти
    {
        
        void AddFacts(Fact newFact); // функция добавления фактов в рабочую память
        
    }
}
