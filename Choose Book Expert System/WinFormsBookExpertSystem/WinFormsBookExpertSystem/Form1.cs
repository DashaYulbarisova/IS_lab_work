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
    public partial class Form1 : Form
    {
        private ExpertShell workShell = new ExpertShell();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudyComp_Click(object sender, EventArgs e)
        {
            workShell.MyStudyComponent.ShowForm();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            bthStartTest.Visible = false;
            btnStudyComp.Visible = false;
            workShell.myWorkMemory.clearMemory();
            Fact startFact = new Fact("start", "yes");
            workShell.myWorkMemory.AddFacts(startFact);
            Rule firstRule = workShell.MyLogicOutput.FindNextRule(startFact);
            if (firstRule != null)
            {                             
                lbtQuestionText.Text = "Вопрос: " + firstRule.Question;
                lblPosValue.Text = "Варианты ответов: ";
                foreach (string posVal in firstRule.PossibleValue)
                {
                    lblPosValue.Text = lblPosValue.Text + " "+posVal;
                }
                lblInput.Visible = true;
                txtBoxInput.Visible = true;
                btnAccept.Visible = true;
                firstRule.used = true;
                workShell.myWorkMemory.bufFact = new Fact(firstRule.NameRule,"");
            }
            else
            {
                bthStartTest.Visible = true;
                btnStudyComp.Visible = true;
                MessageBox.Show("База знаний пуста. Добавьте знания и запустите тест снова", "Внимание!");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAccept.Visible = false;
            lbtQuestionText.Text = "";
            lblPosValue.Text = "";
            lblInput.Visible = false;
            txtBoxInput.Visible = false;
            btnExplain.Visible = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            workShell.myWorkMemory.bufFact.propValueFact = txtBoxInput.Text;
            Fact addFact = workShell.myWorkMemory.bufFact;
            workShell.myWorkMemory.AddFacts(addFact);
            Rule nextRule = workShell.MyLogicOutput.FindNextRule(addFact);
            if (nextRule != null)
            {
                txtBoxInput.Text = "";
                lbtQuestionText.Text = "Вопрос: " + nextRule.Question;
                lblPosValue.Text = "Варианты ответов: ";
                foreach (string posVal in nextRule.PossibleValue)
                {
                    lblPosValue.Text = lblPosValue.Text + " " + posVal;
                }
                lblInput.Visible = true;
                txtBoxInput.Visible = true;
                btnAccept.Visible = true;
                nextRule.used = true;
                workShell.myWorkMemory.bufFact = new Fact(nextRule.NameRule,"");
            }
            else
            {
                Fact finalFact = workShell.myWorkMemory.bufFact;
                
                Rule lastWorkedRule = workShell.MyLogicOutput.FindRuleByName(finalFact.propNameFact);
                int indexAdvice = -1;
                for (int i=0;i<((lastWorkedRule.PossibleValue.Count));i++)
                {
                    if (lastWorkedRule.PossibleValue[i] == finalFact.propValueFact)
                    {
                        indexAdvice = i;
                        break;
                    }
                }
                string adviceText = lastWorkedRule.Advice[indexAdvice];
                MessageBox.Show("Советуем прочитать: " + lastWorkedRule.Advice[indexAdvice]);
                btnExplain.Visible = true;
                lbtQuestionText.Text = "";
                lblPosValue.Text = "";
                lblInput.Text = "";
                txtBoxInput.Visible = false;
            }            
        }

        private void btnExplain_Click(object sender, EventArgs e)
        {
            string explanaionResults = "";
            workShell.MyExplainComponent.ExplainResults();
            explanaionResults = workShell.MyExplainComponent.Print();
            MessageBox.Show("Объяснение: " + Environment.NewLine + explanaionResults);
        }
    }
}
