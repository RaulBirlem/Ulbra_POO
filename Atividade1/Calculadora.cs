using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade03
{
    
    public class Calculadora
    
    {
        public double res {get; set;}
       

        public void Somar(double a, double b)
        {
            res = a+b;
            Console.WriteLine(res);
        }

        public void Subtrair(double a, double b)
        {
            res = a-b;
            Console.WriteLine(res);
        }
        static void Main(string[] args)
    {
         Calculadora conta = new Calculadora();
        conta.Somar(2,6);
        conta.Subtrair(9,1);

    }
    }

   
    
}