﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolDiary.api;

#nullable disable

namespace SchoolDiary.api.Migrations
{
    [DbContext(typeof(DiaryDbContext))]
    [Migration("20220712015914_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolDiary.api.Model.Person", b =>
                {
                    b.Property<Guid>("UserUUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserUUID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.PersonRole", b =>
                {
                    b.Property<int>("PersonRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonRoleID"), 1L, 1);

                    b.Property<int>("FK_RoleID")
                        .HasColumnType("int")
                        .HasColumnName("FK_RoleID");

                    b.Property<Guid>("FK_UserUUID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PersonRoleID");

                    b.HasIndex("FK_RoleID");

                    b.HasIndex("FK_UserUUID");

                    b.ToTable("PersonRole");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.PersonRole", b =>
                {
                    b.HasOne("SchoolDiary.api.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("FK_RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDiary.api.Model.Person", "Person")
                        .WithMany("Roles")
                        .HasForeignKey("FK_UserUUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.Person", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
