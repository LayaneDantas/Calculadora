using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraSimples
    {
        public void Soma(int x,  int y)
        {

            Console.WriteLine($"A soma de {x} e {y} é igual à {x + y}");

        }

        public void Subtração(int x, int y)
        {

            Console.WriteLine($"A subtração de {x} e {y} é igual à {x - y}");

        }

        public void Divisão(int x, int y)
        {

            Console.WriteLine($"A divisão de {x} e {y} é igual à {x / y}");

        }

        public void Multiplicação(int x, int y)
        {

            Console.WriteLine($"A multiplicação de {x} e {y} é igual à {x * y}");

        }





    }
}
