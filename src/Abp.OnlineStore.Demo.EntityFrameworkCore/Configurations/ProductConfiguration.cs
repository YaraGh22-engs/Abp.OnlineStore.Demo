using Abp.OnlineStore.Demo.Products;
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
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention(); // auto mapping like : id ,isDeleted , other fields
             
            builder.Property(x => x.NameAr).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.NameEn).HasMaxLength(DemoConsts.GeneralTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionAr).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();
            builder.Property(x => x.DescriptionEn).HasMaxLength(DemoConsts.DescriptionTextMaxLength).IsRequired();

            // For M->1 Relation
            builder.HasOne(pr => pr.Category)
                   .WithMany()
                   .HasForeignKey(pr => pr.CategoryId)
                   .IsRequired();

            // to name the table in the DB
            builder.ToTable("Products");
        }
    }
}
