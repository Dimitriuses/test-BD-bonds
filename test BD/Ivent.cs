using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    class Ivent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Student")]
        public int Organizator { get; set; }
        public virtual Student Student { get; set; }
        //public virtual Student Student { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
