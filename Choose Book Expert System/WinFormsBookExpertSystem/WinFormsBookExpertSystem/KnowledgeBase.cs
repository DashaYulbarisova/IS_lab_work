using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace WinFormsBookExpertSystem
{
    public class KnowledgeBase // класс база знаний
    {
        private List<Rule> listOfRules; // массив правил
        public List<Rule> PropRulesPool // свойство для чтения и редактирования массива правил
        {
            get { return listOfRules; }
            set { listOfRules = value; }
        }
        public int counterRule;
        public MemoryStream stream1 = new MemoryStream();
        public DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Rule));
        public KnowledgeBase() // конструктор
        {
            counterRule = 0;
            listOfRules = new List<Rule>();
            //ReadFromFile();
        }
        private string SerializeRule()
        {
            StringBuilder sb = new StringBuilder();
            int lengthBuf = 0;
            sb.Append("[");
            foreach (Rule rule in listOfRules)
            {
                sb.Append("{");
                sb.Append('\u0022');
                sb.Append(rule.NameRule);
                sb.Append('\u0022');
                sb.Append(":");
                sb.Append("{");
                sb.Append('\u0022');
                sb.Append("possibleValue");
                sb.Append('\u0022');
                sb.Append(":");
                sb.Append("[");
                foreach (string posVal in rule.PossibleValue)
                {
                    sb.Append('\u0022');
                    sb.Append(posVal);
                    sb.Append('\u0022');
                    sb.Append(",");
                }
                lengthBuf = sb.Length;
                sb.Remove((lengthBuf - 1), 1);
                sb.Append("]");
                sb.Append(",");
                sb.Append('\u0022');
                sb.Append("conditions");
                sb.Append('\u0022');
                sb.Append(":");
                sb.Append("[");
                foreach (MyCondition condition in rule.Condition)
                {
                    sb.Append("{");
                    sb.Append('\u0022');
                    sb.Append("name");
                    sb.Append('\u0022');
                    sb.Append(":");
                    sb.Append('\u0022');
                    sb.Append(condition.NameFact);
                    sb.Append('\u0022');
                    sb.Append(",");
                    sb.Append('\u0022');
                    sb.Append("value");
                    sb.Append('\u0022');
                    sb.Append(":");
                    sb.Append('\u0022');
                    sb.Append(condition.ValueFact);
                    sb.Append('\u0022');
                    sb.Append(",");
                    sb.Append('\u0022');
                    sb.Append("sign");
                    sb.Append('\u0022');
                    sb.Append(":");
                    sb.Append('\u0022');
                    sb.Append(condition.SignFact);
                    sb.Append('\u0022');
                    sb.Append("}");
                    sb.Append(",");
                }
                lengthBuf = sb.Length;
                sb.Remove((lengthBuf - 1), 1);
                sb.Append("]");
                sb.Append(",");
                sb.Append('\u0022');
                sb.Append("question");
                sb.Append('\u0022');
                sb.Append(":");
                sb.Append('\u0022');
                sb.Append(rule.Question);
                sb.Append('\u0022');
                sb.Append(",");
                sb.Append('\u0022');
                sb.Append("advice");
                sb.Append('\u0022');
                sb.Append(":");
                sb.Append("[");
                foreach (string advice in rule.Advice)
                {
                    sb.Append('\u0022');
                    sb.Append(advice);
                    sb.Append('\u0022');
                    sb.Append(",");
                }
                lengthBuf = sb.Length;
                sb.Remove((lengthBuf - 1), 1);
                sb.Append("]");
                sb.Append(",");
                //
                sb.Append('\u0022');
                sb.Append("action");
                sb.Append('\u0022');
                sb.Append(":");
                sb.Append("[");
                foreach (string action in rule.Action)
                {
                    sb.Append('\u0022');
                    sb.Append(action);
                    sb.Append('\u0022');
                    sb.Append(",");
                }
                lengthBuf = sb.Length;
                sb.Remove((lengthBuf - 1), 1);
                sb.Append("]");
                sb.Append("},");
            }
            lengthBuf = sb.Length;
            sb.Remove((lengthBuf - 1), 1);
            sb.Append("]");

            return sb.ToString();

        }


        public void SaveToFile() // функция сохранения базы знаний в файл
        {
            string stringRules;
            stringRules = SerializeRule();
            File.WriteAllText("rulesInJson.json", stringRules);
        }


       
        public void ReadFromFile() // функция чтения базы знаний из файла
        {
            // реализация чтения из JSON


            var json = System.IO.File.ReadAllText("rulesInJson.json");
            var objects = JArray.Parse(json); // parse as array  



            foreach (JObject root in objects)
            {


                foreach (KeyValuePair<String, JToken> rules in root)
                {

                    var appName = rules.Key;
                    //ruleForTest.advice = (String)rules.Value["advice"];

                    //начало
                    string[] valuesOfAdviceArr = new string[100];
                    JToken bufForAdvice = ((JToken)rules.Value["advice"].First);
                    int iAdvice = 0;
                    do
                    {
                        valuesOfAdviceArr[iAdvice] = (String)bufForAdvice;
                        listOfRules[counterRule].Advice[iAdvice] = valuesOfAdviceArr[iAdvice].ToString();
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
                        listOfRules[counterRule].PossibleValue[iPosVal] = valuesOfPosValArr[iPosVal].ToString();
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
                        listOfRules[counterRule].Action[iAction] = valuesOfActionArr[iAction].ToString();
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

                        listOfRules[counterRule].Condition[i].NameFact = name.First.ToString();
                        listOfRules[counterRule].Condition[i].ValueFact = value.First.ToString();
                        listOfRules[counterRule].Condition[i].SignFact = sign.First.ToString();

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


