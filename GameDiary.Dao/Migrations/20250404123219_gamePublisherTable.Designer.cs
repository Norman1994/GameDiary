﻿// <auto-generated />
using System;
using GameDiary.Dao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GameDiary.Dao.Migrations
{
    [DbContext(typeof(GameDiaryDbContext))]
    [Migration("20250404123219_gamePublisherTable")]
    partial class gamePublisherTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GameDiary.Dao.Entities.DevelopEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.GameDeveloperEntity", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DeveloperId")
                        .HasColumnType("uuid");

                    b.HasKey("GameId", "DeveloperId");

                    b.HasIndex("DeveloperId");

                    b.ToTable("GameDeveloperEntities");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.GameEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsLoving")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.GamePublisherEntity", b =>
                {
                    b.Property<Guid>("GameId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uuid");

                    b.HasKey("GameId", "PublisherId");

                    b.ToTable("GamePublisherEntities");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.PublisherEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.GameDeveloperEntity", b =>
                {
                    b.HasOne("GameDiary.Dao.Entities.DevelopEntity", "DevelopEntity")
                        .WithMany("GameDeveloper")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameDiary.Dao.Entities.GameEntity", "GameEntity")
                        .WithMany("Developers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DevelopEntity");

                    b.Navigation("GameEntity");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.GamePublisherEntity", b =>
                {
                    b.HasOne("GameDiary.Dao.Entities.GameEntity", "GameEntity")
                        .WithMany("Publishers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameDiary.Dao.Entities.PublisherEntity", "PublisherEntity")
                        .WithMany("GamePublisher")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameEntity");

                    b.Navigation("PublisherEntity");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.DevelopEntity", b =>
                {
                    b.Navigation("GameDeveloper");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.GameEntity", b =>
                {
                    b.Navigation("Developers");

                    b.Navigation("Publishers");
                });

            modelBuilder.Entity("GameDiary.Dao.Entities.PublisherEntity", b =>
                {
                    b.Navigation("GamePublisher");
                });
#pragma warning restore 612, 618
        }
    }
}
