﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace BridgingIT.DevKit.Examples.GettingStarted.Infrastructure.EntityFramework.Migrations;

[DbContext(typeof(AppDbContext))]
partial class AppDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.4")
            .HasAnnotation("Relational:MaxIdentifierLength", 128);

        SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

        modelBuilder.Entity("BridgingIT.DevKit.Examples.GettingStarted.Domain.Model.Customer", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnType("nvarchar(128)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnType("nvarchar(512)");

                b.HasKey("Id");

                b.ToTable("Customers", (string)null);
            });

        modelBuilder.Entity("BridgingIT.DevKit.Examples.GettingStarted.Domain.Model.Customer", b =>
            {
                b.OwnsOne("BridgingIT.DevKit.Examples.GettingStarted.Domain.Model.EmailAddress", "Email", b1 =>
                    {
                        b1.Property<Guid>("CustomerId")
                            .HasColumnType("uniqueidentifier");

                        b1.Property<string>("Value")
                            .IsRequired()
                            .HasMaxLength(256)
                            .HasColumnType("nvarchar(256)")
                            .HasColumnName("Email");

                        b1.HasKey("CustomerId");

                        b1.HasIndex("Value")
                            .IsUnique()
                            .HasFilter("[Email] IS NOT NULL");

                        b1.ToTable("Customers");

                        b1.WithOwner()
                            .HasForeignKey("CustomerId");
                    });

                b.Navigation("Email");
            });
#pragma warning restore 612, 618
    }
}
