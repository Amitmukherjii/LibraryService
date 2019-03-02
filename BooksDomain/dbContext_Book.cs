using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BooksDomain
{
    public partial class dbContext_Book : DbContext
    {
        public dbContext_Book()
        {
        }

        public dbContext_Book(DbContextOptions<dbContext_Book> options)
            : base(options)
        {
        }

        public virtual DbSet<BookDetail> BookDetails { get; set; }

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

            modelBuilder.Entity<BookDetail>(entity =>
            {
                entity.HasKey(e => e.BookID)
                    .HasName("PK__BookDeta__C223F3942395CF4A");

                entity.Property(e => e.AddedBy).IsUnicode(false);

                entity.Property(e => e.BookDescription).IsUnicode(false);

                entity.Property(e => e.BookName).IsUnicode(false);

                entity.Property(e => e.ImageName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}