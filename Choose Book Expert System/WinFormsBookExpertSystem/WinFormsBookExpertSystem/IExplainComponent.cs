using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public interface IExplainComponent // класс интерфейс компонента объяснения
    {
        void explainResults(); // функция объяснения результатов
        void print(); // функция отображения объяснения
       
    }

}
