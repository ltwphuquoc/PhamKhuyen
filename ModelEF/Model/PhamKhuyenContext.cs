namespace ModelEF.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PhamKhuyenContext : DbContext
    {
        public PhamKhuyenContext()
            : base("name=PhamKhuyenContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<UserAcount> UserAcounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.UnitCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Status)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<UserAcount>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<UserAcount>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<UserAcount>()
                .Property(e => e.Status)
                .IsFixedLength();
        }
    }
}
