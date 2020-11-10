namespace _21_lucene
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserCenterDbContext : DbContext
    {
        public UserCenterDbContext()
            : base("name=UserCenter")
        {
        }

        public virtual DbSet<Colp_Term_Detail> Colp_Term_Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Parent_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Organization_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Department_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Equipment_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Create_User_Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colp_Term_Detail>()
                .Property(e => e.Modified_User_Id)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
