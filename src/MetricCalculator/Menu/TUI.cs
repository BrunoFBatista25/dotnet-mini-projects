
namespace MetricCalculator.Menu;

class TUI
{
    public void AmostraMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo a o Calculador da distâncias!");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Calcular a Distância.");
        Console.WriteLine("2. Sair");
    }
   public int EscolhaDoUser()
    {
        Console.Write("Escolha: ");
        int choice;
        while (true) {

            Console.WriteLine("Envie um número entre 1 e 2.");
            if (!int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 2) {
                return choice;
            }
            Console.WriteLine("Valor Inválido! Digite um número entre 1 e 2.");
        } return 0;
    }
}
//Terminal User Interface (TUI) da Metrica.