namespace homework;

public class ParserArray
{
    public int[] GetArray()
    {
        Console.Write("Enter number array lenght: ");
        int ArrayLenght = Convert.ToInt32(Console.ReadLine());
        int [] array = new int[ArrayLenght];
        
        for (int i = 0; i < ArrayLenght; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        return array;
    }
}