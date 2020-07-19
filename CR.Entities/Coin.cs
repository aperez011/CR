﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Entities
{
    public class Coin : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Type { get; set; }
    }
}
