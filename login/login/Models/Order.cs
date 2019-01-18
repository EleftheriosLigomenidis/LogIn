using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(0, 1000, ErrorMessage = "Cost cannot be negative and must be under 1000 ")]
        public int TotalCost { get; set; }

        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}