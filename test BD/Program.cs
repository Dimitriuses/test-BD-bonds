using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoolContex ctx = new ShoolContex();
            Student vasa = new Student { Name = "VASA" };
            Student tolik = new Student { Name = "TOLIK" };
            var org = new Organisator { Students = new List<Student> { vasa } };
            var par = new Participant { Students = new List<Student> { tolik } };
            var par1 = new Participant { Students = new List<Student> { vasa } };
            Ivent ivent = new Ivent { Name = "Das ist FANTASTISCH", Organisator = org,Participants = new List<Participant> { par, par1 } };
            //vasa.Organizating = ivent.Id;
            
            //ctx.Students.Add(vasa);
           // ctx.Students.Add(tolik);
            ctx.Ivents.Add(ivent);

            ctx.SaveChanges();

        }
    }
}
