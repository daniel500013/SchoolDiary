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
    [Migration("20220714210607_update-db-8")]
    partial class updatedb8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolDiary.api.Model.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassID"), 1L, 1);

                    b.Property<int>("ClassNumber")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.Parent", b =>
                {
                    b.Property<int>("ParentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("ParentID");

                    b.ToTable("Parent");
                });

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

            modelBuilder.Entity("SchoolDiary.api.Model.PersonClass", b =>
                {
                    b.Property<int>("UserClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserClassID"), 1L, 1);

                    b.Property<int>("FK_ClassID")
                        .HasColumnType("int");

                    b.Property<Guid>("FK_UserUUID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserClassID");

                    b.HasIndex("FK_ClassID");

                    b.HasIndex("FK_UserUUID");

                    b.ToTable("UserClass");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.PersonParent", b =>
                {
                    b.Property<int>("PersonParentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonParentID"), 1L, 1);

                    b.Property<int?>("FK_ParentID")
                        .HasColumnType("int");

                    b.Property<Guid>("FK_UserUUID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PersonParentID");

                    b.HasIndex("FK_ParentID");

                    b.HasIndex("FK_UserUUID");

                    b.ToTable("PersonParent");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.PersonRole", b =>
                {
                    b.Property<int>("PersonRoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonRoleID"), 1L, 1);

                    b.Property<int>("FK_RoleID")
                        .HasColumnType("int");

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

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Name = "Student"
                        },
                        new
                        {
                            RoleID = 2,
                            Name = "Parent"
                        },
                        new
                        {
                            RoleID = 3,
                            Name = "Teacher"
                        },
                        new
                        {
                            RoleID = 4,
                            Name = "Tutor"
                        },
                        new
                        {
                            RoleID = 5,
                            Name = "LocalAdmin"
                        },
                        new
                        {
                            RoleID = 6,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("SchoolDiary.api.Model.PersonClass", b =>
                {
                    b.HasOne("SchoolDiary.api.Model.Class", "Class")
                        .WithMany()
                        .HasForeignKey("FK_ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolDiary.api.Model.Person", "Person")
                        .WithMany("Class")
                        .HasForeignKey("FK_UserUUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("SchoolDiary.api.Model.PersonParent", b =>
                {
                    b.HasOne("SchoolDiary.api.Model.Parent", "Parent")
                        .WithMany()
                        .HasForeignKey("FK_ParentID");

                    b.HasOne("SchoolDiary.api.Model.Person", "Person")
                        .WithMany("Parent")
                        .HasForeignKey("FK_UserUUID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent");

                    b.Navigation("Person");
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
                    b.Navigation("Class");

                    b.Navigation("Parent");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}