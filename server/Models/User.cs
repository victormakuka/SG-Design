﻿using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public sealed class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        public string? Profission { get; set; }

        public string PhotoUrl { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<Comment> Comments { get; set; } = new();
    }
}
