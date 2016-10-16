using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
   
    public abstract class Rules // абстрактный класс правило
    {
        public abstract void readMyself(); // считывает в себя (добавить возвращаемый тип значения)
        public abstract void saveMyself(); // сохраняет себя 
        
        
    }
    
}
