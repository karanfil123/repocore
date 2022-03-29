using CoreEntity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData.FluentMap
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.CreateName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("Products");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(2000).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
            builder.HasData(
                new Product
                {
                    ID = 1,
                    CategoryID = 1,
                    CustomerID = 1,
                    Name = "İphone13",
                    Description = "İphone 13 tüm özellikleri",
                    Price = 19000,
                    Stock = 1000,
                    CreateDate=DateTime.Now,
                    CreateName="Admin",
                    IsActive=true
                },
            new Product
            {
                ID = 2,
                CategoryID = 2,
                CustomerID = 2,
                Name = "Samsung S20",
                Description = "S20 tüm özellikleri",
                Price = 12000,
                Stock = 100,
                CreateDate = DateTime.Now,
                CreateName = "Admin",
                IsActive = true
            });
        }
    }
}
