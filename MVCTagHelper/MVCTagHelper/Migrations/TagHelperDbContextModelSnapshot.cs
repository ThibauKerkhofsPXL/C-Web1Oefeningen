﻿// <auto-generated />
using MVCTagHelper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCTagHelper.Migrations
{
    [DbContext(typeof(TagHelperDbContext))]
    partial class TagHelperDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCTagHelper.Models.Afdeling", b =>
                {
                    b.Property<int>("AfdelingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AfdelingId"), 1L, 1);

                    b.Property<string>("AfdelingNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocatieId")
                        .HasColumnType("int");

                    b.HasKey("AfdelingId");

                    b.HasIndex("LocatieId");

                    b.ToTable("Afdelingen");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Land", b =>
                {
                    b.Property<int>("LandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LandId"), 1L, 1);

                    b.Property<string>("LandCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LandId");

                    b.ToTable("Landen");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Locatie", b =>
                {
                    b.Property<int>("LocatieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocatieId"), 1L, 1);

                    b.Property<int>("LandId")
                        .HasColumnType("int");

                    b.Property<string>("Stad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocatieId");

                    b.HasIndex("LandId");

                    b.ToTable("Locaties");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Medewerker", b =>
                {
                    b.Property<int>("MedewerkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedewerkerId"), 1L, 1);

                    b.Property<int>("AfdelingId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedewerkerId");

                    b.ToTable("Medewerker");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Afdeling", b =>
                {
                    b.HasOne("MVCTagHelper.Models.Locatie", "Locatie")
                        .WithMany("Afdelingen")
                        .HasForeignKey("LocatieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locatie");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Locatie", b =>
                {
                    b.HasOne("MVCTagHelper.Models.Land", "Land")
                        .WithMany("Locaties")
                        .HasForeignKey("LandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Land");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Land", b =>
                {
                    b.Navigation("Locaties");
                });

            modelBuilder.Entity("MVCTagHelper.Models.Locatie", b =>
                {
                    b.Navigation("Afdelingen");
                });
#pragma warning restore 612, 618
        }
    }
}
