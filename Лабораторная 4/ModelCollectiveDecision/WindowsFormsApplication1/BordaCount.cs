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
            dataGridView1.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                    dataGridView1.Rows[0].Cells[i].Value = candidates[i];
            }
            int index = Array.IndexOf(candidates, candidates.Max<int>());
            string winner = "";
            switch (index)
            {
                case 0:
                    winner = "Акция";
                    break;
                case 1:
                    winner = "Облигация";
                    break;
                case 2:
                    winner = "Банковский сертификат";
                    break;
                case 3:
                    winner = "Инвестиционный пай";
                    break;
            }
            label3.Visible = true;
            label3.Text = winner;
        }
    }
}
