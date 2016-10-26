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

        public myCondition(string nameF, string val,string sign)
        {
            nameFact = nameF;
            valueFact = val;
            signFact = sign;
        }
    }

    public class RuleJSON 
    {
        public string[] action { get; set; }
        public string[] advice { get; set; }
        public myCondition[] condition;
        public string[] possibleValue { get; set; }
        public string question { get; set; }
        public string nameRule;

        public RuleJSON(string[]arrAct, string[] arrPos,string quest, string[]arrAdv,myCondition[] arrCond)
        {
            
            action = arrAct;
            possibleValue = arrPos;
            question = quest;
            advice = arrAdv;
            condition = arrCond;
            nameRule = action[0];
        }
    }

}
