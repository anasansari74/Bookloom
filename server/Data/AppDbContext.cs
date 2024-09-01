using Microsoft.EntityFrameworkCore;
using Server.DataModels;

namespace Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Optionally override OnConfiguring if not configured in Program.cs
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("YourConnectionStringHere");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Inventory to Book relationship
            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Book)
                .WithMany()
                .HasForeignKey(i => i.BookId)
                .OnDelete(DeleteBehavior.Cascade); // Added delete behavior

            // Configure TransactionItem to Book relationship
            modelBuilder.Entity<TransactionItem>()
                .HasOne(ti => ti.Book)
                .WithMany()
                .HasForeignKey(ti => ti.BookId)
                .OnDelete(DeleteBehavior.Cascade); // Added delete behavior

            // Configure TransactionItem to Transaction relationship
            modelBuilder.Entity<TransactionItem>()
                .HasOne(ti => ti.Transaction)
                .WithMany(t => t.TransactionItems)
                .HasForeignKey(ti => ti.TransactionId)
                .OnDelete(DeleteBehavior.Cascade); // Added delete behavior
        }
    }
}