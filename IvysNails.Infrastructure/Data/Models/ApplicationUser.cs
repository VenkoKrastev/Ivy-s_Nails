﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static IvysNails.Infrastructure.Data.DataConstants;

namespace IvysNails.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [PersonalData]
        [MaxLength(ApplicationUserFirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [PersonalData]
        [MaxLength(ApplicationUserLastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;
    }
}
