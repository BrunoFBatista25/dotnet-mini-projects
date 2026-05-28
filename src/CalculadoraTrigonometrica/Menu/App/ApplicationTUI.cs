using CalculadoraTrigonometrica.Trigonometria.AplicacaoTrigonometrica;
using CalculadoraTrigonometrica.Menu;

public class ApplicationTUI : TUI
{
    private readonly AplicacaoTrigonometrica _aplicacaoTrigonometrica;

    public ApplicationTUI(
        AplicacaoTrigonometrica aplicacaoTrigonometrica) // DI - Injeção de Dependência
    {
        _aplicacaoTrigonometrica = aplicacaoTrigonometrica;
    }

    public void Run()
    {
        while (true)
        {
            MenuAmostra();
            int escolha = EscolhaDoUsuário();
            switch (escolha)
            {
                case 1:
                    _aplicacaoTrigonometrica.CalcularSeno();
                    break;
                case 2:
                    _aplicacaoTrigonometrica.CalcularCosseno();
                    break;
                case 3:
                    _aplicacaoTrigonometrica.CalcularTangente();
                    break;
                case 4:
                    Console.WriteLine("Saindo do programa. Até logo!");
                    return;
            }
        }
    }
}