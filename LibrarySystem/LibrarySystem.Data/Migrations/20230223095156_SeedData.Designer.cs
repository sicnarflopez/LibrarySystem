﻿// <auto-generated />
using LibrarySystem.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibrarySystem.Data.Migrations
{
    [DbContext(typeof(LibrarySystemDbContext))]
    [Migration("20230223095156_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibrarySystem.Data.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "Author 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Author 2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorName = "Author 3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorName = "Author 4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorName = "Author 5"
                        });
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            SubCategoryId = 1,
                            Title = "Book 1"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            SubCategoryId = 2,
                            Title = "Book 2"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            SubCategoryId = 3,
                            Title = "Book 3"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            SubCategoryId = 4,
                            Title = "Book 4"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            SubCategoryId = 5,
                            Title = "Book 5"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 1,
                            SubCategoryId = 6,
                            Title = "Book 6"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 2,
                            SubCategoryId = 7,
                            Title = "Book 7"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 3,
                            SubCategoryId = 8,
                            Title = "Book 9"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 4,
                            SubCategoryId = 1,
                            Title = "Book 9"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 5,
                            SubCategoryId = 2,
                            Title = "Book 10"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 1,
                            SubCategoryId = 3,
                            Title = "Book 11"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 2,
                            SubCategoryId = 4,
                            Title = "Book 12"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 3,
                            SubCategoryId = 5,
                            Title = "Book 13"
                        });
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Category 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Category 2"
                        });
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "C1: Sub Category 1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "C1: Sub Category 2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "C1: Sub Category 3"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "C1: Sub Category 4"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "C2: Sub Category 1"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "C2: Sub Category 2"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "C2: Sub Category 3"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "C2: Sub Category 4"
                        });
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.Book", b =>
                {
                    b.HasOne("LibrarySystem.Data.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibrarySystem.Data.Entities.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.SubCategory", b =>
                {
                    b.HasOne("LibrarySystem.Data.Entities.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibrarySystem.Data.Entities.Category", b =>
                {
                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
