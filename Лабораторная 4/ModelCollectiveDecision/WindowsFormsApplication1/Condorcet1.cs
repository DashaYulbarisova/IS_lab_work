using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class Condorcet1 : Form
    {
        List<int> group = new List<int>();
        int candidate1, candidate2, candidate3, candidate4;
        int[,] result = new int[4, 4];
        string[] variant = new string[]{"Акция", "Облигация", "Банковский сертификат", "Инвестиционный пай" };
        int num;
        int[,] Copland = new int[4,3];
        int[] minvariant = new int[4];

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i != j)
                    {
                        if (result[i, j] >= result[j, i])
                        {
                            Copland[i, 0] = Copland[i, 0] + 1;
                        }
                        else
                        {
                            Copland[i, 1] = Copland[i, 1] + 1;
                        }
                    }
                }
            }
            dataGridView2.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                Copland[i, 2] = Copland[i, 0] - Copland[i, 1];
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = variant[i];
                for (int j = 0; j < 3; j++)
                {
                    dataGridView2.Rows[i].Cells[j + 1].Value = Copland[i, j];
                }
            }
            int max = Copland[0, 2];
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                if (Copland[i, 2] >= max)
                {
                    max = Copland[i, 2];
                    index = i;
                }
            }
            string winner1 = "";
            switch (index)
            {
                case 0:
                    winner1 = "Акция";
                    break;
                case 1:
                    winner1 = "Облигация";
                    break;
                case 2:
                    winner1 = "Банковский сертификат";
                    break;
                case 3:
                    winner1 = "Инвестиционный пай";
                    break;
            }
            label7.Visible = true;
            label7.Text = winner1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            for (int i = 0; i < 4; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells[0].Value = variant[i];
                int min = group.Count / 4;
                for (int j = 0; j < 4; j++)
                {
                    if ((i != j)&(result[i, j] < min))
                    {
                        min = result[i, j];
                    }
                }
                dataGridView3.Rows[i].Cells[1].Value = min;
                minvariant[i] = min;

            }
            int max = minvariant[0];
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                if (minvariant[i] > max)
                {
                    max = minvariant[i];
                    index = i;
                }
            }
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
            label8.Visible = true;
            label8.Text = winner;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = group.Count / 4;
            int three = 0;
            int one = 0;
            int win = 0;
            string winner = "";
            for (int i = 0; i <= 2; i++)
            {
                for (int j = i + 1; j <= 3; j++)
                {
                    result[j, i] = num - result[i, j];
                }
            }
            dataGridView1.Visible = true;
            dataGridView1.RowCount = 4;
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = result[i, j];
                }
            }
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if ((result[i, j] > result[j, i]) & (i != j))
                    {
                        three = three + 1;
                    }
                }
                if (three == 3)
                {
                    one = one + 1;
                    win = i;
                }
            }
            if (one == 1)
            {
                switch (win)
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
            else
            {
                label3.Visible = true;
                label3.Text = "Победитель - Нет явного победителя";
            }
            button1.Visible = true;
            button4.Visible = true;
        }

        public Condorcet1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            candidate1 = Convert.ToInt32(textBox1.Text);
            candidate2 = Convert.ToInt32(textBox2.Text);
            candidate3 = Convert.ToInt32(textBox3.Text);
            candidate4 = Convert.ToInt32(textBox4.Text);
            int[] candidates = new int[] { candidate1, candidate2, candidate3, candidate4 };
            group.AddRange(candidates);
            for (int i = 0; i <= 2; i++)
            {
                for (int j = i + 1; j <= 3; j++)
                {
                    if (candidates[i] < candidates[j])
                    {
                        result[i, j] = result[i, j] + 1;
                    }
                }
            }
            ResultForElectors.Rows.Add(new object[] { group.Count / 4, candidate1, candidate2, candidate3, candidate4 });
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
