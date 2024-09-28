using Abp.OnlineStore.Demo.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.OnlineStore.Demo.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention(); // auto mapping like : id ,isDeleted , other fields

            builder.Property(x=>x.Id).ValueGeneratedNever(); // to generate ID manually
            builder.Property(x => x.NameAr).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x=>x.NameEn).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x=>x.DescriptionAr).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
            builder.Property(x=>x.DescriptionEn).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();

            // to name the table in the DB
            builder.ToTable("Categories");

        }
    }
}
