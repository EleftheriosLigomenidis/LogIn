using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Name must be between 3 and 40 chars", MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Last Name must be between 3 and 40 chars", MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}