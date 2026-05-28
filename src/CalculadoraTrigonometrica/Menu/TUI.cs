
namespace CalculadoraTrigonometrica.Menu;

public abstract class TUI
{
    int choice;

    public void MenuAmostra()
    {
        Console.Clear();
        Console.WriteLine("==============================================");
        Console.WriteLine("|| Bem vindo a o Calculador Trigonométrico! ||");
        Console.WriteLine("==============================================");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Calcular Seno.");
        Console.WriteLine("2. Calcular Cosseno.");
        Console.WriteLine("3. Calcular Tangente.");
        Console.WriteLine("4. Sair");
    }
    public int EscolhaDoUsuário()
    {
        Console.Write("Escolha: ");
        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Valor Inválido! Digite um número entre 1 e 4.");
            }
            else
            {
                return choice;
            }
        }
    }



}