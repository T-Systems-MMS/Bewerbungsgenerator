﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TSystems.MMS.Bewerbungsgenerator.Models;

namespace TSystems.MMS.Bewerbungsgenerator.Migrations
{
    [DbContext(typeof(TSystemsMMSBewerbungsgeneratorContext))]
    [Migration("20190205091753_AddTwoStages")]
    partial class AddTwoStages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TSystems.MMS.Bewerbungsgenerator.Models.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accepted");

                    b.Property<DateTime>("FirstInvitation");

                    b.Property<string>("FristName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Motivation")
                        .IsRequired();

                    b.Property<string>("Organisation")
                        .IsRequired();

                    b.Property<bool>("Study");

                    b.Property<string>("Telephone")
                        .IsRequired();

                    b.Property<string>("TheRight")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Form");
                });
#pragma warning restore 612, 618
        }
    }
}
