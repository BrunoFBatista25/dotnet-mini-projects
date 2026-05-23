
public class DeltaKronecker : IMetric
{
    public double Condition(double[] i, double[] j)
    {
        if (i.Length != j.Length)
        {
            throw new ArgumentException("Os Vetores devem possuir o mesmo tamanho.");
        }
        for (int k = 0; k < i.Length; k++)
        {
            if (i[k] != j[k])
            {
                return 0.0;
            }
        }
        return 1.0;
    }
}