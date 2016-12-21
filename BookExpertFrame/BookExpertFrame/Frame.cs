using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExpertFrame
{
    public enum typeFrameEnum { instanceFrame, classFrame }; //связь наследование между ними //enum массив констант
    public class Frame
    {
        public string nameFrame;
        public List<Slot> slotFrame;
        public typeFrameEnum typeFrame; //НУЖНО ЛИ???
        public Frame(string name, Slot slot)
        {
            nameFrame = name;
            slotFrame.Add(slot);
    }
    }
}
