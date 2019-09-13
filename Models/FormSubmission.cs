using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmisison.Models
{
    public class User
    {
        [Required(ErrorMessage="First name must be at least 4 characters long")]
        [MinLength (4)]
         public string firstname {get;set;}


        [Required(ErrorMessage="Last name must be at least 4 characters long")]
        [MinLength (4)]
        public string lastname {get;set;}

        [Required(ErrorMessage="Age must be a positive number")]
        [Range(1,100)]
        public int age {get;set;}

        [Required(ErrorMessage="Email must be a valid email format")]
        [EmailAddress]
        public string email {get;set;}


        [Required(ErrorMessage="Password must be at least 8 character long")]
        [MinLength(8)]
        public string password {get;set;}
    }
}