using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WinFormsBookExpertSystem
{
    public class KnowledgeBase // класс база знаний
    {
        private RuleJson[] listOfRules; // массив правил
        public RuleJson[] PropRulesPool // свойство для чтения и редактирования массива правил
        {
            get { return listOfRules; }
            set { listOfRules = value; }
        }
        public int counterRule;
        public MemoryStream stream1 = new MemoryStream();
        public DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RuleJson));
        public KnowledgeBase() // конструктор
        {
            counterRule = 0;
            listOfRules = new RuleJson[1000];
           // ReadFromFile();
            //for (int i = 0; i < 999; i++)
            //{
            //    listOfRules[i] = new RuleJson(null,null,null,null,null);
            //}
        }

        public void SaveToFile() // функция сохранения базы знаний в файл
        {
            
            RuleJson p;
            for (int i = 1; i <= counterRule; i++)
            {
                p = listOfRules[i];
                ser.WriteObject(stream1, p);
            }

            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            StreamWriter myStreamWriter;
            FileInfo fileforstream = new FileInfo("rulesInJson1.json");
      //      fileforstream.Replace("rulesInJson.json", "backUpRulesInJson.json");
            myStreamWriter = fileforstream.AppendText();
            myStreamWriter.WriteLine(sr.ReadToEnd());
            myStreamWriter.Close();
           

        }


        public void ReadFromFile() // функция чтения базы знаний из файла
        {
            //MemoryStream stream1 = new MemoryStream();
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(RuleJson));
            stream1.Position = 0;
            RuleJson p2 = (RuleJson)ser.ReadObject(stream1);
            
            
        }

        //public void ReadFromFile() // функция чтения базы знаний из файла
        //{
        //    // реализация чтения из JSON


        //    var json = System.IO.File.ReadAllText("rulesInJson.json");
        //    var objects = JArray.Parse(json); // parse as array  



        //    foreach (JObject root in objects)
        //    {


        //        foreach (KeyValuePair<String, JToken> rules in root)
        //        {

        //            var appName = rules.Key;
        //            //ruleForTest.advice = (String)rules.Value["advice"];

        //            //начало
        //            string[] valuesOfAdviceArr = new string[100];
        //            JToken bufForAdvice = ((JToken)rules.Value["advice"].First);
        //            int iAdvice = 0;
        //            do
        //            {
        //                valuesOfAdviceArr[iAdvice] = (String)bufForAdvice;
        //                listOfRules[counterRule].Advice[iAdvice] = valuesOfAdviceArr[iAdvice].ToString();
        //                iAdvice++;
        //                bufForAdvice = bufForAdvice.Next;
        //            }
        //            while (bufForAdvice != null);
        //            //конец


        //            //начало
        //            string[] valuesOfPosValArr = new string[100];
        //            JToken bufForPosVal = ((JToken)rules.Value["possibleValue"].First);
        //            int iPosVal = 0;
        //            do
        //            {
        //                valuesOfPosValArr[iPosVal] = (String)bufForPosVal;
        //                listOfRules[counterRule].PossibleValue[iPosVal] = valuesOfPosValArr[iPosVal].ToString();
        //                iPosVal++;
        //                bufForPosVal = bufForPosVal.Next;
        //            }
        //            while (bufForPosVal != null);
        //            //конец



        //            //начало
        //            string[] valuesOfActionArr = new string[100];
        //            JToken bufForAction = ((JToken)rules.Value["action"].First);
        //            int iAction = 0;
        //            do
        //            {
        //                valuesOfActionArr[iAction] = (String)bufForAction;
        //                listOfRules[counterRule].Action[iAction] = valuesOfActionArr[iAction].ToString();
        //                iAction++;
        //                bufForAction = bufForAction.Next;
        //            }
        //            while (bufForAction != null);
        //            //конец

        //            JToken bufForCondition = ((JToken)rules.Value["conditions"].First);
        //            int i = 0;

        //            do
        //            {
        //                JToken name = bufForCondition.First;
        //                JToken value = bufForCondition.First.Next;
        //                JToken sign = bufForCondition.First.Next.Next;

        //                listOfRules[counterRule].Condition[i].NameFact = name.First.ToString();
        //                listOfRules[counterRule].Condition[i].ValueFact = value.First.ToString();
        //                listOfRules[counterRule].Condition[i].SignFact = sign.First.ToString();

        //                i++;

        //                bufForCondition = bufForCondition.Next;

        //            }
        //            while ((bufForCondition != null));
        //            //      label1.Text = ruleForTest.advice[0];
        //            var question = (String)rules.Value["question"];
        //            counterRule++;
        //        }
        //    }
        //}
    }
}
