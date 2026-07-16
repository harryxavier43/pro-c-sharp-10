namespace Calc.Cs;
public class Program
{
    public static int Main()
    {
        Calc c = new Calc();
        int ans = c.Add(10, 84);
        Console.WriteLine("10 + 84 is {0}.", ans);
        Console.ReadLine();
        return ans;
    }
}



class Calc
{
    public int Add(int addend1, int addend2)
    {
        return addend1 + addend2;
    }
}