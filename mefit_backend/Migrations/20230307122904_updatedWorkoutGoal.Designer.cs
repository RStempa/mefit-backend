﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mefit_backend.models;

#nullable disable

namespace mefit_backend.Migrations
{
    [DbContext(typeof(MeFitDbContext))]
    [Migration("20230307122904_updatedWorkoutGoal")]
    partial class updatedWorkoutGoal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessProgramGoal", b =>
                {
                    b.Property<int>("FitnessProgramId")
                        .HasColumnType("int");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.HasKey("FitnessProgramId", "GoalId");

                    b.HasIndex("GoalId");

                    b.ToTable("FitnessProgramGoal");

                    b.HasData(
                        new
                        {
                            FitnessProgramId = 1,
                            GoalId = 1
                        });
                });

            modelBuilder.Entity("GoalWorkout", b =>
                {
                    b.Property<int>("GoalsId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutsId")
                        .HasColumnType("int");

                    b.HasKey("GoalsId", "WorkoutsId");

                    b.HasIndex("WorkoutsId");

                    b.ToTable("GoalWorkout");
                });

            modelBuilder.Entity("ImpairmentExercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("ImpairmentId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "ImpairmentId");

                    b.HasIndex("ImpairmentId");

                    b.ToTable("ImpairmentExercise");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            ImpairmentId = 1
                        });
                });

            modelBuilder.Entity("ImpairmentProfile", b =>
                {
                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("ImpairmentId")
                        .HasColumnType("int");

                    b.HasKey("ProfileId", "ImpairmentId");

                    b.HasIndex("ImpairmentId");

                    b.ToTable("ImpairmentProfile");

                    b.HasData(
                        new
                        {
                            ProfileId = 1,
                            ImpairmentId = 1
                        });
                });

            modelBuilder.Entity("WorkoutFitnessProgram", b =>
                {
                    b.Property<int>("FitnessProgramId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("FitnessProgramId", "WorkoutId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutFitnessProgram");

                    b.HasData(
                        new
                        {
                            FitnessProgramId = 1,
                            WorkoutId = 1
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdressLine = "Storgatan 1",
                            City = "Vaxjö",
                            Country = "Sweden",
                            PostalCode = 12345
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetMuscleGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Push up with arms",
                            ImageLink = "some link",
                            Name = "Pushup",
                            TargetMuscleGroup = "Biceps",
                            VideoLink = "some link"
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.FitnessProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FitnessPrograms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Upper body",
                            Name = "Program 1"
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Achieved")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Goals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Achieved = false,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProfileId = 1
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.Impairment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Impairments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cannot use legs",
                            Name = "I have no legs"
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Height = 180,
                            UserId = 1,
                            Weight = 80
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsContributor")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Test@test.com",
                            FirstName = "Urban",
                            IsAdmin = true,
                            IsContributor = true,
                            LastName = "Svensson",
                            Password = "password"
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Complete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Complete = false,
                            Name = "Power Hour",
                            Type = "Hardcore"
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.WorkoutExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("Repetition")
                        .HasColumnType("int");

                    b.Property<int>("Set")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutExercise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExerciseId = 1,
                            Repetition = 3,
                            Set = 5,
                            WorkoutId = 1
                        });
                });

            modelBuilder.Entity("mefit_backend.models.domain.WorkoutGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GoalId")
                        .HasColumnType("int");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GoalId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("WorkoutGoal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GoalId = 1,
                            WorkoutId = 1
                        });
                });

            modelBuilder.Entity("FitnessProgramGoal", b =>
                {
                    b.HasOne("mefit_backend.models.domain.FitnessProgram", null)
                        .WithMany()
                        .HasForeignKey("FitnessProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Goal", null)
                        .WithMany()
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoalWorkout", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Goal", null)
                        .WithMany()
                        .HasForeignKey("GoalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Workout", null)
                        .WithMany()
                        .HasForeignKey("WorkoutsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImpairmentExercise", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Impairment", null)
                        .WithMany()
                        .HasForeignKey("ImpairmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ImpairmentProfile", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Impairment", null)
                        .WithMany()
                        .HasForeignKey("ImpairmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Profile", null)
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WorkoutFitnessProgram", b =>
                {
                    b.HasOne("mefit_backend.models.domain.FitnessProgram", null)
                        .WithMany()
                        .HasForeignKey("FitnessProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Workout", null)
                        .WithMany()
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("mefit_backend.models.domain.Goal", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Profile", "Profile")
                        .WithMany("Goals")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("mefit_backend.models.domain.Profile", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Address", "Address")
                        .WithOne("Profile")
                        .HasForeignKey("mefit_backend.models.domain.Profile", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("mefit_backend.models.domain.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("mefit_backend.models.domain.WorkoutExercise", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Exercise", "Exercise")
                        .WithMany("WorkoutExercise")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Workout", "Workout")
                        .WithMany("WorkoutExercise")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("mefit_backend.models.domain.WorkoutGoal", b =>
                {
                    b.HasOne("mefit_backend.models.domain.Exercise", "Goal")
                        .WithMany()
                        .HasForeignKey("GoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mefit_backend.models.domain.Workout", "Workout")
                        .WithMany()
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Goal");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("mefit_backend.models.domain.Address", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("mefit_backend.models.domain.Exercise", b =>
                {
                    b.Navigation("WorkoutExercise");
                });

            modelBuilder.Entity("mefit_backend.models.domain.Profile", b =>
                {
                    b.Navigation("Goals");
                });

            modelBuilder.Entity("mefit_backend.models.domain.User", b =>
                {
                    b.Navigation("Profile")
                        .IsRequired();
                });

            modelBuilder.Entity("mefit_backend.models.domain.Workout", b =>
                {
                    b.Navigation("WorkoutExercise");
                });
#pragma warning restore 612, 618
        }
    }
}