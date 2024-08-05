using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConversaoDeTemperatura
{
    public static class Temperatura
    {
        // Exercício 3: Teste de Conversão de Temperatura
        // Crie um teste unitário para o método ConverterCelsiusParaFahrenheit que verifica se a conversão de Celsius para Fahrenheit é calculada corretamente.

        public static double ConverterCelsiusParaFahrenheit(double x)
        {
            return (x * 1.8) + 32 ;
        }
    }
}
