using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBookExpertSystem
{
    public partial class StudyComponentForm : Form
    {
        public List<MyCondition> newMyCondition = new List<MyCondition>();
        private StudyComponent lnkStudyComp;
        public StudyComponentForm(StudyComponent studyComp)
        {
            InitializeComponent();
            lnkStudyComp = studyComp;

        }
        private string[] GetArrFromPhrase(string phrase)
        {
            int ind = 0;
            string bufLitera = "";
            int n = phrase.Length;
            int lenArr = 1;
            for (int i1 = 1; i1 <= n-1; i1++)
            {
                bufLitera = phrase.Substring(i1, 1);
                if (bufLitera == ",")
                {
                    lenArr++;
                }
            }

            string[] arrPosVal = new string[lenArr];
            for (int i2 = 0; i2 <= n-1; i2++)
            {
                bufLitera = phrase.Substring(i2,1);
                if (bufLitera != ",")
                {
                    arrPosVal[ind] = arrPosVal[ind] + bufLitera;
                }
                else
                {
                    ind++;
                }           
            }

            return arrPosVal;
        }
        private void StudyComponentForm_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            txtBoxCond.Enabled = false;
        }
        private void btnAddRule_Click(object sender, EventArgs e)
        {
            
            string[] actVar = GetArrFromPhrase(txtBoxNameAct.Text);
            string[] arrPossibleVal = GetArrFromPhrase(txtBoxPosValue.Text);
            string questVar = txtBoxQuestion.Text;
            string[] adviceVar = GetArrFromPhrase(txtBoxAuthor.Text);
            MyCondition[] arrCondVar = this.newMyCondition.ToArray();
            //label1.Text = getArrCond(txtBoxCond).ToString();
            RuleJson rule = new RuleJson(actVar, arrPossibleVal, questVar, adviceVar, arrCondVar);
            if (lnkStudyComp.AddTheRule(rule) == true)
            {
                MessageBox.Show("Правило успешно добавлено!");
            }
           else
           {
                MessageBox.Show("Правило уже есть в базе!");
           }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            AddConditionForm myAddConditionForm = new AddConditionForm(this);
            myAddConditionForm.Show();
        }
    }
}
