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
        private ExpertShell _workShell;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudyComp_Click(object sender, EventArgs e)
        {
            _workShell.MyStudyComponent.ShowForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _workShell = new ExpertShell();
        }
    }
}
