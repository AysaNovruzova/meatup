﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maetup_Core.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
