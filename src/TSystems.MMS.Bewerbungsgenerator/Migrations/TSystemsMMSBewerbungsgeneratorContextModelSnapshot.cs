﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TSystems.MMS.Bewerbungsgenerator.Models;

namespace TSystems.MMS.Bewerbungsgenerator.Migrations
{
    [DbContext(typeof(TSystemsMMSBewerbungsgeneratorContext))]
    partial class TSystemsMMSBewerbungsgeneratorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("FristName");

                    b.Property<string>("LastName");

                    b.Property<string>("Motivation");

                    b.Property<string>("Organisation");

                    b.Property<bool>("Study");

                    b.Property<string>("Telephone");

                    b.Property<string>("TheRight");

                    b.HasKey("Id");

                    b.ToTable("Form");
                });
#pragma warning restore 612, 618
        }
    }
}