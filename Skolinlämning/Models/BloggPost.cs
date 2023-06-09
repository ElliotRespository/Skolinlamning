﻿using System.ComponentModel.DataAnnotations;

namespace Skolinlämning.Models
{
    public class BloggPost
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ?Author { get; set; }
    }
     
}
