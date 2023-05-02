namespace InstaFunc;

public class Program
{
    public static int Calc(int n)
    {
        if (n == 0) return 2;
        if (n == 1) return 1;
        else return Calc(n - 1) + Calc(n - 2);
    }

    static void Main()
    {
        string s = "";

        for (int i = 1; i < 6; i++)
        {
            s += Calc(i).ToString();
        }
        Console.WriteLine("www.multisoft.se/" + s);
    }
}