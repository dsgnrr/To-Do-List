using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    [Serializable]
    public class MyDate
    {
        public int mounth { get; set; } 
        public int day { get; set; } 
        public int year { get; set; }
        public override string ToString()
        {
            return $"{mounth}.{day}.{year}";
        }
        public MyDate()
        {
            mounth = day = year = 0;
        }
        public MyDate(int mounth,int day,int year)
        {
            this.mounth = mounth;
            this.day = day;
            this.year = year;
        }
        public static bool operator ==(MyDate obj1, MyDate obj2)
        {
            if (obj1.day == obj2.day || obj1.mounth == obj2.mounth || obj1.year == obj2.year)
                return true;
            else return false;
        }
        public static bool operator !=(MyDate obj1, MyDate obj2)
        {
            if (obj1.day != obj2.day || obj1.mounth != obj2.mounth || obj1.year != obj2.year)
                return true;
            else return false;
        }
    }
}
