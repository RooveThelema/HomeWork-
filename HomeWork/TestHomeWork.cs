namespace homework;

public class TestHomeWork
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        MyMath math = new MyMath();
        int[] numbers = { 1, 2, -3, 0, 5, 6, 7 };
        double sumResult = math.sum(numbers);
        double maxResult = math.max(numbers);
        double minResult = math.min(numbers);
        double countResult = math.count(numbers);
        
        Console.WriteLine($"sum: {sumResult}");
        Console.WriteLine($"max: {maxResult}");
        Console.WriteLine($"min {minResult}");
        Console.WriteLine($"count {countResult}");
    }
}