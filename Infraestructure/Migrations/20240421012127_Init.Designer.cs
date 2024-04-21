﻿// <auto-generated />
using System;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240421012127_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.ApplicationStatusTypes", b =>
                {
                    b.Property<int>("ApplicationStatusTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationStatusTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationStatusTypeId");

                    b.ToTable("ApplicationStatusType", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Applications", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationId"));

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ApplicationStatusTypeId")
                        .HasColumnType("int");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ApplicationId");

                    b.HasIndex("ApplicationStatusTypeId");

                    b.HasIndex("OfferId");

                    b.ToTable("Application", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cities", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("City", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Countries", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.JobOfferModes", b =>
                {
                    b.Property<int>("JobOfferModeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobOfferModeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobOfferModeId");

                    b.ToTable("JobOfferMode", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OfferCategories", b =>
                {
                    b.Property<int>("OfferCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferCategoryId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("OfferCategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OfferId");

                    b.ToTable("OfferCategory", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.OfferSkills", b =>
                {
                    b.Property<int>("OfferSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferSkillId"));

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("OfferSkillId");

                    b.HasIndex("OfferId");

                    b.HasIndex("SkillId");

                    b.ToTable("OfferSkill", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Offers", b =>
                {
                    b.Property<Guid>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AvailabilityChangeOfResidence")
                        .HasColumnType("bit");

                    b.Property<bool>("AvailabilityToTravel")
                        .HasColumnType("bit");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobOfferModeId")
                        .HasColumnType("int");

                    b.Property<int?>("MaxAge")
                        .HasColumnType("int");

                    b.Property<int>("MaxSalary")
                        .HasColumnType("int");

                    b.Property<int?>("MinAge")
                        .HasColumnType("int");

                    b.Property<int>("MinSalary")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("StudyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vacancies")
                        .HasColumnType("int");

                    b.HasKey("OfferId");

                    b.HasIndex("CityId");

                    b.HasIndex("JobOfferModeId");

                    b.HasIndex("StudyTypeId");

                    b.ToTable("Offer", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Provinces", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinceId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.HasIndex("CountryId");

                    b.ToTable("Province", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Skills", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skill", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.StudyTypes", b =>
                {
                    b.Property<int>("StudyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudyTypeId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudyTypeId");

                    b.ToTable("StudyType", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Applications", b =>
                {
                    b.HasOne("Domain.Entities.ApplicationStatusTypes", "ApplicationStatusType")
                        .WithMany("Applications")
                        .HasForeignKey("ApplicationStatusTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Offers", "Offer")
                        .WithMany("Applications")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationStatusType");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Domain.Entities.Cities", b =>
                {
                    b.HasOne("Domain.Entities.Provinces", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Domain.Entities.OfferCategories", b =>
                {
                    b.HasOne("Domain.Entities.Categories", "Category")
                        .WithMany("OfferCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Offers", "Offer")
                        .WithMany("OfferCategories")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("Domain.Entities.OfferSkills", b =>
                {
                    b.HasOne("Domain.Entities.Offers", "Offer")
                        .WithMany("OfferSkills")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Skills", "Skill")
                        .WithMany("OfferSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Offer");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("Domain.Entities.Offers", b =>
                {
                    b.HasOne("Domain.Entities.Cities", "City")
                        .WithMany("Offers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.JobOfferModes", "JobOfferMode")
                        .WithMany("Offers")
                        .HasForeignKey("JobOfferModeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.StudyTypes", "StudyType")
                        .WithMany("Offers")
                        .HasForeignKey("StudyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("JobOfferMode");

                    b.Navigation("StudyType");
                });

            modelBuilder.Entity("Domain.Entities.Provinces", b =>
                {
                    b.HasOne("Domain.Entities.Countries", "Country")
                        .WithMany("Provinces")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Domain.Entities.ApplicationStatusTypes", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("Domain.Entities.Categories", b =>
                {
                    b.Navigation("OfferCategories");
                });

            modelBuilder.Entity("Domain.Entities.Cities", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Domain.Entities.Countries", b =>
                {
                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("Domain.Entities.JobOfferModes", b =>
                {
                    b.Navigation("Offers");
                });

            modelBuilder.Entity("Domain.Entities.Offers", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("OfferCategories");

                    b.Navigation("OfferSkills");
                });

            modelBuilder.Entity("Domain.Entities.Provinces", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Domain.Entities.Skills", b =>
                {
                    b.Navigation("OfferSkills");
                });

            modelBuilder.Entity("Domain.Entities.StudyTypes", b =>
                {
                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
