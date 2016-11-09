using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public interface ILogicOutput // класс интерфейс механизма логического вывода
    {
        void FindTheRule(); // функция нахождения правила (добавить возвращаемый тип значения)
        void AskTheQuestion(); // функция, задающая вопрос (добавить возвращаемый тип значения) 
        void GetTheAnswer(); // функция, которая принимает ответ
       
    }
}
