﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Supplier
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Contract> ConductedContracts { get; set; }
        public Supplier(string name)
        {
            Name = name;
            ConductedContracts = new List<Contract>();
        }
    }
}
