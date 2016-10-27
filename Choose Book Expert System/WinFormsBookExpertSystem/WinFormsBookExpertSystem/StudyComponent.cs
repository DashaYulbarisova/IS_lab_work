using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class StudyComponent : IStudyComponent // класс  компонент приобретения знаний
    {
        public StudyComponentForm frmStudyComp;
        public KnowledgeBase knowBase;

        public StudyComponent(KnowledgeBase knwldgBase) // конструктор
        {

            frmStudyComp = new StudyComponentForm(this);
            knowBase = knwldgBase;
        }
        public void addTheRule(RuleJSON rule) // функция добавления правила
        {
            int n = knowBase.counterRule;
            knowBase.propRulesPool[n + 1] = rule;
            knowBase.saveToFile();
        }
        public void changeTheRule() // функция изменения правила
        {
            // реализация
        }
        public void ShowForm()
        {

            frmStudyComp.Show();
          //  Form1.ActiveForm.Text = "gthg";
        }

    }
}
