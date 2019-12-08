﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    //Just a comment
    class Factory
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double rawMaterial;

        public double RawMaterial
        {
            get { return rawMaterial; }
            set { rawMaterial = value; }
        }
        public List<Employee> Employees { get; set; }
        public Organisation OrganisationRelated { get; set; }
        //public List<Chocolate> ChocolatesStock?

        public Factory(string name, double rawmaterial, Organisation organisationRelated)
        {
            Name = name;
            RawMaterial = rawmaterial;
            OrganisationRelated = organisationRelated;
            Employees = new List<Employee>();
        }

        void ChocolateCreation()
        {
            rawMaterial--;
        }
    }
}
