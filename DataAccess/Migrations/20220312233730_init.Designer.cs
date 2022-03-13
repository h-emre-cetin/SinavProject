﻿// <auto-generated />
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SinavProjectContext))]
    [Migration("20220312233730_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Sik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DogruMu")
                        .HasColumnType("bit");

                    b.Property<string>("SikText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SoruId");

                    b.ToTable("Siks");
                });

            modelBuilder.Entity("Entities.Concrete.Sinav", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasariPuani")
                        .HasColumnType("int");

                    b.Property<string>("SinavAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SinavKategoriId")
                        .HasColumnType("int");

                    b.Property<int>("SinavSüresi")
                        .HasColumnType("int");

                    b.Property<string>("SınavAciklamasi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SinavKategoriId");

                    b.ToTable("Sinavs");
                });

            modelBuilder.Entity("Entities.Concrete.SinavKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SinavKategoris");
                });

            modelBuilder.Entity("Entities.Concrete.Soru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoruKategoriId")
                        .HasColumnType("int");

                    b.Property<int>("SoruTipi")
                        .HasColumnType("int");

                    b.Property<string>("Sorular")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SoruKategoriId");

                    b.ToTable("Sorus");
                });

            modelBuilder.Entity("Entities.Concrete.SoruKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SoruKategoriAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SoruKategoris");
                });

            modelBuilder.Entity("Entities.Concrete.Sik", b =>
                {
                    b.HasOne("Entities.Concrete.Soru", "Soru")
                        .WithMany()
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Soru");
                });

            modelBuilder.Entity("Entities.Concrete.Sinav", b =>
                {
                    b.HasOne("Entities.Concrete.SinavKategori", "SinavKategori")
                        .WithMany()
                        .HasForeignKey("SinavKategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SinavKategori");
                });

            modelBuilder.Entity("Entities.Concrete.Soru", b =>
                {
                    b.HasOne("Entities.Concrete.SoruKategori", "SoruKategori")
                        .WithMany()
                        .HasForeignKey("SoruKategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SoruKategori");
                });
#pragma warning restore 612, 618
        }
    }
}
