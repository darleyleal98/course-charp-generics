﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenercisCourse
{
    public class Product
    {
        public string Name { get; set; }
        public double Preco {  get; set; }

        public Product(string name, double preco)
        {
            Name = name;
            Preco = preco;
        }
    }
}
