﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketShop.EventCatalog.Data;

#nullable disable

namespace TicketShop.EventCatalog.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketShop.EventCatalog.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Sports"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Concerts"
                        });
                });

            modelBuilder.Entity("TicketShop.EventCatalog.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EventId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            Artist = "Beyonce",
                            CategoryId = 2,
                            Date = new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9754),
                            Name = "Beyonce in concert",
                            Price = 300m
                        },
                        new
                        {
                            EventId = 2,
                            Artist = "GNR",
                            CategoryId = 2,
                            Date = new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9769),
                            Name = "Guns N Roses Tour",
                            Price = 500m
                        },
                        new
                        {
                            EventId = 3,
                            Artist = "ATLUS",
                            CategoryId = 2,
                            Date = new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9771),
                            Name = "Persona Live Concert",
                            Price = 400m
                        },
                        new
                        {
                            EventId = 4,
                            Artist = "MonolithSoft",
                            CategoryId = 2,
                            Date = new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9773),
                            Name = "Xenoblade Orchestra",
                            Price = 500m
                        },
                        new
                        {
                            EventId = 5,
                            Artist = "None",
                            CategoryId = 2,
                            Date = new DateTime(2024, 3, 19, 20, 51, 49, 593, DateTimeKind.Local).AddTicks(9775),
                            Name = "AC Milan vs Inter FC",
                            Price = 700m
                        });
                });

            modelBuilder.Entity("TicketShop.EventCatalog.Models.Event", b =>
                {
                    b.HasOne("TicketShop.EventCatalog.Models.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TicketShop.EventCatalog.Models.Category", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
