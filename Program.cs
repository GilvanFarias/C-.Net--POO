using System.Globalization;
using System;
using System.Collections.Generic;
//using Internal;

namespace CalcIdade
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula idade de uma pessoa");
            //Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa = ");
            string nome = Console.ReadLine();
            //p.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento = ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome,ano);
            Console.Write("Sua idade é: " + p.Idade);
            //p.ExibirDados();
            //p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.Idade);
            

            Console.ReadKey();


        }
    }
}
