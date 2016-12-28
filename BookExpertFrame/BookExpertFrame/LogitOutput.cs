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

        public Frame LinkWithFrame(string nameFrame) // привязка к фрейму
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
                    foreach (Slot subframeSlot in subframe.slotFrame)
                        FillSlot(subframeSlot);
                }
                else
                {
                    if (isSlotHasValue(slot.valueSlot))
                    {
                        Method method = FindAttachedProcedure(slot.AttachedProcedure);
                        method.Execute();
                        // если значение слота определено, вызывай присоединенную процедуру (IF-ADDED)
                    }
                    //FillSlot(slot);
                }
            }

            // может быть, добавить проверку все ли слоты заполнены и если нет, 
            // тогда вызвать метод FillSlot (IF-NEEDED)

            return new Frame(name: null,slot: null,link: null);
        }
        private bool IsSubframe(Slot slot) // проверяем является ли слот фреймом
        {
            var result = slot.typeData == "frame";
            return result;
        }

        private void FillSlot(Slot slot) // процедура заполнения слота, нужна ли?
        {
            //if (!IsNullOrEmpty(slot.valueSlot))
            //{
            //    Method method = myKnowledgeBase.FindAttachedProcedure(slot.AttachedProcedure);
            //    slot.valueSlot = method.Execute();
            //}
        }

        private bool isSlotHasValue(string slotValue)
        {
            var result = slotValue != "";
            return result;
        }

        //абстрактный класс метод
        //имя метода
        //execute()
    }
}
