﻿using FoodEShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodEShopSolution.Data.Configurations
{
    public class CategoriesTranslationConfiguration : IEntityTypeConfiguration<CategoriesTranslation>
    {
        public void Configure(EntityTypeBuilder<CategoriesTranslation> builder)
        {
            builder.ToTable("CategoryTranslations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescriptison).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.CategoriesTranslations).HasForeignKey(x => x.LanguageId);
            builder.HasOne(x => x.Category).WithMany(x => x.CategoriesTranslations).HasForeignKey(x => x.CategoryId);

        }
    }
}
