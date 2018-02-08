using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrmConfigrationDemo.Models
{
    public partial class dbPlayerContext : DbContext
    {
        public virtual DbSet<TblCricket> TblCricket { get; set; }
        public virtual DbSet<TblPlayerInfo> TblPlayerInfo { get; set; }

        public dbPlayerContext(DbContextOptions<dbPlayerContext>abc):base (abc)
        {
            //HERE IS THE CONSTRUCTOR FOR ORM
        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=HASSAN_NAWAZ;Database=dbPlayer;Trusted_Connection=True;User ID=masoom; Password=masoom;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCricket>(entity =>
            {
                entity.HasKey(e => e.MatchId);

                entity.ToTable("tblCricket");

                entity.Property(e => e.MatchId)
                    .HasColumnName("MatchID");
                   

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroundName)
                    .HasColumnName("groundName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPlayerInfo>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("tblPlayerInfo");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID");
                //remove uper line okk
                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Interest)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
