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
    public partial class AddConditionForm : Form
    {
        private StudyComponentForm studyComponentForm;
        public AddConditionForm(StudyComponentForm myStudyComponentForm)
        {
            studyComponentForm = myStudyComponentForm;
            InitializeComponent();
        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            MyCondition newMyCondition1 = new MyCondition(txtBoxNameFact.Text, txtBoxValueFact.Text, txtBoxSign.Text);
            studyComponentForm.newMyCondition.Add(newMyCondition1);
            studyComponentForm.txtBoxCond.Text = studyComponentForm.txtBoxCond.Text+newMyCondition1.printText()+ Environment.NewLine;
            this.Close();
        }
    }
}
