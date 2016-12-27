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
        public string IS_A;
        //public typeFrameEnum typeFrame;
        public Frame(string name, List<Slot> slot, string link)
        {
            nameFrame = name;
            slotFrame = slot;
            IS_A = link;
        }
    }
}
