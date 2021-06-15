using System;
namespace CalcIdade
{
    public class Pessoa
    {
        //propfull atalho para métodos construtores(propriedade)
        private int _anoNascimento;
        public int AnoNascimento
        {
            get { return this._anoNascimento; }
            set { this._anoNascimento = value; }
        }
        
        private string _nome; 
        public string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper();} //ToUpper(); Faz transforma uma string para maiuscula.
        }

        public void ExibirDados(){
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: " + idade);
        }

        private int CalcularIdade(){

            DateTime data = DateTime.Now; //pega a data do sistema atual
            int  ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;

        }
        
    }
}