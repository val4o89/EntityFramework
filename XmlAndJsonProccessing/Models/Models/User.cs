using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class User
    {
        private ICollection<Product> selledProducts;

        private ICollection<Product> buyedProducts;

        private ICollection<User> friends;

        public User()
        {
            this.selledProducts = new HashSet<Product>();
            this.buyedProducts = new HashSet<Product>();
            this.friends = new HashSet<User>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public virtual ICollection<User> Friends
        {
            get { return this.friends; }
            set { this.friends = value; }
        }

        [InverseProperty("Buyer")]
        public virtual ICollection<Product> BoughtProducts { get; set; }

        [InverseProperty("Seller")]
        public virtual ICollection<Product> SoldProducts { get; set; }
    }
}
