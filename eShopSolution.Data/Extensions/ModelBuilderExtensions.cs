using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding - Tạo dữ liệu mẫu

            //Add DL mẫu AppConfig
            modelBuilder.Entity<AppConfig>().HasData(
              new AppConfig() { Key = "HomeTitle", Value = "This Home page of eShopSolution" },
              new AppConfig() { Key="HomeKeyWord", Value= "This Home keyword of eShopSolution"},
              new AppConfig() { Key = "HomeDescription", Value = "This Home Description of eShopSolution" }
              );

            //Add DL mẫu Language
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id="vi-VN", Name="Tiếng Việt", IsDefault=true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            //Add DL mẫu Category
            modelBuilder.Entity<Category>().HasData(
                new Category() { 
                    Id=1,
                    ParentId = null, 
                    IsShowOnHome = true, 
                    Status = Status.Active,
                    SortOrder = 1 
                },
                new Category() { 
                    Id=2,
                    ParentId = null, 
                    IsShowOnHome = true, 
                    Status = Status.Active, 
                    SortOrder = 2 
                }
                );

            //Add DL mẫu CategoryTranslation
            modelBuilder.Entity<CategoryTranslation>().HasData(               
                        new CategoryTranslation(){ Id=1, CategoryId=1, Name="Áo nam",LanguageId="vi-VN", SeoAlias="ao-nam",SeoDescription="Sản phẩm áo thời trang nam",SeoTitle="Sản phẩm áo thời trang nam"},
                        new CategoryTranslation(){ Id=2, CategoryId=1,Name="Men shirt",LanguageId="en-US", SeoAlias="men-shirt",SeoDescription="The shirt Product for men",SeoTitle="The shirt Product for men"},
                        new CategoryTranslation(){ Id=3,CategoryId=2, Name="Áo nữ",LanguageId="vi-VN", SeoAlias="ao-nu",SeoDescription="Sản phẩm áo thời trang nữ",SeoTitle="Sản phẩm áo thời trang nữ"},
                        new CategoryTranslation(){ Id=4, CategoryId=2, Name="Women shirt",LanguageId="en-US", SeoAlias="women-shirt",SeoDescription="The shirt Product for women",SeoTitle="The shirt Product for women"}
               );
            //Add DL mẫu Procduct
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,                     
                    DateCreated = DateTime.Now, 
                    OriginalPrice=10000, 
                    Price=20000, 
                    Stock=0, 
                    ViewCount=0,
                    SeoAlias="ao-nam"
                },
                new Product()
                {
                    Id=2,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 15000,
                    Price = 30000,
                    Stock = 0,
                    ViewCount = 0,
                    SeoAlias="ao-nu"
                });
            //Add DL mẫu ProductTranslation
            modelBuilder.Entity<ProductTranslation>().HasData(                                 
                        new ProductTranslation(){
                            Id=1,
                            ProductId=1,
                            Name="Áo sơ mi nam",
                            LanguageId="vi-VN",
                            SeoAlias="ao-so-mi-nam",
                            SeoDescription="Sản phẩm áo sơ mi thời trang nam",
                            SeoTitle="Sản phẩm áo sơ mi thời trang nam",
                            Details="Mô tả sản phẩm",
                            Description= "Mô tả sản phẩm"                             
                        },
                        new ProductTranslation(){
                            Id = 2,
                            ProductId = 1,
                            Name ="Men T-shirt",
                            LanguageId="en-US",
                            SeoAlias="men-T-shirt",
                            SeoDescription="The t-shirt Product for men",
                            SeoTitle="The t-shirt Product for men",
                            Details="Description of product",
                            Description = "Description of product"
                        },
                        new ProductTranslation()
                        {
                            Id=3,
                            ProductId=2,
                            Name = "Áo nữ",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-nu",
                            SeoDescription = "Sản phẩm áo thời trang nữ",
                            SeoTitle = "Sản phẩm áo thời trang nữ",
                            Details = "Mô tả sản phẩm",
                            Description = "Mô tả sản phẩm"
                        },
                        new ProductTranslation()
                        {
                            Id=4,
                            ProductId=2,
                            Name = "Women shirt",
                            LanguageId = "en-US",
                            SeoAlias = "women-shirt",
                            SeoDescription = "The shirt Product for women",
                            SeoTitle = "The shirt Product for women",
                            Details = "Description of product", 
                            Description= "Description of product"
                        }                    
                    );

            //Add DL mẫu ProductInCategory
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId=1, CategoryId = 1},
                new ProductInCategory() { ProductId = 2, CategoryId = 2}
                );
        }
    }
}
