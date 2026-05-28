namespace MetricCalculator.Metric.Distance;

using MetricCalculator.Metric;

public class Distance<T>
{

        public double CalcDistance(double[,] Del, double[,] dx){


		int n = Del.GetLength(0);
		double SomaTotal = 0.0;

		for (int i = 0;i<n;i++) {
			for (int j = 0;j<n;j++) {
				if (Del[i, j] == 0) continue; 
				
			SomaTotal += Del[i, j] + dx[i, j];
			}
		}
		//dx^2 + dy^2 + dz^2 + ... = d^2
		return Math.Sqrt(SomaTotal);

	}
}
