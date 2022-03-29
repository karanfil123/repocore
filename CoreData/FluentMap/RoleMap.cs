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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.CreateName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("Roles");
            builder.Property(x => x.CustomerType).HasMaxLength(50).IsRequired();
            builder.HasData(new Role {
            ID=1,
            CreateName="Admin",
            CreateDate=DateTime.Now,
            IsActive=true,
            CustomerType="User"
            },
            new Role
            {
                ID = 2,
                CreateName = "Admin",
                CreateDate = DateTime.Now,
                IsActive = true,
                CustomerType = "Admin"
            });
        }
    }
}
