﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form RelativeMajority = new RelativeMajority();
            RelativeMajority.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Condorcet1 = new Condorcet1();
            Condorcet1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form BordaCount = new BordaCount();
            BordaCount.Show();
        }
    }
}
