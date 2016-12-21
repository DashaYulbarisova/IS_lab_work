using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookExpertFrame
{
    public partial class frmFrameExpertSystem : Form
    {
        public frmFrameExpertSystem()
        {
            InitializeComponent();
        }

        private void frmFrameExpertSystem_Load(object sender, EventArgs e)
        {
            panelAuthor.Visible = false;
            panelGenre.Visible = false;
        }

        private void chckBoxAuthor_CheckedChanged(object sender, EventArgs e)
        {
            panelAuthor.Visible = chckBoxAuthor.Checked;          
        }

        private void chckBoxGenre_CheckedChanged(object sender, EventArgs e)
        {
            panelGenre.Visible = chckBoxGenre.Checked;            
        }
    }
}
