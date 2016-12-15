using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ElectorsCondorcet
    {
        public int first;
        public int second;
        public int third;
        public int fourth;

        public ElectorsCondorcet(int cand1, int cand2, int cand3, int cand4)
        {
            first = cand1;
            second = cand2;
            third = cand3;
            fourth = cand4;
    }

        public void SetChoice(int cand1, int cand2, int cand3, int cand4)
        {
            first = cand1;
            second = cand2;
            third = cand3;
            fourth = cand4;
        }
    }
}
