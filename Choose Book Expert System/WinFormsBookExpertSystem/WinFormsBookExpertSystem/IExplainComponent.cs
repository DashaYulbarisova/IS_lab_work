using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public interface IExplainComponent // класс интерфейс компонента объяснения
    {
        void ExplainResults(); // функция объяснения результатов
        void Print(); // функция отображения объяснения
       
    }

}
