using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RelativeMajority : Form
    {
        List<int> group = new List<int>();
        int candidate1, candidate2, candidate3, candidate4;

        public RelativeMajority()
        {
            InitializeComponent();
        }

        public string WhoIsWin()
        {
            candidate1 = group.Count(p => p == 1);
            candidate2 = group.Count(p => p == 2);
            candidate3 = group.Count(p => p == 3);
            candidate4 = group.Count(p => p == 4);
            ResultForCandidates.Rows.Clear();
            ResultForCandidates.Visible = true;
            ResultForCandidates.Rows.Add(new object[] { "Акция", candidate1 });
            ResultForCandidates.Rows.Add(new object[] { "Облигация", candidate2 });
            ResultForCandidates.Rows.Add(new object[] { "Банковский сертификат", candidate3 });
            ResultForCandidates.Rows.Add(new object[] { "Инвестиционный пай", candidate4 });
            int[] candidates = new int[] { candidate1, candidate2, candidate3, candidate4 };
            int different = 0;
            for (int i = 0; i < candidates.Count(); i++)
            {
                if (candidates[i] == candidates.Max<int>())
                {
                    different = different + 1;
                }
            }
            string win = "";
            int index = Array.IndexOf(candidates, candidates.Max());
            if (different == 1)
            {
                switch (index)
                {
                    case 0:
                        win = "Акция";
                        break;
                    case 1:
                        win = "Облигация";
                        break;
                    case 2:
                        win = "Банковский сертификат";
                        break;
                    case 3:
                        win = "Инвестиционный пай";
                        break;
                }
            }
            else
            {
                win = "Нет явного победителя";
            }
            return win;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (((RadioButton)groupBox1.Controls[i]).Checked == true)
                {
                    group.Add(4 - i);
                    ((RadioButton)groupBox1.Controls[i]).Checked = false;
                }
            }
            ResultForElectors.Rows.Add(new object[] { group.Count, group.Last() });
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            string winner = WhoIsWin();
            label3.Visible = true;
            label3.Text = "Победитель - "+ winner;
        }
    }

}
