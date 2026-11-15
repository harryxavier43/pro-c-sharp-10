namespace Calc.Cs;
public class Program
{
    public static int Main()
    {

        var c = new CalcLib.Calc();

        int ans = c.Add(10, 84);
        Console.WriteLine("10 + 84 is {0}.", ans);

        ans = c.Substract(94, 10);
        Console.WriteLine("94 - 10 is {0}.", ans);

        ans = c.Multiply(94, 10);
        Console.WriteLine("94 * 10 is {0}.", ans);

        ans = c.Divide(94, 10);
        Console.WriteLine("94 / 10 is {0}.", ans);



        Console.ReadLine();
        return ans;
    }
}



