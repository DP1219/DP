using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.SqlClient;

namespace CodeFirstExample
{
    class StudentContext:DbContext
    {
        public virtual DbSet<Student1> Students { get; set; }

    }
}
