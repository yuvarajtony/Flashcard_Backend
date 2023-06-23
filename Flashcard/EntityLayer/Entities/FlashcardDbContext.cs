using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityLayer.Entities;

public partial class FlashcardDbContext : DbContext
{
    public FlashcardDbContext()
    {
    }

    public FlashcardDbContext(DbContextOptions<FlashcardDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Flashcard> Flashcards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-G6S85J4G; Database=FLASHCARD_DB; Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Flashcard>(entity =>
        {
            entity.HasKey(e => e.FlashcardId).HasName("PK__flashcar__467571D2E0ED5742");

            entity.ToTable("flashcard");

            entity.Property(e => e.FlashcardId).HasColumnName("flashcard_id");
            entity.Property(e => e.Answer)
                .IsUnicode(false)
                .HasColumnName("answer");
            entity.Property(e => e.Question)
                .IsUnicode(false)
                .HasColumnName("question");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
