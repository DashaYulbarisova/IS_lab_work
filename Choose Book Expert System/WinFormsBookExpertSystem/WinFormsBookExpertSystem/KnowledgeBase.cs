using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class KnowledgeBase // класс база знаний
    {
        private Rules[] rulesPool; // массив правил
        public Rules[] propRulesPool // свойство для чтения и редактирования массива правил
        {
            get { return rulesPool; }
            set { rulesPool = value; }
        }
        public KnowledgeBase() // конструктор
        {

        }
        public void saveToFile() // функция сохранения базы знаний в файл
        { }
        public void readFromFile() // функция чтения базы знаний из файла
        { }
    }
}
