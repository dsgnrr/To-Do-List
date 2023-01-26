using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    [Serializable]
    public class Deal
    {
        public string list_name { get; set; }
        //every deal have status: current,overdue,completed 
        public int status { get; set; }
        //haven't be empty
        public string deal { get; set; }
        public string text_time { get; set; }
        public MyDate date { get; set; }
        public MyTime time { get; set; }
        public string priority { get; set; }
        public string comment { get; set; }
        public override string ToString()
        {
            return $"Task: {deal}  Date: {date}";
        }
    }
}
