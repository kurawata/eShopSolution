﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategories");
            builder.HasKey(x => new { x.CategoryId, x.ProductId });

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
