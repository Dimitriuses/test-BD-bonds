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
            modelBuilder.Entity<Ivent>()
            .HasMany<Student>(g => g.Students)
            .WithRequired(s => s.Ivent)
            .HasForeignKey<int>(s => s.Organizating);

            modelBuilder.Entity<Student>()
                .HasMany<Ivent>(s => s.Ivents)
                .WithMany(c => c.Students)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentRefId");
                    cs.MapRightKey("IventRefId");
                    cs.ToTable("StudentIvents");
                });
        }
    }
}

