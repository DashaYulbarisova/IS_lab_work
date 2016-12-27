using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookExpertFrame
{
    public class LogitOutput
    {
        private KnowledgeBase myKnowledgeBase;
        public LogitOutput(KnowledgeBase knowledgeBase)
        {
            myKnowledgeBase = knowledgeBase;
        }
        public Frame fillFrame(Frame workFrame)
        {
            List<Frame> collectionFrame = getChildFrames(workFrame.IS_A);
            try
            {
                Frame resulFrame = myKnowledgeBase.getFrameByName(workFrame.IS_A);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка");
            }
            
            
            foreach (Slot slot in workFrame.slotFrame)
            {
                if (slot.valueSlot == "")
                {
                    slot.valueSlot = slot.AttachedProcedure;
                }
            }

            return new Frame(null,null);
        }
        private List<Frame> getChildFrames(string parentName)
        {
            List<Frame> resultFrameCollection = new List<Frame>();
            foreach (Frame frame in myKnowledgeBase.listFrame)
            {
                if (frame.IS_A == parentName)
                {
                    resultFrameCollection.Add(frame);
                }
            }
            return resultFrameCollection;
        }
    }
}
