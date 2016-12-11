using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace WinFormsBookExpertSystem
{
    public class MyCondition // вспомогательный класс для хранения условий
    {

        public string NameFact { get; set; }
        public string ValueFact { get; set; }
        public string SignFact { get; set; }

        public string printText()
        {
            string txtCondition;
            txtCondition = "name: " + NameFact + ", " + "value: " + ValueFact + ", " + "sign: " + SignFact;
            return txtCondition;
        }

        public MyCondition(string nameF, string val,string sign)
        {
            NameFact = nameF;
            ValueFact = val;
            SignFact = sign;
        }
    }



    public class Rule 
    {

        public List<string> Action { get; set; }

        public List<string> Advice { get; set; }

        public List<MyCondition> Condition;

        public List<string> PossibleValue { get; set; }

        public string Question { get; set; }

        public string NameRule;

        public bool used;

        public Rule(List<string> arrAct, List<string> arrPos,string quest, List<string> arrAdv, List<MyCondition> arrCond)
        {
            
            Action = arrAct;
            PossibleValue = arrPos;
            Question = quest;
            Advice = arrAdv;
            Condition = arrCond;
            NameRule = arrAct[0];
        }
    }

}
