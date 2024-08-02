using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using Prema.ChamaOne.Api.Backend.Models.Location;
using Prema.ChamaOne.Api.Backend.Models;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using Prema.ChamaOne.Api.Backend.Database.LocationData;


namespace Prema.ChamaOne.Api.Backend.Database
{
    public partial class ChamaOneDatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ChamaOneDatabaseContext(DbContextOptions<ChamaOneDatabaseContext> options) : base(options)
        {
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Gender>()
                .HasMany(g => g.Members)
                .WithOne(m => m.Gender)
                .HasForeignKey(m => m.fk_gender_id)
                .HasPrincipalKey(g => g.id);
            builder.Entity<Member>()
                .HasOne(m => m.Gender)
                .WithMany(g => g.Members)
                .HasForeignKey(m => m.fk_gender_id)
                .HasPrincipalKey(g => g.id);
            builder.Entity<Member>()
                .HasOne(x => x.MemberType)
                .WithMany(x => x.Members)
                .HasForeignKey(x => x.fk_member_type_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Member>()
                .HasOne(x => x.Occupation)
                .WithMany(x => x.Members)
                .HasForeignKey(x => x.fk_occupation_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Member>()
                .HasOne(x => x.Ward)
                .WithMany(x => x.Members)
                .HasForeignKey(x => x.fk_residence_location_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<MemberType>()
                .HasMany(x => x.Members)
                .WithOne(x => x.MemberType)
                .HasForeignKey(x => x.fk_member_type_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Occupation>()
                .HasMany(x => x.Members)
                .WithOne(x => x.Occupation)
                .HasForeignKey(x => x.fk_occupation_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<TransactionType>()
                .HasMany(x => x.Transactions)
                .WithOne(x => x.TransactionType)
                .HasForeignKey(x => x.fk_transaction_type_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Subcounty>()
                .HasOne(i => i.County)
                .WithMany(i => i.Subcounties)
                .HasForeignKey(i => i.fk_county_id)
                .HasPrincipalKey(i => i.id);
            builder.Entity<Ward>()
                .HasOne(i => i.Subcounty)
                .WithMany(i => i.Wards)
                .HasForeignKey(i => i.fk_subcounty_id)
                .HasPrincipalKey(i => i.id);
            builder.Entity<Ward>()
                .HasMany(i => i.Members)
                .WithOne(i => i.Ward)
                .HasForeignKey(i => i.fk_residence_location_id)
                .HasPrincipalKey(i => i.id);
            builder.Entity<SMSRecord>()
                .HasMany(i => i.SMSFailures)
                .WithOne(i => i.SMSRecord)
                .HasForeignKey(i => i.fk_sms_record_id)
                .HasPrincipalKey(i => i.id);
            builder.Entity<SMSFailure>()
                .HasOne(i => i.SMSRecord)
                .WithMany(i => i.SMSFailures)
                .HasForeignKey(i => i.fk_sms_record_id)
                .HasPrincipalKey(i => i.id);

            // TransactionStatus configuration
            builder.Entity<TransactionStatus>()
                .HasKey(ts => ts.id);

            builder.Entity<TransactionStatus>()
                .HasMany(ts => ts.Loans)
                .WithOne(te => te.TransactionStatus)
                .HasForeignKey(te => te.fk_transaction_status_id);

            builder.Entity<TransactionStatus>()
                .HasMany(ts => ts.Contributions)
                .WithOne(te => te.TransactionStatus)
                .HasForeignKey(te => te.fk_transaction_status_id);

            // Transaction configuration
            builder.Entity<Transaction>()
                .HasKey(t => t.id);

            builder.Entity<Transaction>()
                .Property(t => t.date)
                .IsRequired();

            builder.Entity<Transaction>()
                .Property(t => t.date_of_record)
                .IsRequired();

            builder.Entity<Transaction>()
                .Property(t => t.amount)
                .IsRequired();

            builder.Entity<Transaction>()
                .Property(t => t.description)
                .IsRequired();

            builder.Entity<Transaction>()
                .Property(t => t.reference)
                .IsRequired();

            builder.Entity<Transaction>()
                .HasOne(t => t.TransactionType)
                .WithMany(tt => tt.Transactions)
                .HasForeignKey(t => t.fk_transaction_type_id);

            builder.Entity<Transaction>()
                .HasOne(t => t.TransactionEntityType)
                .WithMany(tet => tet.Transactions)
                .HasForeignKey(t => t.fk_transaction_entity_type_id);

            builder.Entity<Transaction>()
                .HasOne(t => t.TransactionEntity)
                .WithMany()
                .HasForeignKey(t => t.fk_transaction_entity_id)
                .OnDelete(DeleteBehavior.Cascade);

            // Contribution configuration
            builder.Entity<Contribution>()
                .HasOne(c => c.Member)
                .WithMany(c => c.Contributions)
                .HasForeignKey(c => c.fk_member_id)
                .HasPrincipalKey(c => c.id);


            builder.Entity<Contribution>()
                .Property(c => c.amount)
                .IsRequired();

            builder.Entity<Contribution>()
                .Property(c => c.penalty)
                .IsRequired();

            builder.Entity<Contribution>()
                .Property(c => c.contribution_period)
                .IsRequired();

            // Loan configuration
            builder.Entity<Loan>()
                .HasOne(l => l.Member)
                .WithMany(l => l.Loans)
                .HasForeignKey(l => l.fk_member_id)
                .HasPrincipalKey(l => l.id);


            builder.Entity<Loan>()
                .Property(l => l.principal)
                .IsRequired();

            builder.Entity<Loan>()
                .Property(l => l.interest_rate)
                .IsRequired();

            builder.Entity<Loan>()
                .Property(l => l.interest)
                .IsRequired();

            builder.Entity<Loan>()
                .Property(l => l.penalty)
                .IsRequired();

            builder.Entity<Loan>()
                .Property(l => l.date_due)
                .IsRequired();

            this.OnModelBuilding(builder);

            builder.Entity<Gender>().HasData(
                new Gender { id = 1, name = "Male" },
                new Gender { id = 2, name = "Female" }
            );

            builder.Entity<MemberType>().HasData(
                new MemberType { id = 1, name = "Member" },
                new MemberType { id = 2, name = "Director" },
                new MemberType { id = 3, name = "Deputy Director" },
                new MemberType { id = 4, name = "Secratary" },
                new MemberType { id = 5, name = "Deputy Secratary" },
                new MemberType { id = 6, name = "Treasurer" }
            );

            builder.Entity<Occupation>().HasData(
                new Occupation { id = 1, name = "Student" },
                new Occupation { id = 2, name = "Employed" },
                new Occupation { id = 3, name = "Self Employed" }
            );

            builder.Entity<TransactionEntityType>().HasData(
                new TransactionEntityType { id = 1, name = "Contribution" },
                new TransactionEntityType { id = 2, name = "Loan" },
                new TransactionEntityType { id = 3, name = "Project" },
                new TransactionEntityType { id = 4, name = "Welfare" }
            );

            builder.Entity<TransactionType>().HasData(
                new TransactionType { id = 1, name = "Contribution Payment" },
                new TransactionType { id = 2, name = "Loan Disbursement" },
                new TransactionType { id = 3, name = "Loan Payment" },
                new TransactionType { id = 4, name = "Project Expense" },
                new TransactionType { id = 5, name = "Project Income" },
                new TransactionType { id = 6, name = "Welfare Disbursement" }
            );

            builder.Entity<TransactionStatus>().HasData(
                new TransactionStatus { id = TransactionStatusEnum.Paid, name = "Paid" },
                new TransactionStatus { id = TransactionStatusEnum.Pending, name = "Pending" },
                new TransactionStatus { id = TransactionStatusEnum.Overdue, name = "Overdue" }
            );

            var csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Database", "LocationData", "kenya-location-data.csv");
            var records = LoadLocationData.LoadCsvData(csvFilePath);

            var counties = records.Select(r => r.Item1).DistinctBy(c => c.id).ToList();
            var subcounties = records.Select(r => r.Item2).DistinctBy(c => c.id).ToList();
            var wards = records.Select(r => r.Item3).DistinctBy(w => w.id).ToList();

            builder.Entity<County>().HasData(counties);
            builder.Entity<Subcounty>().HasData(subcounties);
            builder.Entity<Ward>().HasData(wards);

        }


        public DbSet<Gender> Gender { get; set; }
        public DbSet<County> County { get; set; }
        public DbSet<Subcounty> Subcounty { get; set; }
        public DbSet<Ward> Ward { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<MemberType> MemberType { get; set; }
        public DbSet<Occupation> Occupation { get; set; }
        public DbSet<TransactionStatus> TransactionStatus { get; set; }
        public DbSet<Contribution> Contribution { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionEntityType> TransactionEntityType { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<SMSRecord> SMSRecord { get; set; }
        public DbSet<SMSFailure> SMSFailure { get; set; }
    }

}