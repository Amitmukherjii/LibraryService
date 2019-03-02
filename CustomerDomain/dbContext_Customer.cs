using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CustomerDomain
{
    public partial class dbContext_Customer : DbContext
    {
        public dbContext_Customer()
        {
        }

        public dbContext_Customer(DbContextOptions<dbContext_Customer> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-CJUGQSSD;Initial Catalog=LibraryDB;Integrated Security=True");
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID");

                entity.Property(e => e.AddedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasColumnName("Customer_Address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBorrowedBooks).HasColumnName("Customer_Borrowed_Books");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNumber).HasColumnName("Customer_Number");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}