using CalculadoraTrigonometrica.Menu;
using CalculadoraTrigonometrica.Trigonometria.AplicacaoTrigonometrica;
using CalculadoraTrigonometrica.Trigonometria.SerieTaylor; 
using CalculadoraTrigonometrica.Trigonometria.Conversao;


ConversaoTex conversao = new ConversaoTex();
SeriesTaylor taylor = new SeriesTaylor();
AplicacaoTrigonometrica aplicacao = new AplicacaoTrigonometrica(conversao, taylor);


ApplicationTUI programa = new ApplicationTUI(aplicacao);


programa.Run();