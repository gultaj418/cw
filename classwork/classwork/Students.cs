using System;
using System.Collections.Generic;
using System.Text;

namespace classwork
{
    class Students
    {
        private static int _totalNo;
        public static int totalNo { get => _totalNo; }
        private static int _no;
        public int no { get => _no; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Students(string name,string surname)
        {
            _no++;
            _no = _totalNo;
            this.Name = name;
            this.Surname = surname;
        }
    }
}
