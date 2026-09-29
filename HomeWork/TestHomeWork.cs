namespace homework;

public class TestHomeWork
{
    public static void Main(string[] args)
    {
        ParserArray parserArray = new ParserArray();
        MyMath math = new MyMath();
        int[] array = parserArray.GetArray();;
        
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