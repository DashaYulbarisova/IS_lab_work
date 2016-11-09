using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class StudyComponent : IStudyComponent // класс  компонент приобретения знаний
    {


        // TO DO
       // 1. сохранение правил в файл KnowledgeBase
       // 2. проверка правила на не противоречивость при Add в StudyComp
       ////END of TO DO

        public StudyComponentForm FrmStudyComp;
        public KnowledgeBase KnowBase;

        public StudyComponent(KnowledgeBase knwldgBase) // конструктор
        {

            FrmStudyComp = new StudyComponentForm(this);
            KnowBase = knwldgBase;
        }
        private bool isRuleInPool(RuleJson rule) // проверяем есть ли правило в базе
        {
            bool answer = true;
            for (int i = 0; i < KnowBase.counterRule - 1; i++)
            {
                if (KnowBase.PropRulesPool[i] == rule)
                {
                    answer = true;
                    break;

                }
                else answer = false;

            }
            return answer;

        }
        public void AddTheRule(RuleJson rule) // функция добавления правила
        {
            int n = KnowBase.counterRule;
            if (isRuleInPool(rule) == false)
            {
                KnowBase.PropRulesPool[n + 1] = rule;
                KnowBase.SaveToFile();
            }
        }
        public void ChangeTheRule() // функция изменения правила
        {
            // реализация
        }
        public void ShowForm()
        {

            FrmStudyComp.Show();
          //  Form1.ActiveForm.Text = "gthg";
        }

        

    }
}
