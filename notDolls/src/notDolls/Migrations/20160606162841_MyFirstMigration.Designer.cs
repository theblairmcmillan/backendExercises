using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using notDolls.Models;

namespace notDolls.Migrations
{
    [DbContext(typeof(NotDollsContext))]
    [Migration("20160606162841_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("notDolls.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Height");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quanity");

                    b.Property<bool>("Sold");

                    b.Property<string>("Weight");

                    b.Property<double>("sellerId");

                    b.Property<int>("year");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("notDolls.Models.InventoryImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<int>("InventoryId");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("notDolls.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<string>("Location");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
        }
    }
}
