using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExplainComponent : IExplainComponent // компонент объяснения
    {
        private ILogicOutput _myLogicOutput;
        public ExplainComponent(ILogicOutput logicOutput) // конструктор
        {
            _myLogicOutput = logicOutput;
        }
        public void ExplainResults() // функция объяснения результатов
        {
            // реализация
            
        }
        public void Print() // функция отображения объяснения
        {
            // реализация
        }
    }
}
