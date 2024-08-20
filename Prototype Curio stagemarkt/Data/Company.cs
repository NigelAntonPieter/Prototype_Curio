﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Curio_stagemarkt.Data
{
    internal class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string EmailAddress { get; set; }

        public string Street { get; set; }

        public ICollection<User> Users { get; set; }

    }
}
