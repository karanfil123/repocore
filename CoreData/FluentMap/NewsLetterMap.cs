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
    public class NewsLetterMap : IEntityTypeConfiguration<NewsLetter>
    {
        public void Configure(EntityTypeBuilder<NewsLetter> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd().IsRequired();
            builder.Property(x => x.CreateName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Mail).HasMaxLength(2000).IsRequired();
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.ToTable("NewsLetters");

        }
    }
}
