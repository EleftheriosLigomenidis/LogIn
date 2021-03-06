﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace login.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole UserRole { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public User()
        {
            Customers = new List<Customer>();
        }
    }
}