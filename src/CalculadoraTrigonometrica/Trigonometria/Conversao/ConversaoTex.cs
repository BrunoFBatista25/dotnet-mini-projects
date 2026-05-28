using System;

namespace CalculadoraTrigonometrica.Trigonometria.Conversao
{
    public class ConversaoTex
    {
        public double ConverterTexto()
        {

            Console.WriteLine("digite no modelo: {2pi, 3/2pi ,1/2pi}");

            string texto = Console.ReadLine() ?? string.Empty;

            texto = texto.ToLower().Replace(" ", "");

            if (!texto.Contains("pi"))
            {
                throw new Exception("Expressão invalida");
            }

            //formata o texto para que se tiver "2pi" se torne "2""pi" e o replace torna "pi" em "" usando "2""".        
            string textoSemPi = texto.Replace("pi", "");

            double numero = double.Parse(textoSemPi);

            return numero * Math.PI;

        }
    }
}