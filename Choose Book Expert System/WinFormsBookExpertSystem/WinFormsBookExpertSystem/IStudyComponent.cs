using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public interface IStudyComponent // класс интерфейс компонента приобретения знаний
    {
        void addTheRule(RuleJSON rule); // функция добавления правила
        void changeTheRule(); // функция изменения правила
    }
}
