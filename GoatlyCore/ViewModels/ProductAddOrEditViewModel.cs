﻿using System.Collections.Generic;
using GoatlyCore.Models;

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
namespace GoatlyCore.ViewModels
{
    public class ProductAddOrEditViewModel
    {
        public bool AddsNew { get; set; }
        public Product? Product { get; set; }
        public IList<Category> ProductCategories { get; set; }
        public IList<Supplier>? Suppliers { get; set; }
    }
}
