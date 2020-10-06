using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Pizzeria.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }
        public string PasswordHash { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public ICollection<Order> Orders { get; } = new Collection<Order>();
    }
}