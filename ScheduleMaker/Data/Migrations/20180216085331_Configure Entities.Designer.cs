﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ScheduleMaker.Data;
using ScheduleMaker.Data.Models.Domain;
using System;

namespace ScheduleMaker.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180216085331_Configure Entities")]
    partial class ConfigureEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Classroom", b =>
                {
                    b.Property<int>("ClassroomId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .HasMaxLength(255);

                    b.HasKey("ClassroomId");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.ClassroomDetail", b =>
                {
                    b.Property<int>("ClassroomDetailId");

                    b.Property<string>("Corpus")
                        .HasMaxLength(255);

                    b.Property<string>("Floor")
                        .HasMaxLength(255);

                    b.Property<string>("Number")
                        .HasMaxLength(255);

                    b.HasKey("ClassroomDetailId");

                    b.ToTable("ClassroomDetail");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Course");

                    b.Property<int>("CurrentLessonId");

                    b.Property<string>("Facilty")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Specialication")
                        .HasMaxLength(255);

                    b.HasKey("GroupId");

                    b.HasIndex("CurrentLessonId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Lecturer", b =>
                {
                    b.Property<int>("LecturerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentLessonId");

                    b.Property<string>("FIO")
                        .HasMaxLength(255);

                    b.HasKey("LecturerId");

                    b.HasIndex("CurrentLessonId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.LecturerSubjects", b =>
                {
                    b.Property<int>("LecturerSubjectsId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountHours");

                    b.Property<int>("Credits");

                    b.Property<string>("DetailedData")
                        .HasMaxLength(255);

                    b.Property<int?>("LecturerId");

                    b.Property<int?>("SubjectId");

                    b.HasKey("LecturerSubjectsId");

                    b.HasIndex("LecturerId");

                    b.HasIndex("SubjectId");

                    b.ToTable("LecturerSubjects");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassroomId");

                    b.Property<byte>("Course");

                    b.Property<int>("DayOfWeek");

                    b.Property<int>("GroupNumber");

                    b.Property<int>("ScheduleId");

                    b.HasKey("LessonId");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArtistId")
                        .IsRequired();

                    b.HasKey("ScheduleId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Subject", b =>
                {
                    b.Property<int>("SubjectId");

                    b.Property<string>("Name");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ScheduleMaker.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.ClassroomDetail", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.Domain.Classroom", "Classroom")
                        .WithOne("ClassroomDetails")
                        .HasForeignKey("ScheduleMaker.Data.Models.Domain.ClassroomDetail", "ClassroomDetailId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Group", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.Domain.Lesson", "CurrentLesson")
                        .WithMany("Groups")
                        .HasForeignKey("CurrentLessonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Lecturer", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.Domain.Lesson", "CurrentLesson")
                        .WithMany("Lecturer")
                        .HasForeignKey("CurrentLessonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.LecturerSubjects", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.Domain.Lecturer", "Lecturer")
                        .WithMany("LecturerSubjects")
                        .HasForeignKey("LecturerId");

                    b.HasOne("ScheduleMaker.Data.Models.Domain.Subject", "Subject")
                        .WithMany("LecturerSubjects")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Lesson", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.Domain.Classroom", "Classroom")
                        .WithMany()
                        .HasForeignKey("ClassroomId");

                    b.HasOne("ScheduleMaker.Data.Models.Domain.Schedule", "Schedule")
                        .WithMany("Lessons")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Schedule", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.ApplicationUser", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ScheduleMaker.Data.Models.Domain.Subject", b =>
                {
                    b.HasOne("ScheduleMaker.Data.Models.Domain.Lesson", "Lesson")
                        .WithOne("Subject")
                        .HasForeignKey("ScheduleMaker.Data.Models.Domain.Subject", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
