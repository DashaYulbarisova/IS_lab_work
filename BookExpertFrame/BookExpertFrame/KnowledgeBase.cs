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
        public List<Slot> listSlot;

        public KnowledgeBase()
        {
            listSlot.Add(new Slot("назначение", "unique", "", "", ""));
            listSlot.Add(new Slot("название", "unique", "", "", ""));
            listSlot.Add(new Slot("автор", "unique", "", "", ""));
            listSlot.Add(new Slot("объём", "unique", "", "", ""));
            listFrame.Add(new Frame("книги", listSlot, null));
        }
        public Frame getFrameByName(string nameFrame) // ДАША!!!!!!!!!!!
        {
            return new Frame(null, null);
        }

        //вернет слот по его имени, передаем фрейм
    }
}
