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
            builder.Entity<Contribution>()
                .HasOne(c => c.Member)
                .WithMany(m => m.Contributions)
                .HasForeignKey(c => c.fk_member_id)
                .HasPrincipalKey(m => m.id);
            builder.Entity<Contribution>()
                .HasMany(x => x.Transactions)
                .WithOne(x => x.Contribution)
                .HasForeignKey(x => x.fk_transaction_entity_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Contribution>()
                .HasOne(x => x.TransactionStatus)
                .WithMany(x => x.Contributions)
                .HasForeignKey(x => x.fk_transaction_status_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<TransactionStatus>()
                .HasMany(x => x.Contributions)
                .WithOne(x => x.TransactionStatus)
                .HasForeignKey(x => x.fk_transaction_status_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<TransactionStatus>()
                .HasMany(x => x.Loans)
                .WithOne(x => x.TransactionStatus)
                .HasForeignKey(x => x.fk_transaction_status_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Loan>()
                .HasOne(x => x.Member)
                .WithMany(x => x.Loans)
                .HasForeignKey(x => x.fk_member_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Loan>()
                .HasMany(x => x.Transactions)
                .WithOne(x => x.Loan)
                .HasForeignKey(x => x.fk_transaction_entity_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Loan>()
                .HasOne(x => x.TransactionStatus)
                .WithMany(x => x.Loans)
                .HasForeignKey(x => x.fk_transaction_status_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Transaction>()
                .HasOne(x => x.Contribution)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.fk_transaction_entity_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Transaction>()
                .HasOne(x => x.Loan)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.fk_transaction_entity_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Transaction>()
                .HasOne(x => x.TransactionEntityType)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.fk_transaction_entity_type_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<Transaction>()
                .HasOne(x => x.TransactionType)
                .WithMany(x => x.Transactions)
                .HasForeignKey(x => x.fk_transaction_type_id)
                .HasPrincipalKey(x => x.id);
            builder.Entity<TransactionEntityType>()
                .HasMany(x => x.Transactions)
                .WithOne(x => x.TransactionEntityType)
                .HasForeignKey(x => x.fk_transaction_entity_type_id)
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
    }

}