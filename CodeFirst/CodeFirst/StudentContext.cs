using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst
{
    class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
