using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class Fact // класс факт
    {
        private string nameFact;

        public string propNameFact
        {
            get { return nameFact; }
            set { nameFact = value; }
        }
        private string valueFact;

        public string propValueFact
        {
            get { return valueFact; }
            set { valueFact = value; }
        }

      
        public Fact(string name,string val)
        {
            nameFact = name;
            valueFact = val;
        }
    }
}
