﻿// <auto-generated />
using System;
using Cars.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cars.DataContext.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cars.Model.EntreprisesModel", b =>
                {
                    b.Property<int>("Entrepriseid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Entrepriseid"));

                    b.Property<bool>("ContratActif")
                        .HasColumnType("bit");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Entrepriseid");

                    b.ToTable("Entreprises");

                    b.HasData(
                        new
                        {
                            Entrepriseid = 1,
                            ContratActif = true,
                            Nom = "Entreprise A"
                        },
                        new
                        {
                            Entrepriseid = 2,
                            ContratActif = false,
                            Nom = "Entreprise B"
                        },
                        new
                        {
                            Entrepriseid = 3,
                            ContratActif = true,
                            Nom = "Entreprise C"
                        },
                        new
                        {
                            Entrepriseid = 4,
                            ContratActif = true,
                            Nom = "Entreprise D"
                        });
                });

            modelBuilder.Entity("Cars.Model.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("EntrepriseId")
                        .HasColumnType("int");

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
                        .IsRequired()
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

                    b.HasIndex("EntrepriseId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b1d8162e-550d-4202-917c-884109c87540",
                            Email = "admin@example.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAkQROgsoOpkdJKXw268Cmu3tSlXmtxsXu8bpVmEILsWLJMbmteIx2eh33+8medb7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7b0db5e8-4ee1-4b2e-aaf6-aef7ac35b926",
                            TwoFactorEnabled = false,
                            UserName = "admin@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "946dd7ce-14a4-4c3e-8310-51f3a2b47792",
                            Email = "client1@example.com",
                            EmailConfirmed = false,
                            EntrepriseId = 1,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT1@EXAMPLE.COM",
                            NormalizedUserName = "CLIENT1@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEMe54UJQ8Ce5Pffz4TsBp0eRIa0envLODjs11wBGhVRl++7Y0NOMdPD+elYgKMWfQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5cd24d5f-b496-4842-b722-695b5b8e5c5c",
                            TwoFactorEnabled = false,
                            UserName = "client1@example.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4c72eaa5-4a70-4156-96c1-ee1c28a19bdd",
                            Email = "client2@example.com",
                            EmailConfirmed = false,
                            EntrepriseId = 2,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT2@EXAMPLE.COM",
                            NormalizedUserName = "CLIENT2@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI4wlW8zaYF+oibdyvR3CjjMa3NjGDtqFf48hsYL/kwMLavlIFOkfgY6+plK/GX9sQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3c83ac46-0b56-4d04-a50d-6c3c1133dec3",
                            TwoFactorEnabled = false,
                            UserName = "client2@example.com"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "91f07286-7d53-4334-ba30-8509f6544284",
                            Email = "client3@example.com",
                            EmailConfirmed = false,
                            EntrepriseId = 3,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT3@EXAMPLE.COM",
                            NormalizedUserName = "CLIENT3@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDGf+CduXdSknaMDq7pHs5m6tmeqhndxuxsIr7tfC330L57xXB6J7053ZCZGv0x0Rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d23393f5-6b4d-4282-925e-ba562ff1526f",
                            TwoFactorEnabled = false,
                            UserName = "client3@example.com"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a006d198-dbe0-40ce-9f3a-1f8b02dba975",
                            Email = "client4@example.com",
                            EmailConfirmed = false,
                            EntrepriseId = 4,
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT4@EXAMPLE.COM",
                            NormalizedUserName = "CLIENT4@EXAMPLE.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPEZxa7uy3yy6RxKcrYHNQeJ4J1nx+FpluvCvi+QMGR6/ed62FfO5wpcPS4A+3qLIA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "521099b0-98e7-4975-9c9f-1758c00fab3b",
                            TwoFactorEnabled = false,
                            UserName = "client4@example.com"
                        });
                });

            modelBuilder.Entity("Cars.Model.SalariesModel", b =>
                {
                    b.Property<int>("Salarieid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Salarieid"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Entrepriseid")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Vehiculeid")
                        .HasColumnType("int");

                    b.HasKey("Salarieid");

                    b.HasIndex("Entrepriseid");

                    b.HasIndex("Vehiculeid")
                        .IsUnique()
                        .HasFilter("[Vehiculeid] IS NOT NULL");

                    b.ToTable("Salaries");

                    b.HasData(
                        new
                        {
                            Salarieid = 1,
                            Email = "john.doe@example.com",
                            Entrepriseid = 1,
                            Nom = "John",
                            Prenom = "Doe",
                            Vehiculeid = 1
                        },
                        new
                        {
                            Salarieid = 2,
                            Email = "jane.smith@example.com",
                            Entrepriseid = 2,
                            Nom = "Jane",
                            Prenom = "Smith",
                            Vehiculeid = 2
                        },
                        new
                        {
                            Salarieid = 3,
                            Email = "alice.johnson@example.com",
                            Entrepriseid = 1,
                            Nom = "Alice",
                            Prenom = "Johnson"
                        });
                });

            modelBuilder.Entity("Cars.Model.VehiculesModel", b =>
                {
                    b.Property<int>("Vehiculeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vehiculeid"));

                    b.Property<int>("EntrepriseID")
                        .HasColumnType("int");

                    b.Property<string>("Immatriculation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("statut")
                        .HasColumnType("bit");

                    b.HasKey("Vehiculeid");

                    b.HasIndex("EntrepriseID");

                    b.ToTable("Vehicules");

                    b.HasData(
                        new
                        {
                            Vehiculeid = 1,
                            EntrepriseID = 1,
                            Immatriculation = "ABC123",
                            Marque = "Toyota",
                            Modele = "Corolla",
                            Nom = "Vehicle1",
                            description = "Bon etat",
                            statut = true
                        },
                        new
                        {
                            Vehiculeid = 2,
                            EntrepriseID = 2,
                            Immatriculation = "DEF456",
                            Marque = "Honda",
                            Modele = "Civic",
                            Nom = "Vehicle2",
                            description = "Bon etat",
                            statut = true
                        });
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
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Client",
                            NormalizedName = "CLIENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "4",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "5",
                            RoleId = "2"
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

            modelBuilder.Entity("Cars.Model.Identity.User", b =>
                {
                    b.HasOne("Cars.Model.EntreprisesModel", "Entreprise")
                        .WithMany("Users")
                        .HasForeignKey("EntrepriseId");

                    b.Navigation("Entreprise");
                });

            modelBuilder.Entity("Cars.Model.SalariesModel", b =>
                {
                    b.HasOne("Cars.Model.EntreprisesModel", "Entreprise")
                        .WithMany("Salaries")
                        .HasForeignKey("Entrepriseid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Cars.Model.VehiculesModel", "Vehicule")
                        .WithOne("Salarie")
                        .HasForeignKey("Cars.Model.SalariesModel", "Vehiculeid")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Entreprise");

                    b.Navigation("Vehicule");
                });

            modelBuilder.Entity("Cars.Model.VehiculesModel", b =>
                {
                    b.HasOne("Cars.Model.EntreprisesModel", "Entreprise")
                        .WithMany("Vehicules")
                        .HasForeignKey("EntrepriseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entreprise");
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
                    b.HasOne("Cars.Model.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Cars.Model.Identity.User", null)
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

                    b.HasOne("Cars.Model.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Cars.Model.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Cars.Model.EntreprisesModel", b =>
                {
                    b.Navigation("Salaries");

                    b.Navigation("Users");

                    b.Navigation("Vehicules");
                });

            modelBuilder.Entity("Cars.Model.VehiculesModel", b =>
                {
                    b.Navigation("Salarie");
                });
#pragma warning restore 612, 618
        }
    }
}
