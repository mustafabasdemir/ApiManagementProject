﻿// <auto-generated />
using System;
using ApiKeyManagementService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiKeyManagementService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiKeyManagementService.Models.ApiKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.IpAllowList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApiKeyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiKeyId");

                    b.ToTable("IpAllowLists");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.IpBlockList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IpBlockLists");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApiKeyId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApiKeyId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.RateLimit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApiKeyId")
                        .HasColumnType("int");

                    b.Property<int>("DailyLimit")
                        .HasColumnType("int");

                    b.Property<int>("Used")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApiKeyId");

                    b.ToTable("RateLimits");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.RequestLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApiKeyId")
                        .HasColumnType("int");

                    b.Property<string>("HttpMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResponseCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApiKeyId");

                    b.ToTable("RequestLogs");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.ApiKey", b =>
                {
                    b.HasOne("ApiKeyManagementService.Models.User", "User")
                        .WithMany("ApiKeys")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.IpAllowList", b =>
                {
                    b.HasOne("ApiKeyManagementService.Models.ApiKey", "ApiKey")
                        .WithMany("IpAllowLists")
                        .HasForeignKey("ApiKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.Permission", b =>
                {
                    b.HasOne("ApiKeyManagementService.Models.ApiKey", "ApiKey")
                        .WithMany("Permissions")
                        .HasForeignKey("ApiKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.RateLimit", b =>
                {
                    b.HasOne("ApiKeyManagementService.Models.ApiKey", "ApiKey")
                        .WithMany()
                        .HasForeignKey("ApiKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.RequestLog", b =>
                {
                    b.HasOne("ApiKeyManagementService.Models.ApiKey", "ApiKey")
                        .WithMany()
                        .HasForeignKey("ApiKeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApiKey");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.ApiKey", b =>
                {
                    b.Navigation("IpAllowLists");

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("ApiKeyManagementService.Models.User", b =>
                {
                    b.Navigation("ApiKeys");
                });
#pragma warning restore 612, 618
        }
    }
}
