using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class NaturalPerson : Person
    {
        private String name;
        private double balance;

        public String Name { get { return name; } set => name = value; }
        public global::System.Double Balance { get => balance; set => balance = value; }

        public double CalculateFare(double Balance){
            return Balance * 0.1;
        }
    }
}