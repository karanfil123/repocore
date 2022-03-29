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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.CreateName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("Categories");
            builder.Property(x => x.Name).HasMaxLength(400).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            builder.HasData(new Category
            {
                ID = 1,
                CreateDate = DateTime.Now,
                CreateName = "Bülent",
                IsActive = true,
                Name = "Teknoloji",
                Description = "Kategori açıklası"
            },
            new Category
            {
                ID = 2,
                CreateDate = DateTime.Now,
                CreateName = "Bülent",
                IsActive = true,
                Name = "Telefon",
                Description = "Telefon açıklası"
            });
        }
    }
}
