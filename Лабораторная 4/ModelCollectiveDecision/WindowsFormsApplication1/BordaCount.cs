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
    public partial class BordaCount : Form
    {
        int[] candidates = new int[4];

        public BordaCount()
        {
            InitializeComponent();
        }

        public string WhoIsWin()
        {
            dataGridView1.Visible = true;
            for (int i = 0; i < candidates.Count(); i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = candidates[i];
            }
            int different = 0;
            for (int i = 0; i < candidates.Count(); i++)
            {
                if (candidates[i] == candidates.Max<int>())
                {
                    different = different + 1;
                }
            }
            int index = Array.IndexOf(candidates, candidates.Max<int>());
            string win = "";
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
            candidates[0] = candidates[0] + Convert.ToInt32(textBox1.Text);
            candidates[1] = candidates[1] + Convert.ToInt32(textBox2.Text);
            candidates[2] = candidates[2] + Convert.ToInt32(textBox3.Text);
            candidates[3] = candidates[3] + Convert.ToInt32(textBox4.Text);
            ResultForElectors.Rows.Add(new object[] { ResultForElectors.RowCount, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text });
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string winner = WhoIsWin();
            label3.Visible = true;
            label3.Text = "Победитель - " + winner;
        }
    }
}
