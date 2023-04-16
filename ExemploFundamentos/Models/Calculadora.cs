using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void Dividir(int x, int y)
        {
            double divisao = (double)x/y;
            Console.WriteLine($"{x} / {y} = {divisao}");
        }

        public void Potenciacao(int x, int y)
        {
            double potencia = Math.Pow(x,y);
            Console.WriteLine($"{x} ** {y} = {potencia}");
        }
    }
}