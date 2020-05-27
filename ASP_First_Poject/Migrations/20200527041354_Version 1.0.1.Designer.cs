﻿// <auto-generated />
using System;
using ASP_First_Poject.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_First_Poject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200527041354_Version 1.0.1")]
    partial class Version101
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP_First_Poject.Models.Camera", b =>
                {
                    b.Property<int>("CameraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FocalLength")
                        .HasColumnType("int");

                    b.Property<int>("Megapixel")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLength")
                        .HasColumnType("int");

                    b.Property<string>("Sensor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CameraID");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("ASP_First_Poject.Models.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Battery")
                        .HasColumnType("float");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MainCameraCameraID")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Ram")
                        .HasColumnType("int");

                    b.Property<int>("ScreenSize")
                        .HasColumnType("int");

                    b.Property<int?>("SelfieCameraCameraID")
                        .HasColumnType("int");

                    b.Property<string>("Speaker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Storage")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<DateTime>("YearManufact")
                        .HasColumnType("datetime2");

                    b.HasKey("PhoneID");

                    b.HasIndex("MainCameraCameraID");

                    b.HasIndex("SelfieCameraCameraID");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("ASP_First_Poject.Models.Phone", b =>
                {
                    b.HasOne("ASP_First_Poject.Models.Camera", "MainCamera")
                        .WithMany()
                        .HasForeignKey("MainCameraCameraID");

                    b.HasOne("ASP_First_Poject.Models.Camera", "SelfieCamera")
                        .WithMany()
                        .HasForeignKey("SelfieCameraCameraID");
                });
#pragma warning restore 612, 618
        }
    }
}
