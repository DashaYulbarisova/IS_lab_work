using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExpertFrame
{
    public class Slot
    {
        public string nameSlot;
        public string typeInheritance;
        public string typeData;
        public string valueSlot;
        public string AttachedProcedure;

        public Slot(string name, string inheritance, string data, string value, string procedure)
        {
            nameSlot = name;
            typeInheritance = inheritance;
            typeData = data;
            valueSlot = value;
            AttachedProcedure = procedure;
        }
    }
}
