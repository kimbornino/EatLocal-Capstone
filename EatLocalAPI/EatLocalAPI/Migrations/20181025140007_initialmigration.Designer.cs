﻿// <auto-generated />
using System;
using EatLocalAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EatLocalAPI.Migrations
{
    [DbContext(typeof(EatLocalContext))]
    [Migration("20181025140007_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EatLocalAPI.Models.Markets", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio");

                    b.Property<string>("CityStateZip");

                    b.Property<int>("FridayEnd");

                    b.Property<int>("FridayStart");

                    b.Property<string>("Link");

                    b.Property<int>("MondayEnd");

                    b.Property<int>("MondayStart");

                    b.Property<string>("Name");

                    b.Property<int>("SaturdayEnd");

                    b.Property<int>("SaturdayStart");

                    b.Property<DateTime>("SeasonClose");

                    b.Property<DateTime>("SeasonOpen");

                    b.Property<string>("StreetAddress");

                    b.Property<int>("SundayEnd");

                    b.Property<int>("SundayStart");

                    b.Property<int>("ThursdayEnd");

                    b.Property<int>("ThursdayStart");

                    b.Property<int>("TuesdayEnd");

                    b.Property<int>("TuesdayStart");

                    b.Property<int>("WednesayStart");

                    b.Property<int>("WednesdayEnd");

                    b.HasKey("ID");

                    b.ToTable("Markets");
                });
#pragma warning restore 612, 618
        }
    }
}
