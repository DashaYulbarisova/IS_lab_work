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
        private List<AttachedProcedure> attachedProcedures;

        private void CreateNewSlot(int type)
        {
            switch (type)
            {
                case 1:
                    listSlot.Add(new Slot("назначение", "U", "", "", ""));
                    listSlot.Add(new Slot("название", "U", "", "", ""));
                    listSlot.Add(new Slot("автор", "U", "", "", ""));
                    listSlot.Add(new Slot("объём", "U", "", "", ""));
                    break;
                case 2:
                    listSlot.Add(new Slot("назначение", "U", "string", "в дорогу", ""));
                    listSlot.Add(new Slot("название", "U", "string", "", ""));
                    listSlot.Add(new Slot("автор", "U", "frame", "", "")); //должна быть процедура
                    listSlot.Add(new Slot("объём", "unique", "string", "до 200 страниц", ""));
                    break;
                case 3:
                    listSlot.Add(new Slot("назначение", "U", "string", "дома", ""));
                    listSlot.Add(new Slot("название", "U", "", "", ""));
                    listSlot.Add(new Slot("автор", "U", "frame", "", ""));
                    listSlot.Add(new Slot("объём", "unique", "string", "более 200 страниц", ""));
                    break;
                case 4:
                    listSlot.Add(new Slot("ФИО", "U", "string", "", ""));
                    listSlot.Add(new Slot("жанр", "U", "", "", ""));
                    break;
            }
        }

        public KnowledgeBase()
        {
            CreateNewSlot(1);
            listFrame.Add(new Frame("книги", listSlot, null));
            listSlot.Clear();
            CreateNewSlot(2);
            listFrame.Add(new Frame("книга в дорогу", listSlot, "IS_A"));
            listSlot.Clear();
            CreateNewSlot(3);
            listFrame.Add(new Frame("книга дома", listSlot, "IS_A"));
            listSlot.Clear();
            CreateNewSlot(4);
            listFrame.Add(new Frame("автор", listSlot, null));
            listSlot.Clear();

        }
        public Frame getFrameByName(string nameFrame) // ДАША!!!!!!!!!!!
        {
            return new Frame(name: null, slot: null, link: null);
        }

        //вернет слот по его имени, передаем фрейм

        public AttachedProcedure FindAttachedProcedure(string nameAttachedProcedure)
        {
            foreach (AttachedProcedure attachedProcedure in attachedProcedures)
            {
                if (attachedProcedure.nameAttachedProcedure == nameAttachedProcedure)
                {
                    return attachedProcedure;
                }
            }
            return null;
        }
    }
}
