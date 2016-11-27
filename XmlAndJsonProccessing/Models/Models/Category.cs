﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Category
    {
        private ICollection<Product> products;

        public Category()
        {
            this.products = new HashSet<Product>();
        }

        public int Id { get; set; }

        [MinLength(3), MaxLength(15)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products
        {
            get { return this.products; }
            set { this.products = value; }
        } 
    }
}
