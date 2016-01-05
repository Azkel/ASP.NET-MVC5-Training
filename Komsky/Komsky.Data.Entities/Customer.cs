using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Komsky.Data.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public String Email { get; set; }

        public String Phone { get; set; }

        public String PIN  { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
