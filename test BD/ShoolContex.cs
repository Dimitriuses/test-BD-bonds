using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_BD
{
    class ShoolContex : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Ivent> Ivents { get; set; }

        public virtual DbSet<Organisator> Ornanisators { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        //public virtual DbSet<Ivent_Organizating> Ivent_Organizatings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Organisator>()
            //.HasRequired<Student>(s => s.Student)
            //.WithOptional(w => w.Organisator);


            // configures one-to-many relationship
            // modelBuilder.Entity<Student>()
            // .HasMany<Ivent>(g => g.Ivents)
            // .WithRequired(s => s.Student)
            // .HasForeignKey<int>(s => s.Organizator);


            //modelBuilder.Entity<Ivent>()
            //    .HasRequired(s => s.Ivent_Organizating)
            //    .WithRequiredPrincipal(ad => ad.Ivent);


            //modelBuilder.Entity<Student>()
            //    .HasMany<Ivent>(s => s.Ivents)
            //    .WithMany(c => c.Participants)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("StudentRefId");
            //        cs.MapRightKey("IventRefId");
            //        cs.ToTable("StudentIvents");
            //    });
        }
    }
}

