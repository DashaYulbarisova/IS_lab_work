using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WinFormsBookExpertSystem
{
    public class myCondition // вспомогательный класс для хранения условий
    {

        public string nameFact { get; set; }
        public string valueFact { get; set; }
        public string signFact { get; set; }

        public myCondition()
        {
            nameFact = "";
            valueFact = "";
            signFact = "";
        }
    }

    public class RuleJSON 
    {
        public string[] action { get; set; }
        public string[] advice { get; set; }
        public myCondition[] condition;
        public string[] possibleValue { get; set; }
        public string question { get; set; }

        public RuleJSON()
        {
            possibleValue = new string[100];
            action = new string[100];
            advice = new string[100];
            condition = new myCondition[100];
            for (int i = 0; i < 100 - 1; i++)
            {
                condition[i] = new myCondition();
            }
        }
    }

}
