using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora_cli.Models
{
    public class Calculadora
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(double x, double y)
        {
            double divisao = x / y;
            Console.WriteLine($"{x} / {y} = {divisao}");
        }

        public void Potencia(double x, double y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {potencia}");
        }
    }
}