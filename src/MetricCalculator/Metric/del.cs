namespace Metric.del;

class del<T> : IMetric<T>
{
    public double Condition(T[] i, T[] j)
    {
        if (i.Length != j.Length)
        {
            throw new ArgumentException("Os Vetores devem possuir o mesmo tamanho.");
        }
        for (int k = 0; k < i.Length; k++)
        {
            if (!EqualityComparer<T>.Default.Equals(i[k], j[k]))
            {
                return 0.0;
            }
        }
        return 1.0;
    }


}