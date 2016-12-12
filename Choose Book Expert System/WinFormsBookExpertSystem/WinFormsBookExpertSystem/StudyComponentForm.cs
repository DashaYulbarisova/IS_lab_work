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
        private List<string> GetArrFromPhrase(string phrase)
        {
            int ind = 0;
            string bufLitera = "";
            int n = phrase.Length;
         
            List<string> arrPosVal = new List<string>();
            arrPosVal.Add("");
            for (int i2 = 0; i2 <= n-1; i2++)
            {

                bufLitera = phrase.Substring(i2,1);
               
                if (bufLitera != ",")
                {
                    
                    arrPosVal[ind]= arrPosVal[ind] + bufLitera;
                }
                else
                {
                    arrPosVal.Add("");
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

        private void ClearAllTextBox()
        {
            txtBoxNameAct.Text = "";
            txtBoxPosValue.Text = "";
            txtBoxQuestion.Text = "";
            txtBoxAuthor.Text = "";
            txtBoxCond.Text = "";

        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            List<string> actVar = GetArrFromPhrase(txtBoxNameAct.Text);
            List<string> arrPossibleVal = GetArrFromPhrase(txtBoxPosValue.Text);
            string questVar = txtBoxQuestion.Text;
            List<string> adviceVar = GetArrFromPhrase(txtBoxAuthor.Text);
            List<MyCondition> arrCondVar = this.newMyCondition;
            //label1.Text = getArrCond(txtBoxCond).ToString();
            Rule rule = new Rule(actVar, arrPossibleVal, questVar, adviceVar, arrCondVar);
            List<Rule> lR = new List<Rule>();
            lR.Add(rule); // что за??????
            lnkStudyComp.KnowBase.SaveToFile();
            if (lnkStudyComp.AddTheRule(rule) == true)
            {
                MessageBox.Show("Правило успешно добавлено!");
                ClearAllTextBox();
            }
           else
           {
                MessageBox.Show("Правило уже есть в базе!");
                ClearAllTextBox();
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            AddConditionForm myAddConditionForm = new AddConditionForm(this);
            myAddConditionForm.Show();
        }
        
    }
}
