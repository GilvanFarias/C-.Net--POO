using System;

namespace CalcIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula idade de uma pessoa");
            Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa = ");
            p.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento = ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();

            Console.ReadKey();


        }
    }
}
