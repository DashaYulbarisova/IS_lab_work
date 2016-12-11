using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class StudyComponent : IStudyComponent // класс  компонент приобретения знаний
    {
        public StudyComponentForm FrmStudyComp;
        public KnowledgeBase KnowBase;
        public StudyComponent(KnowledgeBase knwldgBase) // конструктор
        {
            FrmStudyComp = new StudyComponentForm(this);
            KnowBase = knwldgBase;
        }
        private bool isRuleInPool(Rule rule) // проверяем есть ли правило в базе
        {
            bool answer = false;
            for (int i = 0; i < KnowBase.counterRule ; i++)
            {
                if (KnowBase.PropRulesPool[i].NameRule == rule.NameRule)
                {
                    answer = true;
                    break;
                }
                else answer = false;
            }
            return answer;
        }
        public bool AddTheRule(Rule rule) // функция добавления правила
        {
            bool added = false;
            //int n = KnowBase.counterRule;
           
             if (isRuleInPool(rule) == false)
           {
               KnowBase.PropRulesPool.Add(rule);
               KnowBase.counterRule = KnowBase.counterRule + 1;
               added = true;
               //  KnowBase.SaveToFile();

           }
            return added;
        }
        public void ChangeTheRule() // функция изменения правила
        {
            // реализация
        }
        public void ShowForm()
        {
            FrmStudyComp.Show();
        }
    }
}
