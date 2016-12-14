using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExplainElement
    {
        private string ruleText;
        private string valueFact;
        public ExplainElement(string textRule, string factValue)
        {
            ruleText = textRule;
            valueFact = factValue;
        }
        public string Print()
        {
            string str ="Правило: "+ Environment.NewLine+ruleText +Environment.NewLine +"Значение факта: "+ Environment.NewLine+valueFact + Environment.NewLine;
            return str;
        }
    }
}
