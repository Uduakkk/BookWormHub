﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWormHub.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public string? Bio {  get; set; }
        public string? ProfilePicture { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;


        public ICollection<Review>? Reviews { get; set; }
    }
}
