using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UsersDb.Models;
using UsersDbContext.Attributes;

namespace UsersDbContext.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }

        [Required]
        [PassValidator(4, 6, ContainsDigit = true, ContainsLowerCase = true
            , ContainsSpecialSimbol = true, ContainsUpperCase = true)]
        public string Password { get; set; }

        [Required]
        [EmailValidator]
        public string Email { get; set; }
        
        [MaxLength(1048576)]
        public byte[] ProfilePicture { get; set; }

        public DateTime? RegisteredOn { get; set; }

        public DateTime? LastTimeLoggedIn { get; set; }

        [Range(1, 120)]
        public byte? Age { get; set; }

        public bool? IsDeleted { get; set; }

        public Town BirthTown { get; set; }

        public Town LivingTown { get; set; }
    }
}
