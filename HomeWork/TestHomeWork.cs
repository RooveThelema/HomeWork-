namespace homework;

public class TestHomeWork
{
    public static void Main(string[] args)
    {
        MyMath math = new MyMath();
        var arrayLenght = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        double sumResult = math.sum(array);
        double maxResult = math.max(array);
        double minResult = math.min(array);
        double countResult = math.count(array);
        
        Console.WriteLine($"sum: {sumResult}");
        Console.WriteLine($"max: {maxResult}");
        Console.WriteLine($"min {minResult}");
        Console.WriteLine($"count {countResult}");
    }
}