using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WinFormsBookExpertSystem
{
    public class KnowledgeBase // класс база знаний
    {
        private RuleJSON[] listOfRules; // массив правил
        public RuleJSON[] propRulesPool // свойство для чтения и редактирования массива правил
        {
            get { return listOfRules; }
            set { listOfRules = value; }
        }
        public KnowledgeBase() // конструктор
        {
            //
            listOfRules = new RuleJSON[1000];
            for (int i = 0; i < 999; i++)
            {
                listOfRules[i] = new RuleJSON();
            }
        }
        public void saveToFile() // функция сохранения базы знаний в файл
        { }
        public void readFromFile() // функция чтения базы знаний из файла
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
    }
}
