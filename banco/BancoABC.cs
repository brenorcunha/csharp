using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace banco
{
    class BancoABC
    {
        private static Int16 appCli;

        public static Int16 AppCli
        {
            get { return appCli; }
            set { appCli = value; }
        }
        private static double valIa;

        public static double ValIa
        {
            get { return valIa; }
            set { valIa = value; }
        }
        private static double valAcm;

        public static double ValAcm
        {
            get { return valAcm; }
            set { valAcm = value; }
        }
        private static Int16 tsApl;

        public static Int16 TsApl
        {
            get { return tsApl; }
            set { tsApl = value; }
        }
        bool v1 = (appCli == 2);
        bool v2 = (tsApl >= 24);
        bool v3 = (appCli == 3);
        bool v4 = (tsApl == 6);
        bool v5 =(appCli == 4);
        bool v6 = (tsApl >= 6);
        bool v7 =(tsApl < 12);
        bool v8 = (appCli == 5);
        bool v9 = (tsApl >= 12);

        public double VsResg(double valIa, double valAcm, Int16 tsApl, Int16 appCli)
        {
        if ( appCli == 1 )
        {
            return ((ValIa)+(ValIa*0.078))+((ValAcm*0.078)*tsApl);
        } else if(v1 && v2)
        {
            return ((ValIa)+(ValIa*0.078))+((ValAcm*0.097)*tsApl);
        } else if(v3 && v4)
        {
            return ((ValIa)+(ValIa*0.085))+((ValAcm*0.097)*tsApl);
        } else if(v5 && v6 && v7)
        {
            return ((ValIa)+((ValAcm)*tsApl))/2;
        } else if(v8 && v9)
        {
            return ((ValIa)+(ValIa*0.090))+((ValAcm*0.097)*tsApl);
        }
        else
        {
            Console.WriteLine("Algum erro ocorreu. Provavelmente ainda não está em tempo para resgatar o valor!");
            return 0 ;
        }
        }
        
    }
}
