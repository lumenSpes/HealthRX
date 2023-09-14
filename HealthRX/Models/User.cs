﻿using System.ComponentModel.DataAnnotations;

namespace HealthRX.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Role { get; set; }
        
    }
}