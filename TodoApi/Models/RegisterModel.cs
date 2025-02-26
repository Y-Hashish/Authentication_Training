﻿using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Auth.Models
{
    public class RegisterModel
    {
        [Required,StringLength(100)]
        public string FirstName { get; set; }
        [Required, StringLength(100)]
        public string LastName { get; set; }
        [Required, StringLength(50)]
        public string UserName { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(100)]
        public string Password { get; set; }

    }
}
