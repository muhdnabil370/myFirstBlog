﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace myFirstBlog.Models
{
    public class Category
    {
        [Key]
        public  int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public  int DisplayOrder { get; set; }
    }
}
