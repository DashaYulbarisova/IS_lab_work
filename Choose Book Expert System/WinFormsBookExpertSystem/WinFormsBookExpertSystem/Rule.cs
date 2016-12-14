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
        public string Print()
        {
            string conditionText = "";
            string adviceText = "";
            string posValueText = "";
            string actionText = "";

            foreach (MyCondition conditionItem in Condition)
            {
                conditionText = conditionText +conditionItem.printText()+ Environment.NewLine;
            }

            foreach (string adviceItem in Advice)
            {
                adviceText = adviceText + adviceItem + Environment.NewLine;
            }

            foreach (string posValueItem in PossibleValue)
            {
                posValueText = posValueText + posValueItem + Environment.NewLine;
            }

            foreach (string actionItem in Action)
            {
                actionText = actionText + actionItem + Environment.NewLine;
            }


            string str = "Название правила: " + NameRule + Environment.NewLine +
                         "Условия срабатывания:" + conditionText +
                         "Вопрос: " + Question + Environment.NewLine +
                         "Возможные значения: " + posValueText +
                         "Советы: " + adviceText +
                         "Действие:" + actionText;
            return str;
        }
    }

}
