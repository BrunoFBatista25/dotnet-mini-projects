namespace CalculadoraTrigonometrica.Trigonometria.AplicacaoTrigonometrica;

using CalculadoraTrigonometrica.Trigonometria.SerieTaylor;
using CalculadoraTrigonometrica.Trigonometria.Conversao;
using System;

public class AplicacaoTrigonometrica
{
    private readonly ConversaoTex _conversaoTex;
    private readonly SeriesTaylor _taylor;

    public AplicacaoTrigonometrica(
        ConversaoTex conversaoTex,
        SeriesTaylor seriesTaylor)
    {
        _conversaoTex = conversaoTex;
        _taylor = seriesTaylor;
    }

    public double CalcularSeno()
    {
        Console.Write("Escolha o método para calcular o Seno (1-angulo, 2-analitico): ");
        if (!int.TryParse(Console.ReadLine(), out int escolha_s))
            return double.NaN;

        switch (escolha_s)
        {
            case 1:
                Console.Write("Digite o angulo em radianos: ");
                Console.Write("Digite Pi or pi - - - - - >  pi em radianos: ");
                double arg = _conversaoTex.ConverterTexto();
                return _taylor.CalcularSeno(arg, 15);
                
            case 2:
                Console.Write("Digite o valor analitico: {1.0,23.0,23/3 e ...}  ");
                double x = double.Parse(Console.ReadLine());
                return _taylor.CalcularSeno(x, 15);
                

            default:
                return double.NaN;
        }
    }

    public double CalcularCosseno()
    {
        Console.Write("Escolha o método para calcular o Cosseno (1-angulo, 2-analitico): ");
        if (!int.TryParse(Console.ReadLine(), out int escolha_s))
            return double.NaN;

        switch (escolha_s)
        {
            case 1:
                Console.Write("Digite o angulo em radianos: ");
                Console.Write("Digite Pi or pi - - - - - >  pi em radianos: ");
                double arg = _conversaoTex.ConverterTexto();
                return _taylor.CalcularCosseno(arg, 15);
                

            case 2:
                Console.Write("Digite o valor analitico: {1.0,23.0,23/3 e ...}  ");
                double x = double.Parse(Console.ReadLine());
                return _taylor.CalcularCosseno(x, 15);
                
            default:
                return double.NaN;
        }
    }

    public double CalcularTangente()
    {
        Console.Write("Escolha o método para calcular a Tangente (1-angulo, 2-analitico): ");
        if (!int.TryParse(Console.ReadLine(), out int escolha_s))
            return double.NaN;

        switch (escolha_s)
        {
            case 1:
                Console.Write("Digite o angulo em radianos: ");
                Console.Write("Digite Pi or pi - - - - - >  pi em radianos: ");
                double arg = _conversaoTex.ConverterTexto();
                double sin1 = _taylor.CalcularSeno(arg, 15);
                double cos1 = _taylor.CalcularCosseno(arg, 15);
                return cos1 == 0 ? double.NaN : sin1 / cos1;
                

            case 2:
                Console.Write("Digite o valor analitico: {1.0,23.0,23/3 e ...}  ");
                double x = double.Parse(Console.ReadLine());
                double sin2 = _taylor.CalcularSeno(x, 15);
                double cos2 = _taylor.CalcularCosseno(x, 15);
                return cos2 == 0 ? double.NaN : sin2 / cos2;
                

            default:
                return double.NaN;
        }
    }
}