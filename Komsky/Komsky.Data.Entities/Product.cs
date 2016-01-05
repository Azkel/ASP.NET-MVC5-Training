using Komsky.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komsky.Data.Entities
{
    public class Product
    {
        public Int32 Id { get; set; }

        public String Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public ProductType Type { get; set; }

        public Customer Customer { get; set; }
    }
}
