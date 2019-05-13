using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    public class Participant
    {
        public int Id { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Ivent> Ivents { get; set; }
    }
}
