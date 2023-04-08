﻿using Microsoft.AspNetCore.Identity;

namespace CRISPER.Models
{
    public class AppUser:IdentityUser
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

    }
}
