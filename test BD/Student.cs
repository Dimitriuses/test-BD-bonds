﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // [ForeignKey("Ivent")]
     //  public int Organizating { get; set; }
       // public virtual Ivent Ivent { get; set; }
        //public virtual Ivent_Organizating Ivent_Organizating { get; set; }
        //public virtual ICollection<Ivent_Organizating> Ivent_Organizatings { get; set; }

        public virtual Organisator Organisator { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
