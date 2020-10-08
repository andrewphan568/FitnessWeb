namespace FitnessClassWeb.Models.MVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCModel : DbContext
    {
        public MVCModel()
            : base("name=MVCModel")
        {
        }

        public virtual DbSet<FitnessClasses> FitnessClasses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FitnessClasses>()
                .Property(e => e.classTitle)
                .IsUnicode(false);

            modelBuilder.Entity<FitnessClasses>()
                .Property(e => e.classDescription)
                .IsUnicode(false);
            
            modelBuilder.Entity<FitnessClasses>()
                .Property(e => e.thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<FitnessClasses>()
                .Property(e => e.image)
                .IsUnicode(false);
        }
    }
}
