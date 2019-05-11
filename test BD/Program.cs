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
            Ivent ivent = new Ivent { Name = "Das ist FANTASTISCH", Organizator = vasa.Id, Students = new List<Student> { vasa, tolik } };
            //vasa.Organizating = ivent.Id;
            
            ctx.Students.Add(vasa);
            ctx.Students.Add(tolik);
            ctx.Ivents.Add(ivent);

            ctx.SaveChanges();

        }
    }
}
