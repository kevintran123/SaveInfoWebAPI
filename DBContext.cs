namespace IT4230.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }

        public DBContext(string connString)
            : base(connString)
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .Property(e => e.AltID)
                .IsUnicode(false);

            modelBuilder.Entity<APL6Users>()
                .Property(e => e.Phone)
                .IsUnicode(false);
        }
    }
}
