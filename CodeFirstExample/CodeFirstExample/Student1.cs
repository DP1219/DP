using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CodeFirstExample
{
    class Student1
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public string Location { get; set; }
    }
}
