using MetricCalculator.Metric.Distance;

class Program
{
    static void Main(string[] args)
    {
        ProgramTUI app = new ProgramTUI();
        app.Run();
    }
}

class ProgramTUI
{
    private TUI _tui;
    public ProgramTUI()
    {
        _tui = new TUI();
    }
    public void Run()
    {
        while (true)
        {
            _tui.AmostraMenu();
            int choice = _tui.EscolhaDoUser();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Calculando a Distância...");
                    //desenvolver uma função a qual calcula a distância entre dois vetores, utilizando as métricas implementadas.
                    Console.WriteLine("digite o primeiro valor de dx: ");
                    double[] dx = double.Parse(Console.ReadLine());

                    Distance<T> ds = new Distance<double>();

                    ds.CalcDistance(new double[,] { { 1, 0 }, { 0, 1 } },double[,]dx);
                    break;
                case 2:
                    Console.WriteLine("Saindo...");
                    break; // Fim do Programa
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}