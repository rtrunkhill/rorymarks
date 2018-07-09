﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoryMarks.Models;

namespace RoryMarks.Migrations
{
    [DbContext(typeof(RoryMarksContext))]
    partial class RoryMarksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoryMarks.Models.Bookmarks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bookmark");

                    b.Property<string>("TopicID");

                    b.Property<int?>("TopicID1");

                    b.HasKey("ID");

                    b.HasIndex("TopicID1");

                    b.ToTable("Bookmarks");
                });

            modelBuilder.Entity("RoryMarks.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Topic");
                });

            modelBuilder.Entity("RoryMarks.Models.Bookmarks", b =>
                {
                    b.HasOne("RoryMarks.Models.Topic", "Topic")
                        .WithMany("Bookmarks")
                        .HasForeignKey("TopicID1");
                });
#pragma warning restore 612, 618
        }
    }
}
