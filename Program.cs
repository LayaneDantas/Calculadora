﻿using Calculadora.Models;

//Testando a Calculadora Simples

//CalculadoraSimples calc = new();

//calc.Soma(13, 15);
//calc.Subtração(13, 15);
//calc.Divisão(13, 15);
//calc.Multiplicação(3, 5);





// Testado a Calculadora de IMC 
CalculadoraIMC calcIMC = new();

Console.Write("Digite seu peso: ");
calcIMC.peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura: ");
calcIMC.altura = Convert.ToDouble(Console.ReadLine());

calcIMC.CalculoIMC (calcIMC.peso, calcIMC.altura);
calcIMC.ResultadoIMC(); 
   


