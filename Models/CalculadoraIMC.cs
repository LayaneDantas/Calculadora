using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Calculadora.Models
{
    public class CalculadoraIMC
    {

        public double peso, altura;
        
        public double CalculoIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public void ResultadoIMC()
        {
            double imc = CalculoIMC(peso, altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if ( imc > 17)
            {

                Console.WriteLine("Você está muito abaixo do peso.");

            }

            else if (imc > 18.5)
            {

                Console.WriteLine("Você está abaixo do peso.");


            }

            else if (imc > 24.9)
            {

                Console.WriteLine("Você está com o peso normal.");

            }


            else if (imc <= 25 && imc > 29.9)
            {

                Console.WriteLine("Você está acima do peso.");


            }

            else
            {

                Console.WriteLine("Você está obeso.");

            }
        }
    }









}

