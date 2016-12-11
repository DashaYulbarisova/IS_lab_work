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
            Rule firstRule = workShell.MyLogicOutput.FindTheRule(startFact);
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
            }
            else
            {
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
        }
    }
}
