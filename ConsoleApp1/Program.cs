public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
           string result = Print(i);
           Console.WriteLine(result);
        }
        Console.ReadLine();
    }

    public static string Print(int i)
    {
        if (i % 5 == 0 && i % 3 == 0) //15 Fizzbuzz
        {
            return "FizzBuzz";
        }
        else if(i % 3 == 0 && i % 5 != 0) //9 Fizz
        {
            return "Fizz";
        }
        else if (i % 5 == 0 && i % 3 != 0) //Buzz
        {
            return "Buzz";
        }
        else
        {
            return i.ToString(); //2,4
        }
    }
}


