﻿// <auto-generated />
using System;
using FDT.Management.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FDT.Management.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230611080502_AddedItemsToProject")]
    partial class AddedItemsToProject
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DigitalTwinProjectId")
                        .HasColumnType("int");

                    b.Property<int>("DigitalTwinTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DigitalTwinProjectId");

                    b.ToTable("DigitalTwins");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinPropertyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DigitalTwinId")
                        .HasColumnType("int");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DigitalTwinId");

                    b.ToTable("DigitalTwinProps");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DigitalTwinTypes");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinEntity", b =>
                {
                    b.HasOne("FDT.Management.Persistence.Entities.DigitalTwinProject", null)
                        .WithMany("DigitalTwins")
                        .HasForeignKey("DigitalTwinProjectId");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinPropertyEntity", b =>
                {
                    b.HasOne("FDT.Management.Persistence.Entities.DigitalTwinEntity", "DigitalTwin")
                        .WithMany("Properties")
                        .HasForeignKey("DigitalTwinId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DigitalTwin");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinEntity", b =>
                {
                    b.Navigation("Properties");
                });

            modelBuilder.Entity("FDT.Management.Persistence.Entities.DigitalTwinProject", b =>
                {
                    b.Navigation("DigitalTwins");
                });
#pragma warning restore 612, 618
        }
    }
}
