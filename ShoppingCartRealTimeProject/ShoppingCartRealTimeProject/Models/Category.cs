﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCartRealTimeProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(30)]
        [Required]
        [DisplayName("Category name")]
        public string Name { get; set; }
    }
}
