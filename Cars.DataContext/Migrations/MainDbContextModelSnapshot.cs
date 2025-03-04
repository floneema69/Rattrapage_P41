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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
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

                    b.Property<string>("statut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                            statut = "Active"
                        },
                        new
                        {
                            Vehiculeid = 2,
                            EntrepriseID = 2,
                            Immatriculation = "DEF456",
                            Marque = "Honda",
                            Modele = "Civic",
                            Nom = "Vehicle2",
                            statut = "Inactive"
                        });
                });

            modelBuilder.Entity("Cars.Model.SalariesModel", b =>
                {
                    b.HasOne("Cars.Model.EntreprisesModel", "Entreprise")
                        .WithMany("Salaries")
                        .HasForeignKey("Entrepriseid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Cars.Model.VehiculesModel", "Vehicule")
                        .WithOne()
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

            modelBuilder.Entity("Cars.Model.EntreprisesModel", b =>
                {
                    b.Navigation("Salaries");

                    b.Navigation("Vehicules");
                });
#pragma warning restore 612, 618
        }
    }
}
