using LibrarySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibrarySystem.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
                (
                    new Author
                    {
                        Id = 1,
                        AuthorName = "Author 1",

                    },
                    new Author
                    {
                        Id = 2,
                        AuthorName = "Author 2",

                    },
                    new Author
                    {
                        Id = 3,
                        AuthorName = "Author 3",

                    },
                    new Author
                    {
                        Id = 4,
                        AuthorName = "Author 4",

                    },
                    new Author
                    {
                        Id = 5,
                        AuthorName = "Author 5",

                    }
                );
        }
    }
}
