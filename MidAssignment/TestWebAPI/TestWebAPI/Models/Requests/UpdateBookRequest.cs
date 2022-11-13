﻿using System.ComponentModel.DataAnnotations;
using Test.Data.Entities;

namespace TestWebAPI.Models.Requests
{
    public class UpdateBookRequest
    {
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
