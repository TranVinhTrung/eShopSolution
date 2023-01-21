using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            //Tạo (KEY)
            builder.HasKey(t => new { t.CategoryId, t.ProductId });

            //Tạo tên bảng trong database
            builder.ToTable("ProductInCategories");

            //Tạo khóa ngoại: 1 Procduct có nhiều ProductInCategory 
            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.ProductId);

            //Tạo khóa ngoại: 1 Category có nhiều ProductInCategory 
            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories).HasForeignKey(pc => pc.CategoryId);
        }
    }
}
