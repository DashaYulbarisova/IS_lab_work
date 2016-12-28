using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace BookExpertFrame
{
    public class LogitOutput
    {
        private KnowledgeBase myKnowledgeBase;
        public LogitOutput(KnowledgeBase knowledgeBase)
        {
            myKnowledgeBase = knowledgeBase;
        }

        public Frame LinkWithFrame(string nameFrame) 
        {
            Frame linkedFrame = new Frame(null,null,null);
            try
            {
                linkedFrame = myKnowledgeBase.getFrameByName(nameFrame);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка");
            }
            return linkedFrame;

        }

        public Frame FillFrame(Frame linkedFrame) // заполняем фрейм
        {
            foreach (Slot slot in linkedFrame.slotFrame)
            {
                if (IsSubframe(slot))
                {
                    Frame subframe = myKnowledgeBase.getFrameByName(slot.nameSlot);
                    if (subframe != null)
                    {
                        FillFrame(subframe); // рекурсивный вызов 
                    }
                }
                else
                {
                    if (isSlotHasValue(slot.valueSlot)) // (IF-ADDED)
                    {
                       FillSlot(slot);
                    }
                }
            }
            if (!CheckAllSlots(linkedFrame))
            {
                // что делать?   
            }
            return linkedFrame;
        }
        private bool IsSubframe(Slot slot) // проверяем является ли слот фреймом
        {
            var result = slot.typeData == "frame";
            return result;
        }

        private void FillSlot(Slot slot) 
        {
            AttachedProcedure method = myKnowledgeBase.FindAttachedProcedure(slot.AttachedProcedure);
            method?.Execute();
        }

        private bool isSlotHasValue(string slotValue)
        {
            var result = slotValue != "";
            return result;
        }

        private bool CheckAllSlots(Frame frame)
        {
            foreach (Slot slot in frame.slotFrame)
            {
                if (!isSlotHasValue(slot.valueSlot))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
