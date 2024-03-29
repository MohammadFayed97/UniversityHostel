﻿// <auto-generated />
using System;
using CommonLibrary.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace UniversityHostel.Server.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220615213406_AddApplicationSettings")]
    partial class AddApplicationSettings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Applications.Server.Entities.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BasicInformationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<Guid?>("DocumentsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Applications", (string)null);
                });

            modelBuilder.Entity("Applications.Server.Entities.ApplicationDocument", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<Guid>("DocumentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId")
                        .IsUnique();

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.ToTable("ApplicationDocument", (string)null);
                });

            modelBuilder.Entity("Applications.Server.Entities.ApplicationDocuments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<Guid?>("Document1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Document2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Document3Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId")
                        .IsUnique();

                    b.HasIndex("Document1Id");

                    b.HasIndex("Document2Id");

                    b.ToTable("ApplicationDocuments", (string)null);
                });

            modelBuilder.Entity("Applications.Server.Entities.BasicInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<double>("Degree")
                        .HasColumnType("float");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FatherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherJob")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("GuardianId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuardianRelationship")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HousingType")
                        .HasColumnType("int");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFamilyOutside")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSpecialNeeds")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSecondLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PreviousGPA")
                        .HasColumnType("float");

                    b.Property<int>("Religion")
                        .HasColumnType("int");

                    b.Property<Guid>("ResidenceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StudentCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId")
                        .IsUnique();

                    b.HasIndex("FacultyId");

                    b.HasIndex("ResidenceId");

                    b.ToTable("BasicInformations", (string)null);
                });

            modelBuilder.Entity("ApplicationSettings.Server.Entities.ApplicationSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool>("IsRegistrationEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PhaseEndTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ApplicationSettings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e9bb6388-d68d-4346-9981-3a0e8150498f"),
                            CreationDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisplayOrder = 0,
                            IsRegistrationEnabled = true,
                            PhaseEndTime = new DateTime(2022, 6, 22, 23, 34, 6, 228, DateTimeKind.Local).AddTicks(4844)
                        });
                });

            modelBuilder.Entity("Cities.Server.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSecondLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Documents.Server.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("Faculties.Server.Entities.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSecondLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "da80425e-f97f-469b-98ef-bd481b034777",
                            ConcurrencyStamp = "77e77a97-bc4f-4939-a514-2343e2a74f7d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e9bb6388-d68d-4346-9981-3a0e8150498f",
                            ConcurrencyStamp = "747ed223-8b87-4e50-bd6e-07376372feef",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                            RoleId = "da80425e-f97f-469b-98ef-bd481b034777"
                        },
                        new
                        {
                            UserId = "cca1c549-094b-4c45-a9c1-9960068e7f51",
                            RoleId = "e9bb6388-d68d-4346-9981-3a0e8150498f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Payments.Server.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<double>("PaidAmount")
                        .HasColumnType("float");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Payments", (string)null);
                });

            modelBuilder.Entity("Residences.Server.Entities.Residence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameSecondLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Residences", (string)null);
                });

            modelBuilder.Entity("Account.Server.Entities.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("AppUser");

                    b.HasData(
                        new
                        {
                            Id = "5bf8f6b4-3e44-43f8-bf14-b5b1298f0bd7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b133f53d-6271-40aa-9da6-5277acf84c91",
                            Email = "Admin@hostel.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOwGtdLEQY96A7cFWG3RnOx2RR7FtV1T44bii1pxvxscUAADyOsBLXHP4DTBliXrVQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "69c9e6f1-846f-4d25-9a55-8700ffd6a625",
                            TwoFactorEnabled = false,
                            UserName = "Admin",
                            FullName = "Adminstrator",
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = "cca1c549-094b-4c45-a9c1-9960068e7f51",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "83a3314a-51ca-4b86-b2e6-19989ba2f4e0",
                            Email = "user@hostel.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEG5hOvqRsCuNj7F1XOb7LuEm9b2eMPdv4KFUxzLeIo+RC/iNOGwFksk4qh8pg5AdIw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7810534c-a01c-4154-9d17-997c379b6535",
                            TwoFactorEnabled = false,
                            UserName = "user",
                            FullName = "Default User",
                            RefreshTokenExpiryTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Applications.Server.Entities.Application", b =>
                {
                    b.HasOne("Payments.Server.Entities.Payment", "Payment")
                        .WithOne()
                        .HasForeignKey("Applications.Server.Entities.Application", "PaymentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Account.Server.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Applications.Server.Entities.ApplicationDocument", b =>
                {
                    b.HasOne("Applications.Server.Entities.ApplicationDocuments", null)
                        .WithOne("Document3")
                        .HasForeignKey("Applications.Server.Entities.ApplicationDocument", "ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Documents.Server.Entities.Document", "Document")
                        .WithOne()
                        .HasForeignKey("Applications.Server.Entities.ApplicationDocument", "DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");
                });

            modelBuilder.Entity("Applications.Server.Entities.ApplicationDocuments", b =>
                {
                    b.HasOne("Applications.Server.Entities.Application", null)
                        .WithOne("Documents")
                        .HasForeignKey("Applications.Server.Entities.ApplicationDocuments", "ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Applications.Server.Entities.ApplicationDocument", "Document1")
                        .WithMany()
                        .HasForeignKey("Document1Id");

                    b.HasOne("Applications.Server.Entities.ApplicationDocument", "Document2")
                        .WithMany()
                        .HasForeignKey("Document2Id");

                    b.Navigation("Document1");

                    b.Navigation("Document2");
                });

            modelBuilder.Entity("Applications.Server.Entities.BasicInformation", b =>
                {
                    b.HasOne("Applications.Server.Entities.Application", null)
                        .WithOne("BasicInformation")
                        .HasForeignKey("Applications.Server.Entities.BasicInformation", "ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Faculties.Server.Entities.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Residences.Server.Entities.Residence", "Residence")
                        .WithMany()
                        .HasForeignKey("ResidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Residence");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Payments.Server.Entities.Payment", b =>
                {
                    b.HasOne("Account.Server.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Applications.Server.Entities.Application", b =>
                {
                    b.Navigation("BasicInformation");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("Applications.Server.Entities.ApplicationDocuments", b =>
                {
                    b.Navigation("Document3");
                });
#pragma warning restore 612, 618
        }
    }
}
