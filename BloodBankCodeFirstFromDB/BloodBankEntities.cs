using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BloodBankCodeFirstFromDB
{
    public partial class BloodBankEntities : DbContext
    {
        public BloodBankEntities()
            : base("name=BloodBankConnection")
        {
        }

        public virtual DbSet<BloodDeposit> BloodDeposits { get; set; }
        public virtual DbSet<BloodType> BloodTypes { get; set; }
        public virtual DbSet<BloodWithdrawal> BloodWithdrawals { get; set; }
        public virtual DbSet<BloodWithdrawalUnit> BloodWithdrawalUnits { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
        public virtual DbSet<Donor> Donors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodDeposit>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BloodDeposit>()
                .HasMany(e => e.BloodWithdrawalUnits)
                .WithRequired(e => e.BloodDeposit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BloodType>()
                .Property(e => e.BloodType1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BloodType>()
                .HasMany(e => e.BloodDeposits)
                .WithRequired(e => e.BloodType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BloodType>()
                .HasMany(e => e.Donations)
                .WithRequired(e => e.BloodType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BloodType>()
                .HasMany(e => e.Donors)
                .WithRequired(e => e.BloodType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BloodWithdrawal>()
                .HasMany(e => e.BloodWithdrawalUnits)
                .WithRequired(e => e.BloodWithdrawal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.BloodWithdrawals)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Donor>()
                .Property(e => e.DonorPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Donor>()
                .HasMany(e => e.Donations)
                .WithRequired(e => e.Donor)
                .WillCascadeOnDelete(false);
        }
    }
}
