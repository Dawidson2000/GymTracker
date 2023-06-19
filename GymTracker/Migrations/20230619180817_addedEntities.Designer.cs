﻿// <auto-generated />
using System;
using GymTracker.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymTracker.Migrations
{
    [DbContext(typeof(GymTrackerContext))]
    [Migration("20230619180817_addedEntities")]
    partial class addedEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymTracker.Entities.ExerciseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrimaryMuscle")
                        .HasColumnType("int");

                    b.Property<int>("SecondaryMuscle")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("GymTracker.Entities.SetEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Distance")
                        .HasColumnType("int");

                    b.Property<int?>("Reps")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.Property<Guid>("WorkoutExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutExerciseId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("GymTracker.Entities.WorkoutEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("GymTracker.Entities.WorkoutExerciseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkoutEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutEntityId");

                    b.ToTable("WorkoutExercises");
                });

            modelBuilder.Entity("GymTracker.Entities.SetEntity", b =>
                {
                    b.HasOne("GymTracker.Entities.WorkoutExerciseEntity", "WorkoutExercise")
                        .WithMany("Sets")
                        .HasForeignKey("WorkoutExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkoutExercise");
                });

            modelBuilder.Entity("GymTracker.Entities.WorkoutExerciseEntity", b =>
                {
                    b.HasOne("GymTracker.Entities.ExerciseEntity", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GymTracker.Entities.WorkoutEntity", null)
                        .WithMany("Workouts")
                        .HasForeignKey("WorkoutEntityId");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("GymTracker.Entities.WorkoutEntity", b =>
                {
                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("GymTracker.Entities.WorkoutExerciseEntity", b =>
                {
                    b.Navigation("Sets");
                });
#pragma warning restore 612, 618
        }
    }
}
