using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoremIpsum.Web.Models
{
    public class Animal
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public AnimalType Type { get; set; }
    }

    public enum AnimalType
    {
        Cat, Dog, Rat, Duck
    }
}