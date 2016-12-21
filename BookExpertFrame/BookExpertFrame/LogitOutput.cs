using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExpertFrame
{
    public class LogitOutput
    {
        private IKnowledgeBase myKnowledgeBase;
        public LogitOutput(IKnowledgeBase knowledgeBase)
        {
            myKnowledgeBase = knowledgeBase;
        }
        public Frame fillFrame(Frame workFrame)
        {
            Frame resulFrame = myKnowledgeBase.getFrameByName(workFrame.nameFrame);
            foreach (Slot slot in workFrame.slotFrame)
            {
                if (slot.valueSlot == "")
                {
                    slot.valueSlot = slot.AttachedProcedure;
                }
            }

            return new Frame(null,null);
        }
    }
}
