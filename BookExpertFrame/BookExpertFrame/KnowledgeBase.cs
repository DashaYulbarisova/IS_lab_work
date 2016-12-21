using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExpertFrame
{
    public class KnowledgeBase : IKnowledgeBase
    {
        public List<Frame> listFrame;
        public Frame getFrameByName(string nameFrame)
        {
            return new Frame(null, null);
        }
    }
}
