using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade03_2
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public Pessoa(string Nome,int Idade )
        {
            this.Nome = Nome;
            this.Idade = Idade;

        }
        public void Apresentar(int Idade, string Nome)
        {
            this.Idade = Idade;
            this.Nome = Nome;
            Console.WriteLine($"Nome: {Nome}  Idade: {Idade}");
        }
static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa("",0);
            pessoa.Apresentar(22, "Joao");  
            pessoa.Apresentar(90,"Bruno");
        }
    }

        
}