using System.Collections.Generic;

namespace test_BD
{
    public class Organisator
    {
        public int Id { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Ivent> Ivents { get; set; }
    }
}