using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace banco
{
    class BancoABC
    {
        /*
        private double appCli;

        public double AppCli
        {
            get { return appCli; }
            set { appCli = value; }
        }
        */
        private double valIa;

        public double ValIa
        {
            get { return valIa; }
            set { valIa = value; }
        }
        private double valAcm;

        public double ValAcm{
            get {return valAcm;}
            set{valAcm = value;}
        }
        private double tsApl;

        public double TsApl
        {
            get { return tsApl; }
            set { tsApl = value; }
        }
        public double VsResg(string g1)
        {   
            Console.WriteLine("valor do G1 = "+ g1);
            
            if (g1 == "1")
            {
                return (ValIa)+(ValIa*0.078)+(ValAcm*0.078)*TsApl;
                Console.WriteLine($"Chegou no IF do Vsresg G1");
                
            } else if(g1 == "2" && TsApl < 24)
            {
                Console.WriteLine($"Ainda não tem 24 meses! Não é possível resgatar!");
                return 0;
            }else if(g1 == "2" && TsApl >= 24)
            {
                return ((ValIa)+(ValIa*0.078))+((ValAcm*0.097)*TsApl);
            }else if(g1 == "3" && TsApl == 6)
            {
                return ((ValIa)+(ValIa*0.085))+((ValAcm*0.097)*TsApl);
            }else if(g1 == "4" && TsApl >= 6 && TsApl < 12 )
            {
                return ((ValIa)+((ValAcm)*TsApl))/2;
            }else if(g1 == "5" && TsApl >= 12 )
            {
                return ((ValIa)+(ValIa*0.090))+((ValAcm*0.097)*TsApl);
            }
            else
            {
                System.Console.WriteLine("Algo de errado não deu certo!!!");
                return 0;
            }
            
        }
        
    }
}
