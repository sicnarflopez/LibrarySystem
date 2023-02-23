using LibrarySystem.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Data.Configurations
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData
                (
                    new SubCategory
                    {
                        Id = 1,
                        Description = "C1: Sub Category 1",
                        CategoryId = 1
                    },
                    new SubCategory
                    {
                        Id = 2,
                        Description = "C1: Sub Category 2",
                        CategoryId = 1
                    },
                    new SubCategory
                    {
                        Id = 3,
                        Description = "C1: Sub Category 3",
                        CategoryId = 1
                    },
                    new SubCategory
                    {
                        Id = 4,
                        Description = "C1: Sub Category 4",
                        CategoryId = 1
                    },
                    new SubCategory
                    {
                        Id = 5,
                        Description = "C2: Sub Category 1",
                        CategoryId = 2
                    },
                    new SubCategory
                    {
                        Id = 6,
                        Description = "C2: Sub Category 2",
                        CategoryId = 2
                    },
                    new SubCategory
                    {
                        Id = 7,
                        Description = "C2: Sub Category 3",
                        CategoryId = 2
                    },
                    new SubCategory
                    {
                        Id = 8,
                        Description = "C2: Sub Category 4",
                        CategoryId = 2
                    }
                );
        }
    }
}
