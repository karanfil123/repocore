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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.CreateName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("Customers");
            builder.Property(x => x.FirstName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(20).IsRequired();
            builder.Property(x => x.ImageUrl).HasMaxLength(200).IsRequired();

            builder.HasData(new Customer
            {
                ID = 1,
                RoleID = 1,
                CreateName = "Admin",
                CreateDate = DateTime.Now,
                IsActive = true,
                FirstName = "Aylin",
                LastName = "Kırnmızı",
                Email = "ayl@gmail.com",
                Password = "123",
                ImageUrl = "asd.jpg"
            },
            new Customer
            {
                ID = 2,
                RoleID = 2,
                CreateName = "Admin",
                CreateDate = DateTime.Now,
                IsActive = true,
                FirstName = "Mehmet",
                LastName = "Yeşil",
                Email = "mehmet@gmail.com",
                Password = "123",
                ImageUrl = "asdqwerty.jpg"
            });
        }
    }
}
