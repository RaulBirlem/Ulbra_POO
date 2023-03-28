using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade3_3
{
    public class ContaBancaria
    {
        public double Saldo {get; set;}
        public double Numero {get; set;}
        public double Valor {get;set;}

         public void Depositar(double valor)
        {
            this.Valor = valor;
            Saldo += valor;
            Console.WriteLine($"Depositado:+{valor}");
            Console.WriteLine($"Saldo total:{Saldo}");
        }

        public void Sacar(double valor)
        {
            this.Valor = valor;
            Saldo-=valor;
            Console.WriteLine($"Retirado:-{valor}");      
            Console.WriteLine($"Saldo total:{Saldo}");
        }

         static void Main(string[] args)
        {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(800);
        conta.Sacar(200);
        }
    }
}