using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExplainComponent : IExplainComponent // компонент объяснения
    {
        private ILogicOutput myLogicOutput;
        public ExplainComponent(ILogicOutput logicOutput) // конструктор
        {
            myLogicOutput = logicOutput;
        }
        public void explainResults() // функция объяснения результатов
        {
            // реализация
        }
        public void print() // функция отображения объяснения
        {
            // реализация
        }
    }
}
