﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TimpusProject.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string LableColor { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
