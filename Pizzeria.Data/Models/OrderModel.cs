using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pizzeria.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<Product> Products { get; } = new Collection<Product>();
        public Note Note { get; set; }
    }
}