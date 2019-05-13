using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    public class Ivent
    {
        public Ivent()
        {
            Participants = new HashSet<Participant>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Organisator Organisator { get; set; }
        //[ForeignKey("Ivent_Organizating")]
      // public int Organizator { get; set; }
        //public virtual Ivent_Organizating Ivent_Organizating { get; set; }
        //public virtual Student Student { get; set; }
        //public virtual ICollection<Ivent_Organizating> Ivent_Organizatings { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
