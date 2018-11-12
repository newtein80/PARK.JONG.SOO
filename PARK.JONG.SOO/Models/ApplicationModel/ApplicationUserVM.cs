﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PARK.JONG.SOO.Models.ApplicationModel
{
    public class ApplicationUserVM
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Num.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Confirm password")]
        public bool TwoFactorEnabled { get; set; }

        [Display(Name = "Confirm password")]
        public DateTimeOffset? LockoutEnd { get; set; }

        [Display(Name = "Confirm password")]
        public bool LockoutEnabled { get; set; }
    }
}
