﻿using System.ComponentModel.DataAnnotations;
using static IvysNails.Data.DataConstants;


namespace IvysNails.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CustomerNameMaxLength)]
        public string CustomerName { get; set; } = null!;

        [Required]
        [MaxLength(CustomerPhoneNumberMaxLength)]
        public string CustomerPhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;
    }
}