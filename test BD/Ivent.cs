using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    class Ivent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Student Organizator { get; set; }
        //public virtual Student Student { get; set; }
        public virtual ICollection<Student> Recivers { get; set; }
    }
}
