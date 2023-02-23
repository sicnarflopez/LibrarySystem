using LibrarySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibrarySystem.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
                (
                    new Book
                    {
                        Id = 1,
                        Title = "Book 1",
                        AuthorId = 1,
                        SubCategoryId = 1
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Book 2",
                        AuthorId = 2,
                        SubCategoryId = 2
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "Book 3",
                        AuthorId = 3,
                        SubCategoryId = 3
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "Book 4",
                        AuthorId = 4,
                        SubCategoryId = 4
                    },
                    new Book
                    {
                        Id = 5,
                        Title = "Book 5",
                        AuthorId = 5,
                        SubCategoryId = 5
                    },
                    new Book
                    {
                        Id = 6,
                        Title = "Book 6",
                        AuthorId = 1,
                        SubCategoryId = 6
                    },
                    new Book
                    {
                        Id = 7,
                        Title = "Book 7",
                        AuthorId = 2,
                        SubCategoryId = 7
                    },
                    new Book
                    {
                        Id = 8,
                        Title = "Book 9",
                        AuthorId = 3,
                        SubCategoryId = 8
                    },
                    new Book
                    {
                        Id = 9,
                        Title = "Book 9",
                        AuthorId = 4,
                        SubCategoryId = 1
                    },
                    new Book
                    {
                        Id = 10,
                        Title = "Book 10",
                        AuthorId = 5,
                        SubCategoryId = 2
                    },
                    new Book
                    {
                        Id = 11,
                        Title = "Book 11",
                        AuthorId = 1,
                        SubCategoryId = 3
                    },
                    new Book
                    {
                        Id = 12,
                        Title = "Book 12",
                        AuthorId = 2,
                        SubCategoryId = 4
                    },
                    new Book
                    {
                        Id = 13,
                        Title = "Book 13",
                        AuthorId = 3,
                        SubCategoryId = 5
                    }
                );
        }
    }
}
