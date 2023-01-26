using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    [Serializable]
    public class MyTime
    {
        public int hour { get; set; }
        public int minutes { get; set; }
        public MyTime()
        {
            hour = minutes = 0;
        }
        public MyTime(int hour,int minutes)
        {
            this.hour = hour;
            this.minutes = minutes;
        }
        public override string ToString()
        {
            return $"{hour}:{minutes}";
        }
        public static bool operator ==(MyTime obj1, MyTime obj2)
        {
            if (obj1.hour == obj2.hour || obj1.minutes == obj2.minutes) 
                return true;
            else return false;
        }
        public static bool operator !=(MyTime obj1, MyTime obj2)
        {
            if (obj1.hour == obj2.hour || obj1.minutes == obj2.minutes)
                return true;
            else return false;
        }
    }
}
