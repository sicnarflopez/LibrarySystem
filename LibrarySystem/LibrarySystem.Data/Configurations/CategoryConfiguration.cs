using LibrarySystem.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibrarySystem.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                    new Category
                    {
                        Id = 1,
                        Description = "Category 1"
                    },

                    new Category
                    {
                        Id = 2,
                        Description = "Category 2"
                    }
                );
        }
    }
}
