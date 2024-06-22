﻿using System.Reflection;
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


namespace Prema.ChamaOne.Api.Backend.Database
{
    public partial class ChamaOneDatabaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ChamaOneDatabaseContext(DbContextOptions<ChamaOneDatabaseContext> options) : base(options)
        {
        }

        public ChamaOneDatabaseContext()
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


            this.OnModelBuilding(builder);
        }


        public DbSet<Gender> Genders { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Subcounty> SubCounties { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }

}