﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RobsWebsiteV2.Data;

namespace RobsWebsiteV2.Migrations
{
    [DbContext(typeof(CalcTypesDbContext))]
    [Migration("20190120200910_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RobsWebsiteV2.Models.CalcType", b =>
                {
                    b.Property<int>("CalcTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CalcTypeName");

                    b.HasKey("CalcTypeId");

                    b.ToTable("CalcTypes");
                });

            modelBuilder.Entity("RobsWebsiteV2.Models.Calculations", b =>
                {
                    b.Property<int>("CalcId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CalcName");

                    b.Property<int?>("CalcTypeId");

                    b.HasKey("CalcId");

                    b.HasIndex("CalcTypeId");

                    b.ToTable("Calculations");
                });

            modelBuilder.Entity("RobsWebsiteV2.Models.Calculations", b =>
                {
                    b.HasOne("RobsWebsiteV2.Models.CalcType")
                        .WithMany("Calcs")
                        .HasForeignKey("CalcTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
