using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Book)
                .WithMany()
                .HasForeignKey(i => i.BookId);

            modelBuilder.Entity<TransactionItem>()
                .HasOne(ti => ti.Book)
                .WithMany()
                .HasForeignKey(ti => ti.BookId);

            modelBuilder.Entity<TransactionItem>()
                .HasOne(ti => ti.Transaction)
                .WithMany(t => t.TransactionItems)
                .HasForeignKey(ti => ti.TransactionId);
        }
    }
}
