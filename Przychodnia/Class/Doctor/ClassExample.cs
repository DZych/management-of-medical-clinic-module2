using System;
using System.Collections.Generic;
using System.Text;

namespace Przychodnia.Class.Doctor
{
    class ClassExample
    {
        public string date { get; set; }
        public string dayOfWeek { get; set; }
        public string start { get; set; }
        public string end { get; set; }

        public ClassExample(string date, string dayOfWeek , string start, string end)
        {
            this.date = date;
            this.dayOfWeek = dayOfWeek;
            this.start = start;
            this.end = end;
        }
    }
}
