﻿using FoodEShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodEShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { set; get; }
        public Status Status{set;get;}

        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoriesTranslation> CategoriesTranslations { get; set; }
    }
}
