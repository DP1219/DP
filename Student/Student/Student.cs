using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        string firstname;
        string lastname;
        int idno;
        string course;
        DateTime joindate;
        public Student() { }
        public Student(string fn,string ln)
        {
            firstname = fn;
            lastname = ln;
        }
        public string Name
        {
            get
            {
                return string.Format("{0} {1}", firstname, lastname);
            }
        }
        public int Idno
        {
            get { return idno; }
            set { idno = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime Joindate
        {
            get { return joindate; }
            set { joindate = value; }
        }
    }
}
