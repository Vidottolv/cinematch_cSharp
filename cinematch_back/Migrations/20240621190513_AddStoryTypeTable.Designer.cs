﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using cinematch_back.Data;

#nullable disable

namespace cinematch_back.Migrations
{
    [DbContext(typeof(CinematchDBContext))]
    [Migration("20240621190513_AddStoryTypeTable")]
    partial class AddStoryTypeTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("cinematch_back.Models.GenreModel", b =>
                {
                    b.Property<int>("IDGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDGenre"));

                    b.Property<string>("Genre")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("IDGenre");

                    b.ToTable("TBLGenres");
                });

            modelBuilder.Entity("cinematch_back.Models.StoryTypeModel", b =>
                {
                    b.Property<int>("IDStoryType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDStoryType"));

                    b.Property<string>("StoryType")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("IDStoryType");

                    b.ToTable("TBLStoryType");
                });

            modelBuilder.Entity("cinematch_back.Models.TestModel", b =>
                {
                    b.Property<int>("IDTest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDTest"));

                    b.Property<string>("Teste")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("IDTest");

                    b.ToTable("TBLTestes");
                });
#pragma warning restore 612, 618
        }
    }
}
