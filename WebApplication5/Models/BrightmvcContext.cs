using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.models;

public partial class BrightmvcContext : DbContext
{
    public BrightmvcContext()
    {
    }

    public BrightmvcContext(DbContextOptions<BrightmvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=VISHNU\\SQLEXPRESS;database=BRIGHTMVC; trusted_connection=true; trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC073231BFA7");

            entity.ToTable("EMPLOYEES");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MEMBERS__3214EC07F8537C88");

            entity.ToTable("MEMBERS");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Duration)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("duration");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate)
                .HasColumnType("date")
                .HasColumnName("joining_date");
            entity.Property(e => e.Mobile)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TEACHERS__3214EC278D4CE83A");

            entity.ToTable("TEACHERS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
