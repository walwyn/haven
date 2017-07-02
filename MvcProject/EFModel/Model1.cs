namespace MvcProject.EFModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
