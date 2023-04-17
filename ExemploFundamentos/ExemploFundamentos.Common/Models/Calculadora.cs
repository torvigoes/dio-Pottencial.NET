using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
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
            Console.WriteLine($"{x}^ {y} = {potencia}");
        }

        public void Seno(double angulo)
        {
            double radianos = angulo * Math.PI / 180;
            double seno = Math.Sin(radianos);
            Console.WriteLine($"O Seno de {angulo}° é {seno}");
        }

        public void Cosseno(double angulo)
        {
            double radianos = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radianos);
            Console.WriteLine($"O Cosseno de {angulo}° é {cosseno}");
        }

        public void Tangente(double angulo)
        {
            double radianos = angulo * Math.PI / 180;
            double tangente = Math.Tan(radianos);
            Console.WriteLine($"A Tangente de {angulo}° é {tangente}");
        }

        public void Raiz(int x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raíz quadrada de {x} é igual a = {raiz}");
        }                
    }
}