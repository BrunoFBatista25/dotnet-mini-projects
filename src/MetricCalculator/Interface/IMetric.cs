namespace MetricCalculator.Interface;
	
interface IMetric<T>
{
	double Condition<T>(T[] i, T[] j);
}
