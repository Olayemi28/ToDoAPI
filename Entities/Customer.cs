﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniqueTodoApplication.Enum;

namespace UniqueTodoApplication.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public string CustomerPhoto { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public List<Todoitem> Todoitem { get; set; } = new List<Todoitem>();
    }
}
