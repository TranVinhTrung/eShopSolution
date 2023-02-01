using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        //Cấu hình cho bảng Product
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);  //Tạo khóa chính cho bảng Product

            builder.Property(x => x.Price).IsRequired();  //Gán yêu cầu

            builder.Property(x => x.OriginalPrice).IsRequired();
            
            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);  //Mặc định cho Stock = 0

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

        }
    }
}
