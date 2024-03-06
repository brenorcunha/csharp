using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank
{
    class ABCBank
    {
        private static short application;
        private static double initialValue;
        private static double mensalValue;
        private static short timePeriod;

        public static global::System.Int16 Application { get => application; set => application = value; }
        public static global::System.Double InitialValue { get => initialValue; set => initialValue = value; }
        public static global::System.Double MensalValue { get => mensalValue; set => mensalValue = value; }
        public static global::System.Int16 TimePeriod { get => timePeriod; set => timePeriod = value; }

        /* bool v1 = (appCli == 2);
        bool v2 = (tsApl >= 24);
        bool v3 = (appCli == 3);
        bool v4 = (tsApl == 6);
        bool v5 =(appCli == 4);
        bool v6 = (tsApl >= 6);
        bool v7 =(tsApl < 12);
        bool v = (appCli == 5);
        bool v = (tsApl >= 12); */

        public double A2BReed(Int16 Application, double InitialValue, double MensalValue, Int16 TimePeriod)
        {
            if ( application == 1 )
            {
                return InitialValue*1.078+((MensalValue*0.078)*TimePeriod);
            } else if(application == 2 && TimePeriod >= 24)
            {
                return InitialValue*1.078+((MensalValue*0.097)*TimePeriod);
            } else if(application == 3 && TimePeriod >= 6)
            {
                return InitialValue*1.078+((MensalValue*0.097)*TimePeriod);
            } else if(application == 4 && TimePeriod >= 6 && TimePeriod < 12)
            {
                return (InitialValue*1.085+((MensalValue)*TimePeriod))/2;
            } else if(application == 5 && TimePeriod >= 12)
            {
                return InitialValue*1.09+((MensalValue*0.097)*TimePeriod);
            }
            else
            {
                Console.WriteLine("Some error has occurred. You're probably not in time to redeem the value yet!");
                return 0 ;
            }
        }
    }
}