using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            BancoABC babc = new BancoABC();
            Console.WriteLine("insira o número do tipo de aplicação que você irá usar :");
            Console.WriteLine("1 - Poupança: Pode­‐se resgatar o valor aplicado a qualquer momento – 0,78a/m");
            Console.WriteLine("2 - Título de Capitalização: Pode­‐se resgatar após 24 meses – 0,97a/m");
            Console.WriteLine("3 - CDB Pode­‐se resgatar após 6 meses - 0,85 a/m");
            Console.WriteLine("4 - CDB Pode­‐se resgatar após 6 meses - 0,85 a/m");
            Console.WriteLine("5 - RDB Pode­‐se resgatar a metade aplicada em 6 meses \n e após 12 meses poderá ser resgatado a qualquer momento - 0,90 args/m");
            string g1 = Console.ReadLine();
            //double AppCli = Convert.ToDouble(g1);
            
            Console.WriteLine("Inf. qual será o valor inicial aplicado :");
            string g2 = Console.ReadLine();
            double ValIa = Convert.ToDouble(g2);
            
            Console.WriteLine("Inf. qual será o valor aplicado a cada mês :");
            string g3 = Console.ReadLine();
            double ValAcm = Convert.ToDouble(g3);
            
            Console.WriteLine("Inf. qual será o tempo a ser aplicado <em meses> :");
            string g4 = Console.ReadLine();
            double TsApl = Convert.ToDouble(g4);

            Console.WriteLine("Valor a ser resgatado = ", babc.VsResg(g1));
            /*Com 100 reais aplicados a 10 por mes em 6 meses, deve retornar 112,48.
            Pessoa pess =  new Pessoa();
            pess.Nome = "Breno";
            
            PessoaFisica pfis = new PessoaFisica();
            pfis.Nome = "Bruno";
            pfis.CalcularTarifa(100);
            Console.ReadKey();
            */
        }
        
    }
}
