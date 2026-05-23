public class Main
{
    static void Main(string[] args)
    {
        double[] vector1 = { 1.0, 2.0, 3.0 };
        double[] vector2 = { 1.0, 2.0, 3.0 };
        double[] vector3 = { 4.0, 5.0, 6.0 };
        DeltaKronecker deltaKronecker = new DeltaKronecker();
        Console.WriteLine("Comparing vector1 and vector2: " + deltaKronecker.Condition(vector1, vector2)); // retornará 1.0
        Console.WriteLine("Comparing vector1 and vector3: " + deltaKronecker.Condition(vector1, vector3)); // retornará 0.0
    }
}