﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_Programlama__Proje.Models;

#nullable disable

namespace Web_Programlama__Proje.Migrations
{
    [DbContext(typeof(RendevuContext))]
    [Migration("20241222185150_PersoneHizmet_2")]
    partial class PersoneHizmet_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Web_Programlama__Proje.Models.Hizmetler", b =>
                {
                    b.Property<int>("HizmetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HizmetID"), 1L, 1);

                    b.Property<string>("HizmetAd")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HizmetSuresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HizmetUcreti")
                        .HasColumnType("float");

                    b.HasKey("HizmetID");

                    b.ToTable("Hizmetler");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"), 1L, 1);

                    b.Property<string>("PersonelAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonelSoyAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonelYetenekleri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelID");

                    b.ToTable("Personaller");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.PersonelHizmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("HizmetID")
                        .HasColumnType("int");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HizmetID");

                    b.HasIndex("PersonelID");

                    b.ToTable("PersonelHizmetler");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.Rendevu", b =>
                {
                    b.Property<int>("MusteriiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriiID"), 1L, 1);

                    b.Property<string>("MusteriAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MusteriMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MusteriSoyAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MusteriTelefonNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelID")
                        .HasColumnType("int");

                    b.Property<bool>("RendevuOnayDurumu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RendevuZaman")
                        .HasColumnType("datetime2");

                    b.HasKey("MusteriiID");

                    b.HasIndex("PersonelID");

                    b.ToTable("Rendevular");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.PersonelHizmet", b =>
                {
                    b.HasOne("Web_Programlama__Proje.Models.Hizmetler", "Hizmet")
                        .WithMany("PersonelHizmetler")
                        .HasForeignKey("HizmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web_Programlama__Proje.Models.Personel", "Personel")
                        .WithMany("PersonelHizmetler")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hizmet");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.Rendevu", b =>
                {
                    b.HasOne("Web_Programlama__Proje.Models.Personel", "Personel")
                        .WithMany("Rendevu")
                        .HasForeignKey("PersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.Hizmetler", b =>
                {
                    b.Navigation("PersonelHizmetler");
                });

            modelBuilder.Entity("Web_Programlama__Proje.Models.Personel", b =>
                {
                    b.Navigation("PersonelHizmetler");

                    b.Navigation("Rendevu");
                });
#pragma warning restore 612, 618
        }
    }
}
