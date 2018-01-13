﻿// <auto-generated />
using HagDataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HagDataLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180104230705_Another")]
    partial class Another
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HagDataLayer.Models.Levels", b =>
                {
                    b.Property<Guid>("LevelId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumberLevel");

                    b.Property<Guid?>("PlanetId");

                    b.Property<Guid?>("PlanetsPlanetId");

                    b.Property<Guid?>("QuestionsQuestionId");

                    b.HasKey("LevelId");

                    b.HasIndex("PlanetId");

                    b.HasIndex("PlanetsPlanetId");

                    b.HasIndex("QuestionsQuestionId");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("HagDataLayer.Models.Planets", b =>
                {
                    b.Property<Guid>("PlanetId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("LevelId");

                    b.Property<int>("NumberRightAnswers");

                    b.Property<string>("PlanetName");

                    b.Property<Guid?>("QuestionsQuestionId");

                    b.HasKey("PlanetId");

                    b.HasIndex("LevelId");

                    b.HasIndex("QuestionsQuestionId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("HagDataLayer.Models.Questions", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("LevelsLevelId");

                    b.Property<string>("QuestionText");

                    b.Property<string>("RightAnswer");

                    b.HasKey("QuestionId");

                    b.HasIndex("LevelsLevelId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("HagDataLayer.Models.Levels", b =>
                {
                    b.HasOne("HagDataLayer.Models.Planets", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId");

                    b.HasOne("HagDataLayer.Models.Planets")
                        .WithMany("Levels")
                        .HasForeignKey("PlanetsPlanetId");

                    b.HasOne("HagDataLayer.Models.Questions")
                        .WithMany("Levels")
                        .HasForeignKey("QuestionsQuestionId");
                });

            modelBuilder.Entity("HagDataLayer.Models.Planets", b =>
                {
                    b.HasOne("HagDataLayer.Models.Levels", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId");

                    b.HasOne("HagDataLayer.Models.Questions")
                        .WithMany("Planets")
                        .HasForeignKey("QuestionsQuestionId");
                });

            modelBuilder.Entity("HagDataLayer.Models.Questions", b =>
                {
                    b.HasOne("HagDataLayer.Models.Levels")
                        .WithMany("QuestionsList")
                        .HasForeignKey("LevelsLevelId");
                });
#pragma warning restore 612, 618
        }
    }
}