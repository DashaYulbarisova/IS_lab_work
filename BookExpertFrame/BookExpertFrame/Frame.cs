using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExpertFrame
{
    public enum typeFrameEnum { instanceFrame, classFrame };
    public class Frame
    {
        public string nameFrame;
        public List<Slot> slotFrame;
        public typeFrameEnum typeFrame ;
        public Frame(typeFrameEnum type)
        {
            typeFrame = type;            
        }
    }
}
