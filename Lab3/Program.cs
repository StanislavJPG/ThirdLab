class Program
{
    static int Sum(int a, int b)
    {
        int result = a + b;

        return result;
    }   

    static void Main(string[] args)
    {
        int a, b, c;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        c = Sum(a, b);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(c);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("============");
    }
}