using System;
using System.Collections.Generic;
using G4Guidance.Models;
using G4Guidance.Models.Interface;
using G4Guidance.Models.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace G4Guidance
{
    public partial class G4GuidanceContext : DbContext
    {
        public G4GuidanceContext()
        {
        }

        public G4GuidanceContext(DbContextOptions<G4GuidanceContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<LoginInfo> LoginInfos { get; set; } = null!;
        public virtual DbSet<blogInfo> blogInfos { get; set; } = null!;
        public virtual DbSet<Playlist> playlistInfos { get; set; } = null!;
        public virtual DbSet<University> uniInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=G4Guidance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginInfo>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__LoginInf__536C85E5A87CF017");

                entity.ToTable("LoginInfo");

                entity.Property(e => e.Username)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity is University)
                {
                    var referenceEntity = entry.Entity as University;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedOn = DateTime.Now.ToString();
                            referenceEntity.CreatedBy = DataContainer.userifo;

                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.ModifitedOn = DateTime.Now.ToString();
                            referenceEntity.ModifiedBy = DataContainer.userifo;
                            break;
                        default:
                            break;
                    }
                }
                if (entry.Entity is blogInfo)
                {
                    var referenceEntity = entry.Entity as blogInfo;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedOn = DateTime.Now.ToString();
                            referenceEntity.CreatedBy = DataContainer.userifo;

                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.ModifitedOn = DateTime.Now.ToString();
                            referenceEntity.ModifiedBy = DataContainer.userifo;
                            break;
                        default:
                            break;
                    }
                }
                if (entry.Entity is Playlist)
                {
                    var referenceEntity = entry.Entity as Playlist;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedOn = DateTime.Now.ToString();
                            referenceEntity.CreatedBy = DataContainer.userifo;

                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.ModifitedOn = DateTime.Now.ToString();
                            referenceEntity.ModifiedBy = DataContainer.userifo;
                            break;
                        default:
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
