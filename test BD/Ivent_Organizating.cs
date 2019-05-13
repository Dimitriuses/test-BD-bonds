using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    class Ivent_Organizating
    {
        public int Id { get; set; }
        [ForeignKey("Ivent")]
        public int IventId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
        public virtual Ivent Ivent { get; set; }
    }
}
