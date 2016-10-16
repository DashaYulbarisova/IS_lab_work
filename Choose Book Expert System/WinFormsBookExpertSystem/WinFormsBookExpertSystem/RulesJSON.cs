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


    public class RulesJSON : Rules // наследник класса правило, правило в формате JSON
    {
        public override void readMyself() // считывает в себя из формата JSON
        {
            // реализация чтения из JSON

            int counterRule = 0;
            var json = System.IO.File.ReadAllText("rulesInJson.json");
            var objects = JArray.Parse(json); // parse as array  



            foreach (JObject root in objects)
            {


                foreach (KeyValuePair<String, JToken> rules in root)
                {

                    var appName = rules.Key;
                    //  ruleForTest.advice = (String)rules.Value["advice"];

                    //начало
                    string[] valuesOfAdviceArr = new string[100];
                    JToken bufForAdvice = ((JToken)rules.Value["advice"].First);
                    int iAdvice = 0;
                    do
                    {
                        valuesOfAdviceArr[iAdvice] = (String)bufForAdvice;
                        listOfRules[counterRule].advice[iAdvice] = valuesOfAdviceArr[iAdvice].ToString();
                        iAdvice++;
                        bufForAdvice = bufForAdvice.Next;
                    }
                    while (bufForAdvice != null);
                    //конец


                    //начало
                    string[] valuesOfPosValArr = new string[100];
                    JToken bufForPosVal = ((JToken)rules.Value["possibleValue"].First);
                    int iPosVal = 0;
                    do
                    {
                        valuesOfPosValArr[iPosVal] = (String)bufForPosVal;
                        listOfRules[counterRule].possibleValue[iPosVal] = valuesOfPosValArr[iPosVal].ToString();
                        iPosVal++;
                        bufForPosVal = bufForPosVal.Next;
                    }
                    while (bufForPosVal != null);
                    //конец



                    //начало
                    string[] valuesOfActionArr = new string[100];
                    JToken bufForAction = ((JToken)rules.Value["action"].First);
                    int iAction = 0;
                    do
                    {
                        valuesOfActionArr[iAction] = (String)bufForAction;
                        listOfRules[counterRule].action[iAction] = valuesOfActionArr[iAction].ToString();
                        iAction++;
                        bufForAction = bufForAction.Next;
                    }
                    while (bufForAction != null);
                    //конец

                    JToken bufForCondition = ((JToken)rules.Value["conditions"].First);
                    int i = 0;

                    do
                    {
                        JToken name = bufForCondition.First;
                        JToken value = bufForCondition.First.Next;
                        JToken sign = bufForCondition.First.Next.Next;

                        listOfRules[counterRule].condition[i].nameFact = name.First.ToString();
                        listOfRules[counterRule].condition[i].valueFact = value.First.ToString();
                        listOfRules[counterRule].condition[i].signFact = sign.First.ToString();

                        i++;

                        bufForCondition = bufForCondition.Next;

                    }
                    while ((bufForCondition != null));
                    //      label1.Text = ruleForTest.advice[0];
                    var question = (String)rules.Value["question"];
                    counterRule++;
                }

            }

        }

        public override void saveMyself() // сохраняет себя в формате JSON
        {
            // реализация сохранения в JSON
        }
        public RuleJSON[] listOfRules; 
        public RulesJSON() // конструктор
            {
                listOfRules = new RuleJSON[1000];
                for (int i = 0; i < 999; i++)
                    {
                        listOfRules[i] = new RuleJSON();
                    }
            }



        
    }
}
