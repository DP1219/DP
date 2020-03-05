using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst
{
    class Student
    {
        [Key]
        public int Sid { get; set; }
        public string FullName { get; set; }

    }
}
