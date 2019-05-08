﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyUpdateApi.Models;

namespace PropertyUpdateApi.Migrations
{
    [DbContext(typeof(PropertyUpdateApiContext))]
    partial class PropertyUpdateApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PropertyUpdateApi.Models.Property", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<long>("CreaterUserId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long>("DeleterUserId");

                    b.Property<DateTime>("DeletionTime");

                    b.Property<string>("Description");

                    b.Property<string>("ImgPath");

                    b.Property<string>("Name");

                    b.Property<string>("Province");

                    b.Property<long>("UpdaterUserId");

                    b.Property<DateTime>("UpdationTime");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Property");
                });
#pragma warning restore 612, 618
        }
    }
}