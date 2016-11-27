using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Product
    {
        private ICollection<Category> categories;

        public Product()
        {
            this.categories = new HashSet<Category>();
        }

        public int Id { get; set; }

        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public virtual User Seller { get; set; }

        public virtual User Buyer { get; set; }

        public virtual ICollection<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }
    }
}
