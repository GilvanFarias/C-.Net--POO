using System.Globalization;
using System;
using System.Collections.Generic;
//using Internal;
//using System.Globalization;
namespace CalcIdade
{
    public class Pessoa
    {
        //Contrutor é um método publico para que possa interagir com ele que não possui um tipo(string,int)
        public Pessoa(string _nomePessoa, int _anoNascimentoPessoa){
            this.Nome = _nomePessoa;
            this.AnoNascimento = _anoNascimentoPessoa;
            this.CalcularIdade();
        }

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

        //Implementando a propriedade Idade
        private int _idade;
        public int Idade
        {
            get { 
                    this.CalcularIdade();
                    return this._idade; 
                }
            
        }
        

        public void ExibirDados(){
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano de nascimento: " + this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " + this.Idade);
            //int idade = this.Idade;
            //Console.WriteLine("Idade: " + idade);
        }

        private /*int*/ void CalcularIdade(){

            DateTime data = DateTime.Now; //pega a data do sistema atual
            int  ano = data.Year;
            this._idade = ano - this.AnoNascimento;
            //int idade = ano - this.AnoNascimento;
            //return idade;

        }
        
    }
}