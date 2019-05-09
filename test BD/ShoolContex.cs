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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Student>()
                //.HasRequired<Ivent>(s => s.Ivent)
                //.WithMany(g => g.Recivers)
                //.HasForeignKey<int>(s => s.Id);
                .HasOptional(a => a.Ivent)
                .WithRequired(a => a.Student);

            modelBuilder.Entity<Student>()
                .HasMany<Ivent>(s => s.Ivents)
                .WithMany(c => c.Recivers)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentRefId");
                    cs.MapRightKey("IventRefId");
                    cs.ToTable("StudentIvents");
                });
        }
    }
}

