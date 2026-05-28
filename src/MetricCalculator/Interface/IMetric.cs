namespace MetricCalculator.Interface;
	
public interface IMetric<T>
{
	double Condition<T>(T[] i, T[] j);
}
