using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class Person
    {
        private string name;
        private string id; //CPF
        private string sex;
        private double balance;

        public global::System.String Name { get => name; set => name = value; }
        public global::System.String Id { get => id; set => id = value; }
        public global::System.String Sex { get => sex; set => sex = value; }
        public global::System.Double Balance { get => balance; set => balance = value; }

        public double CalculateFare(){
            return Balance;
        }
    }
}
