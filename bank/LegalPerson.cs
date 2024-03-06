using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class LegalPerson : Person
    {
        private string corpName;
        private double threshold;
        private double balance;

        public global::System.String CorpName { get => corpName; set => corpName = value; }
        public global::System.Double Threshold { get => threshold; set => threshold = value; }
        public global::System.Double Balance { get => balance; set => balance = value; }

        private double CalculateFare(double Balance){
            return Balance * 0.2;
        }
    }
}