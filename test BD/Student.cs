using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Ivent Ivent { get; set; }

        public virtual ICollection<Ivent> Ivents { get; set; }
    }
}
