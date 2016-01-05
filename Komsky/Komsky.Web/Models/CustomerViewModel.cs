using Komsky.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Komsky.Web.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public String Name { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        [Phone]
        public String Phone { get; set; }

        [StringLength(8, MinimumLength = 4)]
        public String PIN { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }

    }
}