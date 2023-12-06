﻿using Microsoft.AspNetCore.Identity;

namespace Bookstore.IdentityServer.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}
