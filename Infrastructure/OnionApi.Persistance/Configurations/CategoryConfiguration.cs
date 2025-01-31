using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApi.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id=1,
                Name = "Electronics",
                Priorty = 1,
                ParentId=0,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Category category2 = new()
            {
                Id=2,
                Name = "Fashion",
                Priorty = 2,
                ParentId=0,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Category child1 = new()
            {
                Id=3,
                Name= "Computer",
                Priorty = 1,
                ParentId=1,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Category child2 = new()
            {
                Id=4,
                Name= "Women",
                Priorty = 1,
                ParentId=2,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            builder.HasData(category1, category2, child1, child2);

        }
    }
}
