
namespace CalculadoraTrigonometrica.Trigonometria.Conversao;

	public class ConversaoAng
	{
		public double GrausParaRadianos(double graus)
		{
			//normalmente poderiamos usar 360 graus, mas como seno e cosseno tem um período de 2π, vou usar 180 graus para a conversão.
			return graus * (Math.PI / 180);
		}
		public double RadianosParaGraus(double radianos)
		{
			return radianos * (180 / Math.PI);
		}
	}
