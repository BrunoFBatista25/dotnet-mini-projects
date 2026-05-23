
namespace MetricCalculator.Menu;

public class TUI
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Metric Calculator!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Calculate Area");
        Console.WriteLine("2. Calculate Perimeter");
        Console.WriteLine("3. Exit");
    }
    public int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Invalid input. Please enter a number between 1 and 3: ");
        }
        return choice;
    }
}
//Terminal User Interface (TUI) for the Metric Calculator application.