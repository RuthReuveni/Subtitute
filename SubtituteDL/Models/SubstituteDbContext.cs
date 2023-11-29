using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SubtituteDL.Models;

public partial class SubstituteDbContext : DbContext
{
    public SubstituteDbContext()
    {
    }

    public SubstituteDbContext(DbContextOptions<SubstituteDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Duration> Durations { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<Network> Networks { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<Specialization> Specializations { get; set; }

    public virtual DbSet<SpecializationSubTtreq> SpecializationSubTtreqs { get; set; }

    public virtual DbSet<SpesializitionSubTt> SpesializitionSubTts { get; set; }

    public virtual DbSet<SubTt> SubTts { get; set; }

    public virtual DbSet<SubTtschool> SubTtschools { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-R5RADSP;Database=substituteDB;Trusted_Connection=True;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.AreasId);

            entity.Property(e => e.AreaName).HasMaxLength(50);
        });

        modelBuilder.Entity<Duration>(entity =>
        {
            entity.ToTable("Duration");

            entity.Property(e => e.DurationName).HasColumnType("numeric(18, 0)");
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.HasKey(e => e.IdLesson);

            entity.ToTable("Lesson");

            entity.Property(e => e.Sammary).HasMaxLength(50);
            entity.Property(e => e.Subject).HasMaxLength(50);

            entity.HasOne(d => d.Specialization).WithMany(p => p.Lessons)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lesson_Specialization");
        });

        modelBuilder.Entity<Network>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Network");

            entity.Property(e => e.NetworkId).ValueGeneratedOnAdd();
            entity.Property(e => e.NetworkName).HasMaxLength(50);
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.ToTable("Request");

            entity.Property(e => e.Classes).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("date");

            entity.HasOne(d => d.Duration).WithMany(p => p.Requests)
                .HasForeignKey(d => d.DurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Duration");

            entity.HasOne(d => d.Specialization).WithMany(p => p.Requests)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Specialization");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Requests)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Teacher");
        });

        modelBuilder.Entity<School>(entity =>
        {
            entity.ToTable("School");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.ManagerId).HasMaxLength(50);
            entity.Property(e => e.ManagerName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.SchoolName).HasMaxLength(50);
            entity.Property(e => e.SchoolPhone).HasMaxLength(50);

            entity.HasOne(d => d.Areas).WithMany(p => p.Schools)
                .HasForeignKey(d => d.AreasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_School_Areas");
        });

        modelBuilder.Entity<Specialization>(entity =>
        {
            entity.ToTable("Specialization");

            entity.Property(e => e.SpecializationName).HasMaxLength(50);
        });

        modelBuilder.Entity<SpecializationSubTtreq>(entity =>
        {
            entity.HasKey(e => e.SpecializationSubTtid);

            entity.ToTable("SpecializationSubTTReq");

            entity.Property(e => e.SpecializationSubTtid).HasColumnName("SpecializationSubTTId");

            entity.HasOne(d => d.Request).WithMany(p => p.SpecializationSubTtreqs)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpecializationSubTTReq_Request");

            entity.HasOne(d => d.Specialization).WithMany(p => p.SpecializationSubTtreqs)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpecializationSubTTReq_Specialization");
        });

        modelBuilder.Entity<SpesializitionSubTt>(entity =>
        {
            entity.ToTable("SpesializitionSubTT");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SubTtid).HasColumnName("SubTTId");

            entity.HasOne(d => d.Specialization).WithMany(p => p.SpesializitionSubTts)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpesializitionSubTT_Specialization");

            entity.HasOne(d => d.SubTt).WithMany(p => p.SpesializitionSubTts)
                .HasForeignKey(d => d.SubTtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpesializitionSubTT_SubTT");
        });

        modelBuilder.Entity<SubTt>(entity =>
        {
            entity.ToTable("SubTT");

            entity.Property(e => e.SubTtid).HasColumnName("SubTTId");
            entity.Property(e => e.CitySubTt)
                .HasMaxLength(50)
                .HasColumnName("CitySubTT");
            entity.Property(e => e.Comments).HasMaxLength(50);
            entity.Property(e => e.EmailSubTt)
                .HasMaxLength(50)
                .HasColumnName("EmailSubTT");
            entity.Property(e => e.IdNumberSubTt)
                .HasMaxLength(50)
                .HasColumnName("IdNumberSubTT");
            entity.Property(e => e.PhomeSubTt)
                .HasMaxLength(50)
                .HasColumnName("PhomeSubTT");
            entity.Property(e => e.Resume).HasMaxLength(50);
            entity.Property(e => e.SchoolId).HasColumnName("schoolId");
            entity.Property(e => e.StreetSubTt)
                .HasMaxLength(50)
                .HasColumnName("StreetSubTT");
            entity.Property(e => e.SubTtname)
                .HasMaxLength(50)
                .HasColumnName("SubTTName");

            entity.HasOne(d => d.Areas).WithMany(p => p.SubTts)
                .HasForeignKey(d => d.AreasId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubTT_Areas");

            entity.HasOne(d => d.Duration).WithMany(p => p.SubTts)
                .HasForeignKey(d => d.DurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubTT_Duration");

            entity.HasOne(d => d.School).WithMany(p => p.SubTts)
                .HasForeignKey(d => d.SchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubTT_School");
        });

        modelBuilder.Entity<SubTtschool>(entity =>
        {
            entity.ToTable("SubTTSchool");

            entity.Property(e => e.SubTtschoolId).HasColumnName("SubTTSchoolId");
            entity.Property(e => e.SubTtid).HasColumnName("SubTTId");

            entity.HasOne(d => d.School).WithMany(p => p.SubTtschools)
                .HasForeignKey(d => d.SchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubTTSchool_School");

            entity.HasOne(d => d.SubTt).WithMany(p => p.SubTtschools)
                .HasForeignKey(d => d.SubTtid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SubTTSchool_SubTT");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.ToTable("Teacher");

            entity.Property(e => e.EmailT).HasMaxLength(50);
            entity.Property(e => e.IdNumberT).HasMaxLength(50);
            entity.Property(e => e.PhoneT).HasMaxLength(50);
            entity.Property(e => e.SchoolId).HasColumnName("schoolId");
            entity.Property(e => e.TeacherName).HasMaxLength(50);

            entity.HasOne(d => d.School).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.SchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Teacher_School");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
