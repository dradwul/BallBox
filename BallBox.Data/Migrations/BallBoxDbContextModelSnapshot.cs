﻿// <auto-generated />
using BallBox.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BallBox.Data.Migrations
{
    [DbContext(typeof(BallBoxDbContext))]
    partial class BallBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BallBox.Client.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("BallBox.Client.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("integer");

                    b.Property<int>("AwayTeamStatsId")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentMatchMinute")
                        .HasColumnType("integer");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("integer");

                    b.Property<int>("HomeTeamStatsId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalMatchMinutes")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("AwayTeamStatsId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("HomeTeamStatsId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("BallBox.Client.Models.MatchStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Assists")
                        .HasColumnType("integer");

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<int>("RedCard")
                        .HasColumnType("integer");

                    b.Property<int>("YellowCards")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("MatchStats");
                });

            modelBuilder.Entity("BallBox.Client.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("Assists")
                        .HasColumnType("integer");

                    b.Property<int>("Attacking")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentMatchStatsId")
                        .HasColumnType("integer");

                    b.Property<int>("Defending")
                        .HasColumnType("integer");

                    b.Property<int>("Dribbling")
                        .HasColumnType("integer");

                    b.Property<int>("Goalkeeping")
                        .HasColumnType("integer");

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("Overall")
                        .HasColumnType("integer");

                    b.Property<int>("Passing")
                        .HasColumnType("integer");

                    b.Property<int>("Physical")
                        .HasColumnType("integer");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Shooting")
                        .HasColumnType("integer");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CurrentMatchStatsId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BallBox.Client.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Attacking")
                        .HasColumnType("integer");

                    b.Property<int>("Defending")
                        .HasColumnType("integer");

                    b.Property<int>("Draws")
                        .HasColumnType("integer");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("integer");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("integer");

                    b.Property<int>("Losses")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Overall")
                        .HasColumnType("integer");

                    b.Property<int>("Wins")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BallBox.Client.Models.TeamStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Goals")
                        .HasColumnType("integer");

                    b.Property<int>("RedCards")
                        .HasColumnType("integer");

                    b.Property<int>("ShotsOnGoal")
                        .HasColumnType("integer");

                    b.Property<int>("YellowCards")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TeamStats");
                });

            modelBuilder.Entity("BallBox.Client.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("BallBox.Client.Models.Match", b =>
                {
                    b.HasOne("BallBox.Client.Models.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BallBox.Client.Models.TeamStats", "AwayTeamStats")
                        .WithMany()
                        .HasForeignKey("AwayTeamStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BallBox.Client.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BallBox.Client.Models.TeamStats", "HomeTeamStats")
                        .WithMany()
                        .HasForeignKey("HomeTeamStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("AwayTeamStats");

                    b.Navigation("HomeTeam");

                    b.Navigation("HomeTeamStats");
                });

            modelBuilder.Entity("BallBox.Client.Models.Player", b =>
                {
                    b.HasOne("BallBox.Client.Models.MatchStats", "CurrentMatchStats")
                        .WithMany()
                        .HasForeignKey("CurrentMatchStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BallBox.Client.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentMatchStats");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("BallBox.Client.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
