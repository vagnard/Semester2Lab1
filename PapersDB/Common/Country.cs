﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Country() { }
        public Country(string Name)
        {
            this.Name = Name;
        }
    }
}
