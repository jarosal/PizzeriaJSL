using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pizzeria.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ICollection<ProductAddition> Additions { get; } = new Collection<ProductAddition>();
    }
}