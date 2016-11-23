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

        private MyCondition[] GetArrCond(TextBox txtBox)
        {
            int n = txtBox.Lines.Count()-1;
            MyCondition[] arrCond = new MyCondition[n];
            string bufLine = "";
            string bufLitera = "";
            string[] bufArr = new string[3];
            int ind = 1;
            int indLine = 0;
            bufLine = txtBox.Lines[indLine];
            for (int iWrap = 1; iWrap <= n; iWrap++)
            {

                for (int iInside = 1; iInside <= bufLine.Length; iInside++)
                {
                    bufLitera = bufLine.Substring(iInside, 1);
                    if (bufLitera != ",")
                    {
                        bufArr[ind] = bufArr[ind] + bufLitera;
                    }
                    else
                    {
                        ind++;
                    }
                }

                arrCond[iWrap] = new MyCondition(bufArr[1], bufArr[2], bufArr[3]);
            }
            return arrCond;
        }
        private void StudyComponentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            
            string[] actVar = GetArrFromPhrase(txtBoxNameAct.Text);
            string[] arrPossibleVal = GetArrFromPhrase(txtBoxPosValue.Text);
            string questVar = txtBoxQuestion.Text;
            string[] adviceVar = GetArrFromPhrase(txtBoxAuthor.Text);
            MyCondition[] arrCondVar = GetArrCond(txtBoxCond);
            //label1.Text = getArrCond(txtBoxCond).ToString();

            RuleJson rule = new RuleJson(actVar, arrPossibleVal, questVar, adviceVar, arrCondVar);
            lnkStudyComp.AddTheRule(rule);
            label6.Text = "Правило успешно добавлено!";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lnkStudyComp.KnowBase.ReadFromFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
