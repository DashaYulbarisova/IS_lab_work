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

        public MyCondition(string nameF, string val,string sign)
        {
            NameFact = nameF;
            ValueFact = val;
            SignFact = sign;
        }
    }

    [DataContract]

    public class RuleJson 
    {
        [DataMember]
        public string[] Action { get; set; }
        [DataMember]
        public string[] Advice { get; set; }
        [DataMember]
        public MyCondition[] Condition;
        [DataMember]
        public string[] PossibleValue { get; set; }
        [DataMember]
        public string Question { get; set; }
        [DataMember]
        public string NameRule;

        public RuleJson(string[]arrAct, string[] arrPos,string quest, string[]arrAdv,MyCondition[] arrCond)
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
