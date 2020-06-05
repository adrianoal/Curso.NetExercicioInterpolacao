using System;
using System.Globalization;

namespace Imprimindo_Conteudo_de_Variavel
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero  = 'M';
            int idade    = 35;
            double saldo = 10.35784;
            string nome = "Adriano de Assis Lima";

            
            int idade1 = 35;
            double saldo1 = 10.35784;
            string nome1 = "Adriano de Assis Lima";


            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));// para 2 casas decimai (.ToString("F2"))
            Console.WriteLine(saldo.ToString("F4"));// para 4 casas decimai (.ToString("F4"))
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));// Substitui a , por . --> Não esquecer do  using System.Globalization no inicio do programa...
            Console.WriteLine(nome);

            Console.WriteLine("-----------------------------------------------------------------------");

            // imprimindo com Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            Console.WriteLine("----------------------------------------------");

            //Imprimindo com Interpolação
            Console.WriteLine($"{nome} tem {idade1} anos e tem saldo igual {saldo1:F2} reais");
            Console.WriteLine("-----------------------------------------------------------------------");

            //Imprimindo com Interpolação Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
