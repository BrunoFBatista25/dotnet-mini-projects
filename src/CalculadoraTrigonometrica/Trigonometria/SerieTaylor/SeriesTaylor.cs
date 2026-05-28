namespace CalculadoraTrigonometrica.Trigonometria.SerieTaylor;

public class SeriesTaylor
{
    public double CalcularSeno(double x, int n)
    {
        //a função sendo pode ser expressa por: seno(x) = Σ [(-1)^k * x^(2k + 1)] / (2k + 1)!
        double resultado = 0.0;
        for (int k = 0; k < n; k++)
        {
            resultado += Math.Pow(-1, k) * Math.Pow(x, 2 * k + 1) / Factorial(2 * k + 1);
        }
        return resultado;
    }
    public double CalcularCosseno(double x, int n)
    {
        //a função cosseno pode ser expressa por: cosseno(x) = Σ [(-1)^k * x^(2k)] / (2k)!    
        double resultado = 0.0;
        for (int k = 0; k < n; k++)
        {
            resultado += Math.Pow(-1, k) * Math.Pow(x, 2 * k) / Factorial(2 * k);
        }
        return resultado;
    }
    private double Factorial(int num)
    {
        //fatorial de um número n é o produto de todos os inteiros positivos menores ou iguais a n. O fatorial de 0 e 1 é definido como 1.
        if (num == 0 || num == 1)
            return 1;
        double result = 1;
        for (int i = 2; i <= num; i++)
            result *= i;
        return result;
    }
}